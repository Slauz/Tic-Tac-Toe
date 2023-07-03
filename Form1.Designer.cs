namespace Tic_Tac_Toe
{
    partial class Form1
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
            NewGame = new Button();
            TurnInfo = new Label();
            SuspendLayout();
            // 
            // A1
            // 
            A1.Enabled = false;
            A1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            A1.Location = new Point(29, 33);
            A1.Name = "A1";
            A1.Size = new Size(80, 80);
            A1.TabIndex = 0;
            A1.UseVisualStyleBackColor = true;
            A1.Click += buttonClick;
            // 
            // A2
            // 
            A2.Enabled = false;
            A2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            A2.Location = new Point(115, 33);
            A2.Name = "A2";
            A2.Size = new Size(80, 80);
            A2.TabIndex = 1;
            A2.UseVisualStyleBackColor = true;
            A2.Click += buttonClick;
            // 
            // A3
            // 
            A3.Enabled = false;
            A3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            A3.Location = new Point(201, 33);
            A3.Name = "A3";
            A3.Size = new Size(80, 80);
            A3.TabIndex = 2;
            A3.UseVisualStyleBackColor = true;
            A3.Click += buttonClick;
            // 
            // B1
            // 
            B1.Enabled = false;
            B1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            B1.Location = new Point(29, 119);
            B1.Name = "B1";
            B1.Size = new Size(80, 80);
            B1.TabIndex = 3;
            B1.UseVisualStyleBackColor = true;
            B1.Click += buttonClick;
            // 
            // B2
            // 
            B2.Enabled = false;
            B2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            B2.Location = new Point(115, 119);
            B2.Name = "B2";
            B2.Size = new Size(80, 80);
            B2.TabIndex = 4;
            B2.UseVisualStyleBackColor = true;
            B2.Click += buttonClick;
            // 
            // B3
            // 
            B3.Enabled = false;
            B3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            B3.Location = new Point(201, 119);
            B3.Name = "B3";
            B3.Size = new Size(80, 80);
            B3.TabIndex = 5;
            B3.UseVisualStyleBackColor = true;
            B3.Click += buttonClick;
            // 
            // C1
            // 
            C1.Enabled = false;
            C1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            C1.Location = new Point(29, 205);
            C1.Name = "C1";
            C1.Size = new Size(80, 80);
            C1.TabIndex = 6;
            C1.UseVisualStyleBackColor = true;
            C1.Click += buttonClick;
            // 
            // C2
            // 
            C2.Enabled = false;
            C2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            C2.Location = new Point(115, 205);
            C2.Name = "C2";
            C2.Size = new Size(80, 80);
            C2.TabIndex = 7;
            C2.UseVisualStyleBackColor = true;
            C2.Click += buttonClick;
            // 
            // C3
            // 
            C3.Enabled = false;
            C3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            C3.Location = new Point(201, 205);
            C3.Name = "C3";
            C3.Size = new Size(80, 80);
            C3.TabIndex = 8;
            C3.UseVisualStyleBackColor = true;
            C3.Click += buttonClick;
            // 
            // StartGame
            // 
            StartGame.Location = new Point(29, 306);
            StartGame.Name = "StartGame";
            StartGame.Size = new Size(84, 28);
            StartGame.TabIndex = 9;
            StartGame.Text = "Start Game";
            StartGame.UseVisualStyleBackColor = true;
            StartGame.Click += StartGame_Click;
            // 
            // NewGame
            // 
            NewGame.Enabled = false;
            NewGame.Location = new Point(115, 306);
            NewGame.Name = "NewGame";
            NewGame.Size = new Size(84, 28);
            NewGame.TabIndex = 10;
            NewGame.Text = "New Game";
            NewGame.UseVisualStyleBackColor = true;
            NewGame.Visible = false;
            NewGame.Click += NewGame_Click;
            // 
            // TurnInfo
            // 
            TurnInfo.AutoSize = true;
            TurnInfo.Location = new Point(205, 313);
            TurnInfo.Name = "TurnInfo";
            TurnInfo.Size = new Size(0, 15);
            TurnInfo.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 359);
            Controls.Add(TurnInfo);
            Controls.Add(NewGame);
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
            Name = "Form1";
            Text = "Form1";
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
        private Button NewGame;
        private ContextMenuStrip contextMenuStrip1;
        private Label TurnInfo;
    }
}