Start();
void Start()
{
    while (true)
    {
        Console.Clear();

        Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь");
        Console.WriteLine("Задача 43: Напишите программу, которая найдет точку пересечения двух прямыхб заданных уравнениями y=k1*x + b1, y = k2*x +b2; значения b1, k1, b2, k2 задаются пользователем");

        Console.WriteLine("0: end");

        int numTask = SetNumber("Введите номер задачи");

        switch (numTask)
        {
            case 0: return;
            case 41: GetCount(); break;
            case 43: CoordinatesPoint(); break;
            default: Console.WriteLine("Error"); break;
        }
        Console.WriteLine("Задача выполнена, нажмите любую клавишу");
        Console.ReadKey();
    }
}
int SetNumber(string comment)
{
    Console.Write($" {comment}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//"Задача 41: Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь"



void GetCount()
{
Console.Clear();
    Console.Write("Введите элементы через запятую: ");
    string str = Console.ReadLine();
    var arrStr = str.Split(",");

    int[] arr = Array.ConvertAll(arrStr, int.Parse);
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count = count + 1;
        }
    }
    Console.WriteLine($"Количество чисел больше 0 равно: {count}");

}

// "Задача 43: Напишите программу, которая найдет точку пересечения двух прямых заданных уравнениями y = k1*x + b1, y = k2*x +b2; значения b1, k1, b2, k2 задаются пользователем"

void CoordinatesPoint()
{
  Console.Clear();
    Console.WriteLine("Введите значение b1");
    double b1 = Convert.ToUInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k1");
    double k1 = Convert.ToUInt32(Console.ReadLine());
    Console.WriteLine("Введите значение b2");
    double b2 = Convert.ToUInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k2");
    double k2 = Convert.ToUInt32(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения двух прямых равны х: {x}; y: {y}");
}
