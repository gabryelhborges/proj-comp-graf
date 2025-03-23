using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagens
{
    public class ListBoxItem
    {
        public string Nome { get; set; }
        public Poligono Poligono { get; set; }

        public ListBoxItem(string nome, Poligono poligono)
        {
            Nome = nome;
            Poligono = poligono;
        }

        public override string ToString()
        {
            return Nome; // Isso será exibido no ListBox
        }
    }
}
