using System.Text;
using System.Text.Json;

namespace Matching_Game_V2
{
    public partial class Ana_menu : Form
    {
        int oldScore = Convert.ToInt32(File.ReadAllText("score.txt", Encoding.UTF8));
        public Ana_menu()
        {
            InitializeComponent();
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
            oldScore = Convert.ToInt32(File.ReadAllText("score.txt", Encoding.UTF8));
            switch (txtZorluk.SelectedIndex)
            {
                case 0:
                    oldScore = Convert.ToInt32(File.ReadAllText("score.txt", Encoding.UTF8));
                    if (oldScore != Convert.ToInt32(lblScore.Text))
                        lblScore.Text = File.ReadAllText("score.txt", Encoding.UTF8);
                    break;
                case 1:
                    oldScore = Convert.ToInt32(File.ReadAllText("scoreMiddle.txt", Encoding.UTF8));
                    if (oldScore != Convert.ToInt32(lblScore.Text))
                        lblScore.Text = File.ReadAllText("scoreMiddle.txt", Encoding.UTF8);
                    break;
                case 2:
                    oldScore= Convert.ToInt32(File.ReadAllText("scorehard.txt", Encoding.UTF8));
                    if (oldScore != Convert.ToInt32(lblScore.Text))
                        lblScore.Text = File.ReadAllText("scoreHard.txt", Encoding.UTF8);
                    break;
                default:
                    lblScore.Text = "0";
                    break;

            }
        }
    }
}
