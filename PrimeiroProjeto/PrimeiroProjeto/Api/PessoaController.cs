﻿using Microsoft.AspNetCore.Mvc;

namespace Interface.Api
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
