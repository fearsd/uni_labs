using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_1
{
    public class Drawing
    {
        public int playground_x0, playground_y0, padding, cell_size, playground_size, playground_width;
        public Drawing(int _playground_x0,  int _playground_y0, int _padding, int _cell_size, int _playground_size, int _playground_width)
        {
            playground_x0 = _playground_x0;
            playground_y0 = _playground_y0;
            padding = _padding;
            cell_size = _cell_size;
            playground_size = _playground_size;
            playground_width = _playground_width;
        }
        public void DrawCross(Graphics g, int i, int j)
        {
            int cross_x0 = playground_x0 + cell_size * j + padding;
            int cross_x1 = playground_x0 + cell_size * (j + 1) - padding;
            int cross_y0 = playground_y0 + cell_size * i + padding;
            int cross_y1 = playground_y0 + cell_size * (i + 1) - padding;
            g.DrawLine(new Pen(Color.Blue, 2.0f), cross_x0, cross_y0, cross_x1, cross_y1);
            g.DrawLine(new Pen(Color.Blue, 2.0f), cross_x0, cross_y1, cross_x1, cross_y0);
        }
        public void DrawCircle(Graphics g, int i, int j)
        {
            int x = playground_x0 + j * cell_size + padding;
            int y = playground_y0 + i * cell_size + padding;
            int width = cell_size - padding * 2;
            g.DrawEllipse(new Pen(Color.Red, 2.0f), x, y, width, width);
        }
        public void DrawWinLine(Graphics g, int i0, int j0, int i1, int j1)
        {
            int x0, y0, x1, y1;
            if (j0 == j1)
            {
                x0 = playground_x0 + j0 * cell_size + cell_size / 2;
                y0 = playground_y0 + i0 * cell_size + padding;
                x1 = x0;
                y1 = playground_y0 + (i1 + 1) * cell_size - padding;
            }
            else if (i0 == i1)
            {
                x0 = playground_x0 + j0 * cell_size + padding;
                y0 = playground_y0 + i0 * cell_size + cell_size / 2;
                x1 = playground_x0 + (j1 + 1) * cell_size - padding;
                y1 = y0;
            }
            else
            {
                x0 = playground_x0 + j0 * cell_size + cell_size / 2;
                y0 = playground_y0 + i0 * cell_size + cell_size / 2;
                x1 = playground_x0 + j1 * cell_size + cell_size / 2;
                y1 = playground_y0 + i1 * cell_size + cell_size / 2;
            }

            g.DrawLine(new Pen(Color.Black, 5.0f), x0, y0, x1, y1);
        }
        public void HighlightCurrentPlayer(bool current_player, Label Player1Label, Label Player2Label)
        {
            if (current_player)
            {
                Player1Label.BackColor = Color.Yellow;
                Player2Label.BackColor = Color.White;
            }
            else
            {
                Player1Label.BackColor = Color.White;
                Player2Label.BackColor = Color.Yellow;
            }
        }
        public void DrawPlayground(Graphics g, int[,] field)
        {
            g.DrawRectangle(new Pen(Color.Gray, 2.0f), new Rectangle(150, 150, 300, 300));
            for (int i = 1; i < playground_size; i++)
            {
                g.DrawLine(new Pen(Color.Gray, 1.0f), playground_x0 + cell_size * i, playground_y0, playground_x0 + cell_size * i, playground_y0 + playground_width);
                g.DrawLine(new Pen(Color.Gray, 1.0f), playground_x0, playground_y0 + cell_size * i, playground_x0 + playground_width, playground_y0 + cell_size * i);
            }
            for (int i = 0; i < playground_size; i++)
            {
                for (int j = 0; j < playground_size; j++)
                {
                    if (field[i, j] == 1) DrawCross(g, i, j);
                    else if (field[i, j] == 2) DrawCircle(g, i, j);
                }
            }
        }
    }
}
