namespace WindowsForms_Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.Label_StoredDisplay = new System.Windows.Forms.Label();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearCurrent = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.textBox_MainDisplay = new System.Windows.Forms.TextBox();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnDEC = new System.Windows.Forms.Button();
            this.btnLOC = new System.Windows.Forms.Button();
            this.btnSwapSign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "Addition Button";
            this.btnAdd.AccessibleName = "Add Button";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(253, 313);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 45);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnOperatorInput_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.AccessibleDescription = "Button to Subtract";
            this.btnSubtract.AccessibleName = "Subtract Button";
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtract.Location = new System.Drawing.Point(253, 260);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(50, 45);
            this.btnSubtract.TabIndex = 13;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnOperatorInput_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.AccessibleDescription = "Button to multiply";
            this.btnMultiply.AccessibleName = "Multiply Button";
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(253, 211);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(50, 45);
            this.btnMultiply.TabIndex = 14;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnOperatorInput_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.AccessibleDescription = "Button to Divide";
            this.btnDivide.AccessibleName = "Divide Button";
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(253, 160);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(50, 45);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnOperatorInput_Click);
            // 
            // Label_StoredDisplay
            // 
            this.Label_StoredDisplay.AccessibleDescription = "Stored Values";
            this.Label_StoredDisplay.AccessibleName = "Stored Label";
            this.Label_StoredDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_StoredDisplay.AutoSize = true;
            this.Label_StoredDisplay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_StoredDisplay.Location = new System.Drawing.Point(31, 35);
            this.Label_StoredDisplay.MaximumSize = new System.Drawing.Size(300, 60);
            this.Label_StoredDisplay.Name = "Label_StoredDisplay";
            this.Label_StoredDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_StoredDisplay.Size = new System.Drawing.Size(0, 25);
            this.Label_StoredDisplay.TabIndex = 1;
            this.Label_StoredDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnNum1
            // 
            this.btnNum1.AccessibleDescription = "Button to enter 1";
            this.btnNum1.AccessibleName = "1 button";
            this.btnNum1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum1.Location = new System.Drawing.Point(29, 313);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(50, 45);
            this.btnNum1.TabIndex = 2;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.AccessibleDescription = "Button to enter 2";
            this.btnNum2.AccessibleName = "2 Button";
            this.btnNum2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum2.Location = new System.Drawing.Point(85, 313);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(50, 45);
            this.btnNum2.TabIndex = 3;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.AccessibleDescription = "button to enter 3";
            this.btnNum3.AccessibleName = "3 Button";
            this.btnNum3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum3.Location = new System.Drawing.Point(141, 313);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(50, 45);
            this.btnNum3.TabIndex = 4;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.AccessibleDescription = "Button to enter 4";
            this.btnNum4.AccessibleName = "4 Button";
            this.btnNum4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum4.Location = new System.Drawing.Point(29, 262);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(50, 45);
            this.btnNum4.TabIndex = 5;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.AccessibleDescription = "button to enter 5";
            this.btnNum5.AccessibleName = "5 Button";
            this.btnNum5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum5.Location = new System.Drawing.Point(85, 262);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(50, 45);
            this.btnNum5.TabIndex = 6;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.AccessibleDescription = "button to enter 6";
            this.btnNum6.AccessibleName = "6 Button";
            this.btnNum6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum6.Location = new System.Drawing.Point(141, 262);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(50, 45);
            this.btnNum6.TabIndex = 7;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.AccessibleDescription = "Button to enter 7";
            this.btnNum7.AccessibleName = "7 Button";
            this.btnNum7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum7.Location = new System.Drawing.Point(29, 211);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(50, 45);
            this.btnNum7.TabIndex = 8;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.AccessibleDescription = "Button to enter 8";
            this.btnNum8.AccessibleName = "8 Button";
            this.btnNum8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum8.Location = new System.Drawing.Point(85, 211);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(50, 45);
            this.btnNum8.TabIndex = 9;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.AccessibleDescription = "Button to enter 9";
            this.btnNum9.AccessibleName = "9 Button";
            this.btnNum9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum9.Location = new System.Drawing.Point(141, 211);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(50, 45);
            this.btnNum9.TabIndex = 10;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.AccessibleDescription = "Button to Divide";
            this.btnNum0.AccessibleName = "Divide Button";
            this.btnNum0.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum0.Location = new System.Drawing.Point(28, 364);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(160, 45);
            this.btnNum0.TabIndex = 11;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.AccessibleDescription = "btn to use equals";
            this.btnEquals.AccessibleName = "Equals Button";
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEquals.Location = new System.Drawing.Point(198, 364);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(105, 45);
            this.btnEquals.TabIndex = 1;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.AccessibleDescription = "Button to clear all";
            this.btnClearAll.AccessibleName = "Clear all Button";
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearAll.Location = new System.Drawing.Point(197, 211);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(50, 45);
            this.btnClearAll.TabIndex = 17;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearCurrent
            // 
            this.btnClearCurrent.AccessibleDescription = "button to clear last entered num";
            this.btnClearCurrent.AccessibleName = "C;ear Current Button";
            this.btnClearCurrent.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearCurrent.Location = new System.Drawing.Point(196, 160);
            this.btnClearCurrent.Name = "btnClearCurrent";
            this.btnClearCurrent.Size = new System.Drawing.Size(50, 45);
            this.btnClearCurrent.TabIndex = 16;
            this.btnClearCurrent.Text = "CE";
            this.btnClearCurrent.UseVisualStyleBackColor = true;
            this.btnClearCurrent.Click += new System.EventHandler(this.btnClearCurrent_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.AccessibleDescription = "button to add decimal";
            this.btnDecimal.AccessibleName = "Decimal Button";
            this.btnDecimal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecimal.Location = new System.Drawing.Point(197, 313);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(50, 45);
            this.btnDecimal.TabIndex = 27;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // textBox_MainDisplay
            // 
            this.textBox_MainDisplay.AccessibleDescription = "Results Display";
            this.textBox_MainDisplay.AccessibleName = "Results Display";
            this.textBox_MainDisplay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_MainDisplay.Location = new System.Drawing.Point(31, 96);
            this.textBox_MainDisplay.Margin = new System.Windows.Forms.Padding(8);
            this.textBox_MainDisplay.Name = "textBox_MainDisplay";
            this.textBox_MainDisplay.Size = new System.Drawing.Size(271, 32);
            this.textBox_MainDisplay.TabIndex = 1;
            this.textBox_MainDisplay.TabStop = false;
            this.textBox_MainDisplay.Text = "0";
            this.textBox_MainDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBin
            // 
            this.btnBin.AccessibleDescription = "Convert to Binary";
            this.btnBin.AccessibleName = "BIN button";
            this.btnBin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBin.Location = new System.Drawing.Point(29, 160);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(50, 45);
            this.btnBin.TabIndex = 28;
            this.btnBin.Text = "BIN";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnDEC
            // 
            this.btnDEC.AccessibleDescription = "Convert to Integer";
            this.btnDEC.AccessibleName = "DEC button";
            this.btnDEC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDEC.Location = new System.Drawing.Point(85, 160);
            this.btnDEC.Name = "btnDEC";
            this.btnDEC.Size = new System.Drawing.Size(50, 45);
            this.btnDEC.TabIndex = 29;
            this.btnDEC.Text = "DEC";
            this.btnDEC.UseVisualStyleBackColor = true;
            this.btnDEC.Click += new System.EventHandler(this.btnDEC_Click);
            // 
            // btnLOC
            // 
            this.btnLOC.AccessibleDescription = "Convert to Location Numeral";
            this.btnLOC.AccessibleName = "LOC button";
            this.btnLOC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLOC.Location = new System.Drawing.Point(141, 160);
            this.btnLOC.Name = "btnLOC";
            this.btnLOC.Size = new System.Drawing.Size(50, 45);
            this.btnLOC.TabIndex = 30;
            this.btnLOC.Text = "LOC";
            this.btnLOC.UseVisualStyleBackColor = true;
            // 
            // btnSwapSign
            // 
            this.btnSwapSign.AccessibleDescription = "Swap Number Sign";
            this.btnSwapSign.AccessibleName = "Swap Button";
            this.btnSwapSign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSwapSign.Location = new System.Drawing.Point(196, 262);
            this.btnSwapSign.Name = "btnSwapSign";
            this.btnSwapSign.Size = new System.Drawing.Size(50, 45);
            this.btnSwapSign.TabIndex = 31;
            this.btnSwapSign.Text = "+/-";
            this.btnSwapSign.UseVisualStyleBackColor = true;
            this.btnSwapSign.Click += new System.EventHandler(this.btnSwapSign_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 436);
            this.Controls.Add(this.btnSwapSign);
            this.Controls.Add(this.btnLOC);
            this.Controls.Add(this.btnDEC);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.textBox_MainDisplay);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnClearCurrent);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.Label_StoredDisplay);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Label labelResult;
        private Button btnNum1;
        private Button btnNum2;
        private Button btnNum3;
        private Button btnNum4;
        private Button btnNum5;
        private Button btnNum6;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button btnNum0;
        private Button btnEquals;
        private Button btnClearAll;
        private Button btnClearCurrent;
        private Button btnDecimal;
        private TextBox textBox_MainDisplay;
        private Label Label_StoredDisplay;
        private Button btnBin;
        private Button btnDEC;
        private Button btnLOC;
        private Button btnSwapSign;
    }
}