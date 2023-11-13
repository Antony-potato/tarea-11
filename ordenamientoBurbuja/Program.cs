using System;

public class Program
{
    public static void Main(string[] args)
    {
        //En este codigo probe la creacion de funciones y con foreach
        //queria aprender un poco mas sobre eso pero es algo confuso aun.
        // Declaración de la matriz con 7 indices y 7 valores arbitrarios
        int[] matriz = { 8, 9, 4, 1, 6, 2, 7 };

        // Muestro la matriz original usando la funcion que cree
        Console.WriteLine("Matriz original:");
        verMtz(matriz);

        // Ordenamiento burbuja mediante la funcion creada
        ordBur(matriz);

        Console.WriteLine("\nMatriz ordenada de menor a mayor:");
        verMtz(matriz);
    }

    // Función para mostrar la matriz
    static void verMtz(int[] arrX)
    {
        foreach (var elemento in arrX)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }

    // Función para realizar el ordenamiento burbuja
    static void ordBur(int[] arrX)
    {
        int n = arrX.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                // Comparacion de elementos e intercambio en caso de orden correcto
                if (arrX[j] > arrX[j + 1])
                {
                    int temp = arrX[j];
                    arrX[j] = arrX[j + 1];
                    arrX[j + 1] = temp;

                }
            }
        }
    }
}
