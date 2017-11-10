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
        public int N { get; set; }
        public Color ColorUser { get; set; }
        public Color ColorBot { get; set; }
        public FormGame()
        {
            N = 4;
            ColorBot = Color.Green;
            ColorUser = Color.Purple;
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void buttonStartNewGame_Click(object sender, EventArgs e)
        {
            FormGameProcess newGame = new FormGameProcess(N, ColorUser, ColorBot);
            newGame.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings a = new FormSettings(this);
            a.Show();
        }
    }
}
