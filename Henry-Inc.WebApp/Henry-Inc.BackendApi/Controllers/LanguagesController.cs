using Henry_Inc.Application.System.Languages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Henry_Inc.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {

        private readonly ILanguageService _languagService;

        public LanguagesController(ILanguageService languageService)
        {
            _languagService = languageService;
        }

        public async Task<IActionResult> GetAll()
        {
            var roles = await _languagService.GetAll();
            return Ok(roles);
        }
    }
}
