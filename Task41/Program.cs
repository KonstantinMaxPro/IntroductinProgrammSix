int[] ReadAndConvertStringToIntArray()//переводим введенные числа через ReadLine в целочисленный массив, удаляя пробелы
{
    return Console.ReadLine()
        .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
        .Select(Int32.Parse).ToArray();
} 

Console.Clear();//Очищаем консоль

//ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)
string drawLine = "=======================================\n";
Console.WriteLine($"{drawLine}|  СЧИТАЕМ СКОЛЬКО ЧИСЕЛ БОЛЬШЕ НОЛЯ  |\n{drawLine}");//Название

//БЛОК ВВОДА ДАННЫХ В КОНСОЛЬ
Console.WriteLine("Введите несколько цифр через пробел:");
int[] numbersArray = ReadAndConvertStringToIntArray();

//БЛОК ПОСЧЁТА ЧИСЕЛ БОЛЬШЕ НОЛЯ
int countGreaterZero = 0;
foreach (var numbers in numbersArray)
{
    if(numbers > 0)
    {
        countGreaterZero++;
    }
}

//БЛОК ВЫВОДА РЕЗУЛЬТАТА
Console.Write("\n" + drawLine);
Console.Write("Введено чисел больше ноля: ");
Console.ForegroundColor = ConsoleColor.Yellow; 
Console.WriteLine(countGreaterZero);
Console.ResetColor();
Console.Write(drawLine);