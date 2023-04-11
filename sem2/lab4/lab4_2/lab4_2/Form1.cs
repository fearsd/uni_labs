namespace lab4_2
{
    public partial class Form1 : Form
    {
        public static int[] origins = new int[] { 50, 100 };
        public static int sideSize = 300;
        public Helper helper = new Helper();
        public Drawing drawing = new Drawing(origins, sideSize);
        public System.Timers.Timer timer = new System.Timers.Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            drawing.DrawPie(g, helper.elems, helper.elemCoef, helper.elemNum);
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            if (TimerInput.Text != "")
            {
                timer.Interval = int.Parse(TimerInput.Text) * 1000;
                timer.Elapsed += (sender, e) => BuildGraphics();
                timer.Start();
            }
            else BuildGraphics();

        }
        private void BuildGraphics()
        {
            helper.BuildGraphics();
            Invalidate();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            helper.BuildGraphicsFromFile("");
            Invalidate();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            helper.WriteCurrentDataToFile("");
        }

        private void TimerInput_TextChanged(object sender, EventArgs e)
        {
            if (TimerInput.Text != "")
            {
                timer.Stop();
                timer.Interval = int.Parse(TimerInput.Text) * 1000;
                timer.Elapsed += (sender, e) => BuildGraphics();
                timer.Start();
            }
            else timer.Stop();
        }
    }
}