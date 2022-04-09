using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCprogramacion9
{
    public class ClsImc
    {

        private const double KG = 2.2046;
        public int edad { get; set; }
        public string nombre { get; set; }
        public int altura { get; set; }
        public char sexo { get; set; }
        public int peso { get; set; }
        public double imc { get; set; }
        String Estado = "";
        Char Opcion = ' ';
        public const string mens = "¡IMC!";


        public string prueba()
        {
            Console.WriteLine("Introduzca el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Introduzca su edad");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzaca su altura");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca su peso");
            peso = int.Parse(Console.ReadLine());

            Console.WriteLine("Intruduzca su sexo");
            sexo = char.Parse(Console.ReadLine());

            double pesoKG = this.peso / KG;
            double estaturaMTS = (double)this.altura / 100;
            double altu = (Math.Pow(estaturaMTS, 2));
            imc = pesoKG / altu;


            if (edad >= 18)
            {

                if (imc < 18.5)
                {
                    Estado = "Huuuu estas muy bajo de peso";
                }

                if ((imc >= 18.5) && (imc < 25))
                {
                    Estado = "Tu peso se encuentra normal sigue asi!!";
                }

                if ((imc >= 25) && (imc < 30))
                {
                    Estado = "Estas muy pasado de peso, deberias consultar tu salud";
                }
                if ((imc >= 30) && (imc < 40))
                {
                    Estado = "Recurre a tu medio te encutras en sobre peso";
                }
                if (imc >= 40)
                {
                    Estado = " te encuentras en obeso morbido,deberias hacer ejercicio";

                }
            }
            else
            {
                if (imc < 14.4)
                {
                    Estado = "Niñ@ te encuentras en bajo peso";
                }

                if ((imc >= 14.5) && (imc < 17))
                {
                    Estado = "Niñ@ su peso es normal, muy bien!!";
                }

                if ((imc >= 18) && (imc < 19))
                {
                    Estado = "Niñ@ se encuentra en sobre peso";
                }
                if ((imc >= 19.1) && (imc < 40))
                {
                    Estado = "Niñ@ estas un poco sobre pasado de peso, ve a tu medico";
                }
                if (imc >= 40)
                {
                    Estado = "Niñ@ te encuetras demasiado pasado de peso";

                }
            }



            Console.WriteLine("Tu IMC es de :" + imc);
            Console.WriteLine("Tu estado es :" + Estado);



            return mens.ToString();


        }
    }
    
}
