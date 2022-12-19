using static MyMethod.MyMethod;
using MyMethod;

MyGenerate gen = new MyGenerate();

/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] myArr = gen.ArrayGenDI();
Print(myArr);

int maxString = MaxString(myArr);
Print($"Максимальный вес имеет {maxString} строка ({StringSum(myArr, maxString)})");

int MaxString(int[,] usersArray)
{
    int length = usersArray.GetLength(0);
    int maxStringInd = 0;
    for (int i = 0; i < length; i++)
    {
        if (StringSum(usersArray, i) > StringSum(usersArray, maxStringInd))
        {
            maxStringInd = i;
        }
    }
    return maxStringInd + 1;
}

int StringSum(int[,] usersArray, int stringIndex)
{
    int sum = 0;
    for (int i = 0; i < usersArray.GetLength(1); i++)
    {
        sum += usersArray[stringIndex, i];
    }
    return sum;
}