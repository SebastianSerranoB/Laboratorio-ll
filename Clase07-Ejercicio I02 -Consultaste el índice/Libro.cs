using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07_Ejercicio_I02__Consultaste_el_índice
{
    internal class Libro
    {
        private List<string> paginas;

        private Libro()
        { 
            paginas = new List<string>();
        }

        public Libro(string pagina) : this()
        { 
            this.paginas.Add(pagina);
        }

        public string this[int i]
        {
            get
            {
                if (i > -1 && i < paginas.Count)
                {
                    return paginas.ElementAt(i);
                }
                else
                {
                    return string.Empty;
                }
            }

            set 
            {
                if (i > -1)
                {
                    if (i > paginas.Count)
                    {
                        paginas.Add(value);
                    }
                    else
                    { 
                        paginas.Insert(i, value);    
                    }
                }
            }
        }




    }
}
