namespace University_Management_System_API.Business.Convertor.Account
{
    public class AccountParam : BaseParamNamed
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Egn { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }

        public long UserId { get; set; }
        public long SpecialityId { get; set; }
        public long DepartamentId { get; set; }
        public long StatusId { get; set; }
        public long TypeId { get; set; }
    }
}
