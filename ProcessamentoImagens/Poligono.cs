using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessamentoImagens
{
    public class Poligono
    {
        public List<Point> VerticesOriginais { get; set; }
        public List<Point> VerticesAtuais { get; set; }
        public double[,] MatTransformacao { get; set; }
        public Color Cor { get; set; }
        public PointF Centro { get; set; }
        public string NomeCor { get; set; }

        public Poligono()
        {
            VerticesOriginais = new List<Point>();
            VerticesAtuais = new List<Point>();
            MatTransformacao = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            Cor = Color.Black;
            Centro = PointF.Empty;
        }
        public void CalcularCentro()
        {
            if (VerticesOriginais.Count == 0) return;
            float somaX = 0, somaY = 0;
            foreach (Point p in VerticesOriginais)
            {
                somaX += p.X;
                somaY += p.Y;
            }
            Centro = new PointF(somaX / VerticesOriginais.Count, somaY / VerticesOriginais.Count);
        }
    }
}
