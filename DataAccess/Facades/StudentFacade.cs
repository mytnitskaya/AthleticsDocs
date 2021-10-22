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

        public string FirstName
        {
            get => _model.FirstName;
            set => _model.FirstName = value;
        }

        public string LastName
        {
            get => _model.LastName;
            set => _model.LastName = value;
        }

        public string MiddleName
        {
            get => _model.MiddleName;
            set => _model.MiddleName = value;
        }

        public DateTime BirthDate
        {
            get => _model.BirthDate;
            set => _model.BirthDate = value;
        }

        public Rank Rank
        {
            get => (Rank)_model.Rank;
            set => _model.Rank = (int) value;
        }
        //добавить switch для переделки в стринг если будут проблемы с вьюшкой

        public List<Coach> Coaches
        {
            get => _model.Coaches;
            set => _model.Coaches = value;
        }
    }
}