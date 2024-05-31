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
            lblScore.Text = File.ReadAllText("score.txt", Encoding.UTF8);
        }
        private void btnTek_Click(object sender, EventArgs e)
        {
            if (txtZorluk.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen zorluk seçiniz", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SinglePlayer form = new SinglePlayer();
                form.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            oldScore = Convert.ToInt32(File.ReadAllText("score.txt", Encoding.UTF8));
            if (oldScore != Convert.ToInt32(lblScore.Text))
            {
                lblScore.Text = File.ReadAllText("score.txt", Encoding.UTF8);
            }
        }
    }
}
