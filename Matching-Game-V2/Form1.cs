using System.Text;
using System.Text.Json;

namespace Matching_Game_V2
{
    public partial class Ana_menu : Form
    {
        int oldScore = 0;
        public Ana_menu()
        {
            InitializeComponent();
        }
        private void ScoreReadEasy()
        {
            if (File.Exists("score.txt")) oldScore =Convert.ToInt32(File.ReadAllText("score.txt"));
            else oldScore = 0;

        }
        private void ScoreReadMiddle()
        {
            if (File.Exists("scoreMiddle.txt")) oldScore = Convert.ToInt32(File.ReadAllText("scoreMiddle.txt"));
            else oldScore = 0;
        }
        private void ScoreReadHard()
        {
            if (File.Exists("scoreHard.txt")) oldScore = Convert.ToInt32(File.ReadAllText("scoreHard.txt"));
            else oldScore = 0;

        }
        private void btnTek_Click(object sender, EventArgs e)
        {
            switch (txtZorluk.SelectedIndex)
            {
                case 0:
                    SinglePlayer singleEasy = new SinglePlayer();
                    singleEasy.ShowDialog();
                    break;
                case 1:
                    SinglePlayerMiddle singlemiddle = new SinglePlayerMiddle();
                    singlemiddle.ShowDialog();
                    break;
                case 2:
                    SinglePlayerHard singlePlayerHard = new SinglePlayerHard();
                    singlePlayerHard.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Lütfen zorluk seçiniz", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (txtZorluk.SelectedIndex)
            {
                case 0:
                    ScoreReadEasy();
                    if (oldScore != Convert.ToInt32(lblScore.Text))
                        lblScore.Text = oldScore.ToString();
                    break;
                case 1:
                    ScoreReadMiddle();
                    if (oldScore != Convert.ToInt32(lblScore.Text))
                        lblScore.Text = oldScore.ToString();
                    break;
                case 2:
                    ScoreReadHard();
                    if (oldScore != Convert.ToInt32(lblScore.Text))
                        lblScore.Text = oldScore.ToString();
                    break;
                default:
                    lblScore.Text = oldScore.ToString();
                    break;

            }
        }

       
    }
}
