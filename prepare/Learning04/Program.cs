using System;

class Program
{
    static void Main(string[] args)
    {
        string student = "jim";
        string topic = "math";
        string textBookSection = "7.9";
        string problems = "9-14";
        MathAssignment mathassignment1 = new MathAssignment(student, topic, textBookSection, problems);
        mathassignment1.GetSummary();
        mathassignment1.GetHomeWorkList();

        string writingStudent = "Mary Waters";
        string writingTopic = "World War 2";
        string writingTitle = "Why It Happened";

        WritingAssignment writingAssignment = new WritingAssignment(writingStudent, writingTopic, writingTitle);
        writingAssignment.GetSummary();
        writingAssignment.GetWritingInformation();


    }
}