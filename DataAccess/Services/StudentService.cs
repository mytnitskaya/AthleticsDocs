using System;
using System.Collections.Generic;
using DataAccess.Facades;
using DataAccess.Interfaces;

namespace DataAccess.Services
{
    public class StudentService : IStudentService
    {
        public List<StudentFacade> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public bool DeleteStudentById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void AddStudent(StudentFacade student)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStudent(StudentFacade student)
        {
            throw new NotImplementedException();
        }
    }
}