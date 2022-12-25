// Задача. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*int CutNumber(int number)
{
  int sot = number / 100;
  int ed = number % 10;
  int result = sot*10 + ed;
  return result;
}
 int randNumber = new Random().Next(100,1000);
 int newNumber = CutNumber(randNumber);
 Console.WriteLine($"New version of a number {randNumber} is {newNumber}");
*/

/*
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int func(int num)
{
  int num1 = num / 10;
  int num2 = num % 10;
  if(num1 == num2) 
   {
      return -1; //("Number Equal");
   }
  else 
  {
   if (num1>num2)
     {
      return num1;
     }
  else
  {
   return num2;
   }
}
}
 int randomnum = new Random().Next(10,100);
Console.WriteLine(randomnum);
Console.WriteLine(func(randomnum));
*/

/*
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
bool func(int num1, int num2)
{
  if(num2 % num1 == 0) return true;
else return false;
}
Console.WriteLine("Input number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(func(num1,num2));
*/

/*
bool func(int num1, num2)
{
  if(num1 * num1 == num2 || num2*num2 == num1) return true;
else return false;
}
Console.Write("Input number 1: ");
int num1 = ConvertToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int num1 = ConvertToInt32(Console.ReadLine());
Console.Write(func(num1.num2));
*/



//MyrepozCSDz002
/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Метод вывода цифры нах-ся в середине трехзначного числа
int CentreNum(int numA)
{    
    int result = ((numA / 10) % 10);
    return result;
}
Console.Write("Input in 3znachnoe number: ");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
  Console.WriteLine("You input no 3znachnoe number, input correct");
}
else
{
  Console.WriteLine(CentreNum(number));
}
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Метод принимает число введенное поль-м, кол-во символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
/*int MyArray(int numA, int numAmt)
{
int result = 0;
    if (numAmt < 3)
    {
      Console.Write("3th number no: ");
    }
    else
    {
        int numC = 1;
        for (int i = numAmt; i > 3; i--)
        {
           numC = numC * 10;
        }

        result = (numA / numC) % 10;
    }
return result;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number.ToString().Length;
Console.WriteLine(MyArray(number, count));
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//alternativnyi
/* 
   Console.Write("\n Input number week day  "); 
   int num = int.Parse(Console.ReadLine()); 
   if (num >= 1 && num <= 5) 
   { 
      Console.WriteLine(" No"); 
   } 
 
    else if (num >= 6 && num <= 7) 
    { 
      Console.WriteLine(" Yes"); 
    } 
    else Console.WriteLine(" Input number from 1 to 7"); 
}
*/
/*bool func(int numDay)  
{  
    if(numDay >= 6 && numDay <= 7) return true;
    else 
    return false;
    
}
Console.WriteLine("Input num from 1 to 7: ");
int numDay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(func(numDay) ? "yes" : "no");
*/
// Gotovo!