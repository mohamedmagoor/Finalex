using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx
{
    internal abstract class Question
    {
       

        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public int CorrectAnswerId { get; set; }



      

       
        protected Question(string header, string body, int mark, Answer[] answerList, int correctAnswerId)
        {
            Header = header;
            Body = body;
            Mark = mark;
            CorrectAnswerId = correctAnswerId;
            AnswerList = answerList;

        }

        /*protected Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }*/

        public abstract void PrintQuestion();

    }
}
