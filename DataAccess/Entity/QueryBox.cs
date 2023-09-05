namespace DataAccess.Entity
{
    public class QueryBox
    {
        public int Id { get; set; }
        public int QueryId { get; set; }
        public Query Query{ get; set; }
        public int HostId { get; set; } 
        public Host Host { get; set; }
        public int Count { get; set; }
    }
}
