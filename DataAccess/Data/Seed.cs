using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Models;

namespace DataAccess.Data
{
    public static class Seed
    {
        public static void Initialize(AthleticsDocsContext context)
        {
            context.Database.EnsureCreated();

            if (context.People.Any())
            {
                return;
            }

            var people = new List<Person>()
            {
                new Person()
                {
                    LastName = "Мытницкая", FirstName = "Галина", MiddleName = "Петровна",
                    Gender = Gender.Female, BirthDate = new DateTime(1957, 09, 21)
                },
                new Person() 
                { 
                    LastName = "Новошинская", FirstName = "Надежда", MiddleName = "Николаевна",
                    Gender = Gender.Female
                },
                new Person()
                {
                    LastName = "Мытницкая", FirstName = "Мария", 
                    Gender = Gender.Female, BirthDate = new DateTime(1997,01,06)
                },
                new Person()
                {
                    LastName = "Симонов", FirstName = "Никита", 
                    Gender = Gender.Male, BirthDate = new DateTime(2004, 03,25)
                },
                new Person()
                {
                    LastName = "Сараева", FirstName = "Ольга",
                    Gender = Gender.Female, BirthDate = new DateTime(2006,10,05)
                },
                new Person()
                {
                    LastName = "Шмидт", FirstName = "Александр",
                    Gender = Gender.Male, BirthDate = new DateTime(2006,06,28)
                },
                new Person()
                {
                    LastName = "Мытницкий", FirstName = "Кирилл",
                    Gender = Gender.Male, BirthDate = new DateTime(2006,02,08)
                },
                new Person()
                {
                    LastName = "Сулейманова", FirstName = "Карина",
                    Gender = Gender.Female, BirthDate = new DateTime(2007,04,25)
                },
                new Person()
                {
                    LastName = "Кульменева", FirstName = "Алина", 
                    Gender = Gender.Female, BirthDate = new DateTime(2007,10,18)
                },
                new Person()
                {
                    LastName = "Васильев", FirstName = "Артем",
                    Gender = Gender.Male, BirthDate = new DateTime(2007,11,11)
                },
                new Person()
                {
                    LastName = "Маташов", FirstName = "Курманбек",
                    Gender = Gender.Male, BirthDate = new DateTime(2007,01,17)
                },
                new Person()
                {
                    LastName = "Каштанова", FirstName = "Полина",
                    Gender = Gender.Female, BirthDate = new DateTime(2009,12,25)
                },
                new Person()
                {
                    LastName = "Кравченко", FirstName = "Александра",
                    Gender = Gender.Female, BirthDate = new DateTime(2009,01,16)
                },
                new Person()
                {
                    LastName = "Мерлина", FirstName = "Юлия", 
                    Gender = Gender.Female, BirthDate = new DateTime(2010,06,16)
                },
                new Person()
                {
                    LastName = "Буйнов", FirstName = "Владислав",
                    Gender = Gender.Male, BirthDate = new DateTime(2009,09,16)
                },
                new Person()
                {
                    LastName = "Ефремов", FirstName = "Карим",
                    Gender = Gender.Male, BirthDate = new DateTime(2009,08,11)
                },
                new Person()
                {
                    LastName = "Бердибаев", FirstName = "Эламан",
                    Gender = Gender.Male, BirthDate = new DateTime(2010,07,14)
                },
                new Person()
                {
                    LastName = "Спирина", FirstName = "Юлия",
                    Gender = Gender.Female, BirthDate = new DateTime(2011,01,14)
                },
                new Person()
                {
                    LastName = "Сараева", FirstName = "Мария",
                    Gender = Gender.Female, BirthDate = new DateTime(2011,09,09)
                },
                new Person()
                {
                    LastName = "Вдовенко", FirstName = "Давыд",
                    Gender = Gender.Male, BirthDate = new DateTime(2011,08,23)
                },
                new Person()
                {
                    LastName = "Кузьменко", FirstName = "Степан", 
                    Gender = Gender.Male, BirthDate = new DateTime(2011,11,17)
                },
                new Person()
                {
                    LastName = "Абдуллаев", FirstName = "Дмитрий",
                    Gender = Gender.Male, BirthDate = new DateTime(2013, 07,09)
                }
            };
            people.ForEach(x => context.People.Add(x));
            context.SaveChanges();

            var cities = new List<City>()
            {
                new City()
                {
                    Name = "Томск"
                },
                new City()
                {
                    Name = "Северск"
                }
            };
            cities.ForEach(x => context.Cities.Add(x));
            context.SaveChanges();

            var competitions = new List<Competition>()
            {
                new Competition()
                {
                    Name = "Городской легкоатлетический кросс", StartDate = new DateTime(2021,10,31)
                },
                new Competition()
                {
                    Name = "Первенство ДЮСШ УСЦ ВВС им. В.А. Шевелева по легкой ателтике", StartDate = new DateTime(2021,11,19)
                }
            };
            competitions.ForEach(x => context.Competitions.Add(x));
            context.SaveChanges();

            var levelsoftraining = new List<LevelOfTraining>()
            {
                new LevelOfTraining()
                {
                    Name = "Начальной подготовки", Duration = 1
                },
                new LevelOfTraining()
                {
                    Name = "Начальной подготовки", Duration = 2
                },
                new LevelOfTraining()
                {
                    Name = "Учебно-тренировочная"
                }
            };
            levelsoftraining.ForEach(x => context.LevelsOfTraining.Add(x));
            context.SaveChanges();

            var organizations = new List<Organization>()
            {
                new Organization()
                {
                    Name = "МАУ ДО ДЮСШ УСЦ ВВС им. В.А. Шевелева"
                },
                new Organization()
                {
                    Name = "СДЮСШОР №1 г.Томска"
                },
                new Organization()
                {
                    Name = "СДЮСШОР Северск"
                }
            };
            organizations.ForEach(x => context.Organizations.Add(x));
            context.SaveChanges();

            var ranks = new List<Rank>()
            {
                new Rank() { Name = "1" },
                new Rank() { Name = "2" },
                new Rank() { Name = "3" },
                new Rank() { Name = "1ю" },
                new Rank() { Name = "2ю" },
                new Rank() { Name = "3ю" },
                new Rank() { Name = "КМС" },
            };
            ranks.ForEach(x => context.Ranks.Add(x));
            context.SaveChanges();


            var groups = new List<Group>()
            {
                new Group()
                {
                    //Name = "М.Г.П.", 
                }
            };

            var coaches = new List<Coach>()
            {
                new Coach()
                {
                    //Person = people.FirstOrDefault(x => x.LastName == "Мытницкая" && x.FirstName == "Галина"),

                }
            };
        }
    }
}