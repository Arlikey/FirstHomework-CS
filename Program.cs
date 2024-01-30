namespace firstHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  ОСНОВНАЯ ЗАДАЧА

            /*int number = 0;
            bool isCorrect = false;
            while (!isCorrect)
            {
                Console.Write("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number % 10 == 5)
                {
                    isCorrect = true;
                }
            }
            Console.Write($"{number}^2 = {number/10 * (number/10+1) + "25"}");*/

            //  ДОПОЛНИТЕЛЬНАЯ ЗАДАЧА 1

            /*double number = 32.975;
             Console.WriteLine($"Дробная часть: {number - (int)number}");
             Console.WriteLine($"Целое число: {Convert.ToInt32((number - (int)number) * 1000)}");*/

            //  ДОПОЛНИТЕЛЬНАЯ ЗАДАЧА 2

            /*int a, b, c, d;
            Console.WriteLine("Введите 4 цифры: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine()); 
            d = Convert.ToInt32(Console.ReadLine());

            int number = Convert.ToInt32(a.ToString() + b.ToString() + c.ToString() + d.ToString());
            Console.WriteLine($"Итоговое число: {number}");*/

            //  ДОПОЛНИТЕЛЬНАЯ ЗАДАЧА 5

            /*uint a, b;
            Console.Write("Введите длину катета а: ");
            a = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Введите длину катета b: ");
            b = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine($"Гипотенуза треугольника: {Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2))}");*/

            //  ДОПОЛНИТЕЛЬНАЯ ЗАДАЧА 6

           /* int number = 0;
            bool isCorrect = false;

            while (!isCorrect)
            {
                Console.Write("Введите целое двузначное число (>0): ");
                number = Convert.ToInt32(Console.ReadLine());
                isCorrect = number > 0 ? true : false;
            }

            number = Convert.ToInt32((number % 10).ToString() + (number / 10).ToString()) + 8;
            Console.WriteLine($"Результат: {number}");*/

        }
    }
}