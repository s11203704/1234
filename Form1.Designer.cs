namespace _1234
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
            panel2 = new Panel();
            panel1 = new Panel();
            lblTime = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1130, 624);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(lblTime);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 77);
            panel1.TabIndex = 0;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTime.AutoEllipsis = true;
            lblTime.AutoSize = true;
            lblTime.BackColor = SystemColors.ControlLight;
            lblTime.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = SystemColors.HotTrack;
            lblTime.Location = new Point(329, 11);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(304, 50);
            lblTime.TabIndex = 0;
            lblTime.Text = "經過時間: XX 秒";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 624);
            Controls.Add(panel2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Breakout Game, by James Chen (S1125566)";
            KeyDown += Form1_KeyDown;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label lblTime;
    }
}