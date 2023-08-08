int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[,] matrix, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i, j] = random.Next(minValue, maxValue);
        }
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void FillArrayDouble(double[,] matrix, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.NextDouble() * (maxValue-minValue) + minValue;
            matrix[i, j] = Math.Round(matrix[i, j], 2);
        }
    }
}
void PrintArrayDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Task47()
{
    // Задайте двумерный массив размером m x n,заполненый случайными 
    // вещественными числами.
    int rows = 5;
    int columns = 6;
    double[,] matrix = new double[rows, columns];

    FillArrayDouble(matrix, -100,100);
    PrintArrayDouble(matrix);
}
Task47();

void Task50()
{
    //Напишите программу которая на вход принимает позиции элемента 
    //в двухмерном массиве и возвращает значение этого элемента или же уазывает что его нет.
    int rows = 5;
    int columns = 6;
    int[,] matrix = new int[rows, columns];

    FillArray(matrix, -100,100);
    PrintArray(matrix);

    int InputRow = Input("Введите строку элемента");
    int InputColumn = Input("Введите столбец элемента");

    if(InputRow >= 0 && InputRow < rows && 
       InputColumn >=0 && InputColumn < columns )
       {
            Console.WriteLine($"Ваш элемент : {matrix[InputRow,InputColumn]}");
       }
       else
       {
            Console.WriteLine($"Некоректный ввод");
       }
}

void Task52()
{
    //Задайте двумерный массив из целых чисел.
    //Найдите среднее арифметическое элементов массива.
    int rows = 5;
    int columns = 6;
    int[,] matrix = new int[rows, columns];

    FillArray(matrix, 0, 9);
    PrintArray(matrix);
    Console.WriteLine();

    for(int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += matrix[i, j];
        }
        double result = sum/rows;
        result = Math.Round(result, 2);
        Console.Write($"{result}\t");
    }

}
Console.Clear();
Task52();
