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

int[,] usersArray = new int[sizeRows,sizeColumns];
Print(usersArray);

int[,] baseArray = MkBaseArrayFrom(usersArray);
Print(baseArray);

int[,] spiral = SpiralArray(baseArray,1,1,1,1);
Print(spiral);


int[,] SpiralArray (int[,] baseArray, int startX, int startY, int startValue, int direction){
    //int element = startValue;
    if (startX<baseArray.GetLength(0) && startY<baseArray.GetLength(1) && baseArray[startX,startY] == 0){
        baseArray[startX,startY] = startValue;
        startValue++;

    

    }

    //Console.Clear();
    Print(baseArray);
    int[,] spiralArray = new int[baseArray.GetLength(0)-2,baseArray.GetLength(1)-2];
    for (int i = 1; i < baseArray.GetLength(0)-1; i++){
        for (int j = 1; j < baseArray.GetLength(1)-1; j++){
            spiralArray[i-1,j-1] = baseArray[i,j];
        }
    }


    return spiralArray;
}


int[,] MkBaseArrayFrom (int[,] usersArray){
    int[,] baseArray = new int[usersArray.GetLength(0)+2,usersArray.GetLength(1)+2];
    for (int i = 0; i < baseArray.GetLength(0); i++){
        for (int j = 0; j < baseArray.GetLength(1); j++){
            if (j==0 || i==0 || j==baseArray.GetLength(1)-1 || i==baseArray.GetLength(0)-1){
                baseArray[i,j] = 1;
            }
        }
    }
    return baseArray;
}