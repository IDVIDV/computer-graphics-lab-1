using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KG1
{
    public partial class Paint : Form
    {
        private Color chosenColor;
        private Bitmap paintZone;
        private Filler filler;
        private bool isDrawing;
        private bool isMousePressed;

        public Paint()
        {
            InitializeComponent();
            paintZone = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = paintZone;
            chosenColor = Color.Black;
            filler = new Filler();
            isDrawing = true;
            pictureBox.MouseMove += drawByPencil;
        }

        private void pickColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;


            chosenColor = colorDialog.Color;
            pickColorButton.BackColor = chosenColor;
        }

        private void pencilButton_Click(object sender, EventArgs e)
        {
            if (!isDrawing)
            {
                isDrawing = true;
                pencilButton.FlatAppearance.BorderColor = Color.Red;
                fillerButton.FlatAppearance.BorderColor = Color.Black;

                pictureBox.MouseClick -= fill;

                pictureBox.MouseDown += pictureBox_MouseDown;
                pictureBox.MouseUp += pictureBox_MouseUp;
                pictureBox.MouseMove += drawByPencil;
            }
        }

        private void fillerButton_Click(object sender, EventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                pencilButton.FlatAppearance.BorderColor = Color.Black;
                fillerButton.FlatAppearance.BorderColor = Color.Red;

                pictureBox.MouseClick += fill;

                pictureBox.MouseDown -= pictureBox_MouseDown;
                pictureBox.MouseUp -= pictureBox_MouseUp;
                pictureBox.MouseMove -= drawByPencil;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePressed = true;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePressed = false;
        }

        private void drawByPencil(object sender, MouseEventArgs e)
        {
            if (isMousePressed)
            {
                Point point = pictureBox.PointToClient(Cursor.Position);
                GraphicsUnit unit = GraphicsUnit.Pixel;
                if (!paintZone.GetBounds(ref unit).Contains(new RectangleF(point, new Size(2, 2))))
                {
                    return;
                }

                paintZone.SetPixel(point.X, point.Y, chosenColor);
                paintZone.SetPixel(point.X + 1, point.Y, chosenColor);
                paintZone.SetPixel(point.X, point.Y + 1, chosenColor);
                paintZone.SetPixel(point.X + 1, point.Y + 1, chosenColor);
                pictureBox.Refresh();
            }
        }

        private void fill(object sender, EventArgs e)
        {
            Point startingPoint = pictureBox.PointToClient(Cursor.Position);
            startingPoint = new Point(startingPoint.X, startingPoint.Y);
            //filler.fill(chosenColor, new Bitmap(3, 3), new Point(0, 0));
            filler.fill(chosenColor, paintZone, startingPoint);
            pictureBox.Refresh();
        }
    }
}
