namespace controlsMovementsVisual
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(709, 37);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(709, 60);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "enable";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(711, 92);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "disable";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(708, 11);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 3;
            label2.Text = "squaresControl";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(616, 390);
            label3.Name = "label3";
            label3.Size = new Size(220, 20);
            label3.TabIndex = 4;
            label3.Text = "to enable all square press space";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(616, 410);
            label4.Name = "label4";
            label4.Size = new Size(241, 20);
            label4.TabIndex = 5;
            label4.Text = "to disable all press disable or enter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 430);
            label5.Name = "label5";
            label5.Size = new Size(446, 20);
            label5.TabIndex = 6;
            label5.Text = "to move disable all and press left right up down keyboard buttons";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(437, 340);
            label6.Name = "label6";
            label6.Size = new Size(442, 40);
            label6.TabIndex = 7;
            label6.Text = "press small squares with mouse to find the position in matrix \\r\\n \r\nwhen is enable on and disable button is enable on this form";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}