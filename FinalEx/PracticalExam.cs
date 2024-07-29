using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(string title, int time) : base(title, time) { }
        public override void ShowExam()
        {
            Console.WriteLine($"Practical Exam Title: {Title}");
            Console.WriteLine($"Duration: {Time} minutes");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
            Console.WriteLine("Questions:");
            foreach (var question in Questions)
            {
                question.PrintQuestion();
                Console.WriteLine();
            }
        }
    }
}
