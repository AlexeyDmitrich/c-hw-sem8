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

int[,] productMatrix = MatrixProduct(matrix1,matrix2);
Print(" -----------");
Print(matrix1);
Print("      *     ");
Print(matrix2);
Print(" ===========");
Print(productMatrix);

int[,] MatrixProduct (int[,] matrix1, int[,] mateix2){
    int[,] product = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    for (int i=0; i<product.GetLength(0); i++){
//        Print($"i = {i}");
        for (int j=0; j<matrix1.GetLength(1); j++){
//            Print($"j = {j}");
            for (int k=0; k<matrix2.GetLength(0); k++){
//                Print($"k = {k}");
                product[i,j]+= matrix1[i,j]*matrix2[k,i];
//                Print($"product[{i},{j}] += matrix1[{i},{j}]*matrix2[{k},{i}]");
            }
        }
    }
    return product;
}


