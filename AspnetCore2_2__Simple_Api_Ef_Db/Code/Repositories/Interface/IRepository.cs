using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using template.Entities.Models;

namespace template.Repositories.Interface
{
    public interface IRepository
    {
        ExampleModel Get(int id);
        IEnumerable<ExampleModel> GetAll();
        void Update(int id);
        ExampleModel Add(ExampleModel model);
    }

}
