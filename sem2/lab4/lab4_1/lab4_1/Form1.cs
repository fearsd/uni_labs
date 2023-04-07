namespace lab4_1
{
    public partial class Form1 : Form
    {
        public static int[] origins = new int[] { 50, 300 };
        public static int[] axisSizes = new int[] { 700, 200 };
        public Helper helper = new Helper(axisSizes);
        public Drawing drawing = new Drawing(origins, axisSizes);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            drawing.DrawBaseLines(g);
            drawing.DrawColumns(g, helper.elems, helper.elemWidth, helper.heightCoef, helper.elemNum);
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            helper.BuildGraphics();
            Invalidate();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            helper.WriteCurrentDataToFile("");
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            helper.BuildGraphicsFromFile("");
            Invalidate();
        }
    }
}