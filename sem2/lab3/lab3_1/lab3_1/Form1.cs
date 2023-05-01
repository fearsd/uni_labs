using System.Windows.Forms;

namespace lab3_1
{
    public partial class Form1 : Form
    {
        public static int playground_x0 = 150, playground_y0 = 150; // upperleft corner coordinate of the playground
        public static int playground_width = 300;
        
        public static int playground_size = 3; // the size of matrix
        public static int cell_size = playground_width / playground_size;
        public static int cross_sign = 1;
        public static int circle_sign = 2;
        public static int padding = cell_size / 10;
        public Game game = new Game(playground_size, cross_sign, circle_sign);
        public Drawing drawing = new Drawing(playground_x0, playground_y0, padding, cell_size, playground_size, playground_width);

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Player1ScoreLabel.Text = game.Player1Score.ToString();
            Player2ScoreLabel.Text = game.Player2Score.ToString();
            drawing.HighlightCurrentPlayer(game.current_player, Player1Label, Player2Label);

            Graphics g = e.Graphics;
            drawing.DrawPlayground(g, game.field);
            
            if (game.winned)
            {
                drawing.DrawWinLine(g, game.win_combo[0], game.win_combo[1], game.win_combo[2], game.win_combo[3]);
                ShowMessageBoxAfterWin();
            }
            if (game.moveNum == 9)
            {
                ShowMessageBoxAfterDraw();
            }
        }
        

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int i = (e.Y - playground_y0) / cell_size;
            int j = (e.X - playground_x0) / cell_size;

            if ((e.X < playground_x0 || e.X > playground_x0 + playground_width) 
                || (e.Y < playground_y0 || e.Y > playground_y0 + playground_width) 
                || game.field[i, j] != 0
                || game.winned
            )
            {
                return;
            }

            game.MakeMove(i, j);
            Invalidate();
        }
        
        
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            game.NewGame();
            Invalidate();
        }

        private void ResetScoreButton_Click(object sender, EventArgs e)
        {
            game.ResetScore();
            Invalidate();
        }
        private void ShowMessageBoxAfterWin()
        {
            string messageText = game.current_player ? "Первый игрок победил" : "Второй игрок победил";
            string messageCaption = "Конец раунда";
            game.NewGame();

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(messageText, messageCaption, buttons);
            Invalidate();
        }
        private void ShowMessageBoxAfterDraw()
        {
            string messageText = "Ничья!";
            string messageCaption = "Конец раунда";
            game.NewGame();

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(messageText, messageCaption, buttons);
            Invalidate();
        }
        
    }
}

