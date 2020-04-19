namespace University_Management_System_API.Business.Convertor.User
{
    public class UserResult : BaseResult
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public long StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
