namespace JogoDaVelha
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            A1 = new Button();
            A2 = new Button();
            A3 = new Button();
            B1 = new Button();
            B2 = new Button();
            B3 = new Button();
            C1 = new Button();
            C2 = new Button();
            C3 = new Button();
            button10 = new Button();
            CPUTimer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            aToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem = new ToolStripMenuItem();
            médioToolStripMenuItem = new ToolStripMenuItem();
            difícilToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            aaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(0, 29);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 0;
            label1.Text = "Vitorias Jogador:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(253, 29);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 1;
            label2.Text = "Vitorias CPU:";
            // 
            // A1
            // 
            A1.BackColor = Color.GhostWhite;
            A1.Font = new Font("Microsoft Sans Serif", 18F);
            A1.Location = new Point(41, 144);
            A1.Name = "A1";
            A1.Size = new Size(100, 100);
            A1.TabIndex = 2;
            A1.UseVisualStyleBackColor = false;
            A1.Click += PlayerClickButton;
            // 
            // A2
            // 
            A2.BackColor = Color.GhostWhite;
            A2.Font = new Font("Microsoft Sans Serif", 18F);
            A2.Location = new Point(147, 144);
            A2.Name = "A2";
            A2.Size = new Size(100, 100);
            A2.TabIndex = 3;
            A2.UseVisualStyleBackColor = false;
            A2.Click += PlayerClickButton;
            // 
            // A3
            // 
            A3.BackColor = Color.GhostWhite;
            A3.Font = new Font("Microsoft Sans Serif", 18F);
            A3.Location = new Point(253, 144);
            A3.Name = "A3";
            A3.Size = new Size(100, 100);
            A3.TabIndex = 4;
            A3.UseVisualStyleBackColor = false;
            A3.Click += PlayerClickButton;
            // 
            // B1
            // 
            B1.BackColor = Color.GhostWhite;
            B1.Font = new Font("Microsoft Sans Serif", 18F);
            B1.Location = new Point(41, 250);
            B1.Name = "B1";
            B1.Size = new Size(100, 100);
            B1.TabIndex = 7;
            B1.UseVisualStyleBackColor = false;
            B1.Click += PlayerClickButton;
            // 
            // B2
            // 
            B2.BackColor = Color.GhostWhite;
            B2.Font = new Font("Microsoft Sans Serif", 18F);
            B2.Location = new Point(147, 250);
            B2.Name = "B2";
            B2.Size = new Size(100, 100);
            B2.TabIndex = 6;
            B2.UseVisualStyleBackColor = false;
            B2.Click += PlayerClickButton;
            // 
            // B3
            // 
            B3.BackColor = Color.GhostWhite;
            B3.Font = new Font("Microsoft Sans Serif", 18F);
            B3.Location = new Point(253, 250);
            B3.Name = "B3";
            B3.Size = new Size(100, 100);
            B3.TabIndex = 5;
            B3.UseVisualStyleBackColor = false;
            B3.Click += PlayerClickButton;
            // 
            // C1
            // 
            C1.BackColor = Color.GhostWhite;
            C1.Font = new Font("Microsoft Sans Serif", 18F);
            C1.Location = new Point(41, 356);
            C1.Name = "C1";
            C1.Size = new Size(100, 100);
            C1.TabIndex = 10;
            C1.UseVisualStyleBackColor = false;
            C1.Click += PlayerClickButton;
            // 
            // C2
            // 
            C2.BackColor = Color.GhostWhite;
            C2.Font = new Font("Microsoft Sans Serif", 18F);
            C2.Location = new Point(147, 356);
            C2.Name = "C2";
            C2.Size = new Size(100, 100);
            C2.TabIndex = 9;
            C2.UseVisualStyleBackColor = false;
            C2.Click += PlayerClickButton;
            // 
            // C3
            // 
            C3.BackColor = Color.GhostWhite;
            C3.Font = new Font("Microsoft Sans Serif", 18F);
            C3.Location = new Point(253, 356);
            C3.Name = "C3";
            C3.Size = new Size(100, 100);
            C3.TabIndex = 8;
            C3.UseVisualStyleBackColor = false;
            C3.Click += PlayerClickButton;
            // 
            // button10
            // 
            button10.BackColor = Color.GhostWhite;
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Location = new Point(147, 501);
            button10.Name = "button10";
            button10.Size = new Size(100, 36);
            button10.TabIndex = 11;
            button10.Text = "Reiniciar";
            button10.UseVisualStyleBackColor = false;
            button10.Click += RestartGameButton;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1000;
            CPUTimer.Tick += CPUMove;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(158, 51);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 12;
            label3.Text = "Empates:";
            label3.Click += label3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem, toolStripMenuItem1, aaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(415, 29);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sToolStripMenuItem, médioToolStripMenuItem, difícilToolStripMenuItem });
            aToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(118, 25);
            aToolStripMenuItem.Text = "Dificuldades";
            // 
            // sToolStripMenuItem
            // 
            sToolStripMenuItem.Name = "sToolStripMenuItem";
            sToolStripMenuItem.Size = new Size(129, 26);
            sToolStripMenuItem.Text = "Fácil";
            sToolStripMenuItem.Click += DifficultiesEasy;
            // 
            // médioToolStripMenuItem
            // 
            médioToolStripMenuItem.Name = "médioToolStripMenuItem";
            médioToolStripMenuItem.Size = new Size(129, 26);
            médioToolStripMenuItem.Text = "Médio";
            médioToolStripMenuItem.Click += DifficultiesMedium;
            // 
            // difícilToolStripMenuItem
            // 
            difícilToolStripMenuItem.Name = "difícilToolStripMenuItem";
            difícilToolStripMenuItem.Size = new Size(129, 26);
            difícilToolStripMenuItem.Text = "Difícil";
            difícilToolStripMenuItem.Click += DifficultiesHard;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 25);
            // 
            // aaToolStripMenuItem
            // 
            aaToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aaToolStripMenuItem.ImageAlign = ContentAlignment.TopRight;
            aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            aaToolStripMenuItem.Size = new Size(26, 25);
            aaToolStripMenuItem.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(415, 562);
            Controls.Add(label3);
            Controls.Add(button10);
            Controls.Add(C1);
            Controls.Add(C2);
            Controls.Add(C3);
            Controls.Add(B1);
            Controls.Add(B2);
            Controls.Add(B3);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Jogo da Velha";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button A1;
        private Button A2;
        private Button A3;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button C1;
        private Button C2;
        private Button C3;
        private Button button10;
        private System.Windows.Forms.Timer CPUTimer;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem sToolStripMenuItem;
        private ToolStripMenuItem médioToolStripMenuItem;
        private ToolStripMenuItem difícilToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aaToolStripMenuItem;
    }
}
