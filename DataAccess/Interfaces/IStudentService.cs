using System;
using System.Collections.Generic;
using DataAccess.Facades;

namespace DataAccess.Interfaces
{
    public interface IStudentService
    {
        List<StudentFacade> GetAllStudents();
        bool DeleteStudentById(Guid id);
        void AddStudent(StudentFacade student);
        bool UpdateStudent(StudentFacade student);
    }
}