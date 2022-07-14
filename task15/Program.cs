Console.Write("Введите цифру дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
 if (number<8)
 {
  if (number<6)
  {
    Console.WriteLine("Данный день не является выходным, так что работаем, Солнце еще высоко");
  }
  else
  {
    Console.WriteLine("Ура, выходные!");
  }
 }
 else
 {
    Console.WriteLine("Сказано же, введите число от 1 до 7");
  }
