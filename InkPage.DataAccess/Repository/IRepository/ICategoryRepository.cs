using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ink_Page.Models;

namespace InkPage.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category> 
    {
        void Update(Category category);
        void Save();
    }
}
