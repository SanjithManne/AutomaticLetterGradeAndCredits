using System.Data.Common;
using System.Runtime.ExceptionServices;
decimal currentAssignments = 5m;

decimal[] sophiaScores = new decimal[] { 90, 86, 87, 98, 100, 94, 90 };
decimal[] andrewScores = new decimal[] { 92, 89, 81, 96, 90, 89 };
decimal[] emmaScores = new decimal[] { 90, 85, 87, 98, 68, 89, 89, 89 };
decimal[] loganScores = new decimal[] { 90, 95, 87, 88, 96, 96 };
decimal[] beckyScores = new decimal[] { 92, 91, 90, 91, 92, 92, 92 };
decimal[] chrisScores = new decimal[] { 84, 86, 88, 90, 92, 94, 96, 98 };
decimal[] ericScores = new decimal[] { 80, 90, 100, 80, 90, 100, 80, 90 };
decimal[] gregorScores = new decimal[] { 91, 91, 91, 91, 91, 91, 91 };    


decimal[] studentScores = new decimal[10];
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
string grade = "";
Console.WriteLine("Student\t\tOld Score\tFinal Score\tGrade\t\tExtra Credit\n");

foreach(string name in studentNames)
{
    
    if (name == "Sophia")
    studentScores = sophiaScores;

    else if (name == "Andrew")
    studentScores = andrewScores;

    else if (name == "Emma")
    studentScores = emmaScores;

    else if (name == "Logan")
    studentScores = loganScores;

    else if (name == "Becky")
    studentScores = beckyScores;

    else if (name == "Chris")
    studentScores = chrisScores;

    else if (name == "Eric")
    studentScores = ericScores;

    else if (name == "Gregor")
    studentScores = gregorScores;

    else
    continue;

    decimal sumScores = 0m;
    decimal oldStudentScore = 0m;
    decimal studentScoreAvg = 0m;
    decimal totalExams = 0m;
    decimal oldStudentScoreAvg = 0m;
    decimal extraCredit = 0m;


    foreach(int score in studentScores)
    {

    totalExams += 1;

    if(totalExams <= currentAssignments)
    oldStudentScore += score;
    
            if(totalExams <= currentAssignments)
            sumScores += score ;
            else
            sumScores += score / 10m;
            oldStudentScoreAvg = (decimal)oldStudentScore / (decimal)currentAssignments;
            studentScoreAvg = (decimal)sumScores / (decimal)currentAssignments;
   

        if (studentScoreAvg > 97)
        grade = "A+";
        else if (studentScoreAvg > 93)
        grade = "A";
        else if (studentScoreAvg > 90)
        grade = "A-";
        else if (studentScoreAvg > 87)
        grade = "B+";
        else if (studentScoreAvg > 83)
        grade = "B";
        else if (studentScoreAvg > 80)
        grade = "B-";
        else if (studentScoreAvg > 77)
        grade = "C+";
        else if (studentScoreAvg > 73)
        grade = "C";
        else if (studentScoreAvg > 70)
        grade = "C-";
        else if (studentScoreAvg > 67)
        grade = "D+";
        else if (studentScoreAvg > 63)
        grade = "D";
        else if (studentScoreAvg > 60)
        grade = "D-";
        else 
        grade = "F";
    }
   
    extraCredit = (decimal)studentScoreAvg - (decimal)oldStudentScoreAvg;
    Console.WriteLine($"{name}\t\t{oldStudentScoreAvg:F1}\t\t{studentScoreAvg:F2}\t\t{grade}\t\t{oldStudentScoreAvg:F0} ({extraCredit:F2} pts)");
}
