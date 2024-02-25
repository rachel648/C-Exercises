using System;

class MatrixOne
{
   static void Main(String[] args)
   {
      double[,] matrixA =  new double[3,4];
      double[,] matrixB =  new double[3,4];
      double[,] matrixSum =  new double[3,4];
      int i, j;

      Console.WriteLine("Data input for array A:");
      Console.WriteLine("----------------------------");
      for(i = 0;i < 3;i++)
      {
         for(j = 0;j < 4;j++)
         {
            Console.Write("Enter element A(" + (i + 1) + "," + (j + 1) + "): ");
            matrixA[i,j] = Convert.ToDouble(Console.ReadLine());
         }
      }

      Console.WriteLine("\n\nData input for array B:");
      Console.WriteLine("----------------------------");
      for(i = 0;i < 3;i++)
      {
         for(j = 0;j < 4;j++)
         {
            Console.Write("Enter element B(" + (i + 1) + "," + (j + 1) + "): ");
            matrixB[i,j] = Convert.ToDouble(Console.ReadLine());
         }
      }

      //Adding the matrices
      for(i = 0;i < 3;i++)
      {
         for(j = 0;j < 4;j++)
         {
            matrixSum[i,j] = matrixA[i,j] + matrixB[i,j];
         }
      }

      Console.WriteLine("\n\nMatrix A:");
      Console.WriteLine("------------------");
      for(i = 0;i < 3;i++)
      {
         for(j = 0;j < 4;j++)
         {
            Console.Write(matrixA[i,j] + " ");
         }
         Console.WriteLine();
      }

      Console.WriteLine("\n\nMatrix B:");
      Console.WriteLine("------------------");
      for(i = 0;i < 3;i++)
      {
         for(j = 0;j < 4;j++)
         {
            Console.Write(matrixB[i,j] + " ");
         }
         Console.WriteLine();
      }

      Console.WriteLine("\n\nSum Matrix:");
      Console.WriteLine("------------------");
      for(i = 0;i < 3;i++)
      {
         for(j = 0;j < 4;j++)
         {
            Console.Write(matrixSum[i,j] + " ");
         }
         Console.WriteLine();
      }
   }
}
