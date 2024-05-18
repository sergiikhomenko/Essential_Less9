namespace task3;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть анонімний метод, який приймає як аргумент масив делегатів і повертає
 * середнє арифметичне значення значень методів, повідомлених з делегатами в масиві.
 * Методи, повідомлені з делегатами з масиву, повертають випадкове значення типу int.
 */

delegate int deligateValue();
class Program
{
    static void Main(string[] args)
    {
        deligateValue[] arreyDeligateValues = new deligateValue[5];
        Random rd = new Random();

        for (int i = 0; i < arreyDeligateValues.Length; i++)
        {
            arreyDeligateValues[i] = delegate
            {
                return rd.Next(1, 100);
            };
        }

        #region calculateAverage
        Func <deligateValue[], double> calculateAverage = delegate(deligateValue[] arrey)
        {
            double aver = 0;
            int sum = 0;
            foreach (var deligats in arrey)
            {
                sum += deligats();
            }

            aver = sum / arrey.Length;
            return aver;
        };
        #endregion

        Console.WriteLine( calculateAverage(arreyDeligateValues));
    }
}