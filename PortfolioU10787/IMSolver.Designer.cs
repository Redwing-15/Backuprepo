namespace PortfolioU10787
{
    partial class IMSolver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMSolver));
            this.tabControlMathSolver = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GCD_primeCheckBtn = new System.Windows.Forms.CheckBox();
            this.GCD_calculateBTN = new System.Windows.Forms.Button();
            this.GCD_outputBox = new System.Windows.Forms.TextBox();
            this.GCD_inputLabel = new System.Windows.Forms.Label();
            this.GCD_inputBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LCM_outputBox = new System.Windows.Forms.TextBox();
            this.LCM_inputLabel = new System.Windows.Forms.Label();
            this.LCM_calculateBTN = new System.Windows.Forms.Button();
            this.LCM_inputBox = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LE_Label2 = new System.Windows.Forms.Label();
            this.LE_Label1 = new System.Windows.Forms.Label();
            this.LE_outputLabel = new System.Windows.Forms.Label();
            this.LE_calculateBTN = new System.Windows.Forms.Button();
            this.LE_inputBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DM_outputLabel = new System.Windows.Forms.Label();
            this.DM_calculateBTN = new System.Windows.Forms.Button();
            this.DM_entryBox = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.QE_outputBox = new System.Windows.Forms.TextBox();
            this.QE_calculateButton = new System.Windows.Forms.Button();
            this.QE_entryBox = new System.Windows.Forms.TextBox();
            this.DM_label1 = new System.Windows.Forms.Label();
            this.DM_label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QE_imaginaryCheck = new System.Windows.Forms.CheckBox();
            this.tabControlMathSolver.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMathSolver
            // 
            this.tabControlMathSolver.Controls.Add(this.tabPage1);
            this.tabControlMathSolver.Controls.Add(this.tabPage2);
            this.tabControlMathSolver.Controls.Add(this.tabPage3);
            this.tabControlMathSolver.Controls.Add(this.tabPage4);
            this.tabControlMathSolver.Controls.Add(this.tabPage5);
            this.tabControlMathSolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMathSolver.Location = new System.Drawing.Point(0, 0);
            this.tabControlMathSolver.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMathSolver.Name = "tabControlMathSolver";
            this.tabControlMathSolver.SelectedIndex = 0;
            this.tabControlMathSolver.Size = new System.Drawing.Size(867, 425);
            this.tabControlMathSolver.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GCD_primeCheckBtn);
            this.tabPage1.Controls.Add(this.GCD_calculateBTN);
            this.tabPage1.Controls.Add(this.GCD_outputBox);
            this.tabPage1.Controls.Add(this.GCD_inputLabel);
            this.tabPage1.Controls.Add(this.GCD_inputBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(859, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GCD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GCD_primeCheckBtn
            // 
            this.GCD_primeCheckBtn.AutoSize = true;
            this.GCD_primeCheckBtn.Location = new System.Drawing.Point(666, 39);
            this.GCD_primeCheckBtn.Name = "GCD_primeCheckBtn";
            this.GCD_primeCheckBtn.Size = new System.Drawing.Size(159, 21);
            this.GCD_primeCheckBtn.TabIndex = 6;
            this.GCD_primeCheckBtn.Text = "Prime Factorisation?";
            this.GCD_primeCheckBtn.UseVisualStyleBackColor = true;
            // 
            // GCD_calculateBTN
            // 
            this.GCD_calculateBTN.Location = new System.Drawing.Point(665, 201);
            this.GCD_calculateBTN.Margin = new System.Windows.Forms.Padding(4);
            this.GCD_calculateBTN.Name = "GCD_calculateBTN";
            this.GCD_calculateBTN.Size = new System.Drawing.Size(160, 63);
            this.GCD_calculateBTN.TabIndex = 5;
            this.GCD_calculateBTN.Text = "Calculate";
            this.GCD_calculateBTN.UseVisualStyleBackColor = true;
            this.GCD_calculateBTN.Click += new System.EventHandler(this.GCD_CalculateBTN_Click);
            // 
            // GCD_outputBox
            // 
            this.GCD_outputBox.Location = new System.Drawing.Point(15, 106);
            this.GCD_outputBox.Margin = new System.Windows.Forms.Padding(4);
            this.GCD_outputBox.Multiline = true;
            this.GCD_outputBox.Name = "GCD_outputBox";
            this.GCD_outputBox.ReadOnly = true;
            this.GCD_outputBox.Size = new System.Drawing.Size(595, 276);
            this.GCD_outputBox.TabIndex = 4;
            // 
            // GCD_inputLabel
            // 
            this.GCD_inputLabel.AutoSize = true;
            this.GCD_inputLabel.Location = new System.Drawing.Point(11, 15);
            this.GCD_inputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GCD_inputLabel.Name = "GCD_inputLabel";
            this.GCD_inputLabel.Size = new System.Drawing.Size(409, 17);
            this.GCD_inputLabel.TabIndex = 1;
            this.GCD_inputLabel.Text = "Enter numbers below: (Comma or Space Separated e.g 1,2,3...)";
            // 
            // GCD_inputBox
            // 
            this.GCD_inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCD_inputBox.Location = new System.Drawing.Point(15, 34);
            this.GCD_inputBox.Margin = new System.Windows.Forms.Padding(4);
            this.GCD_inputBox.Name = "GCD_inputBox";
            this.GCD_inputBox.Size = new System.Drawing.Size(595, 26);
            this.GCD_inputBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LCM_outputBox);
            this.tabPage2.Controls.Add(this.LCM_inputLabel);
            this.tabPage2.Controls.Add(this.LCM_calculateBTN);
            this.tabPage2.Controls.Add(this.LCM_inputBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(859, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LCM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LCM_outputBox
            // 
            this.LCM_outputBox.Location = new System.Drawing.Point(15, 106);
            this.LCM_outputBox.Margin = new System.Windows.Forms.Padding(4);
            this.LCM_outputBox.Multiline = true;
            this.LCM_outputBox.Name = "LCM_outputBox";
            this.LCM_outputBox.ReadOnly = true;
            this.LCM_outputBox.Size = new System.Drawing.Size(595, 276);
            this.LCM_outputBox.TabIndex = 5;
            // 
            // LCM_inputLabel
            // 
            this.LCM_inputLabel.AutoSize = true;
            this.LCM_inputLabel.Location = new System.Drawing.Point(11, 15);
            this.LCM_inputLabel.Name = "LCM_inputLabel";
            this.LCM_inputLabel.Size = new System.Drawing.Size(409, 17);
            this.LCM_inputLabel.TabIndex = 3;
            this.LCM_inputLabel.Text = "Enter numbers below: (Comma or Space Separated e.g 1,2,3...)";
            // 
            // LCM_calculateBTN
            // 
            this.LCM_calculateBTN.Location = new System.Drawing.Point(665, 201);
            this.LCM_calculateBTN.Margin = new System.Windows.Forms.Padding(4);
            this.LCM_calculateBTN.Name = "LCM_calculateBTN";
            this.LCM_calculateBTN.Size = new System.Drawing.Size(160, 63);
            this.LCM_calculateBTN.TabIndex = 2;
            this.LCM_calculateBTN.Text = "Calculate";
            this.LCM_calculateBTN.UseVisualStyleBackColor = true;
            this.LCM_calculateBTN.Click += new System.EventHandler(this.LCM_CalculateBTN_Click);
            // 
            // LCM_inputBox
            // 
            this.LCM_inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LCM_inputBox.Location = new System.Drawing.Point(15, 34);
            this.LCM_inputBox.Margin = new System.Windows.Forms.Padding(4);
            this.LCM_inputBox.Multiline = false;
            this.LCM_inputBox.Name = "LCM_inputBox";
            this.LCM_inputBox.Size = new System.Drawing.Size(595, 26);
            this.LCM_inputBox.TabIndex = 0;
            this.LCM_inputBox.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LE_Label2);
            this.tabPage3.Controls.Add(this.LE_Label1);
            this.tabPage3.Controls.Add(this.LE_outputLabel);
            this.tabPage3.Controls.Add(this.LE_calculateBTN);
            this.tabPage3.Controls.Add(this.LE_inputBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(859, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Linear Equations";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LE_Label2
            // 
            this.LE_Label2.AutoSize = true;
            this.LE_Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LE_Label2.Location = new System.Drawing.Point(82, 276);
            this.LE_Label2.Name = "LE_Label2";
            this.LE_Label2.Size = new System.Drawing.Size(124, 38);
            this.LE_Label2.TabIndex = 4;
            this.LE_Label2.Text = "Output:";
            // 
            // LE_Label1
            // 
            this.LE_Label1.AutoSize = true;
            this.LE_Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LE_Label1.Location = new System.Drawing.Point(38, 35);
            this.LE_Label1.Name = "LE_Label1";
            this.LE_Label1.Size = new System.Drawing.Size(253, 100);
            this.LE_Label1.TabIndex = 3;
            this.LE_Label1.Text = "Enter linear equation in the form:\r\nax + b =0\r\nOR\r\nax + by = c\r\nax + by = c";
            // 
            // LE_outputLabel
            // 
            this.LE_outputLabel.AutoSize = true;
            this.LE_outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LE_outputLabel.Location = new System.Drawing.Point(212, 276);
            this.LE_outputLabel.Name = "LE_outputLabel";
            this.LE_outputLabel.Size = new System.Drawing.Size(26, 38);
            this.LE_outputLabel.TabIndex = 2;
            this.LE_outputLabel.Text = " ";
            // 
            // LE_calculateBTN
            // 
            this.LE_calculateBTN.Location = new System.Drawing.Point(58, 188);
            this.LE_calculateBTN.Name = "LE_calculateBTN";
            this.LE_calculateBTN.Size = new System.Drawing.Size(160, 63);
            this.LE_calculateBTN.TabIndex = 1;
            this.LE_calculateBTN.Text = "Calculate";
            this.LE_calculateBTN.UseVisualStyleBackColor = true;
            this.LE_calculateBTN.Click += new System.EventHandler(this.LE_calculateBTN_Click);
            // 
            // LE_inputBox
            // 
            this.LE_inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LE_inputBox.Location = new System.Drawing.Point(338, 35);
            this.LE_inputBox.Multiline = true;
            this.LE_inputBox.Name = "LE_inputBox";
            this.LE_inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LE_inputBox.Size = new System.Drawing.Size(209, 120);
            this.LE_inputBox.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DM_label2);
            this.tabPage4.Controls.Add(this.DM_label1);
            this.tabPage4.Controls.Add(this.DM_outputLabel);
            this.tabPage4.Controls.Add(this.DM_calculateBTN);
            this.tabPage4.Controls.Add(this.DM_entryBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(859, 396);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Determinant of Matrix";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DM_outputLabel
            // 
            this.DM_outputLabel.AutoSize = true;
            this.DM_outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM_outputLabel.Location = new System.Drawing.Point(297, 306);
            this.DM_outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DM_outputLabel.Name = "DM_outputLabel";
            this.DM_outputLabel.Size = new System.Drawing.Size(26, 39);
            this.DM_outputLabel.TabIndex = 2;
            this.DM_outputLabel.Text = " ";
            // 
            // DM_calculateBTN
            // 
            this.DM_calculateBTN.Location = new System.Drawing.Point(490, 157);
            this.DM_calculateBTN.Margin = new System.Windows.Forms.Padding(4);
            this.DM_calculateBTN.Name = "DM_calculateBTN";
            this.DM_calculateBTN.Size = new System.Drawing.Size(160, 63);
            this.DM_calculateBTN.TabIndex = 1;
            this.DM_calculateBTN.Text = "Calculate";
            this.DM_calculateBTN.UseVisualStyleBackColor = true;
            this.DM_calculateBTN.Click += new System.EventHandler(this.DM_calculateBTN_Click);
            // 
            // DM_entryBox
            // 
            this.DM_entryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM_entryBox.Location = new System.Drawing.Point(169, 81);
            this.DM_entryBox.Margin = new System.Windows.Forms.Padding(4);
            this.DM_entryBox.Multiline = true;
            this.DM_entryBox.Name = "DM_entryBox";
            this.DM_entryBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DM_entryBox.Size = new System.Drawing.Size(207, 180);
            this.DM_entryBox.TabIndex = 0;
            this.DM_entryBox.WordWrap = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.QE_imaginaryCheck);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.QE_outputBox);
            this.tabPage5.Controls.Add(this.QE_calculateButton);
            this.tabPage5.Controls.Add(this.QE_entryBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(859, 396);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Quadratic Equation";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // QE_outputBox
            // 
            this.QE_outputBox.Location = new System.Drawing.Point(183, 149);
            this.QE_outputBox.Margin = new System.Windows.Forms.Padding(4);
            this.QE_outputBox.Name = "QE_outputBox";
            this.QE_outputBox.ReadOnly = true;
            this.QE_outputBox.Size = new System.Drawing.Size(351, 22);
            this.QE_outputBox.TabIndex = 4;
            // 
            // QE_calculateButton
            // 
            this.QE_calculateButton.Location = new System.Drawing.Point(186, 222);
            this.QE_calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.QE_calculateButton.Name = "QE_calculateButton";
            this.QE_calculateButton.Size = new System.Drawing.Size(100, 28);
            this.QE_calculateButton.TabIndex = 3;
            this.QE_calculateButton.Text = "Calculate";
            this.QE_calculateButton.UseVisualStyleBackColor = true;
            this.QE_calculateButton.Click += new System.EventHandler(this.QE_calculateButton_Click);
            // 
            // QE_entryBox
            // 
            this.QE_entryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QE_entryBox.Location = new System.Drawing.Point(183, 82);
            this.QE_entryBox.Margin = new System.Windows.Forms.Padding(4);
            this.QE_entryBox.Name = "QE_entryBox";
            this.QE_entryBox.Size = new System.Drawing.Size(323, 28);
            this.QE_entryBox.TabIndex = 0;
            // 
            // DM_label1
            // 
            this.DM_label1.AutoSize = true;
            this.DM_label1.Location = new System.Drawing.Point(166, 30);
            this.DM_label1.Name = "DM_label1";
            this.DM_label1.Size = new System.Drawing.Size(451, 34);
            this.DM_label1.TabIndex = 3;
            this.DM_label1.Text = "Input matrix as comma or space separated list, spanning multiple lines.\r\nSupports" +
    " 2x2, 3x3, and 4x4 matrices.\r\n";
            // 
            // DM_label2
            // 
            this.DM_label2.AutoSize = true;
            this.DM_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM_label2.Location = new System.Drawing.Point(162, 306);
            this.DM_label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DM_label2.Name = "DM_label2";
            this.DM_label2.Size = new System.Drawing.Size(127, 39);
            this.DM_label2.TabIndex = 4;
            this.DM_label2.Text = "Output:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input equation below in the form: ax^2 + bx + c = 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Roots:";
            // 
            // QE_imaginaryCheck
            // 
            this.QE_imaginaryCheck.AutoCheck = false;
            this.QE_imaginaryCheck.AutoSize = true;
            this.QE_imaginaryCheck.Location = new System.Drawing.Point(541, 151);
            this.QE_imaginaryCheck.Name = "QE_imaginaryCheck";
            this.QE_imaginaryCheck.Size = new System.Drawing.Size(99, 21);
            this.QE_imaginaryCheck.TabIndex = 7;
            this.QE_imaginaryCheck.Text = "Imaginary?";
            this.QE_imaginaryCheck.UseVisualStyleBackColor = true;
            // 
            // IMSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 425);
            this.Controls.Add(this.tabControlMathSolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IMSolver";
            this.Text = "Interactive Math Solver";
            this.tabControlMathSolver.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMathSolver;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label GCD_inputLabel;
        private System.Windows.Forms.TextBox GCD_inputBox;
        private System.Windows.Forms.RichTextBox LCM_inputBox;
        private System.Windows.Forms.Button LCM_calculateBTN;
        private System.Windows.Forms.TextBox GCD_outputBox;
        private System.Windows.Forms.Button GCD_calculateBTN;
        private System.Windows.Forms.TextBox QE_entryBox;
        private System.Windows.Forms.TextBox QE_outputBox;
        private System.Windows.Forms.Button QE_calculateButton;
        private System.Windows.Forms.Label DM_outputLabel;
        private System.Windows.Forms.Button DM_calculateBTN;
        private System.Windows.Forms.TextBox DM_entryBox;
        private System.Windows.Forms.Label LE_outputLabel;
        private System.Windows.Forms.Button LE_calculateBTN;
        private System.Windows.Forms.TextBox LE_inputBox;
        private System.Windows.Forms.CheckBox GCD_primeCheckBtn;
        private System.Windows.Forms.Label LCM_inputLabel;
        private System.Windows.Forms.TextBox LCM_outputBox;
        private System.Windows.Forms.Label LE_Label1;
        private System.Windows.Forms.Label LE_Label2;
        private System.Windows.Forms.Label DM_label1;
        private System.Windows.Forms.Label DM_label2;
        private System.Windows.Forms.CheckBox QE_imaginaryCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

