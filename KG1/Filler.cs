using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KG1
{
    public class Filler
    {
        public void fill(Color color, Bitmap bitmap, Point startingPoint)
        {
            GraphicsUnit unit = GraphicsUnit.Pixel;
            RectangleF bounds = bitmap.GetBounds(ref unit);

            Queue<Point> points = new Queue<Point>();

            points.Enqueue(startingPoint);

            int colorArgb = color.ToArgb();

            while (points.Count > 0)
            {
                Point curPoint = points.Dequeue();

                bitmap.SetPixel(curPoint.X, curPoint.Y, color);

                Point neighborPoint = new Point(curPoint.X, curPoint.Y + 1);

                if (bounds.Contains(neighborPoint) && !points.Contains(neighborPoint) && bitmap.GetPixel(neighborPoint.X, neighborPoint.Y).ToArgb() != colorArgb)
                {
                    points.Enqueue(neighborPoint);
                }

                neighborPoint = new Point(curPoint.X, curPoint.Y - 1);

                if (bounds.Contains(neighborPoint) && !points.Contains(neighborPoint) && bitmap.GetPixel(neighborPoint.X, neighborPoint.Y).ToArgb() != colorArgb)
                {
                    points.Enqueue(neighborPoint);
                }

                neighborPoint = new Point(curPoint.X + 1, curPoint.Y);

                if (bounds.Contains(neighborPoint) && !points.Contains(neighborPoint) && bitmap.GetPixel(neighborPoint.X, neighborPoint.Y).ToArgb() != colorArgb)
                {
                    points.Enqueue(neighborPoint);
                }

                neighborPoint = new Point(curPoint.X - 1, curPoint.Y);

                if (bounds.Contains(neighborPoint) && !points.Contains(neighborPoint) && bitmap.GetPixel(neighborPoint.X, neighborPoint.Y).ToArgb() != colorArgb)
                {
                    points.Enqueue(neighborPoint);
                }
            }
        }
    }
}
