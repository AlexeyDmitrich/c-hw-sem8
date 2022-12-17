// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

using static MyMethod.MyMethod;
using MyMethod;

MyGenerate gen = new MyGenerate();

double[,] myArray = gen.ArrayGenDD();
Print(myArray);
double[,] revArray = ReverseRowsFILO(myArray);
Print(revArray);

double[,] ReverseRowsFILO (double[,] usersArray){
    int rows = usersArray.GetLength(0);
    int columns = usersArray.GetLength(1);
    double[,] array = new double[rows, columns];
        for (int i = 1; i < rows-1; i++)
        {
            for (int j= 0; j < columns; j++){
                array[i,j] = usersArray[i,j];
            }  
        }
        for (int j= 0; j < columns; j++){
                array[0,j] = usersArray[rows-1,j];
                array[rows-1,j] = usersArray[0,j];
            } 
    return array;
}
