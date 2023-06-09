using System;
using System.Windows.Forms;

namespace Spillet
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            // Sett opp skjemaet når det lastes
            Text = "Spillet";
            BackColor = System.Drawing.Color.Black;

            Label welcomeLabel = new Label();
            welcomeLabel.Text = "Velkommen til Spillet!";
            welcomeLabel.ForeColor = System.Drawing.Color.White;
            welcomeLabel.Font = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold);
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new System.Drawing.Point((Width - welcomeLabel.Width) / 2, (Height - welcomeLabel.Height) / 2);
            Controls.Add(welcomeLabel);

            Button startButton = new Button();
            startButton.Text = "Start Game";
            startButton.Font = new System.Drawing.Font("Arial", 16);
            startButton.AutoSize = true;
            startButton.Location = new System.Drawing.Point((Width - startButton.Width) / 2, welcomeLabel.Bottom + 20);
            startButton.Click += StartButton_Click;
            Controls.Add(startButton);

            Button quitButton = new Button();
            quitButton.Text = "Quit Game";
            quitButton.Font = new System.Drawing.Font("Arial", 16);
            quitButton.AutoSize = true;
            quitButton.Location = new System.Drawing.Point((Width - quitButton.Width) / 2, startButton.Bottom + 10);
            quitButton.Click += QuitButton_Click;
            Controls.Add(quitButton);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Kode for å starte spillet
            MessageBox.Show("Starter spillet!");
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            // Kode for å avslutte spillet
            Close();
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameForm());
        }
    }
}
