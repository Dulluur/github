internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;


        while (true)
        {
            Console.Clear();
            Console.WriteLine("Лабораторная работа #4");
            Console.WriteLine("Выберите от 1 до 3:");
            int choise = int.Parse(Console.ReadLine());


            switch (choise)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Задание 1");
                    Task1();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Задание 2");
                    Task2();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Задание 3");
                    Task3();
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Не верный выбор!");
                    return;
            }
        }
        
    }

    static void Task1()
    {
        string mainLetter = "Корабли лавировали лавировали но не вылавировали";
        string[] secondLetter = mainLetter.Split(" ");
        for (int i = 0; i < secondLetter.Length; i++)
        {
            if (i % 2 != 0)
            {
                secondLetter[i] = new string(secondLetter[i].Reverse().ToArray());
            }
        }
        Console.WriteLine(string.Join(" ", secondLetter));
    }

    static void Task2()
    {
        Console.WriteLine("Квадратная матрица с заполненными рандомными элементами: ");

        Random random = new Random();
        int N = 5;
        int[,] mainMatrix = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                mainMatrix[i, j] = random.Next(1, 101);
            }
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"{mainMatrix[i, j]} ");
            }
            Console.WriteLine();
        }

        int maxElementInRow = 0;

        Console.WriteLine("Максимальный элемент в каждой строке: ");
        for (int i = 0; i < N; i++)
        {
            maxElementInRow = mainMatrix[i, 0];

            for (int j = 0; j < N; j++)
            {
                if (mainMatrix[i, j] > maxElementInRow)
                {
                    maxElementInRow = mainMatrix[i, j];
                }
            }
            Console.WriteLine($"Строка{i + 1}: {maxElementInRow} ");
        }
    }

    static void Task3()
    {
        char[][] jaggedMatrix = CreateJaggedMatrix();

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(jaggedMatrix);

        char[][] modifiedMatrix = ReplaceChar(jaggedMatrix, 'a', 'e');

        Console.WriteLine("\nМатрица после замены 'a' на 'e':");
        PrintMatrix(modifiedMatrix);

        char[][] transposedMatrix = TransposeMatrix(modifiedMatrix);

        Console.WriteLine("\nТранспонированная матрица:");
        PrintMatrix(transposedMatrix);
    }

    static char[][] CreateJaggedMatrix()
    {
        Random random = new Random();
        int rows = random.Next(3, 6);
        char[][] matrix = new char[rows][];

        for (int i = 0; i < rows; i++)
        {
            int cols = random.Next(3, 6);
            matrix[i] = new char[cols];

            for (int j = 0; j < cols; j++)
            {
                matrix[i][j] = (char)random.Next('a', 'k' + 1);
            }
        }

        return matrix;
    }

    // Замена символов в матрице
    static char[][] ReplaceChar(char[][] matrix, char oldChar, char newChar)
    {
        char[][] newMatrix = new char[matrix.Length][];

        for (int i = 0; i < matrix.Length; i++)
        {
            newMatrix[i] = new char[matrix[i].Length];
            for (int j = 0; j < matrix[i].Length; j++)
            {
                newMatrix[i][j] = matrix[i][j] == oldChar ? newChar : matrix[i][j];
            }
        }

        return newMatrix;
    }

    // Транспонирование матрицы
    static char[][] TransposeMatrix(char[][] matrix)
    {
        int maxCols = 0;

        foreach (var row in matrix)
        {
            if (row.Length > maxCols)
                maxCols = row.Length;
        }

        char[][] transposed = new char[maxCols][];

        for (int i = 0; i < maxCols; i++)
        {
            transposed[i] = new char[matrix.Length];
            for (int j = 0; j < matrix.Length; j++)
            {
                transposed[i][j] = i < matrix[j].Length ? matrix[j][i] : ' ';
            }
        }

        return transposed;
    }

    static void PrintMatrix(char[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}

