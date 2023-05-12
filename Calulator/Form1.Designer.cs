namespace Calulator
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
            Button button16;
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(468, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(39, 88);
            button1.Name = "button1";
            button1.Size = new Size(112, 67);
            button1.TabIndex = 1;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(157, 88);
            button2.Name = "button2";
            button2.Size = new Size(112, 67);
            button2.TabIndex = 2;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(275, 88);
            button3.Name = "button3";
            button3.Size = new Size(112, 67);
            button3.TabIndex = 3;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(395, 88);
            button4.Name = "button4";
            button4.Size = new Size(112, 67);
            button4.TabIndex = 4;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(39, 161);
            button5.Name = "button5";
            button5.Size = new Size(112, 67);
            button5.TabIndex = 5;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click_1;
            // 
            // button6
            // 
            button6.Location = new Point(157, 161);
            button6.Name = "button6";
            button6.Size = new Size(112, 67);
            button6.TabIndex = 6;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click_1;
            // 
            // button7
            // 
            button7.Location = new Point(275, 161);
            button7.Name = "button7";
            button7.Size = new Size(112, 67);
            button7.TabIndex = 7;
            button7.Text = "+";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button10_Click;
            // 
            // button8
            // 
            button8.Location = new Point(395, 161);
            button8.Name = "button8";
            button8.Size = new Size(112, 67);
            button8.TabIndex = 8;
            button8.Text = "-";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(39, 234);
            button9.Name = "button9";
            button9.Size = new Size(112, 67);
            button9.TabIndex = 9;
            button9.Text = "*";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button10_Click;
            // 
            // button10
            // 
            button10.Location = new Point(157, 234);
            button10.Name = "button10";
            button10.Size = new Size(112, 67);
            button10.TabIndex = 10;
            button10.Text = "/";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(395, 307);
            button11.Name = "button11";
            button11.Size = new Size(112, 67);
            button11.TabIndex = 11;
            button11.Text = "=";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(39, 307);
            button12.Name = "button12";
            button12.Size = new Size(112, 67);
            button12.TabIndex = 12;
            button12.Text = ",";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button10_Click;
            // 
            // button13
            // 
            button13.Location = new Point(275, 234);
            button13.Name = "button13";
            button13.Size = new Size(112, 67);
            button13.TabIndex = 13;
            button13.Text = "(";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(395, 234);
            button14.Name = "button14";
            button14.Size = new Size(112, 67);
            button14.TabIndex = 14;
            button14.Text = ")";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(157, 307);
            button15.Name = "button15";
            button15.Size = new Size(112, 67);
            button15.TabIndex = 15;
            button15.Text = "C";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Location = new Point(275, 307);
            button16.Name = "button16";
            button16.Size = new Size(114, 67);
            button16.TabIndex = 16;
            button16.Text = "Del";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 407);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор в 6-ричной системе счисления";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
    }
}