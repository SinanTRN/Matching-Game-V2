using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matching_Game_V2
{
    public partial class SinglePlayer : Form
    {
        Random random = new Random();
        List<string> simgeler;
        List<Label> labelList;
        Label firstClicked;
        Label secondClicked;
        int sure;
        int sayac = 0;
        int total = 0;
        public SinglePlayer()
        {
            InitializeComponent();
            InitializeLabelList();
            InitializeIcons();
        }
        private void InitializeIcons()
        {
            simgeler = new List<string>(){
                            "!", "!", "N", "N", ",", ",", "k", "k",
                            "b", "b", "v", "v", "w", "w", "z", "z",
                            };
        }
        private void labelleriSifirla()
        {
            foreach (Label label in labelList)
            {
                label.Text = "";
            }
        }
        private void InitializeLabelList()
        {
            labelList = new List<Label>();

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label label && ShouldAddLabel(label))
                {
                    labelList.Add(label);
                }
            }
        }
        private bool ShouldAddLabel(Label label)
        {
            // "i1" den "i36" ya kadar olan labelleri filtreleme
            if (label.Name.StartsWith("i"))
            {
                if (int.TryParse(label.Name.Substring(1), out int number))
                {
                    return number >= 1 && number <= 16;
                }
            }
            return false;
        }
        private void randomAta()
        {
            foreach (Label label in labelList)
            {
                int rastgele = random.Next(simgeler.Count);
                label.Text = simgeler[rastgele];
                //label.ForeColor = label.BackColor;
                simgeler.RemoveAt(rastgele);
            }
            InitializeIcons();
        }
        private void i1_Click(object sender, EventArgs e)
        {

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            randomAta();
        }
    }
}
