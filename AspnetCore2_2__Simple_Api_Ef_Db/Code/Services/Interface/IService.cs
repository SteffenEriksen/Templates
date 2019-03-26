using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using template.Entities.Models;

namespace template.Services.Interface
{
    public interface IService
    {
        ExampleModel Get();
        IEnumerable<ExampleModel> GetAll();
        ExampleModel Do();
    }
}
