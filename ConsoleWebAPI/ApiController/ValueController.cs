using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWebAPI.ApiController
{
    public class ValueController:ControllerBase
    {
        [Route("test/index")]
        public string Index()
        {
            return "hello api";
        }
    }
}
