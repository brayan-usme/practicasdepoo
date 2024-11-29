internal class Program
{
    private static void Main(string[] args)
    {
        string[] MESESAÑO = new string[] { "enero", "febrero", "marzo", "abril",  "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "novienbre", "diciembre" };

        decimal[] sales = new decimal[12];

        decimal suma =0 ;


        // metodo almacenar ventas
        Almacenarventas(sales,MESESAÑO);


        //METODO CALCULAR VENTAS DEL AÑO
        suma = Calcularventas(sales, suma);

        //METODO PARA MOSTRAR VENTAS
        Mostrarventas(sales,suma, MESESAÑO);




    }



    private static void Almacenarventas(decimal[] Sales, string[] MESESAÑO)
    {
        for (int i = 0; i < Sales.Length; i++) 
        {
        Console.WriteLine($" ingrese las ventas del mes {MESESAÑO[i]}");
            Sales[i] = Convert.ToDecimal(Console.ReadLine()); 

        }

    }

    private static decimal Calcularventas(decimal[] Sales,decimal suma)
    {
        for (int i = 0; i < Sales.Length; i++) 
        {
         suma = suma + Sales[i]; // otra opcion seria suma+=sales[i];
        
        }
       return suma;
    }

    private static void Mostrarventas(decimal[] Sales, decimal suma, string[]MESESAÑO)
    { 
    
    
    for(int i = 0; i < Sales.Length; i++)
        {
            Console.WriteLine($" {MESESAÑO[i]}:{Sales[i]:C2}");
        
        }

        Console.WriteLine($" EN TODO EL AÑO SE VENDIO : {suma:C2}");


    }

        
        

       




    }