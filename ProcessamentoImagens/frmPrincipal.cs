using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProcessamentoImagens
{
    
    public partial class frmPrincipal : Form
    {
        private Bitmap canvas;
        private Point shadowEnd;
        public List<Poligono> listaPol = new List<Poligono>();
        private List<Point> pontos = new List<Point>(); // Armazenar os pontos
        private Poligono poligonoAtual;

        public frmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            // Habilitar Double Buffering usando reflexão
            panel.GetType().InvokeMember(
                "DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null,
                panel,
                new object[] { true }
            );

            // Inicializar canvas com o tamanho atual do panel1
            UpdateCanvasSize();
            ClearCanvas();

            // Associar o evento de redimensionamento
            this.Resize += frmPrincipal_Resize;
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            UpdateCanvasSize();
            ClearCanvas();
        }

        private void UpdateCanvasSize()
        {
            if (canvas != null) canvas.Dispose(); // Liberar o recurso anterior
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
            pontos.Clear();  // Limpar a lista de pontos
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            // Atualiza a posição da sombra enquanto o mouse se move
            if (pontos.Count > 0)
            {
                shadowEnd = new Point(e.X, e.Y);
                panel.Invalidate(); // Solicita a atualização do painel
            }
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && pontos.Count > 1)
            {
                if (poligonoAtual != null)
                {
                    listaPol.Add(poligonoAtual);
                    using (Graphics g = Graphics.FromImage(canvas))
                    using (Pen pen = new Pen(poligonoAtual.Cor))
                    {
                        DrawLine(g, canvas, pontos[pontos.Count - 1].X, pontos[pontos.Count - 1].Y,
                                 pontos[0].X, pontos[0].Y, pen);
                    }
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
            // Desenhar a imagem do canvas (polígonos anteriores)
            e.Graphics.DrawImage(canvas, 0, 0);

            // Desenhar os polígonos existentes
            foreach (var poligono in listaPol)
            {
                for (int i = 1; i < poligono.VerticesAtuais.Count; i++)
                {
                    using (Pen pen = new Pen(poligono.Cor))
                    {
                        DrawLine(e.Graphics, canvas, poligono.VerticesAtuais[i - 1].X, poligono.VerticesAtuais[i - 1].Y,
                                 poligono.VerticesAtuais[i].X, poligono.VerticesAtuais[i].Y, pen);
                    }
                }
            }

            // Desenhar o polígono atual (em andamento)
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

                // Desenhar a sombra (linha do último ponto até a posição do mouse)
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
    }
}