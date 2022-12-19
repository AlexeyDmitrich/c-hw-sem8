using static MyMethod.MyMethod;
using MyMethod;

MyGenerate gen = new MyGenerate();

/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] myArr = gen.ArrayGenDI();
Print(myArr);

int[,] sortByRaw = SortedArrayByRaw(myArr);
Print(sortByRaw);

int[,] SortedArrayByRaw (int[,] usersArray){
    int[,] editedArray = new int [usersArray.GetLength(0),usersArray.GetLength(1)];
    for (int i = 0; i < usersArray.GetLength(0); i++){
        int temp = 0;
        for (int j = 0; j < usersArray.GetLength(1)-1; j++){
            if (usersArray[i,j] < usersArray[i,j+1]){
                temp = usersArray[i,j];
                usersArray[i,j] = usersArray[i,j+1];
                usersArray[i,j+1] = temp;
                j=0;
            }
        }
        //Print(usersArray);
    }

    return usersArray;
} 