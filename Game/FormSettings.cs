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
        private Color _ColorUser;
        private Color _ColorBot;

<<<<<<< HEAD
        private int _N;

        private FormGame _MainForm;
=======
        private int n;
        // Do not use variables name like 'a', 'b'. Please rename it.
        private FormGame a;
>>>>>>> 1017f8ee37edad532daca0d0f23e36f9b1c21e7f

        public FormSettings()
        {
            InitializeComponent();
        }

        public FormSettings(FormGame mainForm) : this()
        {
            _MainForm = mainForm;
        }

        public void GetData()
        {
            _MainForm.N = _N;
            _MainForm.ColorUser = _ColorUser;
            _MainForm.ColorBot = _ColorBot;
        }

        private void buttonUserSubmit_Click(object sender, EventArgs e)
        {
            if (colorDialogUser.ShowDialog() == DialogResult.OK)
            {
                _ColorUser = colorDialogUser.Color;
                //buttonUserChoose.BackColor = colorDialogUser.Color;
            }
        }

        private void buttonBotChoose_Click(object sender, EventArgs e)
        {
            if (colorDialogBot.ShowDialog() == DialogResult.OK)
            {
                _ColorBot = colorDialogBot.Color;
                //buttonBotChoose.BackColor = colorDialogBot.Color;
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
            _N = trackBarN.Value;
        }
    }
}
