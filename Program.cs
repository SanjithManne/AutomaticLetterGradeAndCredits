using System.Runtime.ExceptionServices;
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    


int[] studentScores = new int[10];
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
string grade = "";
Console.WriteLine("Student\t\tScore\tGrade\n");

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

    int sumScores = 0;
    decimal studentScoreAvg = 0;
    int totalExams = 0;;

    foreach(int score in studentScores)
    {
    totalExams += 1;

        if(totalExams <= currentAssignments)
        sumScores += score ;
        else
        sumScores += score / 10;

    studentScoreAvg = (decimal)sumScores / currentAssignments;
      
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
Console.WriteLine($"{name}\t\t{studentScoreAvg}\t{grade}");
}