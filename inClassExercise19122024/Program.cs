//loops 

using System;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("number: " + i);
}

Console.WriteLine("========================================================");



//question find 1-5 in a for loop total sum of them 
int sum = 0;
for (int i = 1; i <= 5; i++)
{
    // sum = i + i + i + i + i 
    // i want it to take sum  + i then add sum to second i
    //int sum = 0; cant define it here it will reset it 
    Console.WriteLine("current number is " + i);
    sum = sum + i; // 1
}
Console.WriteLine("sum = " + sum);

Console.WriteLine("========================================================");



// enter loops number, loop it 3 times so ask user to write how much looping then add the values he enters to each other 
int n = 0;
int sumation = 0;
Console.WriteLine("enter a variable to be repeated");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine("to find the sum enter the " + i + " number");
    //Console.WriteLine($"to find the sum enter the {i} number"); // another way to write it

    int x = Convert.ToInt32(Console.ReadLine());
    sumation = sumation + x;
    //sumation +=  Convert.ToInt32(Console.ReadLine()); //another way to write it 
}
Console.WriteLine("sum = " + sumation);

Console.WriteLine("===============================================================");


////                                          while
//int j = 0;
//int z = 0;
//Console.WriteLine("write a number: ");
//z = Convert.ToInt32(Console.ReadLine());
//while (j <= 0)
//{
//    Console.WriteLine("write a number: ");
//    j = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("invalid input");

//}
//Console.WriteLine("good job this is a valid number");

int num;
Console.WriteLine("write a number: ");
num = Convert.ToInt32(Console.ReadLine());
while (num < 0)
{
    Console.WriteLine("invalid, write a number: ");
    num = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine("good job this is a valid number");

//int for loops we can find data base just like we use th ewhie loops for that reason, obv while loop is better in that but we could use this
//for (int i = 1; i >= employee.lenght; i++)

Console.WriteLine("===============================================================");

// arrays 
int[] numbers = new int[4];
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;// if we didnt write itd be null
Console.WriteLine(numbers[1]);



int[] bruh = new int[4];
bruh[0] = 1;
bruh[1] = 2;
bruh[2] = 3;
bruh[3] = 4;// if we didnt write itd be null
Console.WriteLine("index: " + numbers[1]);

Console.WriteLine("===============================================================");

int[] test = new int[4];
test[0] = 1;
test[1] = 2;
test[2] = 3;
test[3] = 4;
for (int i = 0; i < test.Length; i++) //if we dont know the length of it we write this 
{
    Console.WriteLine("repeat: " + test[i]);
}

Console.WriteLine("===============================================================");

string[] namesOfPeople = new string[4];
namesOfPeople[0] = "ahmad";
namesOfPeople[1] = "khalid";
namesOfPeople[2] = "mohammad";
namesOfPeople[3] = "nawaf";
for (int f = 0; f <= 4; f++)
{
    Console.WriteLine("print: " + namesOfPeople[f].ToUpper()); // to print upper case
}
