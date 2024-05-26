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
            panel3 = new Panel();
            close3 = new Button();
            periodAns = new Label();
            label9 = new Label();
            freq = new TextBox();
            label8 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            close2 = new Button();
            freqAns = new Label();
            label13 = new Label();
            time = new TextBox();
            label11 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            displacement = new TextBox();
            close1 = new Button();
            answer = new Label();
            label7 = new Label();
            submit = new Button();
            label5 = new Label();
            springconstant = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            force = new TextBox();
            panel5 = new Panel();
            submit4 = new Button();
            ampAns = new Label();
            label19 = new Label();
            amp = new TextBox();
            label17 = new Label();
            springconst = new TextBox();
            label16 = new Label();
            energy = new TextBox();
            label15 = new Label();
            close4 = new Button();
            label14 = new Label();
            label12 = new Label();
            submit3 = new Button();
            submit2 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 83);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Demi", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(249, 61);
            label1.TabIndex = 0;
            label1.Text = "WELCOME";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Franklin Gothic Book", 11.25F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(318, 204);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(194, 28);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "Please select the following";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(submit2);
            panel3.Controls.Add(close3);
            panel3.Controls.Add(periodAns);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(freq);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(-1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(807, 426);
            panel3.TabIndex = 11;
            // 
            // close3
            // 
            close3.BackColor = Color.Transparent;
            close3.Cursor = Cursors.Hand;
            close3.FlatAppearance.BorderSize = 0;
            close3.FlatStyle = FlatStyle.Flat;
            close3.Font = new Font("Harlow Solid Italic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            close3.Location = new Point(723, 12);
            close3.Name = "close3";
            close3.Size = new Size(75, 37);
            close3.TabIndex = 14;
            close3.Text = "x";
            close3.TextAlign = ContentAlignment.TopCenter;
            close3.UseVisualStyleBackColor = false;
            close3.Click += button1_Click_1;
            // 
            // periodAns
            // 
            periodAns.AutoSize = true;
            periodAns.Font = new Font("Franklin Gothic Demi", 12F);
            periodAns.Location = new Point(360, 291);
            periodAns.Name = "periodAns";
            periodAns.Size = new Size(19, 21);
            periodAns.TabIndex = 11;
            periodAns.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Franklin Gothic Demi", 12F);
            label9.Location = new Point(298, 291);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 10;
            label9.Text = "Result:";
            // 
            // freq
            // 
            freq.Font = new Font("Franklin Gothic Demi", 12F);
            freq.Location = new Point(361, 164);
            freq.Multiline = true;
            freq.Name = "freq";
            freq.PlaceholderText = "                             hz";
            freq.Size = new Size(140, 26);
            freq.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Demi", 12F);
            label8.Location = new Point(270, 164);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 1;
            label8.Text = "Frequency:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Demi", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(352, 33);
            label6.Name = "label6";
            label6.Size = new Size(137, 41);
            label6.TabIndex = 0;
            label6.Text = "PERIOD";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click_2;
            // 
            // panel4
            // 
            panel4.Controls.Add(submit3);
            panel4.Controls.Add(close2);
            panel4.Controls.Add(freqAns);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(time);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(-1, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(807, 426);
            panel4.TabIndex = 12;
            // 
            // close2
            // 
            close2.BackColor = Color.Transparent;
            close2.Cursor = Cursors.Hand;
            close2.FlatAppearance.BorderSize = 0;
            close2.FlatStyle = FlatStyle.Flat;
            close2.Font = new Font("Harlow Solid Italic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            close2.Location = new Point(722, 9);
            close2.Name = "close2";
            close2.Size = new Size(75, 37);
            close2.TabIndex = 13;
            close2.Text = "x";
            close2.TextAlign = ContentAlignment.TopCenter;
            close2.UseVisualStyleBackColor = false;
            // 
            // freqAns
            // 
            freqAns.AutoSize = true;
            freqAns.Font = new Font("Franklin Gothic Demi", 12F);
            freqAns.Location = new Point(322, 252);
            freqAns.Name = "freqAns";
            freqAns.Size = new Size(19, 21);
            freqAns.TabIndex = 12;
            freqAns.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Franklin Gothic Demi", 12F);
            label13.Location = new Point(260, 252);
            label13.Name = "label13";
            label13.Size = new Size(61, 21);
            label13.TabIndex = 11;
            label13.Text = "Result:";
            // 
            // time
            // 
            time.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            time.Location = new Point(326, 137);
            time.Multiline = true;
            time.Name = "time";
            time.PlaceholderText = "                               s";
            time.Size = new Size(139, 26);
            time.TabIndex = 2;
            time.TextChanged += textBox1_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(273, 141);
            label11.Name = "label11";
            label11.Size = new Size(48, 21);
            label11.TabIndex = 1;
            label11.Text = "Time:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Demi", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(304, 33);
            label10.Name = "label10";
            label10.Size = new Size(209, 41);
            label10.TabIndex = 0;
            label10.Text = "FREQUENCY";
            label10.TextAlign = ContentAlignment.TopCenter;
            label10.Click += label10_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Menu;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(displacement);
            panel2.Controls.Add(close1);
            panel2.Controls.Add(answer);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(submit);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(springconstant);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(force);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(807, 426);
            panel2.TabIndex = 13;
            // 
            // displacement
            // 
            displacement.BorderStyle = BorderStyle.FixedSingle;
            displacement.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displacement.Location = new Point(318, 222);
            displacement.Name = "displacement";
            displacement.PlaceholderText = "                                           m";
            displacement.Size = new Size(194, 26);
            displacement.TabIndex = 12;
            // 
            // close1
            // 
            close1.BackColor = Color.Transparent;
            close1.Cursor = Cursors.Hand;
            close1.FlatAppearance.BorderSize = 0;
            close1.FlatStyle = FlatStyle.Flat;
            close1.Font = new Font("Harlow Solid Italic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            close1.Location = new Point(722, 12);
            close1.Name = "close1";
            close1.Size = new Size(75, 42);
            close1.TabIndex = 11;
            close1.Text = "x";
            close1.TextAlign = ContentAlignment.TopCenter;
            close1.UseVisualStyleBackColor = false;
            // 
            // answer
            // 
            answer.AutoSize = true;
            answer.Font = new Font("Franklin Gothic Demi", 12F);
            answer.Location = new Point(312, 323);
            answer.Name = "answer";
            answer.Size = new Size(19, 21);
            answer.TabIndex = 10;
            answer.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Demi", 12F);
            label7.Location = new Point(250, 323);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 9;
            label7.Text = "Result:";
            // 
            // submit
            // 
            submit.BackColor = SystemColors.Highlight;
            submit.Cursor = Cursors.Hand;
            submit.FlatAppearance.BorderSize = 0;
            submit.FlatStyle = FlatStyle.Flat;
            submit.Font = new Font("Franklin Gothic Demi", 12F);
            submit.ForeColor = SystemColors.ButtonFace;
            submit.Location = new Point(318, 269);
            submit.Name = "submit";
            submit.Size = new Size(196, 31);
            submit.TabIndex = 8;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Demi", 12F);
            label5.Location = new Point(194, 224);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 5;
            label5.Text = "Displacement:";
            // 
            // springconstant
            // 
            springconstant.BorderStyle = BorderStyle.FixedSingle;
            springconstant.Font = new Font("Franklin Gothic Demi", 12F);
            springconstant.Location = new Point(318, 180);
            springconstant.Name = "springconstant";
            springconstant.PlaceholderText = "                                      N/m";
            springconstant.Size = new Size(194, 26);
            springconstant.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Demi", 12F);
            label4.Location = new Point(176, 182);
            label4.Name = "label4";
            label4.Size = new Size(130, 21);
            label4.TabIndex = 3;
            label4.Text = "Spring Constant:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Demi", 12F);
            label3.Location = new Point(250, 138);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 2;
            label3.Text = "Force:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Demi", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 27);
            label2.Name = "label2";
            label2.Size = new Size(552, 41);
            label2.TabIndex = 1;
            label2.Text = "SIMPLE HARMONIC OSCILLATIONS";
            // 
            // force
            // 
            force.BorderStyle = BorderStyle.FixedSingle;
            force.Font = new Font("Franklin Gothic Demi", 12F);
            force.Location = new Point(318, 136);
            force.Name = "force";
            force.PlaceholderText = "                                           N";
            force.Size = new Size(194, 26);
            force.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(submit4);
            panel5.Controls.Add(ampAns);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(amp);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(springconst);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(energy);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(close4);
            panel5.Controls.Add(label14);
            panel5.Location = new Point(-1, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(807, 426);
            panel5.TabIndex = 15;
            // 
            // submit4
            // 
            submit4.BackColor = SystemColors.Highlight;
            submit4.Cursor = Cursors.Hand;
            submit4.FlatAppearance.BorderSize = 0;
            submit4.FlatStyle = FlatStyle.Flat;
            submit4.Font = new Font("Franklin Gothic Demi", 12F);
            submit4.ForeColor = SystemColors.ButtonFace;
            submit4.Location = new Point(344, 278);
            submit4.Name = "submit4";
            submit4.Size = new Size(182, 31);
            submit4.TabIndex = 21;
            submit4.Text = "Submit";
            submit4.UseVisualStyleBackColor = false;
            // 
            // ampAns
            // 
            ampAns.AutoSize = true;
            ampAns.Font = new Font("Franklin Gothic Demi", 12F);
            ampAns.Location = new Point(332, 324);
            ampAns.Name = "ampAns";
            ampAns.Size = new Size(19, 21);
            ampAns.TabIndex = 20;
            ampAns.Text = "0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Franklin Gothic Demi", 12F);
            label19.Location = new Point(270, 324);
            label19.Name = "label19";
            label19.Size = new Size(61, 21);
            label19.TabIndex = 19;
            label19.Text = "Result:";
            // 
            // amp
            // 
            amp.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amp.Location = new Point(344, 232);
            amp.Multiline = true;
            amp.Name = "amp";
            amp.PlaceholderText = "                                        m";
            amp.Size = new Size(182, 26);
            amp.TabIndex = 18;
            amp.TextChanged += textBox1_TextChanged_3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(247, 235);
            label17.Name = "label17";
            label17.Size = new Size(87, 21);
            label17.TabIndex = 17;
            label17.Text = "Amplitude:";
            // 
            // springconst
            // 
            springconst.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            springconst.Location = new Point(344, 191);
            springconst.Multiline = true;
            springconst.Name = "springconst";
            springconst.PlaceholderText = "                                   N/m";
            springconst.Size = new Size(182, 26);
            springconst.TabIndex = 16;
            springconst.TextChanged += textBox1_TextChanged_2;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(204, 194);
            label16.Name = "label16";
            label16.Size = new Size(130, 21);
            label16.TabIndex = 15;
            label16.Text = "Spring Constant:";
            // 
            // energy
            // 
            energy.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            energy.Location = new Point(344, 149);
            energy.Multiline = true;
            energy.Name = "energy";
            energy.PlaceholderText = "                                         J";
            energy.Size = new Size(182, 26);
            energy.TabIndex = 14;
            energy.TextChanged += textBox1_TextChanged_1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(151, 153);
            label15.Name = "label15";
            label15.Size = new Size(190, 21);
            label15.TabIndex = 13;
            label15.Text = "Total Mechanical Energy:";
            // 
            // close4
            // 
            close4.BackColor = Color.Transparent;
            close4.Cursor = Cursors.Hand;
            close4.FlatAppearance.BorderSize = 0;
            close4.FlatStyle = FlatStyle.Flat;
            close4.Font = new Font("Harlow Solid Italic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            close4.Location = new Point(723, 13);
            close4.Name = "close4";
            close4.Size = new Size(75, 42);
            close4.TabIndex = 12;
            close4.Text = "x";
            close4.TextAlign = ContentAlignment.TopCenter;
            close4.UseVisualStyleBackColor = false;
            close4.Click += button1_Click_2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Franklin Gothic Demi", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(304, 28);
            label14.Name = "label14";
            label14.Size = new Size(201, 41);
            label14.TabIndex = 0;
            label14.Text = "AMPLITUDE";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(176, 174);
            label12.Name = "label12";
            label12.Size = new Size(467, 24);
            label12.TabIndex = 16;
            label12.Text = "A calculator that calculates different parts of Oscillations.";
            label12.Click += label12_Click;
            // 
            // submit3
            // 
            submit3.BackColor = SystemColors.Highlight;
            submit3.Cursor = Cursors.Hand;
            submit3.FlatAppearance.BorderSize = 0;
            submit3.FlatStyle = FlatStyle.Flat;
            submit3.Font = new Font("Franklin Gothic Demi", 12F);
            submit3.ForeColor = SystemColors.ButtonFace;
            submit3.Location = new Point(326, 198);
            submit3.Name = "submit3";
            submit3.Size = new Size(139, 31);
            submit3.TabIndex = 22;
            submit3.Text = "Submit";
            submit3.UseVisualStyleBackColor = false;
            // 
            // submit2
            // 
            submit2.BackColor = SystemColors.Highlight;
            submit2.Cursor = Cursors.Hand;
            submit2.FlatAppearance.BorderSize = 0;
            submit2.FlatStyle = FlatStyle.Flat;
            submit2.Font = new Font("Franklin Gothic Demi", 12F);
            submit2.ForeColor = SystemColors.ButtonFace;
            submit2.Location = new Point(360, 220);
            submit2.Name = "submit2";
            submit2.Size = new Size(141, 31);
            submit2.TabIndex = 22;
            submit2.Text = "Submit";
            submit2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(805, 427);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(comboBox2);
            Controls.Add(panel1);
            Controls.Add(label12);
            Name = "Form1";
            Text = "Oscillations";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private TextBox freq;
        private Label label8;
        private Label periodAns;
        private Label label9;
        private Panel panel4;
        private Label label10;
        private TextBox time;
        private Label label11;
        private Label freqAns;
        private Label label13;
        private Panel panel2;
        private Button close1;
        private Label answer;
        private Label label7;
        private Button submit;
        private Label label5;
        private TextBox springconstant;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox force;
        private Button close2;
        private Button close3;
        private Panel panel5;
        private Label label14;
        private Label label12;
        private Button close4;
        private TextBox energy;
        private Label label15;
        private TextBox springconst;
        private Label label16;
        private TextBox amp;
        private Label label17;
        private Label ampAns;
        private Label label19;
        private TextBox displacement;
        private Button submit4;
        private Button submit2;
        private Button submit3;
    }
}
