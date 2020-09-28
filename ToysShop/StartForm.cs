using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToysShop
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (checkBoxBear.Checked || checkBoxLEGOSet.Checked || checkBoxSetOfSoldiers.Checked || checkBoxRadioCar.Checked || checkBoxBarbiDoll.Checked)
            {
                double s = 0;
                if (checkBoxBear.Checked)
                {
                    s = s + 50;
                }
                if (checkBoxLEGOSet.Checked)
                {
                    s = s + 120;
                }
                if (checkBoxSetOfSoldiers.Checked)
                {
                    s = s + 150;
                }
                if (checkBoxRadioCar.Checked)
                {
                    s = s + 170;
                }
                if (checkBoxBarbiDoll.Checked)
                {
                    s = s + 75;
                }
                MessageBox.Show(Convert.ToString(s) + " руб.", "Стоимость покупки ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не выбран товар!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormHelp f = new FormHelp();
            f.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPrices_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("цены.txt");
            while (sr.EndOfStream != true)
            {
                this.textBoxPrices.Text = sr.ReadLine();
            }
        }
    }
}
