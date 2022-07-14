Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

    string number1 = number.ToString();
    Console.WriteLine(number1[1]);

