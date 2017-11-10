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
    public partial class FormGameProcess : Form
    {
        private FieldContext newGameField;
        private RealPlayer user;
        private BotPlayer bot;
        private Size CellSize;
        public FormGameProcess()
        {
            InitializeComponent();
        }

        public FormGameProcess(int N, Color a, Color b) : this()
        {
            newGameField = new FieldContext(N);
            user = new RealPlayer(a);
            bot = new BotPlayer(b);
            CellSize.Width = GetCellSize().Width;
            CellSize.Height = GetCellSize().Height;
        }

        private void FormGameProcess_Load(object sender, EventArgs e)
        {
            //panelGameArea.Invalidate();
        }

        private void DrawNet(PaintEventArgs e)
        {
            for (int i = 1; i < newGameField.QuanCols; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), new Point(i * CellSize.Width, 0), new Point(i * CellSize.Width, panelGameArea.Height));
            }

            for (int i = 1; i < newGameField.QuanRows; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), new Point(0, i * CellSize.Height), new Point(panelGameArea.Width, i * CellSize.Height));
            }
        }

        private void panelGameArea_Paint(object sender, PaintEventArgs e)
        {
            DrawNet(e);

            for (int i = 0; i < newGameField.QuanRows; i++)
            {
                for (int j = 0; j < newGameField.QuanCols; j++)
                {
                    if (newGameField.Field[i, j] != PlayerCell.Empty)
                    {
                        Color b = Color.White;
                        if (PlayerCell.Hero == newGameField.Field[i, j])
                        {
                            b = user.playerColor;
                        }
                        if (PlayerCell.Antagonist == newGameField.Field[i, j])
                        {
                            b = bot.playerColor;
                        }
                        DrawCell(j * CellSize.Width, CellSize.Height * (newGameField.QuanRows - i - 1), CellSize.Width, CellSize.Height, e, b);
                    }
                }
            }
        }

        private void DrawCell(int x, int y, int width, int height, PaintEventArgs e, Color a)
        {
            Rectangle rect = new Rectangle(x, y, width, height);
            SolidBrush blueBrush = new SolidBrush(a);
            e.Graphics.DrawEllipse(new Pen(a), rect);
            e.Graphics.FillEllipse(blueBrush, rect);
        }

        private Size GetCellSize()
        {
            Size a = new Size(panelGameArea.Width / newGameField.QuanCols, panelGameArea.Height / newGameField.QuanRows);
            return a;
        }

        private void panelGameArea_MouseClick(object sender, MouseEventArgs e)
        {
            Point coordinates = e.Location;
            int col = coordinates.X / CellSize.Width;
            user.MakeStep(col, newGameField, PlayerCell.Hero);
            panelGameArea.Invalidate();
            // This part of code is similar to code below with the same two IF statemants.
            // You can try to create separate method with parameters.
            if (newGameField.EndOfTheGame(PlayerCell.Hero) == 1)
            {
                MessageBox.Show("You won!");
                this.Close();
            }
            if (newGameField.EndOfTheGame(PlayerCell.Hero) == 0)
            {
                MessageBox.Show("Draw!");
                this.Close();
            }
            bot.MakeStep(0, newGameField, PlayerCell.Hero);
            panelGameArea.Invalidate();
            if (newGameField.EndOfTheGame(PlayerCell.Antagonist) == 1)
            {
                MessageBox.Show("Bot won!");
                this.Close();
            }
            if (newGameField.EndOfTheGame(PlayerCell.Antagonist) == 0)
            {
                MessageBox.Show("Draw!");
                this.Close();
            }

        }
    }
}
