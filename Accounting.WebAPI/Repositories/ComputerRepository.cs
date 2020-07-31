using Accounting.Model.EntityLibrary.Entityes.Computers;
using System;
using System.Collections.Generic;

namespace Accounting.WebAPI.Repositories
{
    public class ComputerRepository : IRepository<Computer>
    {
        public List<Computer> Get()
        {
            throw new NotImplementedException();
        }

        public Computer GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Post(Computer comp)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id)
        {
            
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}