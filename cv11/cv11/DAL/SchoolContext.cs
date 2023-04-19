using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cv11.DAL.MODELS;
using Microsoft.EntityFrameworkCore;

namespace cv11.DAL
{
    public class SchoolContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        //public DbSet<StudentSubject> StudentSubjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBUilder)
        {
            optionsBUilder.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Student\source\repos\cv11\cv11\Database.mdf; Integrated Security = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<StudentSubject>()
            //            .HasKey(ss => new { ss.StudentId, ss.SubjectId });

            modelBuilder.Entity<Student>()
                        .HasMany<Subject>(ss => ss.Subjects)
                        .WithMany(ss => ss.Students);
        }

        public void AddStudent(string name, string surname, DateTime date)
        {
            Students.Add(new Student() { Firstname = name, Surname = surname, DateOfBirth = date });
            SaveChanges();
        }
        public void AddSubject(string shortcut, string name)
        {
            Subjects.Add(new Subject() { Shortcut = shortcut, Name = name });
            SaveChanges();
        }

       /*public void AddStudentSubject(int studId, int subjId)
        {
            StudentSubjects.Add(new StudentSubject() {StudentId = studId, SubjectId = subjId});
            SaveChanges();
        }*/

        public IEnumerable<Student> StudentsOfSubjects(int subjId)
        {
            return Subjects.FirstOrDefault(s => s.SubjectId == subjId).Students;
            //IEnumerable<Student> students = Enumerable.Empty<Student>();
            //foreach (var obj in result)
            //{
            //    IEnumerable<Student> local = Students.Where(d => d.StudentId == obj.StudentId);
            //    if (local != null)
            //        students = students.Concat(local);

            //}
            //return students;
        }
    }
}
