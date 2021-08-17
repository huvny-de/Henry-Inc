using Henry_Inc.AdminApp.Services;
using Henry_Inc.ViewModels.System.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Henry_Inc.AdminApp.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _configuration;

        public UsersController(IUserApiClient userApiClient, IConfiguration configuration)
        {
            _userApiClient = userApiClient;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index(string Keyword, int pageIndex = 1, int pageSize = 10)
        {

            var request = new GetUserPagingRequest()
            {
                Keyword = Keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };

            var data = await _userApiClient.GetUsersPagings(request);
            return View(data.ResultObj);
        }
        //Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _userApiClient.RegisterUser(request);
            if (result.IsSucceeded)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", result.Message);
            return View();
        }
        // Update
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var result = await _userApiClient.GetById(id);
            if (result.IsSucceeded)
            {
                var user = result.ResultObj;
                var updateRequest = new UserUpdateRequest()
                {
                    Id = id,
                    Email = user.Email,
                    Dob = user.Dob,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber
                };
                return View(updateRequest);
            }

            return RedirectToAction("Error", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _userApiClient.UpdateUser(request.Id, request);
            if (result.IsSucceeded)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", result.Message);
            return View(request);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
               CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            return RedirectToAction("Login", "Users");

        }

    }
}

