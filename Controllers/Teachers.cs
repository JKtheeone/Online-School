using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Controllers
{
    [ApiController]
    [Route("/Teachers")]
    public class TeachersController : ControllerBase
    {

        [HttpPost("Teachingstudents")]
        public string Teachingstudents(string str)
        {
            return str; // обучение учащихся
        }
        [HttpPost("Providingmaterial")]
        public string Providingmaterial(string str)
        {
            return str;// предоставление дополнительного учебного материала
        }

    }
}