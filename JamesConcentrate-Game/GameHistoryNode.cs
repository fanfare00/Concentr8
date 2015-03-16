using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace JamesConcentrate.Game
{
    class GameHistoryNode : GroupBox
    {
        
        public int NodeNumber
        {
            get{return Int32.Parse(this.Text);}
            set { this.Text = "Game " + value.ToString(); }
        }

        public GameHistoryNode(int gameNumber, int matches, int mismatches, string length)
        {
            InitializeComponents();
            this.Location = new Point(5, 85*(gameNumber-1));

            this.nodeLabelLength.Text = length;
            this.nodeLabelMatches.Text = matches.ToString();
            this.nodeLabelMismatches.Text = mismatches.ToString();
            NodeNumber = gameNumber;

            foreach (Control c in this.Controls)
            {
                c.MouseEnter += new System.EventHandler(this.GameHistoryNode_MouseEnter);
                c.MouseLeave += new System.EventHandler(this.GameHistoryNode_MouseLeave);
            }

        }

        void GameHistoryNode_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(254)))));
        }

        void GameHistoryNode_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        public void AddEvent(EventHandler e)
        {
            foreach (Control c in this.Controls)
            {
                c.Click += e;
            }
        }


        private void InitializeComponents()
        {
            this.nodeLabelStaticMismatches = new System.Windows.Forms.Label();
            this.nodeLabelStaticMatches = new System.Windows.Forms.Label();
            this.nodeLabelStaticLength = new System.Windows.Forms.Label();
            this.nodeLabelMatches = new System.Windows.Forms.Label();
            this.nodeLabelMismatches = new System.Windows.Forms.Label();
            this.nodeLabelLength = new System.Windows.Forms.Label();
            // 
            // nodeLabelStaticMismatches
            // 
            this.nodeLabelStaticMismatches.BackColor = System.Drawing.Color.Transparent;
            this.nodeLabelStaticMismatches.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeLabelStaticMismatches.ForeColor = System.Drawing.Color.White;
            this.nodeLabelStaticMismatches.Location = new System.Drawing.Point(8, 36);
            this.nodeLabelStaticMismatches.Name = "nodeLabelStaticMismatches";
            this.nodeLabelStaticMismatches.Size = new System.Drawing.Size(88, 20);
            this.nodeLabelStaticMismatches.TabIndex = 11;
            this.nodeLabelStaticMismatches.Text = "Mismatches:";
            this.nodeLabelStaticMismatches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nodeLabelStaticMatches
            // 
            this.nodeLabelStaticMatches.BackColor = System.Drawing.Color.Transparent;
            this.nodeLabelStaticMatches.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeLabelStaticMatches.ForeColor = System.Drawing.Color.White;
            this.nodeLabelStaticMatches.Location = new System.Drawing.Point(8, 18);
            this.nodeLabelStaticMatches.Name = "nodeLabelStaticMatches";
            this.nodeLabelStaticMatches.Size = new System.Drawing.Size(88, 20);
            this.nodeLabelStaticMatches.TabIndex = 11;
            this.nodeLabelStaticMatches.Text = "Matches:";
            this.nodeLabelStaticMatches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nodeLabelStaticLength
            // 
            this.nodeLabelStaticLength.BackColor = System.Drawing.Color.Transparent;
            this.nodeLabelStaticLength.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeLabelStaticLength.ForeColor = System.Drawing.Color.White;
            this.nodeLabelStaticLength.Location = new System.Drawing.Point(8, 55);
            this.nodeLabelStaticLength.Name = "nodeLabelStaticLength";
            this.nodeLabelStaticLength.Size = new System.Drawing.Size(88, 20);
            this.nodeLabelStaticLength.TabIndex = 12;
            this.nodeLabelStaticLength.Text = "Length:";
            this.nodeLabelStaticLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nodeLabelMatches
            // 
            this.nodeLabelMatches.BackColor = System.Drawing.Color.Transparent;
            this.nodeLabelMatches.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeLabelMatches.ForeColor = System.Drawing.Color.White;
            this.nodeLabelMatches.Location = new System.Drawing.Point(87, 18);
            this.nodeLabelMatches.Name = "nodeLabelMatches";
            this.nodeLabelMatches.Size = new System.Drawing.Size(47, 20);
            this.nodeLabelMatches.TabIndex = 13;
            this.nodeLabelMatches.Text = "8";
            this.nodeLabelMatches.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nodeLabelMismatches
            // 
            this.nodeLabelMismatches.BackColor = System.Drawing.Color.Transparent;
            this.nodeLabelMismatches.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeLabelMismatches.ForeColor = System.Drawing.Color.White;
            this.nodeLabelMismatches.Location = new System.Drawing.Point(87, 36);
            this.nodeLabelMismatches.Name = "nodeLabelMismatches";
            this.nodeLabelMismatches.Size = new System.Drawing.Size(47, 20);
            this.nodeLabelMismatches.TabIndex = 14;
            this.nodeLabelMismatches.Text = "55";
            this.nodeLabelMismatches.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nodeLabelLength
            // 
            this.nodeLabelLength.BackColor = System.Drawing.Color.Transparent;
            this.nodeLabelLength.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeLabelLength.ForeColor = System.Drawing.Color.White;
            this.nodeLabelLength.Location = new System.Drawing.Point(87, 55);
            this.nodeLabelLength.Name = "nodeLabelLength";
            this.nodeLabelLength.Size = new System.Drawing.Size(47, 20);
            this.nodeLabelLength.TabIndex = 15;
            this.nodeLabelLength.Text = "15:55";
            this.nodeLabelLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;


            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.nodeLabelLength);
            this.Controls.Add(this.nodeLabelMismatches);
            this.Controls.Add(this.nodeLabelMatches);
            this.Controls.Add(this.nodeLabelStaticLength);
            this.Controls.Add(this.nodeLabelStaticMatches);
            this.Controls.Add(this.nodeLabelStaticMismatches);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.Location = new System.Drawing.Point(11, 3);
            this.Name = "groupBox1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(141, 81);
            this.TabIndex = 0;
            this.TabStop = false;
            this.Text = "Game 1";
        }

        private System.Windows.Forms.Label nodeLabelLength;
        private System.Windows.Forms.Label nodeLabelMismatches;
        private System.Windows.Forms.Label nodeLabelMatches;
        private System.Windows.Forms.Label nodeLabelStaticLength;
        private System.Windows.Forms.Label nodeLabelStaticMatches;
        private System.Windows.Forms.Label nodeLabelStaticMismatches;
    }


}
