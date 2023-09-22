using System.Data;
using System.Globalization;

namespace MultidimenseArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int rows = 3;
            //int columns = 3;
            //int[,] matrix = new int[rows, columns];


            ////Inicializuoju matrica su kazkokiomis reiksmemis
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        matrix[i, j] = i + j;
            //    }
            //}
            ////atvaizdavimas 
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //////////////////////////////////////////////////////////////


            //ShowTable();

            //////////////////////////////////////////////////////////////

            //Console.Write("Iveskit matricos dydi, X Y: ");
            //int[,] matrica = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            //MatricaTable(matrica);

            ///////////////////////////////////////////////////////////////

            //int[,] matrix = { { 2, 3, 5 }, { 5, 6, 6 }, { 9, 3, 7 } };
            //FindRepetitiveNumber(matrix);

            ///////////////////////////////////////////////////////////////

            //string[,] nameMatrix = { { "Ona", "Maryte", "Kaziukas" }, { "Valerijus", "Kaziukas", "Jurgita" }, { "Ona", "Maryte", "Petriukas" } };
            //FindRepetitiveNames(nameMatrix);

            //////////////////////////////////////////////////////////////

            //int[,] matrixA = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int[,] matrixB = { { 1 }, { 2 }, { 3 } };

            //int[,] resultMatrix = InitializeMatrixSum(matrixA, matrixB);

            //// spausdinam
            //for (int i = 0; i < resultMatrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < resultMatrix.GetLength(1); j++)
            //    {
            //        Console.Write(resultMatrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //////////////////////////////////////////////////////////////

            //int[,] matrix = { 
            //    { 2, 3, 5 },
            //    { 5, 6, 6 }, 
            //    { 2, 3, 7 } };
            //int maxNumber = FindMaxNumber(matrix, out int rowLocation, out int columnLocation);
            //Console.WriteLine($"Didziausias skaicius yra: {maxNumber}");
            //Console.WriteLine($"Eilutes numeris: {rowLocation}, Stulpelio numeris: {columnLocation}");

        }
        public static int FindMaxNumber(int[,] matrix, out int rowLocation, out int columnLocation)
        {
            int max = 0;
            rowLocation = -1;
            columnLocation = -1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)

                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                        rowLocation = i;
                        columnLocation = j;
                }
            }            
            return max;
        }
        public static int[,] InitializeMatrixSum(int[,] matrixA, int[,] matrixB)
        {          

            int[,] resultMatrix = new int[matrixA.GetLength(0), matrixA.GetLength(1)];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    resultMatrix[i, j] = matrixA[i, j] + matrixB[i, 0];                    
                }
            }
            return resultMatrix;
        }    
        public static void FindRepetitiveNames(string[,] nameMatrix)
        {
            for (int i = 0; i < nameMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < nameMatrix.GetLength(1); j++)
                {
                    string current = nameMatrix[i, j];
                    int currentNameIndex = j + 1;

                    for (int k = i; k < nameMatrix.GetLength(0); k++)
                    {
                        for (int l = currentNameIndex; l < nameMatrix.GetLength(1); l++)
                        {
                            if (current == nameMatrix[k, l])
                            {
                                Console.WriteLine(nameMatrix[k, l]);
                            }
                        }
                        currentNameIndex = 0;
                    }    
                }
            }
        }
        public static void FindRepetitiveNumber(int[,] matrix)
        {            
            for (int i = 0; i < matrix.GetLength(0);i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int current = matrix[i, j];
                    int currentColIndex = j + 1;
                    
                    for (int k = i;  k < matrix.GetLength(0); k++)
                    {
                        for (int l = currentColIndex; l < matrix.GetLength(1); l++)
                        {
                            if (current == matrix[k, l])
                            {
                                Console.WriteLine(matrix[k, l]);
                            }
                        }
                        currentColIndex = 0;
                    }
                }
            }
        }
        public static void MatricaTable(int[,] matrica)
        {
            for (int i = 0; i < matrica.GetLength(0); i++)
            {
                for (int j = 0; j < matrica.GetLength(1); j++)
                {
                    Console.WriteLine("Iveskite skaiciu kuri atvaizduoti: ");
                    matrica[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i = 0; i < matrica.GetLength(0); i++)
            {
                for (int j = 0; j < matrica.GetLength(1); j++)
                {
                    Console.Write(matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void ShowTable()
        {
            //0st indeksas yra eilutes
            //1st indexas yra stulpeliai
            string[,] table = new string[3, 3];

            // uzpildoma lentele su reiksmemis
            table[0, 0] = "Name";
            table[0, 1] = "Age";
            table[0, 2] = "City";

            table[1, 0] = "John";
            table[1, 1] = "25";
            table[1, 2] = "New York";

            table[2, 0] = "Jane";
            table[2, 1] = "30";
            table[2, 2] = "London";

            //duomenu rodymas konsolei

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}