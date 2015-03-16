using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using System.Diagnostics;

using JamesConcentrate.Controller;
using JamesConcentrate.Data;

namespace JamesConcentrate.Game
{
    public partial class MainForm : Form, IMainForm
    {
        JamesDataController _controller;
        PictureBox[] grid;
        bool replayTurnStart;
        Stopwatch watch = new Stopwatch();

        TurnData currentReplayTurn;
        IList replayTurns;

        public MainForm()
        {
            InitializeComponent();
            setUpPictureBoxes();

            replayTurnStart = false;
            replayTurns = new ArrayList();

            //_controller.LoadNewGameState();

        }

        private int _ReplayTurnNumber;
        public int ReplayTurnNumber
        {
            get { return _ReplayTurnNumber; }
            set
            {
                //if ((_ReplayTurnNumber >= 0) && (_ReplayTurnNumber <= replayTurns.Count + 1))
                //{
                    this._ReplayTurnNumber = value;
               // }
            }
        }

        public void UpdateTotalMatches()
        {
            labelMatches.Text = (Int32.Parse(labelMatches.Text) + 1).ToString();
        }

        public void UpdateTotalMismatches()
        {
            labelMismatches.Text = (Int32.Parse(labelMismatches.Text) + 1).ToString();
        }

        public void UpdateTotalMatchRate()
        {
            labelMatchRate.Text = ((Int32.Parse(labelMatches.Text) * 100) / ((Int32.Parse(labelMatches.Text)) + (Int32.Parse(labelMismatches.Text)))).ToString() + "%";
        }

        public void UpdateTotalGamesPlayed()
        {
            labelGamesPlayed.Text = (Int32.Parse(labelGamesPlayed.Text) + 1).ToString();
        }

        public void UpdateGameInfo(GameData game)
        {
            labelGameDetailsNumber.Text = "Game " + game.GameNumber.ToString();

            buttonReplayNext.Visible = true;
            buttonReplayPrev.Visible = true;

            if (game.TurnSummary.Count != 0)
            {
                listBoxGameDetails.Items.Clear();
                listBoxGameDetails.Items.AddRange(game.TurnSummary.ToArray());
                listBoxGameDetails.SelectedItem = listBoxGameDetails.Items[game.TurnSummary.Count - 1];
            }
            else
            {
                listBoxGameDetails.Items.Clear();
                this.listBoxGameDetails.Items.AddRange(new object[] {
            "             - Game Started -      "});  
                listBoxGameDetails.SelectedItem = listBoxGameDetails.Items[0];
            }
        }


        public void SetController(JamesDataController controller)
        {
            _controller = controller;
        }

        public void StartNewGame(GameData game)
        {
            if (game == null)
            {
                return;
            }

            for (int i = 0; i < grid.Length; i++ )
            {
                grid[i].Image = imageListFruits.Images[game.InitialGridState[i]];
            }



            UpdateTotalGamesPlayed();
        }

        public void UpdateGrid(int[] gridState, IList turns, TurnData currentTurn)
        {
            HideAllImages();

            
            foreach(TurnData turn in turns)
            {
                if (turn.IsMatch == true)
                {
                    for (int i = 0; i < grid.Length; i++)
                    {
                        if ((turn.PictureClicked1 == i) || (turn.PictureClicked2 == i))
                        {
                            grid[i].Image = imageListFruits.Images[gridState[i]];
                        }
                    }
                }
             }

            if (turns.Contains(currentTurn))
            {
                if (currentTurn.IsMatch == false)
                {
                    ShowWrongImage(currentTurn.PictureClicked2);
                    ShowWrongImage(currentTurn.PictureClicked1);
                }
            }
            else
            {
                ShowClickedImage(gridState, currentTurn.PictureClicked1);
            }
        }

        public void HideAllImages()
        {
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i].Image = JamesConcentrate.Game.Properties.Resources.Default;
            }
        }

        public void ShowClickedImage(int[] gridState, int imageClicked)
        {
            grid[imageClicked].Image = imageListFruits.Images[gridState[imageClicked]];
        }

        public void ShowWrongImage(int imageClicked)
        {
            grid[imageClicked].Image = JamesConcentrate.Game.Properties.Resources.Wrong;
        }

        public void UpdateGameHistory(GameData game)
        {
            GameHistoryNode historyNode = new GameHistoryNode(game.GameNumber, game.Matches, game.Mismatches, "5:55");

            EventHandler historyNode_Click = new EventHandler(delegate(object sender, EventArgs e)
                {
                    setUpDetailsPanel(game);
                    startReplay(game);
                });

            historyNode.Click += historyNode_Click;
            historyNode.AddEvent(historyNode_Click);

            panelGameList.Controls.Add(historyNode);

        }

        /////////////////////////////////////////////////////////////////////////


 
        private void setUpDetailsPanel(GameData game)
        {
            panelGameHistory.Visible = false;
            panelGameDetails.Visible = true;
            labelGameDetailsNumber.Text = "Game " + game.GameNumber;
            labelTimer.Text = "REPLAY";

            buttonReplayNext.Visible = true;
            buttonReplayPrev.Visible = true;
            buttonReplayBack.Visible = true;

            listBoxGameDetails.Items.Clear();
            listBoxGameDetails.Items.AddRange(new object[] {" - Game Started -"});
            listBoxGameDetails.SelectedItem = listBoxGameDetails.Items[0];

            listBoxGameDetails.Items.AddRange(game.TurnSummary.ToArray());

        }

        private void startReplay(GameData game)
        {

            ReplayTurnNumber = 0;

            buttonReplayNext.Click += new EventHandler(delegate(object sender, EventArgs e)
                {
                    if (ReplayTurnNumber <= game.TurnHistory.Count)
                    {
                        replayUpdateGrid(game);
                        replayTurnStart = !replayTurnStart;



                        
                        if ((listBoxGameDetails.SelectedIndex % 3) == 0)
                        {
                            listBoxGameDetails.SelectedItem = listBoxGameDetails.Items[listBoxGameDetails.SelectedIndex + 1];
                        }
                    }
                    
                });

            buttonReplayPrev.Click += new EventHandler(delegate(object sender, EventArgs e)
                {

                    replayTurnStart = !replayTurnStart;

                   // testing(game);

                    ReplayTurnNumber -= 1;

                    //listBoxGameDetails.SelectedItem = listBoxGameDetails.Items[listBoxGameDetails.SelectedIndex - 1];
                    //if ((listBoxGameDetails.SelectedIndex % 3) == 0)
                    //{
                    //    listBoxGameDetails.SelectedItem = listBoxGameDetails.Items[listBoxGameDetails.SelectedIndex - 1];
                    //}
                     
                });
        }

        //private void testing(GameData game)
        //{
        //    if (replayTurnStart == true)
        //    {
        //        replayTurns.Remove(currentReplayTurn);
        //        UpdateGrid(game.InitialGridState, replayTurns, currentReplayTurn);
        //    }
        //    else
        //    {
        //        currentReplayTurn = (TurnData)game.TurnHistory[ReplayTurnNumber];
        //        UpdateGrid(game.InitialGridState, replayTurns, currentReplayTurn);
        //        ReplayTurnNumber += 1;
        //    }
        //}


        private void replayUpdateGrid(GameData game)
        {
            if(replayTurnStart == true)
            {
                replayTurns.Add(currentReplayTurn);
                UpdateGrid(game.InitialGridState, replayTurns, currentReplayTurn);
                listBoxGameDetails.SelectedItem = listBoxGameDetails.Items[listBoxGameDetails.SelectedIndex + 1];
            }
            else 
            {
                if (ReplayTurnNumber <= game.TurnHistory.Count-1)
                {
                    listBoxGameDetails.SelectedItem = listBoxGameDetails.Items[listBoxGameDetails.SelectedIndex + 1];
                    currentReplayTurn = (TurnData)game.TurnHistory[ReplayTurnNumber];
                }
                
                UpdateGrid(game.InitialGridState, replayTurns, currentReplayTurn);
                ReplayTurnNumber += 1;
            }
        }

        private void setUpPictureBoxes()
        {
            grid = new PictureBox[16];
            int count = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    grid[count] = new PictureBox();
                    grid[count].Size = new Size(125, 92);
                    grid[count].Image = JamesConcentrate.Game.Properties.Resources.Default;
                    grid[count].SizeMode = PictureBoxSizeMode.StretchImage;
                    grid[count].Click += new System.EventHandler(this.pictureBox_Click);
                    grid[count].Location = new Point(7 + (131 * i), 6 + (98 * j));


                    panelGrid.Controls.Add(grid[count]);

                    count += 1;
                }

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerDebug.Start();
            watch.Stop();
            watch.Reset();
            watch.Start();


            _controller.AddPreviousGameToHistory();
            _controller.LoadNewGameState();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            _controller.DisplayStartingState();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            _controller.DisplayCurrentState();       
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pbClicked = sender as PictureBox;        

            for (int i = 0; i < grid.Length; i++)
            {
                if (pbClicked == grid[i])
                {
                    _controller.AddNewTurn(i);
                }
            }
        }


        private void buttonTest_Click(object sender, EventArgs e)
        {

        }

        private void buttonDetailsBack_Click(object sender, EventArgs e)
        {
            panelGameDetails.Visible = false;
        }

        private void buttonHistoryBack_Click(object sender, EventArgs e)
        {
            panelGameHistory.Visible = false;
        }

        

        private void timerDebug_Tick(object sender, EventArgs e)
        {

        }

        private void topBarIcon_MouseEnter(object sender, EventArgs e)
        {
            Label hoverLabel = sender as Label;
            hoverLabel.BackColor = Color.FromArgb(0, 80, 152);
        }

        private void topBarIcon_MouseLeave(object sender, EventArgs e)
        {
            Label hoverLabel = sender as Label;
            hoverLabel.BackColor = Color.Transparent;
        }

        private void labelTopBarMaximize_Click(object sender, EventArgs e)
        {
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void topBarClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelTopBarMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timerDebug_Tick_1(object sender, EventArgs e)
        {
            TimeSpan ts = watch.Elapsed;
            string elapsed = String.Format("{0:0}:{1:00}", ts.Minutes, ts.Seconds);

            labelTimer.Text = elapsed;
            
        }



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelTopBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                Width = 960;
                Height = 540;

                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonGameHistory_Click_1(object sender, EventArgs e)
        {
            timerDebug.Stop();
            panelGameHistory.Visible = !panelGameHistory.Visible;
            //buttonReplayPrev.Visible = !buttonReplayNext.Visible;
        }

        private void buttonGameHistoryBack_Click(object sender, EventArgs e)
        {
            panelGameHistory.Visible = !panelGameHistory.Visible;
            panelGameDetails.Visible = true;
        }

        private void buttonReplayPrev_Click(object sender, EventArgs e)
        {
            _controller.ReverseTurn();

            
            if ((listBoxGameDetails.SelectedIndex % 3) == 0)
            {
                listBoxGameDetails.SelectedItem = listBoxGameDetails.Items[listBoxGameDetails.SelectedIndex - 1];
            }
            listBoxGameDetails.SelectedItem = listBoxGameDetails.Items[listBoxGameDetails.SelectedIndex - 1];
        }
    }
}







////MEDIA
//FRUIT: http://findicons.com/files/icons/790/preview/fruits_illustrated_full.png