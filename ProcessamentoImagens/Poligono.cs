using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagens
{
    public class Poligono
    {
        public List<Point> VerticesOriginais { get; set; }
        public List<Point> VerticesAtuais { get; set; }
        public double[,] MatTransformacao { get; set; }
        public Color Cor { get; set; }

        public Poligono()
        {
            VerticesOriginais = new List<Point>();
            VerticesAtuais = new List<Point>();
            MatTransformacao = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            Cor = Color.Black;
        }
    }
}
