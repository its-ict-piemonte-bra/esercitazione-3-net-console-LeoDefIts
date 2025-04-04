namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int[] array1 = Es1(x);
            int[] array2 = Ess1(array1);
            int[] array3 = Es2(array1);
            int numMag = Es4(array1);
            StampArray(array1);
            StampArray(array2);
            StampArray(array3);
            Es3(array1);
            Console.WriteLine($"{numMag}");



            Console.WriteLine(Console.ReadLine());
        }
        private static void StampArray(int[] array)
        {
            
            for (int y = 0; y < array.Length; y++)
            {
                Console.Write($"{array[y]}\t");
            }
            Console.WriteLine();
        }
        private static int[,] (int[,] a)
        {

        }
        private static int[] Es1(int n)
        {
            if (n > -1)
            {
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                return array;
            }
            else
            {
                Console.Write("x non vallido");
                return new int[] { };
            }
        }
        private static int[] Ess1( int[] a)
        {
            int[] array = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                array[i] = a[i];
            }
            return array;
        }
        private static int[] Es2(int[] a)
        { 
            int[] array = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                array[array.Length - i -1] = a[i];
            }
            return array;
        }
        private static void Es3(int[] a)
        {
            int ind;
            for (int i = 0; i <= a.Length / 2; i++)
            { 
                ind = a[i];
                a[i] = a[a.Length - i - 1];
                a[a.Length - i - 1] = ind;
            }
            StampArray(a);
        }
        private static int Es4(int[] a)
        {
            int ind = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (ind < a[i])
                {
                    ind = a[i];
                }
            }
            return ind;
        }
        private static void Exercise5()
        {
            Console.WriteLine("Inserire il numero di colonne:");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserire il numero di righe: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            int[,] matrixA = LoadMatrix(rows, columns);
            int[,] matrixB = LoadMatrix(rows, columns);

            int[,] matrixResult = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixResult[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            //stampiamo il risultato
            Console.WriteLine("Matrice somma:");
            PrintMatrix(matrixResult);
        }


        private static CodeIdentifier Exercise6()
        {
            Console.WriteLine("Inserire il numero di colonne:");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserire il numero di righe: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserire il numero da cercare: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = LoadMatrix(rows, columns);

            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == x)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Il valore {x} compare esattamente {count} volte della matrice");
        }

    }
}
