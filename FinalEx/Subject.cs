using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string? Name { get; set; }
        public Exam? AssociatedExam { get; set; }

        public Subject(int subjectId, string name)
        {
            SubjectId = subjectId;
            Name = name;
        }
        public void PrintSubject()
        {
            Console.WriteLine($"Subject ID: {SubjectId}");
            Console.WriteLine($"Subject Name: {Name}");
            if (AssociatedExam != null)
            {
                Console.WriteLine("Associated Exam Details:");
                AssociatedExam.ShowExam();
            }
            else
            {
                Console.WriteLine("No associated exam.");
            }

        }
    }
}