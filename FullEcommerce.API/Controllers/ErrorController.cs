﻿using FullEcommerce.API.Errors;
using Microsoft.AspNetCore.Mvc;

namespace FullEcommerce.API.Controllers
{
    [Route("errors/{code}")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {

        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
