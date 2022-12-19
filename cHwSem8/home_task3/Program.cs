using static MyMethod.MyMethod;
using MyMethod;

MyGenerate gen = new MyGenerate();

/*
Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] matrix1 = gen.ArrayGenDI();
int[,] matrix2 = gen.ArrayGenDI();

int[,] MatrixProduct (int[,] matrix1, int[,] mateix2){
    int[,] product = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    for (int i=0; i<product.GetLength(0); i++){
        for (int j=0; i<product.GetLength(1); j++){
            for (int k=0; k<matrix1.GetLength(0); k++){
                for (int l=0; l<matrix2.GetLength(1); l++){
                    product[i,j]=matrix1[i,k]*matrix2[j,l];
                }
            }
        }
    }
}


