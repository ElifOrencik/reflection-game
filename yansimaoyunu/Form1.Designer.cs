namespace yansimaoyunu
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            button6 = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Location = new Point(164, 116);
            button2.Name = "button2";
            button2.Size = new Size(41, 42);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Location = new Point(266, 116);
            button3.Name = "button3";
            button3.Size = new Size(41, 42);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Location = new Point(138, 66);
            button4.Name = "button4";
            button4.Size = new Size(67, 14);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Location = new Point(266, 66);
            button5.Name = "button5";
            button5.Size = new Size(67, 14);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(187, 127);
            label1.Name = "label1";
            label1.Size = new Size(9, 14);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(278, 127);
            label2.Name = "label2";
            label2.Size = new Size(9, 14);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // button6
            // 
            button6.Location = new Point(108, 389);
            button6.Name = "button6";
            button6.Size = new Size(265, 79);
            button6.TabIndex = 7;
            button6.Text = "BAŞLA";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Location = new Point(108, 33);
            button1.Name = "button1";
            button1.Size = new Size(265, 261);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(135, 168, 182);
            ClientSize = new Size(480, 541);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Button button6;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}