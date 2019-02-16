using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherHomeWork
{
    public partial class FormAboutProgram : Form
    {
        public FormAboutProgram()
        {
            InitializeComponent();
            lblAboutProgram.Text = "Данная программа была по обезьянни повторена \nза преподавателем курса основы C# уровень 1 Сергеем Камянецким. \nДополнена и испорчена студентом курса Владимиром Болбатом. \nВсе авторские права не защищены никем, версия 0.1.";
        }
    }
}
