using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2ab
{
    class parcial2
    {
        private string[] nombre;
        private double[] salario;
        static void Main(string[] args)
        {
            parcial2 s1 = new parcial2();
            s1.Cargar();
            s1.MayorSueldo();
        }
        public void Cargar()
        {
            nombre = new string[5];
            salario = new double[5];
            string ln;
            for (int g = 0; g < nombre.Length; g++)
            {
                Console.WriteLine("ingrese el nombre del empleado:\n");
                nombre[g] = Console.ReadLine();
                Console.WriteLine("ingrese el sueldo de el empleado:\n");
                
                ln = Console.ReadLine();
                salario[g] = double.Parse(ln);
            }
        }
        public void MayorSueldo()
        {
            double mayor;
            int ll;
            mayor = salario[0];
            ll = 0;
            for (int g = 1; g < nombre.Length; g++)
            {
                if (salario[g] > mayor)
                {
                    mayor = salario[g];
                    ll = g;
                }
            }
            Console.WriteLine("EMPLEADO " + nombre[ll]);
            Console.WriteLine("Su Sueldo es:"+ mayor);
            Console.ReadKey();
        }
    }
}