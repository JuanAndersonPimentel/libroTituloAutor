using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libroTituloAutor
{
    public class libro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public int paginas { get; set; }

        public void mostrarinformacion()
        {
            Console.WriteLine($"titulo: {titulo}");
            Console.WriteLine($"autor: {autor}");
            Console.WriteLine($"paginas: {paginas}");
        }
        public bool eslargo()
        {
            return paginas > 500;
        }

        
        
    }
    

}

