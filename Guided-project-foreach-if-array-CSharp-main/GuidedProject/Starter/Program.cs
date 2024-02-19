int currentAssignments = 5;
int[] studentScores = new int[10];
int[] extraScores = new int[10];

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

int[] sophiaExtraScores = new int[] { 84, 90 };
int[] andrewExtraScores = new int[] { 89 };
int[] emmaExtraScores = new int[] { 89, 89, 89 };
int[] loganExtraScores = new int[] { 96 };

string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{   string currentStudent = name;

    if (currentStudent == "Sophia")
        {studentScores = sophiaScores;
        extraScores = sophiaExtraScores;}
    else if(currentStudent == "Andrew")
        {studentScores = andrewScores;
        extraScores = andrewExtraScores;}
    else if(currentStudent == "Emma")
        {studentScores = emmaScores;
        extraScores = emmaExtraScores;}
    else if(currentStudent == "Logan")
        {studentScores = loganScores;
        extraScores = loganExtraScores;}
    
    int sumAssignmentScores = 0;

    decimal currentExtraAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
        {
            sumAssignmentScores += score;
        }
    
    foreach (int score in extraScores)
        {
            currentExtraAssignmentScores += score;
        }

    currentStudentGrade = (decimal)(sumAssignmentScores + (currentExtraAssignmentScores/10)) / currentAssignments;

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

    Console.WriteLine($"{currentStudent}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
    
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
