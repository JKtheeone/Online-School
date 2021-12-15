using getone.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace getone.Storages
{
        public class EducationalPlanStorage
        {
            private Dictionary<int, EducationalPlan> EducationalPlans { get; } = new Dictionary<int, EducationalPlan>();

            public void Create(EducationalPlan educationalPlan)
            {
                EducationalPlans.Add(educationalPlan.PlanId, educationalPlan);
            }

            public EducationalPlan Read(int planId)
            {
                return EducationalPlans[planId];
            }

            public EducationalPlan Update(int planId, EducationalPlan newEducationalPlan)
            {
                EducationalPlans[planId] = newEducationalPlan;
                return EducationalPlans[planId];
            }

            public bool Delete(int planId)
            {
                return EducationalPlans.Remove(planId);
            }
        }
    
}