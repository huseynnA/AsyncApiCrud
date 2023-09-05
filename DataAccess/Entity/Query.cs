using System.Text;

namespace DataAccess.Entity
{
    public class Query:BaseEntity
    {
        public StringBuilder Purpose { get; set; }
        public bool QueryActiveOrNot { get; set; }
    }
}
