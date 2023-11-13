using System;
using System.ComponentModel.Design.Serialization;
using System.IO.Compression;

public class Program
{
    public static void Main(string[] args)
    {
		// Defino variables a usar
        int lonA = 0, lonB = 0, i, j;
		bool A = false, B = false;
	
	//PRIMER CONJUNTO

		//creo un loop para pedir la longitud de el primer conjunto y si no da un numero valido se repita
		while (A == false)
		{
		Console.WriteLine("Hola! Porfavor define el tamaño del conjunto (puede ser de 1 a 20 valores)");
		lonA = Convert.ToInt32(Console.ReadLine());

		if (lonA<=20 && lonA>=1)
		{
        	A = true;
		}
		else
		{
			Console.WriteLine("Favor de introducir un numero valido");
		}
		}

		// creo el array
		int[] conjA = new int [lonA];

		//pido los valores del array:
		j=1;
		for (i = 0; i < conjA.Length; i++)
		{
		Console.WriteLine("dame el valor "+ j);
				conjA[i] = Convert.ToInt32(Console.ReadLine());
				j++;
		}


	//SEGUNDO CONJUNTO (Mismo procedimiento)
		while (B == false)
			{
		Console.WriteLine("Hola! Porfavor define el tamaño del conjunto (puede ser de 1 a 20 valores)");
		lonB = Convert.ToInt32(Console.ReadLine());

		if (lonB<=20 && lonB>=1)
		{
        	B = true;
		}
		else
		{
			Console.WriteLine("Favor de introducir un numero valido");
		}
		}

		// creo el array
		int[] conjB = new int [lonB];

		//pido los valores del array:
		j=1;
		for (i = 0; i < conjB.Length; i++)
		{
		Console.WriteLine("dame el valor "+ j++);
				conjB[i] = Convert.ToInt32(Console.ReadLine());
		}

	// A UNION B
	 	int[] conjToU = new int[lonA + lonB];
        int D = 0;

        // Copiar elementos de A a conjToU
        for (i = 0; i < lonA; i++)
        {
            conjToU[D] = conjA[i];
            D++;
        }

        // Comprobar duplicados y copiar elementos únicos de B a conjToU
        for (i = 0; i < lonB; i++)
        {
            bool duplicado = false;

            for (j = 0; j < lonA; j++)
            {
                if (conjB[i] == conjA[j])
                {
                    duplicado = true;
                    break;
                }
            }

            if (!duplicado)
            {
                conjToU[D] = conjB[i];
                D++;
            }
        }

	//A interseccion B
	 int[] conjInt = new int[Math.Min(lonA, lonB)]; // Tamaño máximo posible de la intersección
        int E = 0;

        for (i = 0; i < lonA; i++)
        {
            for (j = 0; j < lonB; j++)
            {
                if (conjA[i] == conjB[j])
                {
                    conjInt[E] = conjA[i];
                    E++;
                }
            }
        }

	// Diferencia A - B
		int[] conjDif = new int[lonA]; // Tamaño máximo posible de la diferencia
        int F = 0;

        for (i = 0; i < lonA; i++)
        {
            bool encontrado = false;

            for (j = 0; j < lonB; j++)
            {
                if (conjA[i] == conjB[j])
                {
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                conjDif[F] = conjA[i];
                F++;
            }
        }
	// Mostramos los resultados:
		//union
		Console.Write("\nA unión B: ");
		for(i = 0; i < D; i++)
		{
			Console.Write(conjToU[i] + " ");
			
		}

		//interseccion
		Console.Write("\nA intersección B: ");
		for(i = 0; i < E; i++)
		{
			Console.Write(conjInt[i] + " ");
		}

		//diferencia
		Console.Write("\nDiferencia A-B: ");
		for(i = 0; i < F; i++)
		{
			Console.Write(conjDif[i] + " ");
		}
	}
}

