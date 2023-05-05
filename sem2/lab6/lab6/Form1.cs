namespace lab6
{
    public partial class Form1 : Form
    {
        Helper helper = new Helper(new int[] { 950, 530 });
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            helper.DrawFigures(g);
        }

        private void NewFigureButton_Click(object sender, EventArgs e)
        {
            helper.NewFigure();
            Invalidate();
        }

        private void SaveFiguresButton_Click(object sender, EventArgs e)
        {
            helper.SaveFigures();
        }

        private void LoadFiguresButton_Click(object sender, EventArgs e)
        {
            helper.LoadFigures();
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            helper.ChooseFigure(e);
            Invalidate();
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            helper.Erase();
            Invalidate();
        }
    }
}