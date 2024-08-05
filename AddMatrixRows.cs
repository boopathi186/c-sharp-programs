using System;
class AddMatrixRow
{
    static void Main()
    {
        int[,] arr ={
          {1,2,3},
          {4,5,6},
          {7,8,9}
      };
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int temp = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                temp += arr[i, j];
            }
            Console.WriteLine($"Sum of Row {i + 1} : {temp}");
        }
    }
}
