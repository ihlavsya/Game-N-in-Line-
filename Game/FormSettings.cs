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
    public partial class FormSettings : Form
    {
        private Color colorUser;
        private Color colorBot;

        private int n;

        private FormGame a;

        public FormSettings()
        {
            InitializeComponent();
        }

        public FormSettings(FormGame b):this()
        {
            a = b;
        }

        public void GetData()
        {
            a.N = n;
            a.colorUser = colorUser;
            a.colorBot = colorBot;
        }

        private void buttonUserSubmit_Click(object sender, EventArgs e)
        {
            if (colorDialogUser.ShowDialog() == DialogResult.OK)
            {
                colorUser = colorDialogUser.Color;
                buttonUserChoose.BackColor = colorDialogUser.Color;
            }
        }

        private void buttonBotChoose_Click(object sender, EventArgs e)
        {
            if (colorDialogBot.ShowDialog() == DialogResult.OK)
            {
                colorBot = colorDialogBot.Color;
                buttonBotChoose.BackColor = colorDialogBot.Color;
            }
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            GetData();
            this.Hide();
        }

        private void trackBarN_ValueChanged(object sender, EventArgs e)
        {
            n = trackBarN.Value;
        }
    }
}
