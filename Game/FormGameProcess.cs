﻿using System;
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
        private FieldContext _NewGameField;
        private RealPlayer _User;
        private BotPlayer _Bot;
        private Size _CellSize;
        public FormGameProcess()
        {
            InitializeComponent();
        }

        public FormGameProcess(int N, Color a, Color b) : this()
        {
            _NewGameField = new FieldContext(N);
            _User = new RealPlayer(a);
            _Bot = new BotPlayer(b);
            _CellSize.Width = GetCellSize().Width;
            _CellSize.Height = GetCellSize().Height;
        }

        private void FormGameProcess_Load(object sender, EventArgs e)
        {
            //panelGameArea.Invalidate();
        }

        private void DrawNet(PaintEventArgs e)
        {
            for (int i = 1; i < _NewGameField.QuanCols; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), new Point(i * _CellSize.Width, 0), new Point(i * _CellSize.Width, panelGameArea.Height));
            }

            for (int i = 1; i < _NewGameField.QuanRows; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), new Point(0, i * _CellSize.Height), new Point(panelGameArea.Width, i * _CellSize.Height));
            }
        }

        private void panelGameArea_Paint(object sender, PaintEventArgs e)
        {
            DrawNet(e);

            for (int i = 0; i < _NewGameField.QuanRows; i++)
            {
                for (int j = 0; j < _NewGameField.QuanCols; j++)
                {
                    if (_NewGameField.Field[i, j] != PlayerCell.Empty)
                    {
                        Color b = Color.White;
                        if (PlayerCell.Hero == _NewGameField.Field[i, j])
                        {
                            b = _User.playerColor;
                        }
                        if (PlayerCell.Antagonist == _NewGameField.Field[i, j])
                        {
                            b = _Bot.playerColor;
                        }
                        DrawCell(j * _CellSize.Width, _CellSize.Height * (_NewGameField.QuanRows - i - 1), _CellSize.Width, _CellSize.Height, e, b);
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
            Size a = new Size(panelGameArea.Width / _NewGameField.QuanCols, panelGameArea.Height / _NewGameField.QuanRows);
            return a;
        }

        private void panelGameArea_MouseClick(object sender, MouseEventArgs e)
        {
            Point coordinates = e.Location;
            int col = coordinates.X / _CellSize.Width;
            _User.MakeStep(col, _NewGameField, PlayerCell.Hero);
            panelGameArea.Invalidate();
            if (_NewGameField.EndOfTheGame(PlayerCell.Hero) == 1)
            {
                MessageBox.Show("You won!");
                this.Close();
            }
            if (_NewGameField.EndOfTheGame(PlayerCell.Hero) == 0)
            {
                MessageBox.Show("Draw!");
                this.Close();
            }
            _Bot.MakeStep(0, _NewGameField, PlayerCell.Hero);
            panelGameArea.Invalidate();
            if (_NewGameField.EndOfTheGame(PlayerCell.Antagonist) == 1)
            {
                MessageBox.Show("Bot won!");
                this.Close();
            }
            if (_NewGameField.EndOfTheGame(PlayerCell.Antagonist) == 0)
            {
                MessageBox.Show("Draw!");
                this.Close();
            }

        }
    }
}
