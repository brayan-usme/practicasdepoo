using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {

        /* Realizar un programa en C# que declare un array con N enteros, a continuación, lo 
 inicialice con valores aleatorios(del 1 al 10) y posteriormente en otros 2 arrays
 guardar el cuadrado de cada uno de los números número y cubo de ese número. 
 Muestre en pantalla cada elemento del primer vector de enteros junto con su
 cuadrado y su cubo.
  */

        Console.WriteLine("ingrese el numero de elementos ");
        int n = Convert.ToInt32(Console.ReadLine());


        int[] Numeros = new int[n];
        int[] Cuadrados = new int[n];
        int[] Cubos = new int[n];



        llenararray(n, Numeros);

        calcularoperaciones(n, Numeros, Cuadrados, Cubos);

        mostrarresultado(n, Numeros, Cuadrados, Cubos);


    }

    private static void llenararray(int n, int[] numeros)
    {
        Random random = new Random();

        for (int i = 0; i < n; i++) 
        {
            numeros[i] = random.Next(1, 11);
            

        
        }

    }

    private static void calcularoperaciones(int n, int[] numeros, int[] cuadrados, int[] cubos)
    {
        for (int i = 0; i < n; i++) 
        {
            cuadrados[i] = (int) Math.Pow(numeros[i], 2);
            cubos[i]= (int)Math.Pow(numeros[i], 3);


        }
    }

    private static void mostrarresultado(int n, int[] numeros, int[] cuadrados, int[] cubos)
    {



        for(int i = 0;i < n; i++) 
        
        {
            Console.WriteLine($"NUMERO\tCUADRADOS\tCUBOS");
            Console.WriteLine($"{numeros[i]}\t{cuadrados[i]}\t{cubos[i]}");
        }


    }



}