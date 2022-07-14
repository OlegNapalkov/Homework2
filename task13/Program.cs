Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if(number<100)
{
    Console.WriteLine("Третьей цифры нет");
}
 else
 {
    string number1 = number.ToString();
    Console.WriteLine(number1[2]);
 }

//  else 
// {
//  while (number>1000 && number>99)
//  {
//    number = number/10;  
//  }
//  int third = number % 10;
//  Console.WriteLine(third); 
// } 