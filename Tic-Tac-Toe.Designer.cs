namespace Tic_Tac_Toe
{
    partial class TTT
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            A1 = new Button();
            A2 = new Button();
            A3 = new Button();
            B1 = new Button();
            B2 = new Button();
            B3 = new Button();
            C1 = new Button();
            C2 = new Button();
            C3 = new Button();
            StartGame = new Button();
            TurnInfo = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            About = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            SoloPlay = new Button();
            WithBotPlay = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // A1
            // 
            A1.Enabled = false;
            A1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            A1.Location = new Point(30, 35);
            A1.Name = "A1";
            A1.Size = new Size(80, 80);
            A1.TabIndex = 0;
            A1.UseVisualStyleBackColor = true;
            A1.Visible = false;
            A1.Click += buttonClick;
            // 
            // A2
            // 
            A2.Enabled = false;
            A2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            A2.Location = new Point(116, 35);
            A2.Name = "A2";
            A2.Size = new Size(80, 80);
            A2.TabIndex = 1;
            A2.UseVisualStyleBackColor = true;
            A2.Visible = false;
            A2.Click += buttonClick;
            // 
            // A3
            // 
            A3.Enabled = false;
            A3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            A3.Location = new Point(202, 35);
            A3.Name = "A3";
            A3.Size = new Size(80, 80);
            A3.TabIndex = 2;
            A3.UseVisualStyleBackColor = true;
            A3.Visible = false;
            A3.Click += buttonClick;
            // 
            // B1
            // 
            B1.Enabled = false;
            B1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            B1.Location = new Point(30, 121);
            B1.Name = "B1";
            B1.Size = new Size(80, 80);
            B1.TabIndex = 3;
            B1.UseVisualStyleBackColor = true;
            B1.Visible = false;
            B1.Click += buttonClick;
            // 
            // B2
            // 
            B2.Enabled = false;
            B2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            B2.Location = new Point(116, 121);
            B2.Name = "B2";
            B2.Size = new Size(80, 80);
            B2.TabIndex = 4;
            B2.UseVisualStyleBackColor = true;
            B2.Visible = false;
            B2.Click += buttonClick;
            // 
            // B3
            // 
            B3.Enabled = false;
            B3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            B3.Location = new Point(202, 121);
            B3.Name = "B3";
            B3.Size = new Size(80, 80);
            B3.TabIndex = 5;
            B3.UseVisualStyleBackColor = true;
            B3.Visible = false;
            B3.Click += buttonClick;
            // 
            // C1
            // 
            C1.Enabled = false;
            C1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            C1.Location = new Point(30, 207);
            C1.Name = "C1";
            C1.Size = new Size(80, 80);
            C1.TabIndex = 6;
            C1.UseVisualStyleBackColor = true;
            C1.Visible = false;
            C1.Click += buttonClick;
            // 
            // C2
            // 
            C2.Enabled = false;
            C2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            C2.Location = new Point(116, 207);
            C2.Name = "C2";
            C2.Size = new Size(80, 80);
            C2.TabIndex = 7;
            C2.UseVisualStyleBackColor = true;
            C2.Visible = false;
            C2.Click += buttonClick;
            // 
            // C3
            // 
            C3.Enabled = false;
            C3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            C3.Location = new Point(202, 207);
            C3.Name = "C3";
            C3.Size = new Size(80, 80);
            C3.TabIndex = 8;
            C3.UseVisualStyleBackColor = true;
            C3.Visible = false;
            C3.Click += buttonClick;
            // 
            // StartGame
            // 
            StartGame.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            StartGame.Location = new Point(66, 121);
            StartGame.Name = "StartGame";
            StartGame.Size = new Size(183, 91);
            StartGame.TabIndex = 9;
            StartGame.Text = "Start";
            StartGame.UseVisualStyleBackColor = true;
            StartGame.Click += StartGame_Click;
            // 
            // TurnInfo
            // 
            TurnInfo.AutoSize = true;
            TurnInfo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TurnInfo.Location = new Point(12, 297);
            TurnInfo.Name = "TurnInfo";
            TurnInfo.Size = new Size(298, 30);
            TurnInfo.TabIndex = 11;
            TurnInfo.Text = "Informarion about current turn";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, About });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(315, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(50, 20);
            fileToolStripMenuItem.Text = "Game";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(132, 22);
            toolStripMenuItem1.Text = "New Game";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click_1;
            // 
            // About
            // 
            About.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            About.Name = "About";
            About.Size = new Size(40, 20);
            About.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // SoloPlay
            // 
            SoloPlay.Enabled = false;
            SoloPlay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SoloPlay.Location = new Point(66, 71);
            SoloPlay.Name = "SoloPlay";
            SoloPlay.Size = new Size(183, 91);
            SoloPlay.TabIndex = 13;
            SoloPlay.Text = "Solo";
            SoloPlay.UseVisualStyleBackColor = true;
            SoloPlay.Visible = false;
            SoloPlay.Click += SoloPlay_Click;
            // 
            // WithBotPlay
            // 
            WithBotPlay.Enabled = false;
            WithBotPlay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            WithBotPlay.Location = new Point(66, 168);
            WithBotPlay.Name = "WithBotPlay";
            WithBotPlay.Size = new Size(183, 91);
            WithBotPlay.TabIndex = 14;
            WithBotPlay.Text = "With bot";
            WithBotPlay.UseVisualStyleBackColor = true;
            WithBotPlay.Visible = false;
            WithBotPlay.Click += WithBotPlay_Click;
            // 
            // TTT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 336);
            Controls.Add(WithBotPlay);
            Controls.Add(SoloPlay);
            Controls.Add(TurnInfo);
            Controls.Add(StartGame);
            Controls.Add(C3);
            Controls.Add(C2);
            Controls.Add(C1);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "TTT";
            Text = "Tic Tac Toe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button A1;
        private Button A2;
        private Button A3;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button C1;
        private Button C2;
        private Button C3;
        private Button StartGame;
        private ContextMenuStrip contextMenuStrip1;
        private Label TurnInfo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem About;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button SoloPlay;
        private Button WithBotPlay;
    }
}