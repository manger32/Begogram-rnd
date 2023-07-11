char[,] SpiralMatrix(int N)
{
    int Dim_quadratic = N;
    var SpiralMatrix = new char[Dim_quadratic, Dim_quadratic];
    //int AllElems = (int)Math.Pow(Dim_quadratic, 2); //Deprecated since char Matrix
    string KeyToMatrix_1 = "BEGOGRAM-RND-FOREVER-AND-EVER-AND-EVER";
    int indexToKey = 0;
    int IndexToSpiral = 0;
    while (Dim_quadratic != 0)
    {
        for (int t = 0; t < 4; ++t)
        {
            for (int l = 0; l < Dim_quadratic; ++l)
            {
                if (t == 0 && l < Dim_quadratic - IndexToSpiral)
                    SpiralMatrix[t + IndexToSpiral,l + IndexToSpiral] = KeyToMatrix_1[indexToKey++];
                if (t == 1 && l < Dim_quadratic - IndexToSpiral && l != 0)
                    SpiralMatrix[l + IndexToSpiral,Dim_quadratic - 1] = KeyToMatrix_1[indexToKey++];
                if (t == 2 && l < Dim_quadratic - IndexToSpiral && l != 0)
                    SpiralMatrix[Dim_quadratic - 1,Dim_quadratic - (l + 1)] = KeyToMatrix_1[indexToKey++];
                if (t == 3 && l < Dim_quadratic - (IndexToSpiral + 1) && l != 0)
                    SpiralMatrix[Dim_quadratic - (l + 1),IndexToSpiral] = KeyToMatrix_1[indexToKey++];
            }
        }
        Dim_quadratic--;
        IndexToSpiral++;
    }
    return SpiralMatrix;
}

void PrintMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

char[,] Matrix = SpiralMatrix(5);
PrintMatrix(Matrix);