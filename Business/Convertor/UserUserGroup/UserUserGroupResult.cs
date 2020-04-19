namespace University_Management_System_API.Business.Convertor.UserUserGroup
{
    public class UserUserGroupResult : BaseResult
    {
        public long UserId { get; set; }
        public string UserName { get; set; }

        public long UserGroupId { get; set; }
        public string UserGroupName { get; set; }
    }
}
