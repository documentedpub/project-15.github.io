using System;
int examAssignments = 5;
int[] sophiaExamScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewExamScores = [92, 89, 81, 96, 90, 89];
int[] emmaExamScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganExamScores = [90, 95, 87, 88, 96, 96];
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];
int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

foreach (var name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaExamScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewExamScores;
    
    else if (currentStudent == "Emma")
        studentScores = emmaExamScores;
    
    else if (currentStudent == "Logan")
        studentScores = loganExamScores;
    
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    
    else
        continue;
    

    int sumAssignmentScores = 0; // sum
    decimal currentStudentGrade = 0; // average
    int gradedAssignments = 0; // exams without extra credit assignments
    foreach (int score in studentScores)
    {
        gradedAssignments++;
        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
        }
        else
        {
            sumAssignmentScores += score / 10;
        }
    }
    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";
    Console.WriteLine($"{currentStudent}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
