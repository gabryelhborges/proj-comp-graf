using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProcessamentoImagens
{
    public partial class frmPrincipal : Form
    {
        private Bitmap canvas;
        private Point shadowEnd;
        public List<Poligono> listaPol = new List<Poligono>();
        private List<Point> pontos = new List<Point>();
        private Poligono poligonoAtual;
        private Poligono poligonoSelecionado = null;

        public frmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            panel.GetType().InvokeMember(
                "DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null,
                panel,
                new object[] { true }
            );

            UpdateCanvasSize();
            ClearCanvas();

            this.Resize += frmPrincipal_Resize;
            listBoxPoligonos.SelectionMode = SelectionMode.One;

            dataGridViewPontos.Columns.Add("Numero", "Ponto");
            dataGridViewPontos.Columns.Add("X", "X");
            dataGridViewPontos.Columns.Add("Y", "Y");
            dataGridViewPontos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            comboBoxReflexao.SelectedIndex = 0;
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            UpdateCanvasSize();
            ClearCanvas();
        }

        private void UpdateCanvasSize()
        {
            if (canvas != null) canvas.Dispose();
            canvas = new Bitmap(panel.Width, panel.Height);
        }

        private void ClearCanvas()
        {
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.Clear(Color.White);
            }
            panel.Invalidate();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ClearCanvas();
            listaPol.Clear();
            pontos.Clear();
            listBoxPoligonos.Items.Clear();
            dataGridViewPontos.Rows.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listBoxPoligonos.SelectedItem != null)
            {
                ListBoxItem itemSelecionado = (ListBoxItem)listBoxPoligonos.SelectedItem;
                Poligono poligonoExcluido = itemSelecionado.Poligono;

                if (poligonoExcluido == poligonoSelecionado)
                {
                    poligonoExcluido.Cor = Color.Black;
                    poligonoSelecionado = null;
                }

                listaPol.Remove(poligonoExcluido);
                listBoxPoligonos.Items.Remove(itemSelecionado);

                RedrawCanvas();
                dataGridViewPontos.Rows.Clear();
            }
        }

        private void listBoxPoligonos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (poligonoSelecionado != null)
            {
                poligonoSelecionado.Cor = Color.Black;
            }

            dataGridViewPontos.Rows.Clear();

            if (listBoxPoligonos.SelectedItem != null)
            {
                ListBoxItem itemSelecionado = (ListBoxItem)listBoxPoligonos.SelectedItem;
                poligonoSelecionado = itemSelecionado.Poligono;
                poligonoSelecionado.Cor = Color.Blue;

                for (int i = 0; i < poligonoSelecionado.VerticesAtuais.Count; i++)
                {
                    Point ponto = poligonoSelecionado.VerticesAtuais[i];
                    dataGridViewPontos.Rows.Add($"Ponto {i + 1}", ponto.X, ponto.Y);
                }
            }
            else
            {
                poligonoSelecionado = null;
            }

            RedrawCanvas();
        }

        private void RedrawCanvas()
        {
            ClearCanvas();
            foreach (var poligono in listaPol)
            {
                using (Graphics g = Graphics.FromImage(canvas))
                using (Pen pen = new Pen(poligono.Cor))
                {
                    for (int i = 1; i < poligono.VerticesAtuais.Count; i++)
                    {
                        DrawLine(g, canvas, poligono.VerticesAtuais[i - 1].X, poligono.VerticesAtuais[i - 1].Y,
                                 poligono.VerticesAtuais[i].X, poligono.VerticesAtuais[i].Y, pen);
                    }
                }
            }
            panel.Invalidate();
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (pontos.Count > 0)
            {
                shadowEnd = new Point(e.X, e.Y);
                panel.Invalidate();
            }
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && pontos.Count > 1)
            {
                if (poligonoAtual != null)
                {
                    pontos.Add(pontos[0]);
                    poligonoAtual.VerticesOriginais = new List<Point>(pontos);
                    poligonoAtual.VerticesAtuais = new List<Point>(pontos);
                    poligonoAtual.CalcularCentro();

                    listaPol.Add(poligonoAtual);
                    using (Graphics g = Graphics.FromImage(canvas))
                    using (Pen pen = new Pen(poligonoAtual.Cor))
                    {
                        for (int i = 1; i < pontos.Count; i++)
                        {
                            DrawLine(g, canvas, pontos[i - 1].X, pontos[i - 1].Y,
                                     pontos[i].X, pontos[i].Y, pen);
                        }
                    }

                    string nomePoligono = $"Polígono {listaPol.Count}";
                    listBoxPoligonos.Items.Add(new ListBoxItem(nomePoligono, poligonoAtual));

                    pontos.Clear();
                    shadowEnd = Point.Empty;
                    poligonoAtual = null;
                }
            }
            else
            {
                if (poligonoAtual == null)
                {
                    poligonoAtual = new Poligono();
                }

                pontos.Add(new Point(e.X, e.Y));
                poligonoAtual.VerticesOriginais = new List<Point>(pontos);
                poligonoAtual.VerticesAtuais = new List<Point>(pontos);
                shadowEnd = new Point(e.X, e.Y);
            }
            panel.Invalidate();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(canvas, 0, 0);

            foreach (var poligono in listaPol)
            {
                using (Pen pen = new Pen(poligono.Cor))
                {
                    for (int i = 1; i < poligono.VerticesAtuais.Count; i++)
                    {
                        DrawLine(e.Graphics, canvas, poligono.VerticesAtuais[i - 1].X, poligono.VerticesAtuais[i - 1].Y,
                                 poligono.VerticesAtuais[i].X, poligono.VerticesAtuais[i].Y, pen);
                    }
                }
            }

            if (poligonoAtual != null && pontos.Count > 0)
            {
                for (int i = 1; i < pontos.Count; i++)
                {
                    using (Pen pen = new Pen(Color.Gray))
                    {
                        DrawLine(e.Graphics, canvas, pontos[i - 1].X, pontos[i - 1].Y,
                                 pontos[i].X, pontos[i].Y, pen);
                    }
                }

                if (shadowEnd != Point.Empty && pontos.Count > 0)
                {
                    using (Pen pen = new Pen(Color.Gray))
                    {
                        DrawLine(e.Graphics, canvas, pontos[pontos.Count - 1].X, pontos[pontos.Count - 1].Y,
                                 shadowEnd.X, shadowEnd.Y, pen);
                    }
                }
            }
        }

        private void DrawLine(Graphics g, Bitmap bmp, int x1, int y1, int x2, int y2, Pen pen)
        {
            if (radioDDA?.Checked == true)
                DrawLineDDA(g, bmp, x1, y1, x2, y2, pen);
            else if (radioGeneralEquation?.Checked == true)
                DrawLineGeneralEquation(g, bmp, x1, y1, x2, y2, pen);
            else if (radioMidpoint?.Checked == true)
                DrawLineMidpoint(g, bmp, x1, y1, x2, y2, pen);
        }

        private void DrawLineDDA(Graphics g, Bitmap bmp, int x1, int y1, int x2, int y2, Pen pen)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
            float xIncrement = dx / (float)steps;
            float yIncrement = dy / (float)steps;
            float x = x1;
            float y = y1;

            for (int i = 0; i <= steps; i++)
            {
                if (x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height)
                    g.DrawRectangle(pen, x, y, 1, 1);
                x += xIncrement;
                y += yIncrement;
            }
        }

        private void DrawLineGeneralEquation(Graphics g, Bitmap bmp, int x1, int y1, int x2, int y2, Pen pen)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;

            if (dx == 0)
            {
                int yStart = Math.Min(y1, y2);
                int yEnd = Math.Max(y1, y2);
                for (int y = yStart; y <= yEnd; y++)
                    if (x1 >= 0 && x1 < bmp.Width && y >= 0 && y < bmp.Height)
                        g.DrawRectangle(pen, x1, y, 1, 1);
                return;
            }

            if (dy == 0)
            {
                int xStart = Math.Min(x1, x2);
                int xEnd = Math.Max(x1, x2);
                for (int x = xStart; x <= xEnd; x++)
                    if (x >= 0 && x < bmp.Width && y1 >= 0 && y1 < bmp.Height)
                        g.DrawRectangle(pen, x, y1, 1, 1);
                return;
            }

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                int xStart = Math.Min(x1, x2);
                int xEnd = Math.Max(x1, x2);
                for (int x = xStart; x <= xEnd; x++)
                {
                    int y = y1 + (dy * (x - x1)) / dx;
                    if (x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height)
                        g.DrawRectangle(pen, x, y, 1, 1);
                }
            }
            else
            {
                int yStart = Math.Min(y1, y2);
                int yEnd = Math.Max(y1, y2);
                for (int y = yStart; y <= yEnd; y++)
                {
                    int x = x1 + (dx * (y - y1)) / dy;
                    if (x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height)
                        g.DrawRectangle(pen, x, y, 1, 1);
                }
            }
        }

        private void DrawLineMidpoint(Graphics g, Bitmap bmp, int x1, int y1, int x2, int y2, Pen pen)
        {
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            int sx = x1 < x2 ? 1 : -1;
            int sy = y1 < y2 ? 1 : -1;
            int err = dx - dy;
            int x = x1;
            int y = y1;

            while (true)
            {
                if (x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height)
                    g.DrawRectangle(pen, x, y, 1, 1);

                if (x == x2 && y == y2) break;

                int e2 = 2 * err;
                if (e2 > -dy)
                {
                    err -= dy;
                    x += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    y += sy;
                }
            }
        }

        // Métodos Auxiliares para Transformações com Matrizes
        private double[,] MultiplicarMatrizes(double[,] a, double[,] b)
        {
            double[,] resultado = new double[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                        resultado[i, j] += a[i, k] * b[k, j];
            return resultado;
        }

        private double[] MultiplicarMatrizVetor(double[,] matriz, double[] vetor)
        {
            double[] resultado = new double[3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    resultado[i] += matriz[i, j] * vetor[j];
            return resultado;
        }

        private void AplicarTransformacao(Poligono poligono)
        {
            for (int i = 0; i < poligono.VerticesOriginais.Count; i++)
            {
                double[] ponto = new double[] { poligono.VerticesOriginais[i].X, poligono.VerticesOriginais[i].Y, 1 };
                double[] resultado = MultiplicarMatrizVetor(poligono.MatTransformacao, ponto);
                poligono.VerticesAtuais[i] = new Point((int)resultado[0], (int)resultado[1]);
            }
        }

        private void bttAplicaTranslacao_Click(object sender, EventArgs e)
        {
            if (poligonoSelecionado != null)
            {
                int dx = (int)numTranslacaoX.Value;
                int dy = (int)numTranslacaoY.Value;

                double[,] matrizTranslacao = new double[3, 3] {
                    { 1, 0, dx },
                    { 0, 1, dy },
                    { 0, 0, 1 }
                };

                poligonoSelecionado.MatTransformacao = MultiplicarMatrizes(matrizTranslacao, poligonoSelecionado.MatTransformacao);
                AplicarTransformacao(poligonoSelecionado);

                RedrawCanvas();
                UpdateDataGridView();
            }
        }

        private void bttAplicaEscala_Click(object sender, EventArgs e)
        {
            if (poligonoSelecionado != null)
            {
                float sx = (float)numEscalaX.Value;
                float sy = (float)numEscalaY.Value;

                double[,] translacaoParaOrigem = new double[3, 3] { { 1, 0, -poligonoSelecionado.Centro.X }, { 0, 1, -poligonoSelecionado.Centro.Y }, { 0, 0, 1 } };
                double[,] escala = new double[3, 3] { { sx, 0, 0 }, { 0, sy, 0 }, { 0, 0, 1 } };
                double[,] translacaoDeVolta = new double[3, 3] { { 1, 0, poligonoSelecionado.Centro.X }, { 0, 1, poligonoSelecionado.Centro.Y }, { 0, 0, 1 } };

                var temp = MultiplicarMatrizes(escala, translacaoParaOrigem); // Ordem ajustada
                var matrizFinal = MultiplicarMatrizes(translacaoDeVolta, temp);
                poligonoSelecionado.MatTransformacao = MultiplicarMatrizes(matrizFinal, poligonoSelecionado.MatTransformacao);

                AplicarTransformacao(poligonoSelecionado);

                RedrawCanvas();
                UpdateDataGridView();
            }
        }

        private void bttRotacionar_Click(object sender, EventArgs e)
        {
            if (poligonoSelecionado != null)
            {
                float anguloGraus = (float)numRotacionar.Value;
                float anguloRad = anguloGraus * (float)Math.PI / 180f;

                double[,] translacaoParaOrigem = new double[3, 3] { { 1, 0, -poligonoSelecionado.Centro.X }, { 0, 1, -poligonoSelecionado.Centro.Y }, { 0, 0, 1 } };
                double[,] rotacao = new double[3, 3] {
                    { Math.Cos(anguloRad), -Math.Sin(anguloRad), 0 },
                    { Math.Sin(anguloRad), Math.Cos(anguloRad), 0 },
                    { 0, 0, 1 }
                };
                double[,] translacaoDeVolta = new double[3, 3] { { 1, 0, poligonoSelecionado.Centro.X }, { 0, 1, poligonoSelecionado.Centro.Y }, { 0, 0, 1 } };

                var temp = MultiplicarMatrizes(rotacao, translacaoParaOrigem); // Ordem ajustada
                var matrizFinal = MultiplicarMatrizes(translacaoDeVolta, temp);
                poligonoSelecionado.MatTransformacao = MultiplicarMatrizes(matrizFinal, poligonoSelecionado.MatTransformacao);

                AplicarTransformacao(poligonoSelecionado);

                RedrawCanvas();
                UpdateDataGridView();
            }
        }

        private void bttReflexao_Click(object sender, EventArgs e)
        {
            if (poligonoSelecionado != null)
            {
                string tipoReflexao = comboBoxReflexao.SelectedItem?.ToString();
                double[,] matrizReflexao = new double[3, 3];

                switch (tipoReflexao)
                {
                    case "Eixo X":
                        matrizReflexao = new double[3, 3] { { 1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };
                        break;
                    case "Eixo Y":
                        matrizReflexao = new double[3, 3] { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
                        break;
                    case "Ambos":
                        matrizReflexao = new double[3, 3] { { -1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };
                        break;
                    default:
                        return;
                }

                double[,] translacaoParaOrigem = new double[3, 3] { { 1, 0, -poligonoSelecionado.Centro.X }, { 0, 1, -poligonoSelecionado.Centro.Y }, { 0, 0, 1 } };
                double[,] translacaoDeVolta = new double[3, 3] { { 1, 0, poligonoSelecionado.Centro.X }, { 0, 1, poligonoSelecionado.Centro.Y }, { 0, 0, 1 } };

                var temp = MultiplicarMatrizes(matrizReflexao, translacaoParaOrigem); // Ordem ajustada
                var matrizFinal = MultiplicarMatrizes(translacaoDeVolta, temp);
                poligonoSelecionado.MatTransformacao = MultiplicarMatrizes(matrizFinal, poligonoSelecionado.MatTransformacao);

                AplicarTransformacao(poligonoSelecionado);

                RedrawCanvas();
                UpdateDataGridView();
            }
        }

        private void bttCisalhamento_Click(object sender, EventArgs e)
        {
            if (poligonoSelecionado != null)
            {
                float shearX = (float)numCisalhamentoX.Value;
                float shearY = (float)numCisalhamentoY.Value;

                double[,] translacaoParaOrigem = new double[3, 3] { { 1, 0, -poligonoSelecionado.Centro.X }, { 0, 1, -poligonoSelecionado.Centro.Y }, { 0, 0, 1 } };
                double[,] cisalhamento = new double[3, 3] {
                    { 1, shearX, 0 },
                    { shearY, 1, 0 },
                    { 0, 0, 1 }
                };
                double[,] translacaoDeVolta = new double[3, 3] { { 1, 0, poligonoSelecionado.Centro.X }, { 0, 1, poligonoSelecionado.Centro.Y }, { 0, 0, 1 } };

                var temp = MultiplicarMatrizes(cisalhamento, translacaoParaOrigem); // Ordem ajustada
                var matrizFinal = MultiplicarMatrizes(translacaoDeVolta, temp);
                poligonoSelecionado.MatTransformacao = MultiplicarMatrizes(matrizFinal, poligonoSelecionado.MatTransformacao);

                AplicarTransformacao(poligonoSelecionado);

                RedrawCanvas();
                UpdateDataGridView();
            }
        }

        private void UpdateDataGridView()
        {
            dataGridViewPontos.Rows.Clear();
            if (poligonoSelecionado != null)
            {
                for (int i = 0; i < poligonoSelecionado.VerticesAtuais.Count; i++)
                {
                    Point ponto = poligonoSelecionado.VerticesAtuais[i];
                    dataGridViewPontos.Rows.Add($"Ponto {i + 1}", ponto.X, ponto.Y);
                }
            }
        }
    }
}