namespace University_Management_System_API.Business.Convertor
{
    public abstract class BaseResultNamed : BaseResult
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
