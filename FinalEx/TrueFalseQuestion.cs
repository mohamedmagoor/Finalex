using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark, bool correctAnswer)
        : base(header, body, mark, new Answer[]
        {
            new Answer(1, "True"),
            new Answer(2, "False")
        }, correctAnswer ? 1 : 2)
        { }



        public override void PrintQuestion()
        {
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine("Options: ");
           /* foreach (var answer in Answers)
            {
                answer.PrintAnswer();
            }
            Console.WriteLine($"Mark: {Mark}");*/
        }
    }

       
        
    }

