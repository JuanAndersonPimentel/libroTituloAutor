using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libroTituloAutor
{
    public class Program
    {
        static void Main(string[] args)
        {
            libro libro = new libro();

            try
            {
                Console.WriteLine("ingrese el titulo del libro:");
                libro.titulo = Console.ReadLine();

                Console.WriteLine("ingrese el autor del libro:");
                libro.autor = Console.ReadLine();

                Console.WriteLine("ingrese el nuemro de paginas del libro:");
                libro.paginas = int.Parse(Console.ReadLine());

                libro.mostrarinformacion();

                if (libro.eslargo())
                {
                    Console.WriteLine("el libro es largo (mas de 500 paginas).");
                }
                else 
                {
                    Console.WriteLine("el libro no es largo.");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("error: el valor ingresado no es valido. ingrese un numero entero para las paginas");
                
            }
        }
    }
}
