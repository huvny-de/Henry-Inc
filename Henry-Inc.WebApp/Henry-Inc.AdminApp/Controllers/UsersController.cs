using Henri_Inc.ApiIntergration;
using Henry_Inc.ViewModels.Commons;
using Henry_Inc.ViewModels.System.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace Henry_Inc.AdminApp.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _configuration;
        private readonly IRoleApiClient _roleApiClient;
        public UsersController(IUserApiClient userApiClient,
            IConfiguration configuration,
            IRoleApiClient roleApiClient)
        {
            _userApiClient = userApiClient;
            _configuration = configuration;
            _roleApiClient = roleApiClient;
        }
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 3)
        {
            var request = new GetUserPagingRequest()

            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            if (TempData != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            var data = await _userApiClient.GetUsersPagings(request);
            ViewBag.Keyword = keyword;
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
            //var result = await _userApiClient.RegisterUserForm(request);

            if (result.IsSucceeded)
            {
                TempData["result"] = "Create new user successful";
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
                TempData["result"] = "Update user successful";

                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", result.Message);
            return View(request);
        }
        //Details
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var result = await _userApiClient.GetById(id);
            if (result.IsSucceeded)
            {
                return View(result.ResultObj);
            }
            return RedirectToAction("Error", "Home");
        }
        //Delete
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            return View(
                new UserDeleteRequest()
                {
                    Id = id
                });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(UserDeleteRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _userApiClient.DeleteUser(request.Id);
            if (result.IsSucceeded)
            {
                TempData["result"] = "Delete successful";
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
            return RedirectToAction("Index", "Login");

        }
        //RoleAssign
        [HttpGet]
        public async Task<IActionResult> RoleAssign(Guid id)
        {

            var roleAssignRequest = await GetRoleAssignRequest(id);

            return View(roleAssignRequest);

        }
        [HttpPost]
        public async Task<IActionResult> RoleAssign(RoleAssignRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _userApiClient.RoleAssign(request.Id, request);

            if (result.IsSucceeded)
            {
                TempData["result"] = "Roles assign successful";

                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", result.Message);
            var roleAssignRequest = await GetRoleAssignRequest(request.Id);

            return View(request);
        }
        private async Task<RoleAssignRequest> GetRoleAssignRequest(Guid id)
        {
            var userObj = await _userApiClient.GetById(id);
            var roleObj = await _roleApiClient.GetAll();
            var roleAssignRequest = new RoleAssignRequest();

            foreach (var role in roleObj.ResultObj)
            {
                roleAssignRequest.Roles.Add(new SelectedItem()
                {
                    Id = role.Id.ToString(),
                    Name = role.Name,
                    Selected = userObj.ResultObj.Roles.Contains(role.Name)
                });
            }
            return roleAssignRequest;
        }
    }
}

