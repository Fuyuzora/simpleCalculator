namespace WindowsFormsApplication1
{
    partial class Simple_calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.result = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.bracketL = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.bracketR = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSq = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDevision = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.btnEq = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.White;
            this.result.Enabled = false;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(110, 94);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(620, 67);
            this.result.TabIndex = 0;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.Menu;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn7.Location = new System.Drawing.Point(109, 277);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(149, 93);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Menu;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn4.Location = new System.Drawing.Point(109, 376);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(149, 93);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Menu;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1.Location = new System.Drawing.Point(110, 475);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(149, 93);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.Menu;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn8.Location = new System.Drawing.Point(264, 277);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(149, 93);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.Menu;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn9.Location = new System.Drawing.Point(419, 277);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(149, 93);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.Menu;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn5.Location = new System.Drawing.Point(264, 375);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(149, 94);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.Menu;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn6.Location = new System.Drawing.Point(419, 376);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(149, 93);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Menu;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn2.Location = new System.Drawing.Point(264, 475);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(149, 93);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Menu;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn3.Location = new System.Drawing.Point(419, 475);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(149, 93);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // bracketL
            // 
            this.bracketL.BackColor = System.Drawing.SystemColors.Menu;
            this.bracketL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bracketL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bracketL.Location = new System.Drawing.Point(110, 574);
            this.bracketL.Name = "bracketL";
            this.bracketL.Size = new System.Drawing.Size(72, 93);
            this.bracketL.TabIndex = 10;
            this.bracketL.Text = "(";
            this.bracketL.UseVisualStyleBackColor = false;
            this.bracketL.Click += new System.EventHandler(this.BracketL_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.Menu;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn0.Location = new System.Drawing.Point(264, 574);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(149, 93);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // bracketR
            // 
            this.bracketR.BackColor = System.Drawing.SystemColors.Menu;
            this.bracketR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bracketR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bracketR.Location = new System.Drawing.Point(188, 574);
            this.bracketR.Name = "bracketR";
            this.bracketR.Size = new System.Drawing.Size(70, 93);
            this.bracketR.TabIndex = 12;
            this.bracketR.Text = ")";
            this.bracketR.UseVisualStyleBackColor = false;
            this.bracketR.Click += new System.EventHandler(this.BracketR_Click);
            // 
            // btnClr
            // 
            this.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClr.Location = new System.Drawing.Point(575, 277);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(154, 93);
            this.btnClr.TabIndex = 13;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlus.Location = new System.Drawing.Point(575, 377);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(154, 92);
            this.btnPlus.TabIndex = 14;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinus.Location = new System.Drawing.Point(575, 475);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(154, 92);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMultiplication.Location = new System.Drawing.Point(574, 573);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(154, 93);
            this.btnMultiplication.TabIndex = 16;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            // 
            // btnSq
            // 
            this.btnSq.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSq.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSq.Location = new System.Drawing.Point(110, 673);
            this.btnSq.Name = "btnSq";
            this.btnSq.Size = new System.Drawing.Size(149, 92);
            this.btnSq.TabIndex = 17;
            this.btnSq.Text = "Square";
            this.btnSq.UseVisualStyleBackColor = false;
            this.btnSq.Click += new System.EventHandler(this.BtnSq_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSqrt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSqrt.Location = new System.Drawing.Point(265, 673);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(148, 92);
            this.btnSqrt.TabIndex = 18;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEqual.Location = new System.Drawing.Point(420, 673);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(148, 90);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnDevision
            // 
            this.btnDevision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevision.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevision.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDevision.Location = new System.Drawing.Point(574, 673);
            this.btnDevision.Name = "btnDevision";
            this.btnDevision.Size = new System.Drawing.Size(154, 90);
            this.btnDevision.TabIndex = 20;
            this.btnDevision.Text = "/";
            this.btnDevision.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnC.Location = new System.Drawing.Point(574, 278);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(154, 93);
            this.btnC.TabIndex = 13;
            this.btnC.Text = "Clear";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnP.Location = new System.Drawing.Point(574, 378);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(154, 92);
            this.btnP.TabIndex = 14;
            this.btnP.Text = "+";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.BtnP_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnS.Location = new System.Drawing.Point(574, 476);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(154, 92);
            this.btnS.TabIndex = 15;
            this.btnS.Text = "-";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.BtnS_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnM.Location = new System.Drawing.Point(573, 574);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(154, 93);
            this.btnM.TabIndex = 16;
            this.btnM.Text = "*";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.BtnM_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sqrt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sqrt.Location = new System.Drawing.Point(264, 674);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(148, 92);
            this.sqrt.TabIndex = 18;
            this.sqrt.Text = "Sqrt";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // btnEq
            // 
            this.btnEq.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEq.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEq.Location = new System.Drawing.Point(419, 674);
            this.btnEq.Name = "btnEq";
            this.btnEq.Size = new System.Drawing.Size(148, 90);
            this.btnEq.TabIndex = 19;
            this.btnEq.Text = "=";
            this.btnEq.UseVisualStyleBackColor = false;
            this.btnEq.Click += new System.EventHandler(this.BtnEq_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnD.Location = new System.Drawing.Point(573, 674);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(154, 90);
            this.btnD.TabIndex = 20;
            this.btnD.Text = "/";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(420, 577);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(73, 91);
            this.btnDecimal.TabIndex = 21;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.BtnDecimal_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.BackColor = System.Drawing.SystemColors.Menu;
            this.btnNegative.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNegative.Location = new System.Drawing.Point(497, 577);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(70, 91);
            this.btnNegative.TabIndex = 22;
            this.btnNegative.Text = "( - )";
            this.btnNegative.UseVisualStyleBackColor = false;
            this.btnNegative.Click += new System.EventHandler(this.BtnNegative_Click);
            // 
            // Simple_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 835);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnDevision);
            this.Controls.Add(this.btnEq);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnSq);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.bracketR);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.bracketL);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Simple_calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button bracketL;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button bracketR;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnSq;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDevision;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button btnEq;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnNegative;
    }
}

