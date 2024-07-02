namespace TicTacToe2
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
            a1 = new Button();
            c2 = new Button();
            b2 = new Button();
            a2 = new Button();
            c3 = new Button();
            b3 = new Button();
            a3 = new Button();
            c1 = new Button();
            b1 = new Button();
            label1 = new Label();
            label2 = new Label();
            announceLabel = new Label();
            newGameButton = new Button();
            SuspendLayout();
            // 
            // a1
            // 
            a1.Font = new Font("Segoe UI", 15F);
            a1.Location = new Point(211, 141);
            a1.Name = "a1";
            a1.Size = new Size(70, 54);
            a1.TabIndex = 0;
            a1.UseVisualStyleBackColor = true;
            a1.Click += chooseField;
            // 
            // c2
            // 
            c2.Font = new Font("Segoe UI", 15F);
            c2.Location = new Point(397, 214);
            c2.Name = "c2";
            c2.Size = new Size(70, 54);
            c2.TabIndex = 1;
            c2.UseVisualStyleBackColor = true;
            c2.Click += chooseField;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 15F);
            b2.Location = new Point(305, 214);
            b2.Name = "b2";
            b2.Size = new Size(70, 54);
            b2.TabIndex = 2;
            b2.UseVisualStyleBackColor = true;
            b2.Click += chooseField;
            // 
            // a2
            // 
            a2.Font = new Font("Segoe UI", 15F);
            a2.Location = new Point(211, 214);
            a2.Name = "a2";
            a2.Size = new Size(70, 54);
            a2.TabIndex = 3;
            a2.UseVisualStyleBackColor = true;
            a2.Click += chooseField;
            // 
            // c3
            // 
            c3.Font = new Font("Segoe UI", 15F);
            c3.Location = new Point(397, 287);
            c3.Name = "c3";
            c3.Size = new Size(70, 54);
            c3.TabIndex = 4;
            c3.UseVisualStyleBackColor = true;
            c3.Click += chooseField;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI", 15F);
            b3.Location = new Point(305, 287);
            b3.Name = "b3";
            b3.Size = new Size(70, 54);
            b3.TabIndex = 5;
            b3.UseVisualStyleBackColor = true;
            b3.Click += chooseField;
            // 
            // a3
            // 
            a3.Font = new Font("Segoe UI", 15F);
            a3.Location = new Point(211, 287);
            a3.Name = "a3";
            a3.Size = new Size(70, 54);
            a3.TabIndex = 6;
            a3.UseVisualStyleBackColor = true;
            a3.Click += chooseField;
            // 
            // c1
            // 
            c1.Font = new Font("Segoe UI", 15F);
            c1.Location = new Point(397, 141);
            c1.Name = "c1";
            c1.Size = new Size(70, 54);
            c1.TabIndex = 7;
            c1.UseVisualStyleBackColor = true;
            c1.Click += chooseField;
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 15F);
            b1.Location = new Point(305, 141);
            b1.Name = "b1";
            b1.Size = new Size(70, 54);
            b1.TabIndex = 8;
            b1.UseVisualStyleBackColor = true;
            b1.Click += chooseField;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 107);
            label1.Name = "label1";
            label1.Size = new Size(230, 15);
            label1.TabIndex = 9;
            label1.Text = "         a                              b                             c";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 161);
            label2.Name = "label2";
            label2.Size = new Size(13, 165);
            label2.TabIndex = 10;
            label2.Text = "1\r\n\r\n\r\n\r\n\r\n2\r\n\r\n\r\n\r\n\r\n3";
            // 
            // announceLabel
            // 
            announceLabel.AutoSize = true;
            announceLabel.Location = new Point(237, 375);
            announceLabel.Name = "announceLabel";
            announceLabel.Size = new Size(0, 15);
            announceLabel.TabIndex = 11;
            // 
            // newGameButton
            // 
            newGameButton.Location = new Point(472, 409);
            newGameButton.Name = "newGameButton";
            newGameButton.Size = new Size(126, 23);
            newGameButton.TabIndex = 12;
            newGameButton.Text = "Start a new Game?";
            newGameButton.UseVisualStyleBackColor = true;
            newGameButton.Click += newPlayfield;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 488);
            Controls.Add(newGameButton);
            Controls.Add(announceLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(b1);
            Controls.Add(c1);
            Controls.Add(a3);
            Controls.Add(b3);
            Controls.Add(c3);
            Controls.Add(a2);
            Controls.Add(b2);
            Controls.Add(c2);
            Controls.Add(a1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button a1;
        private Button c2;
        private Button b2;
        private Button a2;
        private Button c3;
        private Button b3;
        private Button a3;
        private Button c1;
        private Button b1;
        private Label label1;
        private Label label2;
        private Label announceLabel;
        private Button newGameButton;
    }
}
