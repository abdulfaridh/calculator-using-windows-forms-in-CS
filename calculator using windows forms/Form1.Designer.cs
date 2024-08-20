

namespace calculator_using_windows_forms
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
            txtTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btnClear = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnEquals = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtTotal.Location = new Point(12, 12);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(616, 67);
            txtTotal.TabIndex = 0;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.Location = new Point(23, 100);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 74);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click_1;
            // 
            // btn2
            // 
            btn2.Location = new Point(142, 100);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 74);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(262, 100);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 74);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(392, 100);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 74);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(529, 100);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 74);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(529, 204);
            btn0.Name = "btn0";
            btn0.Size = new Size(94, 74);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(392, 204);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 74);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(262, 204);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 74);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(142, 204);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 74);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(23, 204);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 74);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(529, 305);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 74);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(392, 305);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(94, 74);
            btnDiv.TabIndex = 14;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(262, 305);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(94, 74);
            btnMul.TabIndex = 13;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(142, 305);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(94, 74);
            btnMinus.TabIndex = 12;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(23, 305);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(94, 74);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(82, 400);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(486, 74);
            btnEquals.TabIndex = 16;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 486);
            Controls.Add(btnEquals);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }



        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btnClear;
        private Button btnDiv;
        private Button btnMul;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnEquals;
    }
}
