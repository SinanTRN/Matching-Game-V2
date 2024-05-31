using System.Text;
using System.Text.Json;

namespace Matching_Game_V2
{
    public partial class Ana_menu : Form
    {
        public Ana_menu()
        {
            InitializeComponent();
            //lblScore.Text = File.ReadAllText("score.txt", Encoding.UTF8);
        }
        private void btnTek_Click(object sender, EventArgs e)
        {
            SinglePlayer form = new SinglePlayer();
            form.Show();
            this.Close();
        }
    }
}
