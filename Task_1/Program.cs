// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int[,] CreateArray(int m = 3, int n = 4) {
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {array[i, j] = rnd.Next(1, 10);}
    }
    return array;
}

void PrintArray(int[,] array, string msg) {
    System.Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++) {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++) {System.Console.Write(array[i, j] + "\t");}
        System.Console.WriteLine();
    }
}

int[,] OrderArrayLines(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(1) - 1; k++) {
                if (array[i, k] < array[i, k + 1]) {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

int[,] baseArray = CreateArray();
PrintArray(baseArray, "Базовый массив:");
System.Console.WriteLine();
int[,] resArray = OrderArrayLines(baseArray);
PrintArray(resArray, "Измененный массив:");