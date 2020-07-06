namespace Accounting.Model.EntityLibrary.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string SurName { get; set; }
        string Name { get; set; }
        string SecondName { get; set; }
    }
}
