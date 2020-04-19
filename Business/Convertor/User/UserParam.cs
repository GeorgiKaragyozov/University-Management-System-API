namespace University_Management_System_API.Business.Convertor.User
{
    public class UserParam : BaseParam
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public long StatusId { get; set; }
    }
}

