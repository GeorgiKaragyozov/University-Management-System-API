namespace University_Management_System_API.Business.Convertor.Lecture
{
    using University_Management_System_API.Business.Convertor.Common;

    public class LectureResultConverter : BaseResultConverter<Model.Lecture, LectureResult>, ILectureResultConverter
    {
        public override void ConvertSpecific(Model.Lecture entity, LectureResult result)
        {
            result.TeacherDisciplineId = entity.TeacherDiscipline.Id;
            result.TeacherDisciplineName = entity.TeacherDiscipline.Name;
            result.RoomId = entity.Room.Id;
            result.RoomName = entity.Room.Name;
            result.StatusId = entity.Status.Id;
            result.StatusName = entity.Status.Name;
        }

        public override LectureResult GetResult()
        {
            return new LectureResult();
        }
    }
}
