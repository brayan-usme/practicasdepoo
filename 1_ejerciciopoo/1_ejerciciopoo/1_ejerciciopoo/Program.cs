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









            // COMO DECLARAR UN ARAYS Y INSTANCIARLO




            //PRIMERA FORMA
            // PRIMERO SE DEFINE EL TIPO DE DATO en este caso es int
            // SEGUNDO SE HACE UN CORCHETE
            // TERCERO SE LE DA EL NOMBRE AL ARRAY
            //CUARTO SE PONE IGUAL Y NEW
            //QUINTO SE VUELVE A PONER EL TIPO DE DATO SEGUIDO DE UNOS CORCHETES
            //SEXTO SE  PONE DENTRO DEL ULTIMO CORCHETE EL VALOR DE ESPACIOS QUE VA A TENER EL ARRAYS
            // SEPTIMO SE PONE EL UNTO Y COMA


            // RECORDAR QUE LAS ARRAYS EMPIEZAN DESDE CERO Y QUE SOLO PUEDEN ALMACENAR UN MISMO TIPO DE DATO


            int[] myArray = new int[5];




            // ** SEGUNDA FORMA PERO CON INSERCION** 

            // EN ESTA FORMA NO HAY NECESIDAD DE PONER EN EL CORCHETE CUANTAS POSICIONES TIENE EL ARRAY EL PROGRAMA LO DEFINE AUNTOMATICAMENTE

            int[] myArrayy = new int[] { 1, 2, 3, 4, 5, 6, 7 }; // LOS NUMEROS QUE PONEMOS EN LAS LLAVES SON LOS DATOS QUE SE VAN A ALMACENAR EN LOS ESPACIOS DEL ARRAY




            // FORMA ABREVIADA
            int[] myArrayyY = { 1, 2, 3, 4, 5, 6, 7 };

            // OTRA FORMA DE DARLE VALORES A OS ESPACIOS DEL ARRAYS ES

            int[] myArrayYYY = new int[5];
            myArrayYYY[0] = 1;
            myArrayYYY[1] = 2;
            myArrayYYY[2] = 43;
            myArrayYYY[3] = 444;
            myArrayYYY[4] = 44;


            // EJEMPLO DEL VIDEO DEL PROFE 

            string[] MESESAÑO = new string[] { "enero", "febrero", "marzo", "abril", "marzo", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "novienbre", "diciembre" };

            decimal[] sales = new decimal[12];

            decimal suma = 0;

            // crear unos metodos para utilizar la poo






        }




        // metodo almacenar ventas
        Almacenarventas();


        //METODO CALCULAR VENTAS DEL AÑO
        Calcularventas();
        //METODO PARA MOSTRAR VENTAS
        Mostrarventas();
















    }

    private static void Almacenarventas()
    {


    }

    private static void Calcularventas() 
    {
    
    
    }

    private static void Mostrarventas()
    {


    }



}