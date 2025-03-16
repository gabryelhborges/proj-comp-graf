using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProcessamentoImagens
{
    public partial class frmPrincipal : Form
    {
        private Bitmap canvas;
        private bool flag = true;
        private int x1, y1, x2, y2;
        private Point shadowEnd;

        public frmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            comboBoxAlgoritmos.SelectedIndex = 1;

            // Habilitar Double Buffering usando reflexão
            panel1.GetType().InvokeMember(
                "DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null,
                panel1,
                new object[] { true }
            );

            // Inicializar canvas com o tamanho atual do panel1
            UpdateCanvasSize();
            ClearCanvas();

            // Associar o evento de redimensionamento
            this.Resize += frmPrincipal_Resize;
        }

        private void UpdateCanvasSize()
        {
            if (canvas != null) canvas.Dispose(); // Liberar o recurso anterior
            canvas = new Bitmap(panel1.Width, panel1.Height);
        }

        private void ClearCanvas()
        {
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.Clear(Color.White);
            }
            panel1.Invalidate();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ClearCanvas();
            flag = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!flag)
            {
                shadowEnd = new Point(e.X, e.Y);
                panel1.Invalidate();
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                x1 = e.X;
                y1 = e.Y;
                Console.WriteLine("Primeiro click: Coord -> X = " + x1 + " Y = " + y1);
            }
            else
            {
                x2 = e.X;
                y2 = e.Y;
                Console.WriteLine("Segundo click: Coord -> X = " + x2 + " Y = " + y2);

                using (Graphics g = Graphics.FromImage(canvas))
                {
                    switch (comboBoxAlgoritmos.SelectedIndex)
                    {
                        case 0: DrawLineDDA(g, canvas, x1, y1, x2, y2, new Pen(Color.Red)); break;
                        case 1: DrawLineGeneralEquation(g, canvas, x1, y1, x2, y2, new Pen(Color.Blue)); break;
                        case 2: DrawLineMidpoint(g, canvas, x1, y1, x2, y2, new Pen(Color.Green)); break;
                    }
                }
                panel1.Invalidate();
            }
            flag = !flag;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(canvas, 0, 0);
            if (!flag && shadowEnd != Point.Empty)
            {
                using (Pen shadowPen = new Pen(Color.Gray, 1))
                {
                    switch (comboBoxAlgoritmos.SelectedIndex)
                    {
                        case 0: DrawLineDDA(e.Graphics, canvas, x1, y1, shadowEnd.X, shadowEnd.Y, shadowPen); break;
                        case 1: DrawLineGeneralEquation(e.Graphics, canvas, x1, y1, shadowEnd.X, shadowEnd.Y, shadowPen); break;
                        case 2: DrawLineMidpoint(e.Graphics, canvas, x1, y1, shadowEnd.X, shadowEnd.Y, shadowPen); break;
                    }
                }
            }
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            UpdateCanvasSize();
            ClearCanvas();
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