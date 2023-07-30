// Напишите программу, которая принимает на 
//вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


{
Console.WriteLine("Введите три числа:");
        int number1 = Int32.Parse(Console.ReadLine());
        int number2 = Int32.Parse(Console.ReadLine());
        int number3 = Int32.Parse(Console.ReadLine());

        int maxNumber = GetMaxNumber(number1, number2, number3);

        Console.WriteLine("Максимальное число: " + maxNumber);
}

static int GetMaxNumber(int a, int b, int c)

{
   int max = a;
       if (b > max)
        {
           max = b;
        }

       if (c > max)
       {
           max = c;
        }

        return max;
}