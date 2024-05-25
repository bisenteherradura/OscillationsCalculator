namespace OscillationsCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            comboBox2 = new ComboBox();
            panel2 = new Panel();
            close1 = new Button();
            answer = new Label();
            label7 = new Label();
            submit = new Button();
            displacement = new TextBox();
            label5 = new Label();
            springconstant = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            force = new TextBox();
            panel3 = new Panel();
            periodAns = new Label();
            label9 = new Label();
            submit2 = new Button();
            freq = new TextBox();
            label8 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            freqAns = new Label();
            label13 = new Label();
            submit3 = new Button();
            time = new TextBox();
            label11 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 83);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 65);
            label1.TabIndex = 0;
            label1.Text = "WELCOME";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(291, 219);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(209, 29);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "Please select the following";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(close1);
            panel2.Controls.Add(answer);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(submit);
            panel2.Controls.Add(displacement);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(springconstant);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(force);
            panel2.Location = new Point(2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 426);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // close1
            // 
            close1.Location = new Point(719, 9);
            close1.Name = "close1";
            close1.Size = new Size(75, 23);
            close1.TabIndex = 11;
            close1.Text = "x";
            close1.UseVisualStyleBackColor = true;
            close1.Click += close1_Click;
            // 
            // answer
            // 
            answer.AutoSize = true;
            answer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answer.Location = new Point(312, 323);
            answer.Name = "answer";
            answer.Size = new Size(19, 21);
            answer.TabIndex = 10;
            answer.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(250, 323);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 9;
            label7.Text = "Result:";
            // 
            // submit
            // 
            submit.Location = new Point(318, 269);
            submit.Name = "submit";
            submit.Size = new Size(93, 32);
            submit.TabIndex = 8;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            // 
            // displacement
            // 
            displacement.BorderStyle = BorderStyle.FixedSingle;
            displacement.Location = new Point(318, 222);
            displacement.Name = "displacement";
            displacement.Size = new Size(194, 23);
            displacement.TabIndex = 6;
            displacement.TextChanged += displacement_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(194, 224);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 5;
            label5.Text = "Displacement:";
            label5.Click += label5_Click;
            // 
            // springconstant
            // 
            springconstant.BorderStyle = BorderStyle.FixedSingle;
            springconstant.Location = new Point(318, 180);
            springconstant.Name = "springconstant";
            springconstant.Size = new Size(194, 23);
            springconstant.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(176, 182);
            label4.Name = "label4";
            label4.Size = new Size(125, 21);
            label4.TabIndex = 3;
            label4.Text = "Spring Constant:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(250, 138);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 2;
            label3.Text = "Force:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 27);
            label2.Name = "label2";
            label2.Size = new Size(563, 47);
            label2.TabIndex = 1;
            label2.Text = "SIMPLE HARMONIC OSCILLATIONS";
            // 
            // force
            // 
            force.BorderStyle = BorderStyle.FixedSingle;
            force.Location = new Point(318, 136);
            force.Name = "force";
            force.Size = new Size(194, 23);
            force.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(periodAns);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(submit2);
            panel3.Controls.Add(freq);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(806, 426);
            panel3.TabIndex = 11;
            // 
            // periodAns
            // 
            periodAns.AutoSize = true;
            periodAns.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            periodAns.Location = new Point(403, 323);
            periodAns.Name = "periodAns";
            periodAns.Size = new Size(19, 21);
            periodAns.TabIndex = 11;
            periodAns.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(341, 323);
            label9.Name = "label9";
            label9.Size = new Size(56, 21);
            label9.TabIndex = 10;
            label9.Text = "Result:";
            // 
            // submit2
            // 
            submit2.Location = new Point(361, 224);
            submit2.Name = "submit2";
            submit2.Size = new Size(93, 32);
            submit2.TabIndex = 3;
            submit2.Text = "Submit";
            submit2.UseVisualStyleBackColor = true;
            // 
            // freq
            // 
            freq.Location = new Point(361, 164);
            freq.Name = "freq";
            freq.Size = new Size(128, 23);
            freq.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(270, 164);
            label8.Name = "label8";
            label8.Size = new Size(85, 21);
            label8.TabIndex = 1;
            label8.Text = "Frequency:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(317, 27);
            label6.Name = "label6";
            label6.Size = new Size(139, 47);
            label6.TabIndex = 0;
            label6.Text = "PERIOD";
            label6.Click += label6_Click_2;
            // 
            // panel4
            // 
            panel4.Controls.Add(freqAns);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(submit3);
            panel4.Controls.Add(time);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(-1, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(807, 426);
            panel4.TabIndex = 12;
            // 
            // freqAns
            // 
            freqAns.AutoSize = true;
            freqAns.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            freqAns.Location = new Point(333, 269);
            freqAns.Name = "freqAns";
            freqAns.Size = new Size(19, 21);
            freqAns.TabIndex = 12;
            freqAns.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(271, 269);
            label13.Name = "label13";
            label13.Size = new Size(56, 21);
            label13.TabIndex = 11;
            label13.Text = "Result:";
            // 
            // submit3
            // 
            submit3.BackColor = SystemColors.ActiveCaption;
            submit3.Cursor = Cursors.Hand;
            submit3.FlatStyle = FlatStyle.Popup;
            submit3.Location = new Point(326, 193);
            submit3.Name = "submit3";
            submit3.Size = new Size(93, 32);
            submit3.TabIndex = 3;
            submit3.Text = "Submit";
            submit3.UseVisualStyleBackColor = false;
            // 
            // time
            // 
            time.Location = new Point(326, 139);
            time.Name = "time";
            time.Size = new Size(139, 23);
            time.TabIndex = 2;
            time.TextChanged += textBox1_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(273, 141);
            label11.Name = "label11";
            label11.Size = new Size(47, 21);
            label11.TabIndex = 1;
            label11.Text = "Time:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(304, 27);
            label10.Name = "label10";
            label10.Size = new Size(211, 47);
            label10.TabIndex = 0;
            label10.Text = "FREQUENCY";
            label10.Click += label10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(805, 427);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(comboBox2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Oscillations";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox force;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox springconstant;
        private System.Windows.Forms.TextBox displacement;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private Button submit2;
        private TextBox freq;
        private Label label8;
        private Label periodAns;
        private Label label9;
        private Button close1;
        private Panel panel4;
        private Label label10;
        private TextBox time;
        private Label label11;
        private Button submit3;
        private Label freqAns;
        private Label label13;
    }
}
