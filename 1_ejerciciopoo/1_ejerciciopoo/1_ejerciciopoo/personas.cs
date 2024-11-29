using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ejerciciopoo
{
    public class personas
    {
        //propiedades de mi clase personas

        public string Nombre { get; set; } // FORMA DE DEFINIR PROPIEDADES
        public int Edad { get; set; } // get =  Se utiliza cuando necesitas leer el valor de un campo.
                                      // set = Se utiliza cuando necesitas escribir o actualizar el valor de un campo.
        private double Salario { get; set; }

        // METODOS DE MI CLASE PERSONA 

        public void Presentar() // FORMA DE CREAR UN METODO EN C# :
                                // = MODIFICADOR DE ACCESO + TIPO DE DATO QUE RETORNA + NOMBRE DEL METODO + SECCION DE PARAMETROS + CORCHETES FINALES
        {
            Console.WriteLine($" Hola, mí nombre es {Nombre} \n tengo {Edad} \n");

        }

        public void MayorEdad()
        {

            if (Edad >= 18)
            {

                Console.WriteLine(" Soy mayor de edad y ya me puedo endeudar\n ");

            }
            else 
            {
             Console.WriteLine(" Soy menor de edad y no me puedo endeudar\n ");
            } 
        }


    }
}
