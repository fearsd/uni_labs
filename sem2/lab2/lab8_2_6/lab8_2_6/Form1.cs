namespace lab8_2_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int xc = this.Width / 2;
            int yc = this.Height / 2;

            g.TranslateTransform(xc, yc);

            g.DrawEllipse(new Pen(Color.Red, 8.0f), 0, 0, 1, 1);
            double x, z;
            g.DrawLine(new Pen(Color.Brown, 1.0f), -200, 0, 200, 0);
            g.DrawLine(new Pen(Color.Brown, 1.0f), 0, -200, 0, 200);

            for (int i = 0; i <= 40; i++)
            {
                x = 1 + i*10/40;
                z = x*x*x + 5*x*x + 14*x - 56;
                g.DrawEllipse(new Pen(Color.Blue, 2.0f), (float)x * 1/11, (float)-z * 1/11, 1, 1);
            }
        }
    }
}