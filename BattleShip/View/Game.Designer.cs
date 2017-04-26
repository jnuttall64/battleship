﻿namespace BattleShip
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPlayer = new System.Windows.Forms.DataGridView();
            this.dgvComputer = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.ComputerTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlayer
            // 
            this.dgvPlayer.AllowUserToResizeColumns = false;
            this.dgvPlayer.AllowUserToResizeRows = false;
            this.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayer.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlayer.Location = new System.Drawing.Point(28, 28);
            this.dgvPlayer.MultiSelect = false;
            this.dgvPlayer.Name = "dgvPlayer";
            this.dgvPlayer.ReadOnly = true;
            this.dgvPlayer.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dgvPlayer.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlayer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvPlayer.Size = new System.Drawing.Size(363, 363);
            this.dgvPlayer.TabIndex = 0;
            this.dgvPlayer.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPlayer_CellMouseDoubleClick);
            this.dgvPlayer.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPlayer_CellMouseDown);
            this.dgvPlayer.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPlayer_CellMouseMove);
            this.dgvPlayer.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPlayer_CellMouseUp);
            this.dgvPlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvPlayer_MouseUp);
            // 
            // dgvComputer
            // 
            this.dgvComputer.AllowUserToResizeColumns = false;
            this.dgvComputer.AllowUserToResizeRows = false;
            this.dgvComputer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputer.ColumnHeadersVisible = false;
            this.dgvComputer.Location = new System.Drawing.Point(496, 28);
            this.dgvComputer.MultiSelect = false;
            this.dgvComputer.Name = "dgvComputer";
            this.dgvComputer.ReadOnly = true;
            this.dgvComputer.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dgvComputer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvComputer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvComputer.Size = new System.Drawing.Size(363, 363);
            this.dgvComputer.TabIndex = 1;
            this.dgvComputer.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvComputer_CellMouseDown);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(60, 443);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(289, 443);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(605, 458);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(75, 23);
            this.btnShoot.TabIndex = 4;
            this.btnShoot.Text = "Test";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // ComputerTimer
            // 
            this.ComputerTimer.Tick += new System.EventHandler(this.ComputerTimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 583);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dgvComputer);
            this.Controls.Add(this.dgvPlayer);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Leave += new System.EventHandler(this.Game_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPlayer;
        private System.Windows.Forms.DataGridView dgvComputer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Timer ComputerTimer;
    }
}