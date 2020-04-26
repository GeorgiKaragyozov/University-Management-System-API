namespace University_Management_System_API.Business.Convertor
{
    using System;
        
    public abstract class BaseResult
    {
        public long Id { get; set; }
        public sbyte Active { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
