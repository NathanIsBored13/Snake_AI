using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_AI
{
    public partial class Defeat_Window : Form
    {
        public Defeat_Window()
        {
            InitializeComponent();
        }

        private void Continue_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
