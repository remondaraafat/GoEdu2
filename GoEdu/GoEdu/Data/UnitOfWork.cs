﻿using GoEdu.Models;
using GoEdu.Repositories;

namespace GoEdu.Data
{
    public class UnitOfWork
    {
        private readonly GoEduContext context;
        private IAnswerRepository _AnswerRepo;
        private IAttendRepository _AttendRepo;
        private ICommentRepository _CommentRepo;
        private ICourseRepository _CourseRepo;       
        private IInstructorRepository _InstructorRepo;
        private ILectureRepository _LectureRepo;
        private IOptionRepository _OptionRepo;
        private IQuestionRepository _QuestionRepo;
        private IEnrollRepository _EnrollRepo;
        private IStudentPerformanceRepository _StudentPerformanceRepo;
        private IStudentRepository _StudentRepo;

        public UnitOfWork(GoEduContext ctx)
        {
            context = ctx;
        }

        public IAnswerRepository AnswerRepo
        {
            get
            {
                if (_AnswerRepo == null)
                    _AnswerRepo = new AnswerRepository(context);
                return _AnswerRepo;
            }
        }
        public void save()
        {
            context.SaveChanges();
        }

        public IAttendRepository AttendRepo
        {
            get
            {
                if (_AttendRepo == null)
                    _AttendRepo = new AttendRepository(context);
                return _AttendRepo;
            }
        }

        public ICommentRepository CommentRepo
        {
            get
            {
                if (_CommentRepo == null)
                    _CommentRepo = new CommentRepository(context);
                return _CommentRepo;
            }
        }

        public ICourseRepository CourseRepo
        {
            get
            {
                if (_CourseRepo == null)
                    _CourseRepo = new CourseRepository(context);
                return _CourseRepo;
            }
        }

        //public IInstructorRepository InstructorRepo
        //{
        //    get
        //    {
        //        if (_InstructorRepo == null)
        //            _InstructorRepo = new InstructorRepository(context);
        //        return _InstructorRepo;
        //    }
        //}

        public ILectureRepository LectureRepository
        {
            get
            {
                if (_LectureRepo == null)
                    _LectureRepo = new LectureRepository(context, this);
                return _LectureRepo;
            }
        }

        public IOptionRepository OptionRepo
        {
            get
            {
                if (_OptionRepo == null)
                    _OptionRepo = new OptionRepository(context);
                return _OptionRepo;
            }
        }

        public IQuestionRepository QuestionRepo
        {
            get
            {
                if (_QuestionRepo == null)
                    _QuestionRepo = new QuestionRepository(context);
                return _QuestionRepo;
            }
        }

        public IEnrollRepository EnrollRepo
        {
            get
            {
                if (_EnrollRepo == null)
                    _EnrollRepo = new EnrollRepository(context);
                return _EnrollRepo;
            }
        }

        public IStudentPerformanceRepository StudentPerformanceRepo
        {
            get
            {
                if (_StudentPerformanceRepo == null)
                    _StudentPerformanceRepo = new StudentPerformanceRepository(context);
                return _StudentPerformanceRepo;
            }
        }

        public IStudentRepository StudentRepo
        {
            get
            {
                if (_StudentRepo == null)
                    _StudentRepo = new StudentRepository(context);
                return _StudentRepo;
            }
        }


    }
}
