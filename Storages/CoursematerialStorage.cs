using getone.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace getone.Storages
{

    public class CoursematerialStorage
    {
        private Dictionary<int, Coursematerial> Coursematerials { get; } = new Dictionary<int, Coursematerial>();

        public void Create(Coursematerial coursematerial)
        {
            Coursematerials.Add(coursematerial.MaterialId, coursematerial);
        }

        public Coursematerial Read(int materialId)
        {
            return Coursematerials[materialId];
        }

        public Coursematerial Update(int materialId, Coursematerial newCoursematerial)
        {
            Coursematerials[materialId] = newCoursematerial;
            return Coursematerials[materialId];
        }

        public bool Delete(int materialId)
        {
            return Coursematerials.Remove(materialId);
        }
    }
}   
