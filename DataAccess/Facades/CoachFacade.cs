using System;
using System.Linq;
using DataAccess.Models;

namespace DataAccess.Facades
{
    public class CoachFacade
    {
        private Coach _model;

        public CoachFacade()
        {
            _model = new Coach();
        }

        public Coach GetModel()
        {
            return _model;
        }

        public Guid Id
        {
            get => _model.Id;
        }

        public string FullName
        {
            get => _model.LastName + " " + _model.FirstName + " " + _model.MiddleName;
        }
        public string FullNameShort
        {
            get => _model.LastName + " " + _model.FirstName.FirstOrDefault() + "." +
                   _model.MiddleName.FirstOrDefault() + ".";
        }
    }
}