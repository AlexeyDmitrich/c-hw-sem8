namespace MyMethod;
public static class MyMethod {
    
    /*========= Методы ввода данных ============*/

    // метод для ввода int числа
    public static int IntInput (string commonText){
        Console.WriteLine ($"Ожидается целое число : {commonText}");
        bool isInt = int.TryParse((Console.ReadLine()), out int num);
        if (! isInt){
            Console.WriteLine ("Недопустимый тип данных");
            return IntInput(commonText);
        } else {
            return num;
        }
    }

    // метод для ввода положительного целого числа
    public static uint UintInput (string commonText){
        Console.WriteLine ($"Ожидается положительное целое число : {commonText}");
        bool isUint = uint.TryParse((Console.ReadLine()), out uint num);
        if (! isUint){
            Console.WriteLine ("Недопустимый тип данных");
            return UintInput(commonText);
        } else {
            return num;
        }
    }

    // метод для ввода вещественных чисел
    public static double DoubleInput (string commonText){
        Console.WriteLine ($"Ожидается вещественное число : {commonText}");
        bool isDouble = double.TryParse((Console.ReadLine()), out double num);
        if (! isDouble){
            Console.WriteLine ("Недопустимый тип данных");
            return DoubleInput(commonText);
        } else {
            return num;
        }
    }

    // метод последовательного ввода ряда значений
    public static int[] InputArrInt (){
        Print("Введите целые числовые значения");
        Print("В качестве разделителя используйте пробел");
        string[] userInput = (Console.ReadLine()).Split(new char[] {' '});
        int[] input = new int[userInput.Length];
        for (int i = 0; i<input.Length; i++){
            bool isInt = int.TryParse(userInput[i], out int num);
            if (isInt) {
                input[i] = num;
            } else {
                Print("Вы ввели недопустимые значения. \n проверьте правильность: \n * целые числа \n * разделены пробелом \n * другие символы отсутствуют");
                return InputArrInt();
            }
        }
        return input;
    } 
    public static double[] InputArrDouble (){
        Print("Введите числовые значения");
        Print("В качестве разделителя используйте пробел");
        string[] userInput = (Console.ReadLine()).Split(new char[] {' '});
        double[] input = new double[userInput.Length];
        for (int i = 0; i<input.Length; i++){
            bool isInt = double.TryParse(userInput[i], out double num);
            if (isInt) {
                input[i] = num;
            } else {
                Print("Вы ввели недопустимые значения. \n проверьте правильность: \n * вещественные числа \n * разделены пробелом \n * дробная часть отделена запятой \n * другие символы отсутствуют");
                return InputArrDouble();
            }
        }
        return input;
    } 



    /*========= Методы вывода в консоль ============*/

    // Печать простой строки с поддержкой интерполяции
    public static void Print (string text){
        Console.WriteLine(text);
    }
    
    // Вывод в консоль ToString переменной
    public static void Print (object text){
        Console.WriteLine(text);
    }

    // вывод в консоль массива универсальных объектов
    public static void Print (object[] array){
        for(int i = 0; i < array.Length; i++){
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
        }

    // вывод в консоль int массива
    public static void Print (int[] array){
        for(int i = 0; i < array.Length; i++){
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
        }

    // вывод в консоль массива натуральных чисел
    public static void Print (uint[] array){
        for(int i = 0; i < array.Length; i++){
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
        }

    // вывод в консоль double массива
    public static void Print (double[] array){
        for(int i = 0; i < array.Length; i++){
            if (array[i]>0) Console.ForegroundColor = ConsoleColor.Red;
            if (array[i]<0) Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (array[i]==0) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{array[i]}; ");
            Console.ResetColor();
        }
        Console.WriteLine();
        }

    // вывод двухмерного массива
    public static void Print (object[,] array){
        int rows = array.GetUpperBound(0)+1;
        int columns = array.Length / rows;
        for(int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    // вывод двухмерного int массива 
    public static void Print (int[,] array){
        int rows = array.GetUpperBound(0)+1;
        int columns = array.Length / rows;
        for(int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    // вывод двухмерного double массива
    public static void Print (double[,] array){
        Console.ForegroundColor = ConsoleColor.Red;
        //Console.BackgroundColor = ConsoleColor.Green;
        int rows = array.GetUpperBound(0)+1;
        int columns = array.Length / rows;
        for(int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                if (array[i,j]>0) Console.ForegroundColor = ConsoleColor.Red;
                if (array[i,j]<0) Console.ForegroundColor = ConsoleColor.DarkBlue;
                if (array[i,j]==0) Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{array[i, j]} \t");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        Console.ResetColor();
        Console.WriteLine();
    }


    /*======= Операционные и математические методы =======*/
    
    // метод возвращения модуля целого числа
    public static int Md (int num){
        if (num > 0){
            return num;
        } else {
            return (num * -1);
        }
    }

    // метод возвращения модуля вещественного числа
    public static double Md (double num){
        if (num > 0){
            return num;
        } else {
            return (num * -1);
        }
    } 

    /* ========= Методы для операций с массивами =========*/

    // метод поиска максимального элемента в массиве вещественных чисел
    public static double Max (double[] usersArray){
        double max = double.NegativeInfinity; 
        for (int i = 0; i<usersArray.Length; i++){
            if (usersArray[i]>max){
                max=usersArray[i];
            }
        }
        return max;
    }

    // метод поиска максимального элемента в массиве целых чисел
    public static int Max (int[] usersArray){
        int max = usersArray[0]; 
        for (int i = 1; i<usersArray.Length; i++){
            if (usersArray[i]>max){
                max=usersArray[i];
            }
        }
        return max;
    }

    // метод поиска минимального элемента в массиве вещественных чисел
    public static double Min (double[] usersArray){
        double min = double.PositiveInfinity; 
        for (int i = 0; i<usersArray.Length; i++){
            if (usersArray[i]<min){
                min=usersArray[i];
            }
        }
        return min;
    }

    // метод поиска минимального элемента в массиве целых чисел
    public static int Min (int[] usersArray){
        int min = int.MaxValue; 
        for (int i = 1; i<usersArray.Length; i++){
            if (usersArray[i]<min){
                min=usersArray[i];
            }
        }
        return min;
    }

    // метод создания копии массива
    public static double[] ArrayCopy (double[] usersArray){
        double[] arrayCopied = new double[usersArray.Length];
        for (int i = 0; i<usersArray.Length; i++){
            arrayCopied[i] = usersArray[i];
        }
        return arrayCopied;
        }

}

public class MyGenerate{
    Random rnd = new Random();

    bool DebugString (){
        MyMethod.Print("Добавить отладочную информацию? (y/N)");
        string agreement ="";
        try{
        agreement = Console.ReadLine();
        } catch (Exception ex) {
            MyMethod.Print("Неподходящее значение");
        }
        if (agreement=="y" || agreement=="Y" || agreement=="yes" || agreement=="Yes" || agreement=="д" || agreement=="Д" || agreement=="да" || agreement=="Да") return true;
        else return false;
    }

    bool AutoGen (){
        MyMethod.Print(" ________________________________ ");
        MyMethod.Print("| Выберите тип генерации массива |");
        MyMethod.Print("|                                |");
        MyMethod.Print("|  1. ручная настройка           |");
        MyMethod.Print("|  2. автоматическая настройка   |");
        MyMethod.Print("|________________________________|");
        uint type=MyMethod.UintInput("пункт меню");
        switch (type){
            case 1:
            return true;
            case 2:
            return false;
            default:
            return false;
        }
    }

    // метод для генерации массива
    public int[] ArrayGen()
    {
        int length;
        int min;
        int max;
        bool man = AutoGen();
        bool debug = DebugString();
        
        if (man) {
            length = MyMethod.IntInput("длина массива");
            min = MyMethod.IntInput("минимальное значение");
            max = MyMethod.IntInput("максимальное значение");
        } else {
            length = rnd.Next(0,(Int16.MaxValue/(rnd.Next(16, 64))));
            min = int.MinValue;
            max = int.MaxValue;
        }
        int[] array = new int[length];
        if (debug) MyMethod.Print($"Длина массива составит {length} значений");
        for (int i = 0; i < length; i++)
        {
            array[i] = rnd.Next(min, max);  
        }
        if (debug) {
            MyMethod.Print("Сгенерированный массив:");
            MyMethod.Print(array);
            int minV = MyMethod.Min(array);
            MyMethod.Print ($"Минимальное значение в массиве: {minV}");
            int maxV = MyMethod.Max(array);
            MyMethod.Print ($"Максимальное значение в массиве: {maxV}");
            }

        return array;
    }

    // метод генерации случайного массива вещественных чисел
    public double[] ArrayGenD()
    {
        int length = MyMethod.IntInput("длина массива");
        int min = MyMethod.IntInput("минимальное значение");
        int max = MyMethod.IntInput("максимальное значение");
        double[] array = new double[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = rnd.Next(min, max);  
        }
        // отладка:
        // my.Print(array);
        return array;
    }

    /// <summary>
    /// Метод для генерации двумерного массива заполненного случайными числами с ограничениями
    /// </summary>
    /// <returns>Массив формата double[,]</returns>
    public double[,] ArrayGenDD()
    {
        int rows = MyMethod.IntInput("число строк");
        int columns = MyMethod.IntInput("число столбцов");
        int min = MyMethod.IntInput("минимальное значение");
        int max = MyMethod.IntInput("максимальное значение");
        double[,] array = new double[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j= 0; j < columns; j++){
                array[i,j] = Math.Round(((rnd.NextDouble())*rnd.Next(min,max)), 1);
            }  
        }
        // отладка:
        // my.Print(array);
        return array;
    }

    public int[,] ArrayGenDI()
    {
        int rows = MyMethod.IntInput("число строк");
        int columns = MyMethod.IntInput("число столбцов");
        int min = MyMethod.IntInput("минимальное значение");
        int max = MyMethod.IntInput("максимальное значение");
        int[,] array = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j= 0; j < columns; j++){
                array[i,j] = rnd.Next(min,max);
            }  
        }
        // отладка:
        // my.Print(array);
        return array;
    }

}