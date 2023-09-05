namespace DataAccess.Entity
{
    public class Host : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Department Department { get; set; }
    }
    public enum Department
    {
        IT,
        UID
    }
}
