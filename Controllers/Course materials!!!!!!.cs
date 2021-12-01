using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Controllers
{
    [ApiController]
    [Route("/Coursematerial")]
    public class CoursematerialController : ControllerBase
    {
        [HttpPost]
        public Coursematerial Create(Coursematerial coursematerial)
        {
            Storage.CoursematerialStorage.Create(coursematerial)
            return coursematerial;
        }

        [HttpGet]
        public Coursematerial Read(int materialId)
        {
            return Storage.CoursematerialStorage.Read(materialId);
        }

        [HttpPut]
        public Coursematerial Update(int reqId, Coursematerial newCoursematerial)
        {
            return Storage.CoursematerialStorage.Update(materialId, newCoursematerial);
        }

        [HttpDelete]
        public bool Delete(int materialId)
        {
            return Storage.CoursematerialStorage.Delete(materialId);
        }
    }
}