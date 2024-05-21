namespace OscillationsCalculator
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
            panel1 = new Panel();
            label1 = new Label();
            listBox1 = new ListBox();
            comboBox2 = new ComboBox();
            panel2 = new Panel();
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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 83);
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(249, 180);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(0, 4);
            listBox1.TabIndex = 1;
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
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(781, 435);
            panel2.TabIndex = 4;
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
            submit.Text = "Submit\r\n";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(779, 431);
            Controls.Add(panel2);
            Controls.Add(comboBox2);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Oscillations";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListBox listBox1;
        private ComboBox comboBox2;
        private Panel panel2;
        private TextBox force;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox springconstant;
        private TextBox displacement;
        private Button submit;
        private Label answer;
        private Label label7;
    }
}
