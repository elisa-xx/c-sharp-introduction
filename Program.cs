/*
 Q1.
Create a program to find a student’s grade. The user will provide a test score (out of 100) and the
program will display a “PASS” or “FAIL” output on the screen. If the test score is at least 50 out of
100, the output is “PASS”. Otherwise it will display “FAIL”.
*/
//https://codeeasy.io/lesson/input_validation

Console.WriteLine("Question 1\n");



Console.WriteLine("Please enter your test score");
var score1aStr = Console.ReadLine();// why var and not string?
int score1a;
while (!int.TryParse(score1aStr, out score1a))
{
    Console.WriteLine($"Please enter a number");
    score1aStr= Console.ReadLine();// why do I not have to write the data type of score1aStr before the name?
} 
    Console.WriteLine($"Thanks for entering a score");
if (score1a >= 0 && score1a <= 49)
{
    Console.WriteLine("FAIL");
}
else if (score1a >= 50 && score1a <= 100)
{
    Console.WriteLine("PASS");
}
else
    Console.WriteLine("You have entered an invalid score");


/* The code below works well
 * 
Console.WriteLine("Please enter your test score");
int score1 = int.Parse(Console.ReadLine());
if (score1 >= 50 && score1 <= 100)
{
    Console.WriteLine("PASS");
}
else Console.WriteLine("FAIL");
*/


/*
Q2.
Modify the program created in Q1 to display the student grade based on the following score table:
Test Score Grade
Less than 0 ERROR
1 - 49 FAIL
50 - 64 PASS
65 - 79 CREDIT
80 - 100 DISTINCTION
Over 100 ERROR
*/

Console.WriteLine("\nQuestion 2 \n");
Console.WriteLine("Please enter your test score:");
int score2 = int.Parse(Console.ReadLine());
if (score2 >= 1 && score2 <= 49)
{
    Console.WriteLine("FAIL");

}

else if (score2 >= 50 && score2 <= 64)
{
    Console.WriteLine("PASS");

}
else if (score2 >= 65 && score2 <= 79)
{
    Console.WriteLine("CREDIT");
}
else if (score2 >= 80 && score2 <= 100)
{
    Console.WriteLine("DISTINCTION");
}
else
    Console.WriteLine("Error");
Console.WriteLine("\n");


/*
Q3.
Create a program to check if the input character is a vowel or a consonant. Vowel characters are a,
i, e, o and u
*/

Console.WriteLine("Question 3 \n");
Console.WriteLine("Type a character");
//string input = Console.ReadLine().ToLower;// why does this line not work when the ToUpper example in class did?
string input = Console.ReadLine();
if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
{
    Console.WriteLine($"{input} is a vowel");
}
else Console.WriteLine($"{input} is a consanant");