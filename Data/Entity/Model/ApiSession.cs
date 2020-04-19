namespace University_Management_System_API.Model
{
    public class ApiSession : PersistentNamed
    {
        public long UserId { get; set; }
        public string AuthToken { get; set; }
    }
}
