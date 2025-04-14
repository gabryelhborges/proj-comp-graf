using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProcessamentoImagens
{
    public static class Preenchimento
    {
        public static void FloodFill(Bitmap bmp, int x, int y, Color targetColor, Color replacementColor)
        {
            if (x < 0 || y < 0 || x >= bmp.Width || y >= bmp.Height)
                return;

            if (bmp.GetPixel(x, y) != targetColor)
                return;

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(x, y));

            while (pixels.Count > 0)
            {
                Point pt = pixels.Pop();
                if (pt.X < 0 || pt.Y < 0 || pt.X >= bmp.Width || pt.Y >= bmp.Height)
                    continue;

                if (bmp.GetPixel(pt.X, pt.Y) == targetColor)
                {
                    bmp.SetPixel(pt.X, pt.Y, replacementColor);

                    pixels.Push(new Point(pt.X + 1, pt.Y));
                    pixels.Push(new Point(pt.X - 1, pt.Y));
                    pixels.Push(new Point(pt.X, pt.Y + 1));
                    pixels.Push(new Point(pt.X, pt.Y - 1));
                }
            }
        }

        public static void ScanLineFill(Bitmap bmp, int x, int y, Color targetColor, Color replacementColor)
        {
            if (targetColor == replacementColor)
                return;

            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(new Point(x, y));

            while (queue.Count > 0)
            {
                Point p = queue.Dequeue();

                int y1 = p.Y;
                while (y1 >= 0 && bmp.GetPixel(p.X, y1) == targetColor)
                    y1--;

                y1++;
                bool spanLeft = false;
                bool spanRight = false;

                while (y1 < bmp.Height && bmp.GetPixel(p.X, y1) == targetColor)
                {
                    bmp.SetPixel(p.X, y1, replacementColor);

                    if (!spanLeft && p.X > 0 && bmp.GetPixel(p.X - 1, y1) == targetColor)
                    {
                        queue.Enqueue(new Point(p.X - 1, y1));
                        spanLeft = true;
                    }
                    else if (spanLeft && p.X > 0 && bmp.GetPixel(p.X - 1, y1) != targetColor)
                    {
                        spanLeft = false;
                    }

                    if (!spanRight && p.X < bmp.Width - 1 && bmp.GetPixel(p.X + 1, y1) == targetColor)
                    {
                        queue.Enqueue(new Point(p.X + 1, y1));
                        spanRight = true;
                    }
                    else if (spanRight && p.X < bmp.Width - 1 && bmp.GetPixel(p.X + 1, y1) != targetColor)
                    {
                        spanRight = false;
                    }

                    y1++;
                }
            }
        }
    }
}
