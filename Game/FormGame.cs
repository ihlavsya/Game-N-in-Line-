using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class FormGame : Form
    {
        public int N;
        public Color colorUser;
        public Color colorBot;
        public FormGame()
        {
            N = 4;
            colorBot = Color.Green;
            colorUser = Color.Purple;
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void buttonStartNewGame_Click(object sender, EventArgs e)
        {
            FormGameProcess newGame = new FormGameProcess(N,colorUser,colorBot);
            newGame.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings a = new FormSettings(this);
            a.Show();
        }
    }
}
