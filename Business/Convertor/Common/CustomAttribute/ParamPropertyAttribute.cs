namespace University_Management_System_API.Business.Convertor.Common
{
    using System;

    [AttributeUsage(AttributeTargets.All)]
    public class ParamPropertyAttribute : Attribute
    { 
        public bool Ignored { get; set; }

        public string Sourse { get; set; }

        public string Destination { get; set; }

        public ParamPropertyAttribute() { }

        public ParamPropertyAttribute(bool ignored)
        {
            this.Ignored = ignored;
        }

        public ParamPropertyAttribute(bool ignored, string sourse, string destination)
        {
            this.Sourse = sourse;
            this.Destination = destination;
            this.Ignored = ignored;
        }

        public ParamPropertyAttribute(string sourse, string destination)
        {
            this.Sourse = sourse;
            this.Destination = destination;
        }   
    }
}
