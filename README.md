# 📝 Exam System in C#

## 📖 Description
This is a simple console-based Exam System built using C#. It demonstrates object-oriented programming principles such as:
- Abstraction
- Inheritance
- Polymorphism
- Interfaces

The system supports two types of exams:
- Final Exam
- Practical Exam

Each exam can contain **True/False** and **Multiple Choice Questions (MCQ)**. It also allows managing subjects and assigning exams to them.

---

## Project Structure

| File         | Description                                         |
|--------------|-----------------------------------------------------|
| `Program.cs` | Entry point of the program where the exam is created and displayed. |
| `Class1.cs`  | Contains all core classes: `Answer`, `Question`, `Exam`, `FinalExam`, `PracticalExam`, and `Subject`. |

---

## ✅ Features
- Add subjects with IDs and names.
- Create final or practical exams.
- Support True/False and MCQ question types.
- Show questions and answers in the console.
- Display correct answers in practical exams.

---

## 🧠 Example Output

Q1: Is 2+2=4?

True

False 

Q2: What is 2+2?

2

3

4

5


> PracticalExam also shows correct answers at the end.

---

## 🛠 Technologies Used
- C#
- .NET Console Application

---

## 🚀 How to Run
1. Open the project in **Visual Studio** or any C# IDE.
2. Make sure all files are in the same namespace `Exam`.
3. Press `F5` or run the application.

---

## 👨‍💻 Author
Mahmoud Ahmed Alam Eldin

---

## 📌 Notes
You can extend this system by:
- Adding more question types.
- Saving/loading questions from a file or database.
- Adding a timer for exams.
