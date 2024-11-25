using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BerestenDS.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            int maxEven = 0;
            string strx = File.ReadAllText(path);
            strx = strx.Replace(".", ",");
            // Читаем файл и обрабатываем строки
            foreach (var line in File.ReadLines(strx)) 
                {
                    // Разбиваем строку на числа
                    var numbers = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(x =>
                                      {
                                          // Пробуем преобразовать каждую строку в число
                                          if (double.TryParse(x, out double number))
                                          {
                                              // Округляем до трёх знаков после запятой
                                              return Math.Round(number, 3);
                                          }
                                          return double.NaN; // Если не удалось преобразовать, возвращаем NaN
                                      })
                                      .Where(x => !double.IsNaN(x)); // Убираем NaN

                    // Находим максимальное чётное целое число
                    foreach (var num in numbers)
                    {
                        if (num % 2 == 0 && num % 1 == 0) // Проверяем, что число целое и делится на 2
                        {
                            maxEven = Math.Max(maxEven, (int)num);
                        }
                    }
                }
            static long Factorial(int n)
            {
                long res = 1;
                for (int i = 2; i <= n; i++)
                {
                    res *= i;
                }
                return res;
            }
            return res;
        }
    }
}
