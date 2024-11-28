using System.Timers;

internal class Program
{
    private static void Main(string[] args)
    {





        //hacer un codigo que pida dos numeros y luego lo sume

        Console.WriteLine("ingrese el primer numero");
       double num1= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" EL NUMERO INGRESADO FUE " + num1);


        Console.WriteLine("ingrese el SEGUNDO numero");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" EL NUMERO INGRESADO FUE " + num2);

        double opereacion = num1 + num2;

        Console.WriteLine(" el resultado de la suma es " + opereacion);







    }
}