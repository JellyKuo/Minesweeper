namespace Minesweeper
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.GameStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickResetStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewVariablesStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MineStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mineCountStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opensStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExecuteStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InitStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmptyDetectStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompleteDetectStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EndGameStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FillAllStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.遊戲狀態ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClockStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlagStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.AboutStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTimeStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameStripItem,
            this.debugToolStripMenuItem,
            this.AboutStripItem,
            this.遊戲狀態ToolStripMenuItem,
            this.FlagStripItem,
            this.ClockStripItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(436, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // GameStripItem
            // 
            this.GameStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestartStripItem,
            this.SetStripItem,
            this.ExitStripItem});
            this.GameStripItem.Name = "GameStripItem";
            this.GameStripItem.Size = new System.Drawing.Size(43, 20);
            this.GameStripItem.Text = "遊戲";
            // 
            // RestartStripItem
            // 
            this.RestartStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuickResetStripItem,
            this.ResetStripItem});
            this.RestartStripItem.Name = "RestartStripItem";
            this.RestartStripItem.Size = new System.Drawing.Size(122, 22);
            this.RestartStripItem.Text = "重新開始";
            // 
            // QuickResetStripItem
            // 
            this.QuickResetStripItem.Name = "QuickResetStripItem";
            this.QuickResetStripItem.Size = new System.Drawing.Size(146, 22);
            this.QuickResetStripItem.Text = "快速重新開始";
            this.QuickResetStripItem.Click += new System.EventHandler(this.QuickResetStripItem_Click);
            // 
            // ResetStripItem
            // 
            this.ResetStripItem.Name = "ResetStripItem";
            this.ResetStripItem.Size = new System.Drawing.Size(146, 22);
            this.ResetStripItem.Text = "重新設定";
            this.ResetStripItem.Click += new System.EventHandler(this.ResetStripItem_Click);
            // 
            // SetStripItem
            // 
            this.SetStripItem.Name = "SetStripItem";
            this.SetStripItem.Size = new System.Drawing.Size(122, 22);
            this.SetStripItem.Text = "設定";
            this.SetStripItem.Click += new System.EventHandler(this.SetStripItem_Click);
            // 
            // ExitStripItem
            // 
            this.ExitStripItem.Name = "ExitStripItem";
            this.ExitStripItem.Size = new System.Drawing.Size(122, 22);
            this.ExitStripItem.Text = "離開";
            this.ExitStripItem.Click += new System.EventHandler(this.ExitStripItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewVariablesStripItem,
            this.ExecuteStripItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // ViewVariablesStripItem
            // 
            this.ViewVariablesStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MineStripItem,
            this.mineCountStripItem,
            this.sizeStripItem,
            this.opensStripItem,
            this.TimeStripItem,
            this.timerTimeStripItem});
            this.ViewVariablesStripItem.Name = "ViewVariablesStripItem";
            this.ViewVariablesStripItem.Size = new System.Drawing.Size(156, 22);
            this.ViewVariablesStripItem.Text = "View Variables";
            // 
            // MineStripItem
            // 
            this.MineStripItem.Name = "MineStripItem";
            this.MineStripItem.Size = new System.Drawing.Size(152, 22);
            this.MineStripItem.Text = "Mine";
            this.MineStripItem.Click += new System.EventHandler(this.MineStripItem_Click);
            // 
            // mineCountStripItem
            // 
            this.mineCountStripItem.Name = "mineCountStripItem";
            this.mineCountStripItem.Size = new System.Drawing.Size(152, 22);
            this.mineCountStripItem.Text = "mineCount";
            this.mineCountStripItem.Click += new System.EventHandler(this.mineCountStripItem_Click);
            // 
            // sizeStripItem
            // 
            this.sizeStripItem.Name = "sizeStripItem";
            this.sizeStripItem.Size = new System.Drawing.Size(152, 22);
            this.sizeStripItem.Text = "size";
            this.sizeStripItem.Click += new System.EventHandler(this.sizeStripItem_Click);
            // 
            // opensStripItem
            // 
            this.opensStripItem.Name = "opensStripItem";
            this.opensStripItem.Size = new System.Drawing.Size(152, 22);
            this.opensStripItem.Text = "opens";
            this.opensStripItem.Click += new System.EventHandler(this.opensStripItem_Click);
            // 
            // TimeStripItem
            // 
            this.TimeStripItem.Name = "TimeStripItem";
            this.TimeStripItem.Size = new System.Drawing.Size(152, 22);
            this.TimeStripItem.Text = "Time";
            this.TimeStripItem.Click += new System.EventHandler(this.TimeStripItem_Click);
            // 
            // ExecuteStripItem
            // 
            this.ExecuteStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InitStripItem,
            this.GenerateStripItem,
            this.EmptyDetectStripItem,
            this.CompleteDetectStripItem,
            this.EndGameStripItem,
            this.FillAllStripItem});
            this.ExecuteStripItem.Name = "ExecuteStripItem";
            this.ExecuteStripItem.Size = new System.Drawing.Size(156, 22);
            this.ExecuteStripItem.Text = "Execute";
            // 
            // InitStripItem
            // 
            this.InitStripItem.Name = "InitStripItem";
            this.InitStripItem.Size = new System.Drawing.Size(167, 22);
            this.InitStripItem.Text = "Init";
            this.InitStripItem.Click += new System.EventHandler(this.InitStripItem_Click);
            // 
            // GenerateStripItem
            // 
            this.GenerateStripItem.Name = "GenerateStripItem";
            this.GenerateStripItem.Size = new System.Drawing.Size(167, 22);
            this.GenerateStripItem.Text = "Generate";
            this.GenerateStripItem.Click += new System.EventHandler(this.GenMineStripItem_Click);
            // 
            // EmptyDetectStripItem
            // 
            this.EmptyDetectStripItem.Name = "EmptyDetectStripItem";
            this.EmptyDetectStripItem.Size = new System.Drawing.Size(167, 22);
            this.EmptyDetectStripItem.Text = "EmptyDetect";
            this.EmptyDetectStripItem.Click += new System.EventHandler(this.EmptyDetectStripItem_Click);
            // 
            // CompleteDetectStripItem
            // 
            this.CompleteDetectStripItem.Name = "CompleteDetectStripItem";
            this.CompleteDetectStripItem.Size = new System.Drawing.Size(167, 22);
            this.CompleteDetectStripItem.Text = "CompleteDetect";
            this.CompleteDetectStripItem.Click += new System.EventHandler(this.CompleteDetectStripItem_Click);
            // 
            // EndGameStripItem
            // 
            this.EndGameStripItem.Name = "EndGameStripItem";
            this.EndGameStripItem.Size = new System.Drawing.Size(167, 22);
            this.EndGameStripItem.Text = "EndGame";
            this.EndGameStripItem.Click += new System.EventHandler(this.EndGameStripItem_Click);
            // 
            // FillAllStripItem
            // 
            this.FillAllStripItem.Name = "FillAllStripItem";
            this.FillAllStripItem.Size = new System.Drawing.Size(167, 22);
            this.FillAllStripItem.Text = "FillAll";
            this.FillAllStripItem.Click += new System.EventHandler(this.FillAllStripItem_Click);
            // 
            // 遊戲狀態ToolStripMenuItem
            // 
            this.遊戲狀態ToolStripMenuItem.Name = "遊戲狀態ToolStripMenuItem";
            this.遊戲狀態ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.遊戲狀態ToolStripMenuItem.Text = "遊戲狀態";
            // 
            // ClockStripItem
            // 
            this.ClockStripItem.AutoToolTip = true;
            this.ClockStripItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClockStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClockStripItem.Name = "ClockStripItem";
            this.ClockStripItem.Size = new System.Drawing.Size(37, 20);
            this.ClockStripItem.Text = "🕐: ";
            this.ClockStripItem.ToolTipText = "剩餘時間";
            // 
            // FlagStripItem
            // 
            this.FlagStripItem.AutoToolTip = true;
            this.FlagStripItem.BackColor = System.Drawing.Color.LightCoral;
            this.FlagStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FlagStripItem.Name = "FlagStripItem";
            this.FlagStripItem.Size = new System.Drawing.Size(34, 20);
            this.FlagStripItem.Text = "⚑: ";
            this.FlagStripItem.ToolTipText = "剩餘炸彈";
            // 
            // buttonPanel
            // 
            this.buttonPanel.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPanel.Location = new System.Drawing.Point(0, 25);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(50, 50);
            this.buttonPanel.TabIndex = 1;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // AboutStripItem
            // 
            this.AboutStripItem.Name = "AboutStripItem";
            this.AboutStripItem.Size = new System.Drawing.Size(43, 20);
            this.AboutStripItem.Text = "關於";
            this.AboutStripItem.Click += new System.EventHandler(this.AboutStripItem_Click);
            // 
            // timerTimeStripItem
            // 
            this.timerTimeStripItem.Name = "timerTimeStripItem";
            this.timerTimeStripItem.Size = new System.Drawing.Size(152, 22);
            this.timerTimeStripItem.Text = "timerTime";
            this.timerTimeStripItem.Click += new System.EventHandler(this.timerTimeStripItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 287);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "踩地雷";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem GameStripItem;
        private System.Windows.Forms.ToolStripMenuItem RestartStripItem;
        private System.Windows.Forms.ToolStripMenuItem SetStripItem;
        private System.Windows.Forms.ToolStripMenuItem ExitStripItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.ToolStripMenuItem ViewVariablesStripItem;
        private System.Windows.Forms.ToolStripMenuItem QuickResetStripItem;
        private System.Windows.Forms.ToolStripMenuItem ResetStripItem;
        private System.Windows.Forms.ToolStripMenuItem MineStripItem;
        private System.Windows.Forms.ToolStripMenuItem ExecuteStripItem;
        private System.Windows.Forms.ToolStripMenuItem InitStripItem;
        private System.Windows.Forms.ToolStripMenuItem GenerateStripItem;
        private System.Windows.Forms.ToolStripMenuItem EmptyDetectStripItem;
        private System.Windows.Forms.ToolStripMenuItem CompleteDetectStripItem;
        private System.Windows.Forms.ToolStripMenuItem EndGameStripItem;
        private System.Windows.Forms.ToolStripMenuItem mineCountStripItem;
        private System.Windows.Forms.ToolStripMenuItem sizeStripItem;
        private System.Windows.Forms.ToolStripMenuItem opensStripItem;
        private System.Windows.Forms.ToolStripMenuItem TimeStripItem;
        private System.Windows.Forms.ToolStripMenuItem FillAllStripItem;
        private System.Windows.Forms.ToolStripMenuItem 遊戲狀態ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClockStripItem;
        private System.Windows.Forms.ToolStripMenuItem FlagStripItem;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.ToolStripMenuItem AboutStripItem;
        private System.Windows.Forms.ToolStripMenuItem timerTimeStripItem;
    }
}

