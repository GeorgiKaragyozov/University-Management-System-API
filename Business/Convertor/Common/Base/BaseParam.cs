namespace University_Management_System_API.Business.Convertor
{
    using University_Management_System_API.Business.Convertor.Common;

    public abstract class BaseParam
    {
        [ParamProperty(true)]
        public long Id { get; set; }
        public sbyte Active { get; set; }
    }
}
