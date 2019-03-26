using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using template.Entities.Models;
using template.Repositories.Interface;

namespace template.Repositories
{
    public class Repository : IRepository
    {
        private ExampleContext _dbContext;

        public Repository(ExampleContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<ExampleModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ExampleModel Get(int id)
        {
            //return _dbContext.ExampleModels.First(e => e.Id == id);

            return _dbContext.ExampleModels.FirstOrDefault();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public ExampleModel Add(ExampleModel model)
        {
            _dbContext.ExampleModels.Add(model);
            _dbContext.SaveChanges();

            return model;
        }
    }
}
