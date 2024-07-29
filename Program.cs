namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject math = new Subject
            {
                SubjectId = 1,
                SubjectName = "Mathematics"
            };

            FinalExam finalExam = new FinalExam
            {
                TimeOfExam = DateTime.Now,
                NumberOfQuestions = 2,
                Questions = new List<Question>
            {
                new TrueFalseQuestion
                {
                    Header = "Q1",
                    Body = "Is 2+2=4?",
                    Mark = 1,
                    RightAnswer = new Answer { AnswerId = 1, AnswerText = "True" }
                },
                new MCQQuestion(
                    new List<Answer>
                    {
                        new Answer { AnswerId = 1, AnswerText = "2" },
                        new Answer { AnswerId = 2, AnswerText = "3" },
                        new Answer { AnswerId = 3, AnswerText = "4" },
                        new Answer { AnswerId = 4, AnswerText = "5" }
                    },
                    new Answer { AnswerId = 3, AnswerText = "4" }
                )
                {
                    Header = "Q2",
                    Body = "What is 2+2?",
                    Mark = 1
                }
            }
            };

            math.CreateExam(finalExam);

            math.SubjectExam.ShowExam();
        }
    }
}
