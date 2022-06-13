using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen
{
    class Producto
    {
        //Campos de la clase 
        string nombreProducto;
        int cantidad;
        float precio;
        //Creacion del constructor
        public Producto(string nombreProducto, int cantidad, float precio)
        {
            this.nombreProducto = nombreProducto;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        //creacion del metodo 
        public void MostrarProducto()
        {
            Console.WriteLine("Producto: " + nombreProducto);
            Console.WriteLine("Cantidad del producto en existencia: " + cantidad);
            Console.WriteLine("Precio del producto: {0:c}" , precio);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables 
            string nombreProducto;
            int cantidad;
            float precio;
            StreamWriter sw = new StreamWriter("Productos.txt", true);

            try
            {
                Console.WriteLine("                                         ------ Registros Productos ------");
                Console.Write("Introduce el nombre del producto: ");
                nombreProducto = Console.ReadLine();

                Console.Write("Introduce la cantidad en existencia del producto: ");
                cantidad = Int32.Parse(Console.ReadLine());

                Console.Write("Introduce el precio del producto: ");
                precio = float.Parse(Console.ReadLine());
                
                Console.WriteLine("Presiona ENTER para continuar.");
                Console.ReadKey();
                Console.Clear();
                //Creacion del objeto
                Producto p1 = new Producto(nombreProducto, cantidad, precio);

                //llamada de los metodos
                p1.MostrarProducto();

                sw.WriteLine("Producto: " + nombreProducto);
                sw.WriteLine("Cantidad: " + cantidad);
                sw.WriteLine("Precio: {0:c} ", precio);
            }
            catch (IOException m)
            {
                Console.WriteLine(m.Message);
                Console.WriteLine(m.StackTrace);
            }
            finally
            {
                sw.Close();
            }



        }
        
    }
}
