namespace task5;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть анонімний метод, який приймає як параметри три цілих аргументи і
 * повертає середнє арифметичне цих аргументів.
 */
class Program
{
    static void Main(string[] args)
    {
        Func<int, int, int, double> veacl = (a, b, c) => (double)(a+b+c)/3;
        Console.WriteLine("Введіть перше число");
        Int32.TryParse(Console.ReadLine(), out int a);
        Console.WriteLine("Введіть друге число");
        Int32.TryParse(Console.ReadLine(), out int b);
        Console.WriteLine("Введіть третье число");
        Int32.TryParse(Console.ReadLine(), out int c);
        
        Console.WriteLine($"Середне значення {veacl(a, b, c)}");
    }
}