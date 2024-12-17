namespace WinFormsApp1._0
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
            button1 = new Button();
            Label1 = new Label();
            Label2 = new Label();
            label3 = new Label();
            num1 = new TextBox();
            num2 = new TextBox();
            result = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(186, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(36, 38);
            Label1.Name = "Label1";
            Label1.Size = new Size(40, 15);
            Label1.TabIndex = 1;
            Label1.Text = "Num1";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(35, 79);
            Label2.Name = "Label2";
            Label2.Size = new Size(40, 15);
            Label2.TabIndex = 2;
            Label2.Text = "Num2";
            Label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 122);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Result";
            // 
            // num1
            // 
            num1.Location = new Point(80, 34);
            num1.Name = "num1";
            num1.Size = new Size(100, 23);
            num1.TabIndex = 7;
            // 
            // num2
            // 
            num2.Location = new Point(81, 76);
            num2.Name = "num2";
            num2.Size = new Size(100, 23);
            num2.TabIndex = 8;
            // 
            // result
            // 
            result.Location = new Point(80, 119);
            result.Name = "result";
            result.Size = new Size(100, 23);
            result.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(187, 76);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(267, 34);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button4_Click;
            // 
            // button4
            // 
            button4.Location = new Point(268, 76);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button5_Click;
            // 
            // button5
            // 
            button5.Location = new Point(187, 118);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 14;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(result);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Label1;
        private Label Label2;
        private Label label3;
        private TextBox num1;
        private TextBox num2;
        private TextBox result;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
    }
}
