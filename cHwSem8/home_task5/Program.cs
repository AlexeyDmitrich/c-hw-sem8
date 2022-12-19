using static MyMethod.MyMethod;
using MyMethod;

MyGenerate gen = new MyGenerate();

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int sizeRows = IntInput("Введите число строк в массиве");
int sizeColumns = IntInput("Введите число столбцов в массиве");
int startX = 1;
int startY = 1;
int startValue = IntInput("Введите стартовое значение");
int[,] usersArray = new int[sizeRows, sizeColumns];
//Print(usersArray);

int[,] baseArray = MkBaseArrayFrom(usersArray);
//Print(baseArray);

int[,] spiral = SpiralArray(baseArray, startX, startY, startValue, 1);
Print(spiral);

/// <summary>
/// Метод заполняет массив числами по спирали снаружи внутрь
/// </summary>
/// <param name="baseArray"> базовый массив (все крайние значения == 1)</param>
/// <param name="startX">координата X начала отсчета</param>
/// <param name="startY">координата Y начала отсчета</param>
/// <param name="startValue">с какого числового значения вести заполнение</param>
/// <param name="direction">первичное направление (1-вправо, 2-вниз, 3-влево, 4-вверх)</param>
/// <returns></returns>
int[,] SpiralArray(int[,] baseArray, int startX, int startY, int startValue, int direction)
{
    if (baseArray[startX, startY] == 0)
    {
        baseArray[startX, startY] = startValue;
        startValue++;
        
        // огромным элсифом определяем предыдущее направление и куда двигаться дальше
        if (direction == 1 && baseArray[startX, startY + 1] == 0)
        {
            direction = 1;
        }
        else if (direction == 1 && baseArray[startX, startY + 1] != 0)
        {
            direction = 2;
        }
        else if (direction == 2 && baseArray[startX + 1, startY] == 0)
        {
            direction = 2;
        }
        else if (direction == 2 && baseArray[startX + 1, startY] != 0)
        {
            direction = 3;
        }
        else if (direction == 3 && baseArray[startX, startY - 1] == 0)
        {
            direction = 3;
        }
        else if (direction == 3 && baseArray[startX, startY - 1] != 0)
        {
            direction = 4;
        }
        else if (direction == 4 && baseArray[startX - 1, startY] == 0)
        {
            direction = 4;
        }
        else if (direction == 4 && baseArray[startX + 1, startY] != 0)
        {
            direction = 1;
        }
        
        switch (direction)
        {
            case 1: // right
                return SpiralArray(baseArray, startX, startY + 1, startValue, 1);
            case 2: // down
                return SpiralArray(baseArray, startX + 1, startY, startValue, 2);
            case 3: // left
                return SpiralArray(baseArray, startX, startY - 1, startValue, 3);
            case 4: // up
                return SpiralArray(baseArray, startX - 1, startY, startValue, 4);
        }
    }
    //Console.Clear();
    //Print(baseArray);

    // в этом блоке метода мы убираем лишнюю рамку из единиц
    int[,] spiralArray = new int[baseArray.GetLength(0) - 2, baseArray.GetLength(1) - 2];
    for (int i = 1; i < baseArray.GetLength(0) - 1; i++)
    {
        for (int j = 1; j < baseArray.GetLength(1) - 1; j++)
        {
            spiralArray[i - 1, j - 1] = baseArray[i, j];
        }
    }
    return spiralArray;
}

/// <summary>
/// Метод для создания базового массива
/// </summary>
/// <param name="usersArray">двумерный массив, заполненный нулевыми значениями</param>
/// <returns>вернется тот же массив, но снаружи будут добавлены ячейки со значением 1</returns>
int[,] MkBaseArrayFrom(int[,] usersArray)
{
    int[,] baseArray = new int[usersArray.GetLength(0) + 2, usersArray.GetLength(1) + 2];
    for (int i = 0; i < baseArray.GetLength(0); i++)
    {
        for (int j = 0; j < baseArray.GetLength(1); j++)
        {
            if (j == 0 || i == 0 || j == baseArray.GetLength(1) - 1 || i == baseArray.GetLength(0) - 1)
            {
                baseArray[i, j] = 1;
            }
        }
    }
    return baseArray;
}