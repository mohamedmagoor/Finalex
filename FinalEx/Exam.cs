using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx
{
    internal abstract class  Exam
    {
        public string Title { get; set; }
        public int Time { get; set; } //===> for timingg...
        public int NumberOfQuestions
        {
            get { return Questions.Count; }
        }
        public List<Question> Questions { get; set; }

        public Exam(string title,int time)
        {
            Title = title;
            Time = time;
            Questions = new List<Question>();
        }
        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
        public void PrintExam()
        {
            Console.WriteLine($"Exam Title: {Title}");
            Console.WriteLine("Questions:");
            foreach (var question in Questions)
            {
                question.PrintQuestion();
            }
        }
        public abstract void ShowExam();
    }
}
