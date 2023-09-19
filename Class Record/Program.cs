// Initialize Student Name Array

string[] studentNames = {"John", "George", "Paul", "Ringo"};

// Initialize Student Scores Array

int[] studentScore1 = {97, 80, 99, 87, 91, 77, 80, 80};
int[] studentScore2 = {91, 82, 99, 84, 95, 91};
int[] studentScore3 = {95, 84, 99, 81, 92, 80, 71};
int[] studentScore4 = {90, 82, 99, 84, 80, 80};

// Initialize constant variables

int rawScoreSize = 5;
int[] currentScores = new int[10];
string studentRating = "";

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tRating\tBonus\n");

// List all student names from the student array

foreach (string name in studentNames)
{
    
    if (name == "John")
    {
        currentScores = studentScore1;
    }
    else if (name == "George")
    {
        currentScores = studentScore2;
    }
    else if (name == "Paul")
    {
        currentScores = studentScore3;
    }
    else if (name == "Ringo")
    {
        currentScores = studentScore4;
    }

    decimal studentRawScore = 0;
    decimal studentBonusScore = 0;
    decimal studentTotalScore = 0;
    int indexCounter = 0;

    // List student's raw score

    foreach (int score in currentScores)
    {   
        indexCounter +=1;
        
        if (indexCounter <= rawScoreSize)
        {
            studentRawScore += score;
        }
        else
        {
            studentBonusScore += score;
        }
    }

    studentRawScore /= rawScoreSize;

    studentBonusScore /= (currentScores.Length - rawScoreSize);

    // Compute the total grade of each students

    studentTotalScore = studentRawScore + (studentBonusScore / 10);


// Determine the letter rating based from the given range

if (studentTotalScore >= 97)

        studentRating = "A+";

    else if (studentTotalScore >= 93)
        studentRating = "A";

    else if (studentTotalScore >= 90)
        studentRating = "A-";

    else if (studentTotalScore >= 87)
        studentRating = "B+";

    else if (studentTotalScore >= 83)
        studentRating = "B";

    else if (studentTotalScore >= 80)
        studentRating = "B-";

    else if (studentTotalScore >= 77)
        studentRating = "C+";

    else if (studentTotalScore >= 73)
        studentRating = "C";

    else if (studentTotalScore >= 70)
        studentRating = "C-";

    else if (studentTotalScore >= 67)
        studentRating = "D+";

    else if (studentTotalScore >= 63)
        studentRating = "D";

    else if (studentTotalScore >= 60)
        studentRating = "D-";
    else
        studentRating = "F";


    // Output the grading table 

    Console.WriteLine($"{name}\t\t{studentRawScore}\t\t{studentTotalScore}\t\t{studentRating}\t{studentBonusScore} ({(studentBonusScore / 10) / rawScoreSize} pts)");
}

Console.WriteLine("Press any key to continue...");
Console.ReadLine();