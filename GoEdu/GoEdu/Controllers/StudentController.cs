using GoEdu.Data;
using GoEdu.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GoEdu.Models;

namespace GoEdu.Controllers
{
    public class StudentController : Controller
    {
        private UnitOfWork unitOfWork;
        public StudentController(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }  
        
        public IActionResult DashBoard(int StudentId)
        {
                VMStudentDashBoard Dashboard = new VMStudentDashBoard
                {
                    TodayLectures = unitOfWork.LectureRepository.GetTodayLectureByStudentId(StudentId),
                    LateLectures = unitOfWork.LectureRepository.GetLateLectures(StudentId),
                };
            //nessecary need to send error from action "LectureDetails" in lecture controller
            if (ModelState.IsValid) { }
            return View(Dashboard);
        }


        
        public IActionResult AllStudentsByInstructor(int instructorId)
        {
            StudentsCoursesVM StdVM = new();

            //all Students by instructor
            StdVM.Students = unitOfWork.StudentRepo.GetStudentsByInstructor(instructorId);

            // get courses by instructor
            StdVM.Courses = unitOfWork.CourseRepo.CoursesByInstructor(instructorId);            

            return View(StdVM);
        }

        [HttpPost]
        public IActionResult FilterStudentsByCourse(int id, StudentsCoursesVM StudentsfromView)
        {
            if (StudentsfromView.CourseId != 0)
            {
                // get students with a specific course
                StudentsfromView.Students = unitOfWork.StudentRepo.
                                            GetStudentsByCourse(StudentsfromView.CourseId);
            }
           
            
            return View("AllStudentsByInstructor", StudentsfromView);
        }

        public IActionResult Details(int id)
        {
            Student std = unitOfWork.StudentRepo.GetByID(id);
            return View(std);
        }       
    }
}
