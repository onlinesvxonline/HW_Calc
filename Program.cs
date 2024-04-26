namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите первое число:");
                string num1 = Console.ReadLine();
                if (string.IsNullOrEmpty(num1))
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }
                double numDouble1 = double.Parse(num1);

                Console.WriteLine("Выберите действие (+, -, *, /):");
                string operation = Console.ReadLine();

                Console.WriteLine("Введите второе число:");
                string num2 = Console.ReadLine();
                double numDouble2 = double.Parse(num2);

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = numDouble1 + numDouble2;
                        break;
                    case "-":
                        result = numDouble1 - numDouble2;
                        break;
                    case "*":
                        result = numDouble1 * numDouble2;
                        break;
                    case "/":
                        result = numDouble1 / numDouble2;
                        break;
                    default:
                        Console.WriteLine("Некорректное действие.");
                        break;
                }

                Console.WriteLine("Результат: " + result);
            }
        }
    }
}
