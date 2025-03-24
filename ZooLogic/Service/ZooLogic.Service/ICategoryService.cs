using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLogic.Data.Models;
using ZooLogic.Service.Models;

namespace ZooLogic.Service
{
    public interface ICategoryService : IGenericService<Category, CategoryServiceModel>
    {
    }
}
