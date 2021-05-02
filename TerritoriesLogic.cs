using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class TerritoriesLogic : BaseLogic, IABMLogic<Territories>
    {
        public void Add(Territories newTerritory)
        {
            throw new NotImplementedException();
        }

        public void deleteCustomer(string id)
        {
            throw new NotImplementedException();
        }

        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }

        public void updateCustomer(string id, string newContactName)
        {
            throw new NotImplementedException();
        }
    }
}
