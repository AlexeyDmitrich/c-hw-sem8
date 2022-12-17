// Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 1 встречается 1 раз 2 встречается 1 раз 8 встречается 1 раз 9 встречается 3 раза
// 1, 2, 3 4, 6, 1 2, 1, 6
// 1 встречается 3 раза 2 встречается 2 раз 3 встречается 1 раз 4 встречается 1 раз 6 встречается 2 раза

using static MyMethod.MyMethod;
using MyMethod;

MyGenerate gen = new MyGenerate();

double[,] myArray = gen.ArrayGenDD();
Print(myArray);

double[,] Dictonary (double[,] usersArray){
    int rows = usersArray.GetLength(0);
    int columns = usersArray.GetLength(1);
    double[,] dict = new double[rows*columns, 2];
        
        int tempI = 0;
        int tempJ = 0;
        int count = 0;
        
        for (int i = tempI; i < rows; i++)
        {
            for (int j= tempJ; j < columns; j++){
                if (usersArray[i,j] == usersArray[tempI,tempJ]){
                    count++;
                }
            }  
            dict[i,0] = usersArray[tempI,tempJ];
            dict[i,1] = count;
        }
        return dict;
}