using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declare
        int mineCount = 0, size = 0, remainMine = 0;
        int[,] Mine;
        int Opens = 0;
        int timerTime = 0;
        Button[,] buttonArr;
        Random rnd = new Random();
        Stopwatch Time = new Stopwatch();
        //Declare

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }//開始初始化

        private void Init()
        {
            //Reset all variables
            mineCount = 0;
            size = 0;
            timerTime = 0;
            Time.Stop();
            Time.Reset();
            ClockStripItem.Text = "🕐: ";
            FlagStripItem.Text = "⚑: ";
            //Reset all variables

            //Input
            try
            {
                mineCount = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("請輸入炸彈數", "初始化", "5"));
                size = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("請輸入長寬", "初始化", "5"));
            }
            catch
            {
                MessageBox.Show("請輸入正確的數值!", "錯誤!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Init();
            }
            //Input

            Generate();
        }//初始化

        private void Generate()
        {
            //Generate Controls
            buttonPanel.Controls.Clear();
            int x = 25, y = 25;
            buttonArr = new Button[size, size];
            for (int b = 0; b < size; b++)
            {
                for (int a = 0; a < size; a++)
                {
                    buttonArr[a, b] = new Button();
                    buttonArr[a, b].Size = new Size(50, 50);
                    buttonArr[a, b].Location = new Point(x, y);
                    buttonArr[a, b].Font = buttonPanel.Font;
                    x += 75;
                    buttonPanel.Controls.Add(buttonArr[a, b]);
                    buttonArr[a, b]. MouseUp +=new MouseEventHandler(buttonClick);
                    buttonArr[a, b].Tag = new Point(a, b);
                }
                x = 25;
                y += 75;
            }
            
            this.Width = 75 * (size + 1) - 25;
            this.Height = 75 * (size + 1) + 25;
            buttonPanel.Size = this.Size;
            buttonPanel.Location = new Point(0, 25);
            //Generate Controls

            //Generate Mines
            Mine = new int[size, size];
            int genMineCount = 0;
            while (genMineCount < mineCount)
            {
                int rndX = rnd.Next(0, size);
                int rndY = rnd.Next(0, size);
                if (Mine[rndX, rndY] != 0)
                    continue;
                Mine[rndX, rndY] = 10;
                genMineCount++;
            }
            //Generate Mines

            //Adding Numbers
            for (int b = 0; b< size; b++)
            {
                for (int a = 0; a < size; a++)
                {
                    if (Mine[a, b] >= 10)
                    {
                        try { Mine[a - 1, b]++; } catch { }
                        try { Mine[a + 1, b]++; } catch { }
                        try { Mine[a, b - 1]++; } catch { }
                        try { Mine[a, b + 1]++; } catch { }
                        try { Mine[a - 1, b - 1]++; } catch { }
                        try { Mine[a - 1, b + 1]++; } catch { }
                        try { Mine[a + 1, b - 1]++; } catch { }
                        try { Mine[a + 1, b + 1]++; } catch { }
                    }
                }
            }
            //Adding Numbers

            //Finalizing
            remainMine = mineCount;
            FlagStripItem.Text = "🕐: " + remainMine.ToString();
            gameTimer.Enabled = true;
            Time.Start();
            //Finalizing
        }//生成&設定物件

        private void buttonClick(Object sender, MouseEventArgs e)
        {
            Button sendButton = (Button)sender;
            Point pos = (Point)sendButton.Tag;

            if (e.Button == MouseButtons.Left&&sendButton.Text=="")
            {
                switch (Mine[pos.X, pos.Y])
                {
                    case 0:
                        EmptyDetect(pos);
                        break;
                    case 1:
                        sendButton.Text = Mine[pos.X, pos.Y].ToString();
                        sendButton.ForeColor = Color.Blue;
                        break;
                    case 2:
                        sendButton.Text = Mine[pos.X, pos.Y].ToString();
                        sendButton.ForeColor = Color.Green;
                        break;
                    case 3:
                        sendButton.Text = Mine[pos.X, pos.Y].ToString();
                        sendButton.ForeColor = Color.DarkCyan;
                        break;
                    case 4:
                        sendButton.Text = Mine[pos.X, pos.Y].ToString();
                        sendButton.ForeColor = Color.Red;
                        break;
                    case 5:
                        sendButton.Text = Mine[pos.X, pos.Y].ToString();
                        sendButton.ForeColor = Color.Gray;
                        break;
                    case 6:
                        sendButton.Text = Mine[pos.X, pos.Y].ToString();
                        sendButton.ForeColor = Color.Purple;
                        break;
                    case 7:
                        sendButton.Text = Mine[pos.X, pos.Y].ToString();
                        sendButton.ForeColor = Color.Orange;
                        break;
                    case 8:
                        sendButton.Text = Mine[pos.X, pos.Y].ToString();
                        sendButton.ForeColor = Color.Lavender;
                        break;
                    default:
                        sendButton.BackColor = Color.Pink;
                        EndGame(false);
                        break;
                }
                Opens++;
                if (CompleteDetect())
                    EndGame(true);
            }
            else if(e.Button == MouseButtons.Right&&sendButton.Text == "" && remainMine>0)
            {
                sendButton.Text = "⚑";
                sendButton.ForeColor = Color.Red;
                remainMine--;
            }
            else if (e.Button == MouseButtons.Right && sendButton.Text == "⚑")
            {
                sendButton.Text = "";
                sendButton.ForeColor = buttonPanel.ForeColor;
                remainMine++;
            }
            FlagStripItem.Text = "⚑: " + remainMine.ToString();
        }//按鈕觸發事件

        private void EmptyDetect(Point pos)
        {
            buttonArr[pos.X, pos.Y].Enabled = false;
            
        }//檢查空格

        private bool CompleteDetect()
        {
            for (int b = 0; b < size; b++)
                for (int a = 0; a < size; a++)
                {
                    if ((buttonArr[a, b].Text == string.Empty||buttonArr[a,b].Text == "⚑") && Mine[a, b] < 10&&buttonArr[a,b].Enabled ==true)
                        return false;
                }
            return true;
        }//檢查是否完成

        private void EndGame(bool isWin)
        {
            Time.Stop();
            gameTimer.Enabled = false;
            if (isWin == true)
            {
                FillAll();
                MessageBox.Show("你贏了\n消耗秒數: " + timerTime.ToString() +"\n計時器時長: " + Time.Elapsed.ToString(), "恭喜!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Init();
            }
            else if (isWin == false)
            {
                FillAll();
                MessageBox.Show("你死了\n消耗秒數: " + timerTime.ToString() + "\n計時器時長: " + Time.Elapsed.ToString(), "Boom!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Init();
            }
        }//結束遊戲

        private void FillAll()
        {
            for (int b = 0; b < size; b++)
                for (int a = 0; a < size; a++)
                {
                    switch (Mine[a, b])
                    {
                        case 0:
                            buttonArr[a, b].Enabled = false;
                            break;
                        case 1:
                            buttonArr[a, b].Text = Mine[a, b].ToString();
                            buttonArr[a, b].ForeColor = Color.Blue;
                            break;
                        case 2:
                            buttonArr[a, b].Text = Mine[a, b].ToString();
                            buttonArr[a, b].ForeColor = Color.Green;
                            break;
                        case 3:
                            buttonArr[a, b].Text = Mine[a, b].ToString();
                            buttonArr[a, b].ForeColor = Color.DarkCyan;
                            break;
                        case 4:
                            buttonArr[a, b].Text = Mine[a, b].ToString();
                            buttonArr[a, b].ForeColor = Color.Red;
                            break;
                        case 5:
                            buttonArr[a, b].Text = Mine[a, b].ToString();
                            buttonArr[a, b].ForeColor = Color.Gray;
                            break;
                        case 6:
                            buttonArr[a, b].Text = Mine[a, b].ToString();
                            buttonArr[a, b].ForeColor = Color.Purple;
                            break;
                        case 7:
                            buttonArr[a, b].Text = Mine[a, b].ToString();
                            buttonArr[a, b].ForeColor = Color.Orange;
                            break;
                        case 8:
                            buttonArr[a, b].Text = Mine[a, b].ToString();
                            buttonArr[a, b].ForeColor = Color.Lavender;
                            break;
                        default:
                            buttonArr[a, b].ForeColor = Color.DarkRed;
                            buttonArr[a, b].Text = "💣";
                            break;
                    }
                }
        }//填滿


        private void ResetStripItem_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void QuickResetStripItem_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void SetStripItem_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void ExitStripItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitStripItem_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void GenMineStripItem_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void EmptyDetectStripItem_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("EmptyDetect requires \"Point\"\npos.X = ", "Arguments Required"));
                int y = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("EmptyDetect requires \"Point\"\npos.Y = ", "Arguments Required"));
                EmptyDetect(new Point(x, y));
            }
            catch { }
        }

        private void CompleteDetectStripItem_Click(object sender, EventArgs e)
        {
            CompleteDetect();
        }

        private void EndGameStripItem_Click(object sender, EventArgs e)
        {
            DialogResult arg = MessageBox.Show("EndGame requires\"bool\"\nisWin = ", "Arguments Required", MessageBoxButtons.YesNoCancel);
            switch (arg)
            {
                case DialogResult.Yes:
                    EndGame(true);
                    break;
                case DialogResult.No:
                    EndGame(false);
                    break;
                case DialogResult.Cancel:
                    break;
            }
            
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timerTime++;
            ClockStripItem.Text = "🕐: " + timerTime.ToString(); 
        }

        private void FillAllStripItem_Click(object sender, EventArgs e)
        {
            FillAll();
        }

        private void MineStripItem_Click(object sender, EventArgs e)
        {
            string debug = string.Empty;
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    debug += Mine[x, y].ToString("00") + " ";
                }
                debug += "\n";
            }
            MessageBox.Show(debug, "Mine");
        }
    }
}
