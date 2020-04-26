namespace University_Management_System_API.Business.Convertor
{
    using University_Management_System_API.Business.Convertor.Common;

    public abstract class BaseParamNamed : BaseParam
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
