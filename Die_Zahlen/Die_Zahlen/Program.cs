namespace Die_Zahlen
{
    class Program
    {
        static void Main (string [] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int result = num1 + num2;
            Console.WriteLine ("Сумма чисел равна: " + result);
            result = num1 * num2;
            Console.WriteLine("Произведение чисел равно: " + result);
            double average = (double) (num1 + num2) / 2;
            Console.WriteLine ("Среднее арифметическое чисел равно: " + average);

        }
    }
}