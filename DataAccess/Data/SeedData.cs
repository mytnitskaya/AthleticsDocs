using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AthleticsDocsContext
                (serviceProvider.GetRequiredService
                <DbContextOptions<AthleticsDocsContext>>()))
            {
                if (context.People.Any())
                {
                    return;
                }

                var cities = new List<City>
                {
                    new City { Name = "Томск" },
                    new City { Name = "Северск" }
                };
                //cities.ForEach(x => context.Cities.AddRange(x));
                context.AddRange(cities);
                context.SaveChanges();

                var organizations = new List<Organization>
                {
                    new Organization { Name = "МАУ ДО ДЮСШ УСЦ ВВС им. В.А. Шевелева" },
                    new Organization { Name = "СДЮСШОР №1 г. Томска" }
                };
                //organizations.ForEach(x => context.Organizations.AddRange(x));
                context.AddRange(organizations);
                context.SaveChanges();

                var ranks = new List<Rank>
                {
                    new Rank { Name = "1" },
                    new Rank { Name = "2" },
                    new Rank { Name = "3" },
                    new Rank { Name = "1ю" },
                    new Rank { Name = "2ю" },
                    new Rank { Name = "3ю" },
                };
                //ranks.ForEach(x => context.Ranks.AddRange(x));
                context.AddRange(ranks);
                context.SaveChanges();

                var coaches = new List<Coach>
                {
                    new Coach
                    {
                        Person = new Person
                        {
                            FirstName = "Галина", MiddleName = "Петровна", LastName = "Мытницкая",
                            Gender = Gender.Female
                        },
                    },

                    new Coach
                    {
                        Person = new Person
                        {
                            FirstName = "Надежда", MiddleName = "Николаевна", LastName = "Новошинская",
                            Gender = Gender.Female
                        },
                    }

                };
                //coaches.ForEach(x => context.Coaches.AddRange(x));
                context.AddRange(coaches);
                context.SaveChanges();

                var students = new List<Student>
                {
                    new Student
                    {
                        Person = new Person
                        {
                            FirstName = "Алина", LastName = "Изофенко",
                            Gender = Gender.Female, BirthDate = new DateTime(1997, 09, 09),
                        },
                        Coach = coaches.Single(x => x.Person.LastName == "Новошинская"),
                        City = cities.Single(x => x.Name == "Северск"),
                        Rank = ranks.Single(x => x.Name == "2")
                    },

                    new Student
                    {
                        Person = new Person
                        {
                            FirstName = "Кирилл", LastName = "Мытницкий",
                            Gender = Gender.Male, BirthDate = new DateTime(2006, 02, 08),
                        },
                        Rank = ranks.Single(x => x.Name == "2ю")
                    },

                    new Student
                    {
                        Person = new Person
                        {
                            FirstName = "Дарья", LastName = "Гритчина",
                            Gender = Gender.Female, BirthDate = new DateTime(1998, 05, 05),
                        },
                        Rank = ranks.Single(x => x.Name == "1"),
                        Organization = organizations.Single(x => x.Name == "МАУ ДО ДЮСШ УСЦ ВВС им. В.А. Шевелева")
                    },

                    new Student
                    {
                        Person = new Person
                        {
                            FirstName = "Дмитрий", LastName = "Абдуллаев",
                            Gender = Gender.Male, BirthDate = new DateTime(2013, 07, 09),
                        },
                        Coach = coaches.Single(x => x.Person.LastName == "Новошинская"),
                        City = cities.Single(x => x.Name == "Томск")
                    },

                    new Student
                    {
                        Person = new Person
                        {
                            FirstName = "Никита", LastName = "Симонов",
                            Gender = Gender.Male, BirthDate = new DateTime(2004, 03, 24),
                        },
                        Coach = coaches.Single(x => x.Person.LastName == "Мытницкая"),
                        Rank = ranks.Single(x => x.Name == "1ю")

                    },

                    new Student
                    {
                        Person = new Person
                        {
                            FirstName = "Мария", MiddleName = "Егоркина", LastName = "Шубкина",
                            Gender = Gender.Female, BirthDate = new DateTime(1997, 07, 27),
                        },
                        Coach = coaches.Single(x => x.Person.LastName == "Мытницкая")

                    },

                    new Student
                    {
                        Person = new Person
                        {
                            FirstName = "Мария", MiddleName = "Викторовна", LastName = "Мытницкая",
                            Gender = Gender.Female, BirthDate = new DateTime(1997,01,06)
                        },
                        Coach = coaches.Single(x => x.Person.LastName == "Мытницкая"),
                        City = cities.Single(x => x.Name == "Томск")
                    }
                };
                //students.ForEach(x => context.Students.AddRange(x));
                context.AddRange(students);
                context.SaveChanges();


            }
        }
    }
}