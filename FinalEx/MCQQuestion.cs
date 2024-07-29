using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, Answer[] answerList, int correctAnswerId) : base(header, body, mark, answerList, correctAnswerId)
        {
            
        }

        public List<string> Options { get; set; }
        public int CorrectAnswerIndex { get; set; }


        public override void PrintQuestion()
        {
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine("Options:");
            for (int i = 0; i < AnswerList.Length; i++)
            {
                AnswerList[i].PrintAnswer();
            }
            Console.WriteLine($"Mark: {Mark}");
        }
    }
}
