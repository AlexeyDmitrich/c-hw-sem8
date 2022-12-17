// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

using static MyMethod.MyMethod;
using MyMethod;

MyGenerate gen = new MyGenerate();

double[,] usersArray = gen.ArrayGenDD();
Print(usersArray);

try{
double[,] turnedArray = Turn2DArray(usersArray);
Print(turnedArray);
} catch (IndexOutOfRangeException) {
    Print ("Что-то не так с Вашим массивом");
    return;
} 


double[,] Turn2DArray (double[,] usersArray){
    int rows = usersArray.GetLength(0);
    int columns = usersArray.GetLength(1);
    double[,] turnedArr = new double [columns, rows];
    for (int i = 0; i < columns; i++) {
        for (int j = 0; j < rows; j++){
            turnedArr[i,j] = usersArray[j,i];
        }
    }

    return turnedArr;
}
