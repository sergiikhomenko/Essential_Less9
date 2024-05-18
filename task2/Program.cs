namespace task2;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть чотири лямбда оператора для виконання арифметичних дій:
 * (Add – додавання, Sub – віднімання, Mul – множення, Div – поділ).
 * Кожен лямбда оператор повинен приймати два аргументи та повертати результат обчислення.
 * Лямбда оператор поділу повинен перевірити поділ на нуль. Написати програму,
 * яка виконуватиме арифметичні дії, вказані користувачем.
 */
class Program
{
    static void Main(string[] args)
    {
        double a =0 , b = 0;
        Func<double, double, double> Add = (a, b) => (double)a + b;
        Func<double, double, double> Sub = (a, b) => (double)a - b;
        Func<double, double, double> Mul = (a, b) => (double)a * b;
        Func<double, double, double> Div = (a, b) =>
        {
            double div = 0;
            if (b!=0)
            {
                div = a / b;
            }
            else
            {
                Console.WriteLine("Ділення на 0");
            }
            return div;
        };
        Console.WriteLine("Введіть перше число");
        Double.TryParse(Console.ReadLine(), out a);
        Console.WriteLine("Введіть друге число");
        Double.TryParse(Console.ReadLine(), out b);
        Console.WriteLine($"Додаваня {Add(a,b)}");
        Console.WriteLine($"Віднімання {Sub(a,b)}");
        Console.WriteLine($"Множення {Mul(a,b)}");
        Console.WriteLine($"Ділення {Div(a,b)}");
    }
}