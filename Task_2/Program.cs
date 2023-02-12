// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int[,] CreateArray(int m = 4, int n = 4) {
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {System.Console.Write(array[i, j] + "   ");}
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[] FindSumLines(int[,] array) {
    int[] sumArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++) {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++) {sum += array[i, k];}
        }
        sumArray[i] = sum;
    }
    return sumArray;
}

int FindLess(int[] array) {
    int minValue = array[0];
    int minValueIndex = 0;
    for (int i = 1; i < array.Length; i++) {
        if (minValue > array[i]) {
            minValue = array[i];
            minValueIndex = i;
        }
    }
    return minValueIndex;
}

int[,] array = CreateArray();
PrintArray(array);
int[] sumsArray = FindSumLines(array);
int lesserSumString = FindLess(sumsArray) + 1;
System.Console.WriteLine($"Строкой с наименьшей суммой элементов является - {lesserSumString}.");