using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using template.Entities.Models;
using template.Repositories.Interface;
using template.Services.Interface;

namespace template.Services
{
    public class Service : IService
    {
        private IRepository _repository;

        public Service(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ExampleModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ExampleModel Get()
        {
            var res = _repository.Get(1);


            return res;
        }

        public ExampleModel Do()
        {
            var res = _repository.Add(new ExampleModel
            {
                //Id = 1,
                Created = DateTime.Now,
                Payload = "Test payload"
            });


            return res;
        }
    }
}
