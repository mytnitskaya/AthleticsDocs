using System;
using System.Collections.Generic;
using DataAccess.Models;

namespace DataAccess.Facades
{
    public class StudentFacade
    {
        private Student _model;

        public StudentFacade()
        {
            _model = new Student();
        }
        //разобраться зачем нам два конструктора и нужны ли оба
        public StudentFacade(Student model)
        {
            _model = model;
        }

        public Student GetModel()
        {
            return _model;
        }

        public Guid Id
        {
            get => _model.Id;
        }

    }
}