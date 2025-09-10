namespace CS345Calc
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
            inputBox = new TextBox();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            btnDec = new Button();
            btnBackspace = new Button();
            btnClear = new Button();
            btnEqual = new Button();
            btnOpenPar = new Button();
            btnClosePar = new Button();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Location = new Point(12, 12);
            inputBox.Name = "inputBox";
            inputBox.ReadOnly = true;
            inputBox.Size = new Size(399, 27);
            inputBox.TabIndex = 0;
            inputBox.Text = "0";
            inputBox.TextAlign = HorizontalAlignment.Right;
            // 
            // btn0
            // 
            btn0.Location = new Point(12, 97);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 75);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += OnNumButtonClick;
            // 
            // btn1
            // 
            btn1.Location = new Point(93, 97);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 75);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += OnNumButtonClick;
            // 
            // btn2
            // 
            btn2.Location = new Point(174, 97);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 75);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += OnNumButtonClick;
            // 
            // btn3
            // 
            btn3.Location = new Point(255, 97);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 75);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += OnNumButtonClick;
            // 
            // btn4
            // 
            btn4.Location = new Point(336, 97);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 75);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += OnNumButtonClick;
            // 
            // btn5
            // 
            btn5.Location = new Point(12, 178);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 75);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += OnNumButtonClick;
            // 
            // btn6
            // 
            btn6.Location = new Point(93, 178);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 75);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += OnNumButtonClick;
            // 
            // btn7
            // 
            btn7.Location = new Point(174, 178);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 75);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += OnNumButtonClick;
            // 
            // btn8
            // 
            btn8.Location = new Point(255, 178);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 75);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += OnNumButtonClick;
            // 
            // btn9
            // 
            btn9.Location = new Point(336, 178);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 75);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += OnNumButtonClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 259);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 75);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnOperationClick;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(93, 259);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 75);
            btnSub.TabIndex = 12;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += BtnOperationClick;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(174, 259);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(75, 75);
            btnMul.TabIndex = 13;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += BtnOperationClick;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(255, 259);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 75);
            btnDiv.TabIndex = 14;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += BtnOperationClick;
            // 
            // btnDec
            // 
            btnDec.Location = new Point(336, 259);
            btnDec.Name = "btnDec";
            btnDec.Size = new Size(75, 75);
            btnDec.TabIndex = 15;
            btnDec.Text = ".";
            btnDec.UseVisualStyleBackColor = true;
            btnDec.Click += BtnDecimalClick;
            // 
            // btnBackspace
            // 
            btnBackspace.Location = new Point(12, 340);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(75, 75);
            btnBackspace.TabIndex = 16;
            btnBackspace.Text = "<-";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += BtnBackspaceClick;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(93, 340);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 75);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClearClick;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(336, 340);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(75, 75);
            btnEqual.TabIndex = 18;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += BtnEqualClick;
            // 
            // btnOpenPar
            // 
            btnOpenPar.Location = new Point(174, 340);
            btnOpenPar.Name = "btnOpenPar";
            btnOpenPar.Size = new Size(75, 75);
            btnOpenPar.TabIndex = 19;
            btnOpenPar.Text = "(";
            btnOpenPar.UseVisualStyleBackColor = true;
            btnOpenPar.Click += BtnParenthesesClick;
            // 
            // btnClosePar
            // 
            btnClosePar.Location = new Point(255, 340);
            btnClosePar.Name = "btnClosePar";
            btnClosePar.Size = new Size(75, 75);
            btnClosePar.TabIndex = 20;
            btnClosePar.Text = ")";
            btnClosePar.UseVisualStyleBackColor = true;
            btnClosePar.Click += BtnParenthesesClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 430);
            Controls.Add(btnClosePar);
            Controls.Add(btnOpenPar);
            Controls.Add(btnEqual);
            Controls.Add(btnClear);
            Controls.Add(btnBackspace);
            Controls.Add(btnDec);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(inputBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputBox;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private Button btnDec;
        private Button btnBackspace;
        private Button btnClear;
        private Button btnEqual;
        private Button btnOpenPar;
        private Button btnClosePar;
    }
}
