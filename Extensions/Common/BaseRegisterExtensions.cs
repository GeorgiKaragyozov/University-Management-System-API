namespace University_Management_System_API.Extensions.Common
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Extensions.Account;
    using University_Management_System_API.Extensions.AccountStatus;
    using University_Management_System_API.Extensions.AccountType;
    using University_Management_System_API.Extensions.ApiSession;
    using University_Management_System_API.Extensions.Authentication;
    using University_Management_System_API.Extensions.Departament;
    using University_Management_System_API.Extensions.DepartamentStatus;
    using University_Management_System_API.Extensions.Discipline;
    using University_Management_System_API.Extensions.DisciplineStatus;
    using University_Management_System_API.Extensions.EducationalDegree;
    using University_Management_System_API.Extensions.Faculty;
    using University_Management_System_API.Extensions.FacultyStatus;
    using University_Management_System_API.Extensions.Lecture;
    using University_Management_System_API.Extensions.LectureStatus;
    using University_Management_System_API.Extensions.Auth;
    using University_Management_System_API.Extensions.Room;
    using University_Management_System_API.Extensions.RoomStatus;
    using University_Management_System_API.Extensions.Speciality;
    using University_Management_System_API.Extensions.SpecialityStatus;
    using University_Management_System_API.Extensions.SpecialityTrainingType;
    using University_Management_System_API.Extensions.TeacherDiscipline;
    using University_Management_System_API.Extensions.TeacherDisciplineStatus;
    using University_Management_System_API.Extensions.TrainingType;
    using University_Management_System_API.Extensions.User;
    using University_Management_System_API.Extensions.UserGroup;
    using University_Management_System_API.Extensions.UserGroupStatus;
    using University_Management_System_API.Extensions.UserStatus;
    using University_Management_System_API.Extensions.UserUserGroup;

    public static class BaseRegisterExtensions
    {
        /// <summary>
        /// Function that returns all registered objects with dependency Injection 
        /// </summary>
        /// <param name="services">services</param>
        public static void BaseRegisterDependencies(this IServiceCollection services)
        {
            //------------------- Account -------------------//
            RegisterAccountExtensions.RegisterDependencies(services);

            //------------------- AccountStatus -------------------//
            RegisterAccountStatusExtensions.RegisterDependencies(services);

            //------------------- AccountType -------------------//
            RegisterAccountTypeExtensions.RegisterDependencies(services);

            //------------------- Departament -------------------//
            RegisterDepartamentExtensions.RegisterDependencies(services);

            //------------------- DepartamentStatus -------------------//
            RegisterDepartamentStatusExtensions.RegisterDependencies(services);

            //------------------- Discipline -------------------//
            RegisterDisciplineExtensions.RegisterDependencies(services);

            //------------------- DisciplineStatus -------------------//
            RegisterDisciplineStatusExtensions.RegisterDependencies(services);

            //------------------- EducationalDegree -------------------//
            RegisterEducationalDegreeExtensions.RegisterDependencies(services);

            //------------------- Faculty -------------------//
            RegisterFacultyExtensions.RegisterDependencies(services);

            //------------------- FacultyStatus -------------------//
            RegisterFacultyStatusExtensions.RegisterDependencies(services);

            //------------------- Lecture -------------------//
            RegisterLectureExtensions.RegisterDependencies(services);

            //------------------- LectureStatus -------------------//
            RegisterLectureStatusExtensions.RegisterDependencies(services);

            //------------------- Room -------------------//
            RegisterRoomExtensions.RegisterDependencies(services);

            //------------------- RoomStatus -------------------//
            RegisterRoomStatusExtensions.RegisterDependencies(services);

            //------------------- Speciality -------------------//
            RegisterSpecialityExtensions.RegisterDependencies(services);

            //------------------- SpecialityStatus -------------------//
            RegisterSpecialityStatusExtensions.RegisterDependencies(services);

            //------------------- SpecialityTrainingType -------------------//
            RegisterSpecialityTrainingTypeExtensions.RegisterDependencies(services);

            //------------------- TeacherDiscipline -------------------//
            RegisterTeacherDisciplineExtensions.RegisterDependencies(services);

            //------------------- TeacherDisciplineStatus -------------------//
            RegisterTeacherDisciplineStatusExtensions.RegisterDependencies(services);

            //------------------- TrainingType -------------------//
            RegisterTrainingTypeExtensions.RegisterDependencies(services);

            //------------------- User -------------------//
            RegisterUserExtensions.RegisterDependencies(services);

            //------------------- UserStatus -------------------//
            RegisterUserStatusExtensions.RegisterDependencies(services);

            //------------------- UserGroup -------------------//
            RegisterUserGroupExtensions.RegisterDependencies(services);

            //------------------- UserGroupStatus -------------------//
            RegisterUserGroupStatusExtensions.RegisterDependencies(services);

            //------------------- UserUserGroup -------------------//
            RegisterUserUserGroupExtensions.RegisterDependencies(services);

            //------------------- AuthenticationProvider -------------------//
            RegisterAuthenticationProviderExtensions.RegisterDependencies(services);

            //------------------- ApiSession -------------------//
            RegisterApiSessionExtensions.RegisterDependencies(services);

            //------------------- Login -------------------//
            RegisterAuthExtensions.RegisterDependencies(services);
        }       
    }
}
