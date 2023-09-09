using DataBase.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Logic
{
    public class DetailsLogic
    {
        private readonly Excel_AddinsContext _dbContext;
        public DetailsLogic(Excel_AddinsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Details> GetDetails() 
        {
            var result = _dbContext.Details.ToList();
            return result;
        }
    }
}
