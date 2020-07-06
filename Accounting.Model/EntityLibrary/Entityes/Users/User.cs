using Accounting.Model.EntityLibrary.Entityes.Departments;
using Accounting.Model.EntityLibrary.Interfaces;

namespace Accounting.Model.EntityLibrary.Entityes.Users
{
    public class User : IEntity, IUser
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }

        public string SurName { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }

        public int DepartamentId { get; set; }
        public Department Departament { get; set; }
  
    }
}
