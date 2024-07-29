using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{

    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
    }

    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
    }

    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion()
        {
            AnswerList = new List<Answer>
        {
            new Answer { AnswerId = 1, AnswerText = "True" },
            new Answer { AnswerId = 2, AnswerText = "False" }
        };
        }
    }

    public class MCQQuestion : Question
    {
        public MCQQuestion(List<Answer> answers, Answer rightAnswer)
        {
            AnswerList = answers;
            RightAnswer = rightAnswer;
        }
    }

    public abstract class Exam
    {
        public DateTime TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }

        public abstract void ShowExam();
    }

    public class FinalExam : Exam
    {
        public override void ShowExam()
        {
            foreach (var question in Questions)
            {
                Console.WriteLine($"{question.Header}: {question.Body}");
                foreach (var answer in question.AnswerList)
                {
                    Console.WriteLine($"- {answer.AnswerText}");
                }
            }
        }
    }

    public class PracticalExam : Exam
    {
        public override void ShowExam()
        {
            foreach (var question in Questions)
            {
                Console.WriteLine($"{question.Header}: {question.Body}");
                foreach (var answer in question.AnswerList)
                {
                    Console.WriteLine($"- {answer.AnswerText}");
                }
            }

            Console.WriteLine("Correct Answers:");
            foreach (var question in Questions)
            {
                Console.WriteLine($"{question.Header}: {question.RightAnswer.AnswerText}");
            }
        }
    }

    public class Subject : ICloneable, IComparable<Subject>
    {
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public void CreateExam(Exam exam)
        {
            SubjectExam = exam;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Subject other)
        {
            return this.SubjectId.CompareTo(other.SubjectId);
        }

        public override string ToString()
        {
            return $"Subject Id: {SubjectId}, Subject Name: {SubjectName}";
        }
    }

    
}
