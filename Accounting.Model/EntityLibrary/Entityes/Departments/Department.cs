using Accounting.Model.EntityLibrary.Interfaces;

namespace Accounting.Model.EntityLibrary.Entityes.Departments
{
    public class Department : IEntity
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
    }
}
