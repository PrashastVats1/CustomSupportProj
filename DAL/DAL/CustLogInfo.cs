namespace DAL
{
    public class CustLogInfo
    {
        public int LogId { get; set; }
        public string CustEmail { get; set; }
        public string CustName { get; set; }
        public string LogStatus { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
    }
}