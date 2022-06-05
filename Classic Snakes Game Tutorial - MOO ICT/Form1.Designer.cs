
namespace Classic_Snakes_Game_Tutorial___MOO_ICT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bt_lvl = new System.Windows.Forms.ToolStripMenuItem();
            this.Lite = new System.Windows.Forms.ToolStripMenuItem();
            this.Middle = new System.Windows.Forms.ToolStripMenuItem();
            this.Hard = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.menubt_play = new System.Windows.Forms.ToolStripMenuItem();
            this.menubt_finish = new System.Windows.Forms.ToolStripMenuItem();
            this.menubt_save = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menubt_info = new System.Windows.Forms.ToolStripMenuItem();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(2, 710);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(71, 20);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Cчет: 0";
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.Location = new System.Drawing.Point(2, 730);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(156, 20);
            this.txtHighScore.TabIndex = 2;
            this.txtHighScore.Text = "Наивысший счет:";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 80;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_lvl,
            this.bt_Game,
            this.информацияToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bt_lvl
            // 
            this.bt_lvl.BackColor = System.Drawing.Color.DarkGreen;
            this.bt_lvl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lite,
            this.Middle,
            this.Hard});
            this.bt_lvl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_lvl.Name = "bt_lvl";
            this.bt_lvl.Size = new System.Drawing.Size(120, 20);
            this.bt_lvl.Text = "Выбрать уровень";
            // 
            // Lite
            // 
            this.Lite.BackColor = System.Drawing.Color.PaleGreen;
            this.Lite.Checked = true;
            this.Lite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Lite.Image = global::Classic_Snakes_Game_Tutorial___MOO_ICT.Properties.Resources.skill_level_1;
            this.Lite.Name = "Lite";
            this.Lite.Size = new System.Drawing.Size(130, 22);
            this.Lite.Text = "Легкий";
            this.Lite.Click += new System.EventHandler(this.Lite_Click);
            // 
            // Middle
            // 
            this.Middle.BackColor = System.Drawing.Color.Khaki;
            this.Middle.Image = global::Classic_Snakes_Game_Tutorial___MOO_ICT.Properties.Resources.skill_level_5;
            this.Middle.Name = "Middle";
            this.Middle.Size = new System.Drawing.Size(130, 22);
            this.Middle.Text = "Средний";
            this.Middle.Click += new System.EventHandler(this.Middle_Click);
            // 
            // Hard
            // 
            this.Hard.BackColor = System.Drawing.Color.IndianRed;
            this.Hard.Image = global::Classic_Snakes_Game_Tutorial___MOO_ICT.Properties.Resources.skill_level_max;
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(130, 22);
            this.Hard.Text = "Сложный";
            this.Hard.Click += new System.EventHandler(this.Hide_Click);
            // 
            // bt_Game
            // 
            this.bt_Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubt_play,
            this.menubt_finish,
            this.menubt_save});
            this.bt_Game.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Game.Name = "bt_Game";
            this.bt_Game.Size = new System.Drawing.Size(46, 20);
            this.bt_Game.Text = "Игра";
            // 
            // menubt_play
            // 
            this.menubt_play.Image = global::Classic_Snakes_Game_Tutorial___MOO_ICT.Properties.Resources.Play_Games_30030;
            this.menubt_play.Name = "menubt_play";
            this.menubt_play.Size = new System.Drawing.Size(193, 22);
            this.menubt_play.Text = "Начать";
            this.menubt_play.Click += new System.EventHandler(this.menubt_play_Click);
            // 
            // menubt_finish
            // 
            this.menubt_finish.Enabled = false;
            this.menubt_finish.Image = global::Classic_Snakes_Game_Tutorial___MOO_ICT.Properties.Resources.stop_red256_24890;
            this.menubt_finish.Name = "menubt_finish";
            this.menubt_finish.Size = new System.Drawing.Size(193, 22);
            this.menubt_finish.Text = "Закончить";
            this.menubt_finish.Click += new System.EventHandler(this.menubt_finish_Click);
            // 
            // menubt_save
            // 
            this.menubt_save.Image = global::Classic_Snakes_Game_Tutorial___MOO_ICT.Properties.Resources.Save_Icon_icon_icons_com_69139;
            this.menubt_save.Name = "menubt_save";
            this.menubt_save.Size = new System.Drawing.Size(193, 22);
            this.menubt_save.Text = "Сохранить результат";
            this.menubt_save.Click += new System.EventHandler(this.menubt_save_Click);
            // 
            // информацияToolStripMenuItem1
            // 
            this.информацияToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubt_info});
            this.информацияToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.информацияToolStripMenuItem1.Name = "информацияToolStripMenuItem1";
            this.информацияToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.информацияToolStripMenuItem1.Text = "Помощь";
            // 
            // menubt_info
            // 
            this.menubt_info.Image = global::Classic_Snakes_Game_Tutorial___MOO_ICT.Properties.Resources._6066e75c002f09ce9147202c28d3c976;
            this.menubt_info.Name = "menubt_info";
            this.menubt_info.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menubt_info.Size = new System.Drawing.Size(171, 22);
            this.menubt_info.Text = "Информация";
            this.menubt_info.Click += new System.EventHandler(this.menubt_info_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.picCanvas.BackgroundImage = global::Classic_Snakes_Game_Tutorial___MOO_ICT.Properties.Resources.screen_15;
            this.picCanvas.Cursor = System.Windows.Forms.Cursors.No;
            this.picCanvas.Location = new System.Drawing.Point(6, 25);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(580, 680);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(592, 754);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bt_lvl;
        private System.Windows.Forms.ToolStripMenuItem Lite;
        private System.Windows.Forms.ToolStripMenuItem Middle;
        private System.Windows.Forms.ToolStripMenuItem Hard;
        private System.Windows.Forms.ToolStripMenuItem bt_Game;
        private System.Windows.Forms.ToolStripMenuItem menubt_play;
        private System.Windows.Forms.ToolStripMenuItem menubt_finish;
        private System.Windows.Forms.ToolStripMenuItem menubt_save;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menubt_info;
    }
}

