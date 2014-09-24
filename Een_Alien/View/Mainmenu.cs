using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Een_Alien.View
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void btn_level1_Click(object sender, EventArgs e)
        {

        }

        private void btn_level2_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Een_Alien.Controller.Mainmenu.Shutdown();
        }

        private void btn_highscores_Click(object sender, EventArgs e)
        {
            Highscores scores = new Highscores();
            scores.ShowDialog();
        }
    }
}
