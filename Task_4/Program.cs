// Напишите программу, которая заполнит спирально квадратный массив.

Console.Clear();

void PrintArray(int[,] array, string msg) {
    System.Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            if (array[i, j] / 10 <= 0) {System.Console.Write($"0{array[i, j]} ");}
            else System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] CreateArray(int n = 4) {
    int[,] array = new int[n, n];
    int temp = 1;
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            while (temp <= array.GetLength(0) * array.GetLength(1)) {
                array[i, j] = temp;
                temp++;
                if (i <= j + 1 && i + j < array.GetLength(1) - 1) {j++;}
                else if (i < j && i + j >= array.GetLength(0) - 1) {i++;}
                    else if (i >= j && i + j > array.GetLength(1) - 1) {j--;}
                    else i--;
            }
        }
    }
    return array;
}

int[,] sqareMatrix = CreateArray();
PrintArray(sqareMatrix, "Наш массив:");