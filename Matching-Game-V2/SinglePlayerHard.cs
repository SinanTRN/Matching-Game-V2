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
    public partial class SinglePlayerHard : Form
    {
        Random random = new Random();
        List<string> simgeler;
        List<Label> labelList;
        Label firstClicked;
        Label secondClicked;
        int sure;
        int score = 10000;
        int sayac = 0;
        int total = 0;
        bool isClickEnabler = false;
        public SinglePlayerHard()
        {
            InitializeComponent();
            InitializeLabelList();
            InitializeIcons();
            total = labelList.Count() / 2;
            timer1.Stop();
            timer2.Stop();
        }
        private int readScoreText()
        {
            string readScore = "0";
            if (File.Exists("scoreHard.txt"))
                readScore = File.ReadAllText("scoreHard.txt", Encoding.UTF8);
            return Convert.ToInt32(readScore);
        }
        public void ScoreUpdate()
        {
            if (!File.Exists("scoreHard.txt")) 
                File.Create("scoreHard.txt");
                
            File.WriteAllText("scoreHard.txt", sure + "", Encoding.UTF8);
        }
        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            timer2.Stop();
            timer1.Stop();
            isClickEnabler |= false;
            if (readScoreText() > sure||readScoreText()==0) ScoreUpdate();
            MessageBox.Show(sure + " saniyede bitirdiniz", "Tebrikler");
        }
        private void InitializeIcons()
        {
            simgeler = new List<string>(){
                            "!", "!", "N", "N", ",", ",", "k", "k",
                            "b", "b", "v", "v", "w", "w", "z", "z",
                            "m","m","d","d","f","f","l","l","s","s",
                            "B","B","F","F","J","J","V","V",";",";",
                            "a","a","c","c","e","e","g","g","h","h",
                            "i","i","j","j","n","n","o","o","p","p",
                            "r","r","t","t","u","u","y","y"
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
                    return number >= 1 && number <= 64;
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
                label.ForeColor = label.BackColor;
                simgeler.RemoveAt(rastgele);
            }
            InitializeIcons();
        }
        private void i1_Click(object sender, EventArgs e)
        {
            if (isClickEnabler == true)
            {
                if (timer2.Enabled == true) return;

                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {
                    if (clickedLabel.ForeColor == Color.Black) return;
                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;
                        return;
                    }

                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    CheckForWinner();

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        sayac++;
                        return;
                    }
                    timer2.Start();
                }
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            randomAta();
            isClickEnabler = true;
            sure = 0;
            sayac = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtSure.Text = sure.ToString();
            sure++;
            if (sayac == total)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }
    }
}
