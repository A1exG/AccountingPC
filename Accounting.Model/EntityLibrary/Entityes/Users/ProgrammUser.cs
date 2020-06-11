using Accounting.Model.EntityLibrary.Interfaces;

namespace Accounting.Model.EntityLibrary.Entityes.Users
{
    class ProgrammUser : IEntity, IUser
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }

        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
    }
}
