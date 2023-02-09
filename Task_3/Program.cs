// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int[,] CreateArray(int m = 2, int n = 2) {
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) { array[i, j] = rnd.Next(1, 10); }
    }
    return array;
}

void PrintArray(int[,] array, string msg) {
    System.Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {System.Console.Write(array[i, j] + " ");}
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void MatrixMultiplication(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix) {
    for (int i = 0; i < resultMatrix.GetLength(0); i++) {
        for (int j = 0; j < resultMatrix.GetLength(1); j++) {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++) {sum += firstMartrix[i, k] * secomdMartrix[k, j];}
            resultMatrix[i, j] = sum;
        }
    }
}

int[,] martrix1 = CreateArray();
PrintArray(martrix1, "Первая матрица:");
int[,] martrix2 = CreateArray();
PrintArray(martrix2, "Вторая матрица:");
int[,] resMatrix = CreateArray();
MatrixMultiplication(martrix1, martrix2, resMatrix);
PrintArray(resMatrix, "Произведение матриц:");