using _1_ejerciciopoo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // creacion de un objeto 

        // vamos a preguntar por pantalla cuantas personas vamos a presentar

        Console.WriteLine(" ¿Cuantas personas quieres presentar ? ");
        
        double n = Convert.ToDouble(Console.ReadLine());

        for (int i = 0; i < n; i++)

        {
                                                 // FORMA LARGA  DE INICIALIZAR 

           /* Console.WriteLine(" INGRESE EL NOMBRE DE LA PERSONA");
            string nombre = Console.ReadLine();

            Console.WriteLine(" INGRESE LA EDAD DE LA PERSONA");
            int edad = Convert.ToInt32(Console.ReadLine());

            // ( vamos a crear una nueva isntacia de la clase personas es decir un nuevo objeto)

            personas objeto_personas = new personas();

            // seteando propiedades

            objeto_personas.Nombre = nombre;

            objeto_personas.Edad = edad;
           */


                                                        // FROMA CORTA

            personas objeto_personas = new personas(); // SE CREA PRIMERO EL OBJETO Y DESPUES SE INSTANCIA  Y DEBE  IR FUERA DEL FOR ES DECIR CREAR AL PRINCIPIO DEL PRGRAMA

            Console.WriteLine(" INGRESE EL NOMBRE DE LA PERSONA  \n");
            objeto_personas.Nombre = Console.ReadLine();

            Console.WriteLine(" INGRESE LA EDAD DE LA PERSONA\n ");
            objeto_personas.Edad = Convert.ToInt32(Console.ReadLine());

            // 2 INVOCAR METODOS DE LAS CLASES PERSONAS
            objeto_personas.Presentar();
            objeto_personas.MayorEdad();

















        }





















    }
}