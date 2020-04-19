namespace University_Management_System_API.Business.Convertor.Lecture
{
    public class LectureParam : BaseParamNamed
    {
        public long TeacherDisciplineId { get; set; }
        public long RoomId { get; set; }
        public long StatusId { get; set; }
    }
}
