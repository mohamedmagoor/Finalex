using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx
{
    internal class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
        public void PrintAnswer()
        {
            Console.WriteLine($"Answer ID: {AnswerId}");
            Console.WriteLine($"Answer Text: {AnswerText}");
        }
    }
}
