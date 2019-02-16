using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblCtrl.Text = "введите число от 0 до 100";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkGuess();
        }        


    public void checkGuess()
    {
        int trueValue;
        bool flag = int.TryParse(tbText.Text, out trueValue);
        if (flag == true)
        {
                int i = Convert.ToInt32(tbText.Text);
                if (i <= 100 && i >= 0)
                {
                    nudTest.Value = Convert.ToInt32(tbText.Text);
                    lblCtrl.Text = "введите число от 0 до 100";
                }
                else lblCtrl.Text = "введите число от 0 до 100";

            }
        else { lblCtrl.Text = "необходимо ввести числа от 0 до 100"; }
    }
    }
}
