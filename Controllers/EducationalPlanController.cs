using getone.Domains;
using getone.Storages;
using Microsoft.AspNetCore.Mvc;

namespace getone.Controllers
{
    [ApiController]
    [Route("/EducationalPlan")]
    public class EducationalPlanController : ControllerBase
    {
        [HttpPost]
        public EducationalPlan Create(EducationalPlan educationalPlan)
        {
            Storage.EducationalPlanStorage.Create(educationalPlan);
            return educationalPlan;
        }

        [HttpGet]
        public EducationalPlan Read(int planId)
        {
            return Storage.EducationalPlanStorage.Read(planId);
        }

        [HttpPut]
        public EducationalPlan Update(int planId, EducationalPlan newEducationalPlan)
        {
            return Storage.EducationalPlanStorage.Update(planId, newEducationalPlan);
        }

        [HttpDelete]
        public bool Delete(int planId)
        {
            return Storage.EducationalPlanStorage.Delete(planId);
        }
    }
}