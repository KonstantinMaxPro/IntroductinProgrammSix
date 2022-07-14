double[] ReadAndConvertStringToIntArray()//переводим введенные числа через ReadLine в целочисленный массив, удаляя пробелы
{
    return Console.ReadLine()
        .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
        .Select(Double.Parse).ToArray();
} 

double[] IntersectionPointTwoLine(double[] firstArray, double[] secondArray)//Находим точку пересечения
{   
    double x = (firstArray[0] - secondArray[0]) / (secondArray[1] - firstArray[1]);
    double y = firstArray[1] * x + firstArray[0];
    double[] crossPoint = {x,y};  
    return crossPoint;     
}

void ComparisonTwoLine(double[] firstArray, double[] secondArray, double[] crossPoint)//Проверяем на возможность пересечения линий
{
    if(firstArray[0] == secondArray[0] && firstArray[1] == secondArray[1])
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if(firstArray[0] != secondArray[0] && firstArray[1] == secondArray[1])
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if(firstArray[0] == secondArray[0] && firstArray[1] != secondArray[1])
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        Console.Write("Точка пересечения двух прямых: ");
        Console.ForegroundColor = ConsoleColor.Yellow; 
        Console.WriteLine($"({crossPoint[0]};{crossPoint[1]})");
        Console.ResetColor();
    }
}

Console.Clear();//Очищаем консоль

//ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)
string drawLine = "===========================================";
Console.WriteLine($"{drawLine}\n|      ТОЧКА ПЕРЕСЕЧЕНИЯ ДВУХ ПРЯМЫХ      |\n{drawLine}");//Название

//БЛОК ВВОДА КООРДИНАТ
Console.WriteLine("Введите координаты первой прямой A и B через пробел:");
double[] firstСoordinatesArray = ReadAndConvertStringToIntArray();
Console.WriteLine("Введите координаты второй прямой A и B через пробел:");
double[] secondCoorditatesArray = ReadAndConvertStringToIntArray();

//БЛОК ВЫВОДА РЕЗУЛЬТАТА
Console.WriteLine("\n" + drawLine);
double[] crossPoint = IntersectionPointTwoLine(firstСoordinatesArray, secondCoorditatesArray);
ComparisonTwoLine(firstСoordinatesArray, secondCoorditatesArray, crossPoint);
Console.WriteLine(drawLine);