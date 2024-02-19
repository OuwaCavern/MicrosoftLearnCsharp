/*
What is the do-while statement?
The do-while statement executes a statement or a block of statements while a specified Boolean expression evaluates to true. Because that expression is evaluated after each execution of the loop, a do-while loop executes one or more times.

c#

do
{
    // This code executes at least one time
} while (true);

The flow of execution starts inside of the curly brace. The code executes at least one time, then the Boolean expression next to the while keyword is evaluated. If the Boolean expression returns true, the code block is executed again.

By hard coding the Boolean expression to true, we've created an infinite loop--a loop that will never end, at least, not as it's currently written. We would need a way to break out of the loop inside of the code block. We'll discuss the exit criteria of a do-while in a bit.

*/

Random randnumberer = new Random();
int randnumber = 0;
int randnumber2 = 0;

do
{
     randnumber = randnumberer.Next(1,7);
     Console.WriteLine(randnumber);
}    while(randnumber != 6);

// continue keyword skips all lines below inside the do statement if it evaluates to true

do
{
    randnumber2 = randnumberer.Next(1,20);
    if (randnumber2 >=10)
    continue;
    Console.WriteLine(randnumber2);
} while (randnumber2 < 15);