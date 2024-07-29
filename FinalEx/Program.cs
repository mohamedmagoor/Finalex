namespace FinalEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 10- In the Main you need to declare a subject object to create one type of exam
            Subject math = new Subject(101, "Mathematics");
            string examType = "practical";
            if (math.AssociatedExam is PracticalExam practicalExam)
            {
                practicalExam.AddQuestion(new MCQQuestion("Question 1", "Choose the correct data type for 'Hello World':", 20,
                    new Answer[]
                    {
                    new Answer(1, "int"),
                    new Answer(2, "string"),
                    new Answer(3, "bool"),
                    new Answer(4, "char")
                    }, 2));
                practicalExam.AddQuestion(new MCQQuestion("Question 2", "What does HTML stand for?", 25,
                    new Answer[]
                    {
                    new Answer(1, "Hyper Text Markup Language"),
                    new Answer(2, "Hot Mail"),
                    new Answer(3, "How to Make Proj"),
                    new Answer(4, "High Text Markup Language")
                    }, 1));
            }
            else if (math.AssociatedExam is FinalExam finalExam)
            {
                finalExam.AddQuestion(new TrueFalseQuestion("Question 1", "Is the sky blue?", 10, true));
                finalExam.AddQuestion(new MCQQuestion("Question 2", "What is the best football player ?", 15,
                    new Answer[]
                    {
                    new Answer(1, "Cr7"),
                    new Answer(2, "Messi"),
                    new Answer(3, "Mo Salah"),
                    new Answer(4, "Mpappi")
                    }, 1));
            }
            Console.WriteLine("Subject Details:");
            math.PrintSubject();
            Console.WriteLine();


            #endregion

        }
    }
    }

