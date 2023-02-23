using universesity.Models;

namespace universesity.Services
{
    public class ClassScheduleService
    {
        public interface IClassScheduleService
        {
            // Class methods
            IEnumerable<Class> GetClasses();
            Class GetClassById(int classId);
            void InsertClass(Class @class);
            void DeleteClass(int classId);
            void UpdateClass(Class @class);

            // Room methods
            IEnumerable<Room> GetRooms();
            Room GetRoomById(int roomId);
            void InsertRoom(Room room);
            void DeleteRoom(int roomId);
            void UpdateRoom(Room room);

            // Student Group methods
            IEnumerable<StudentGroup> GetStudentGroups();
            StudentGroup GetStudentGroupById(int studentGroupId);
            void InsertStudentGroup(StudentGroup studentGroup);
            void DeleteStudentGroup(int studentGroupId);
            void UpdateStudentGroup(StudentGroup studentGroup);

            // Subject methods
            IEnumerable<Subject> GetSubjects();
            Subject GetSubjectById(int subjectId);
            void InsertSubject(Subject subject);
            void DeleteSubject(int subjectId);
            void UpdateSubject(Subject subject);

            // Schedule methods
            IEnumerable<Class> GetSchedule();
            IEnumerable<Class> GetScheduleByStudentGroupId(int studentGroupId);
        }


    }



}

