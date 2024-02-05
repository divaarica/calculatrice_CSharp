namespace AppCalculatrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPourcent = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btnCE = new Button();
            btn9 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            button9 = new Button();
            btnMoins = new Button();
            btnMulti = new Button();
            btnDiv = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btnVirgule = new Button();
            btnEgal = new Button();
            btn0 = new Button();
            txtResult = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnAC = new Button();
            SuspendLayout();
            // 
            // btnPourcent
            // 
            btnPourcent.BackColor = SystemColors.WindowFrame;
            btnPourcent.BackgroundImageLayout = ImageLayout.None;
            btnPourcent.FlatAppearance.BorderColor = Color.Black;
            btnPourcent.FlatAppearance.BorderSize = 0;
            btnPourcent.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnPourcent.FlatStyle = FlatStyle.Flat;
            btnPourcent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPourcent.ForeColor = SystemColors.ControlLightLight;
            btnPourcent.Location = new Point(67, 138);
            btnPourcent.Name = "btnPourcent";
            btnPourcent.Size = new Size(67, 73);
            btnPourcent.TabIndex = 1;
            btnPourcent.Text = "-/+";
            btnPourcent.UseVisualStyleBackColor = false;
            btnPourcent.Click += clickMoinsPlus;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(64, 64, 64);
            btn2.BackgroundImageLayout = ImageLayout.None;
            btn2.FlatAppearance.BorderColor = Color.Black;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.ForeColor = SystemColors.ControlLightLight;
            btn2.Location = new Point(67, 357);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 73);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += clickNumber;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(64, 64, 64);
            btn5.BackgroundImageLayout = ImageLayout.None;
            btn5.FlatAppearance.BorderColor = Color.Black;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.ForeColor = SystemColors.ControlLightLight;
            btn5.Location = new Point(67, 284);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 73);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += clickNumber;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(64, 64, 64);
            btn8.BackgroundImageLayout = ImageLayout.None;
            btn8.FlatAppearance.BorderColor = Color.Black;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.ForeColor = SystemColors.ControlLightLight;
            btn8.Location = new Point(67, 211);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 73);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += clickNumber;
            // 
            // btnCE
            // 
            btnCE.BackColor = SystemColors.WindowFrame;
            btnCE.BackgroundImageLayout = ImageLayout.None;
            btnCE.FlatAppearance.BorderColor = Color.Black;
            btnCE.FlatAppearance.BorderSize = 0;
            btnCE.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnCE.FlatStyle = FlatStyle.Flat;
            btnCE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCE.ForeColor = SystemColors.ControlLightLight;
            btnCE.Location = new Point(134, 138);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(67, 73);
            btnCE.TabIndex = 5;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += clickCE;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(64, 64, 64);
            btn9.BackgroundImageLayout = ImageLayout.None;
            btn9.FlatAppearance.BorderColor = Color.Black;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.ForeColor = SystemColors.ControlLightLight;
            btn9.Location = new Point(134, 211);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 73);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += clickNumber;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(64, 64, 64);
            btn3.BackgroundImageLayout = ImageLayout.None;
            btn3.FlatAppearance.BorderColor = Color.Black;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.ForeColor = SystemColors.ControlLightLight;
            btn3.Location = new Point(134, 357);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 73);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += clickNumber;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(64, 64, 64);
            btn6.BackgroundImageLayout = ImageLayout.None;
            btn6.FlatAppearance.BorderColor = Color.Black;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.ForeColor = SystemColors.ControlLightLight;
            btn6.Location = new Point(134, 284);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 73);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += clickNumber;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(64, 64, 64);
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.FlatAppearance.BorderColor = Color.Black;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseOverBackColor = Color.Silver;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(201, 357);
            button9.Name = "button9";
            button9.Size = new Size(67, 73);
            button9.TabIndex = 9;
            button9.Text = "+";
            button9.UseVisualStyleBackColor = false;
            button9.Click += clickOp;
            // 
            // btnMoins
            // 
            btnMoins.BackColor = Color.FromArgb(64, 64, 64);
            btnMoins.BackgroundImageLayout = ImageLayout.None;
            btnMoins.FlatAppearance.BorderColor = Color.Black;
            btnMoins.FlatAppearance.BorderSize = 0;
            btnMoins.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnMoins.FlatStyle = FlatStyle.Flat;
            btnMoins.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMoins.ForeColor = SystemColors.ControlLightLight;
            btnMoins.Location = new Point(201, 284);
            btnMoins.Name = "btnMoins";
            btnMoins.Size = new Size(67, 73);
            btnMoins.TabIndex = 10;
            btnMoins.Text = "-";
            btnMoins.UseVisualStyleBackColor = false;
            btnMoins.Click += clickOp;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = Color.FromArgb(64, 64, 64);
            btnMulti.BackgroundImageLayout = ImageLayout.None;
            btnMulti.FlatAppearance.BorderColor = Color.Black;
            btnMulti.FlatAppearance.BorderSize = 0;
            btnMulti.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnMulti.FlatStyle = FlatStyle.Flat;
            btnMulti.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMulti.ForeColor = SystemColors.ControlLightLight;
            btnMulti.Location = new Point(201, 211);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(67, 73);
            btnMulti.TabIndex = 11;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += clickOp;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.WindowFrame;
            btnDiv.BackgroundImageLayout = ImageLayout.None;
            btnDiv.FlatAppearance.BorderColor = Color.Black;
            btnDiv.FlatAppearance.BorderSize = 0;
            btnDiv.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDiv.ForeColor = SystemColors.ControlLightLight;
            btnDiv.Location = new Point(201, 138);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(67, 73);
            btnDiv.TabIndex = 12;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += clickOp;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(64, 64, 64);
            btn7.BackgroundImageLayout = ImageLayout.None;
            btn7.FlatAppearance.BorderColor = Color.Black;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.ForeColor = SystemColors.ControlLightLight;
            btn7.Location = new Point(0, 211);
            btn7.Name = "btn7";
            btn7.Size = new Size(67, 73);
            btn7.TabIndex = 13;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += clickNumber;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(64, 64, 64);
            btn4.BackgroundImageLayout = ImageLayout.None;
            btn4.FlatAppearance.BorderColor = Color.Black;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.ForeColor = SystemColors.ControlLightLight;
            btn4.Location = new Point(0, 284);
            btn4.Name = "btn4";
            btn4.Size = new Size(67, 73);
            btn4.TabIndex = 14;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += clickNumber;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(64, 64, 64);
            btn1.BackgroundImageLayout = ImageLayout.None;
            btn1.FlatAppearance.BorderColor = Color.Black;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.ControlLightLight;
            btn1.Location = new Point(0, 357);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 73);
            btn1.TabIndex = 15;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += clickNumber;
            // 
            // btnVirgule
            // 
            btnVirgule.BackColor = Color.FromArgb(64, 64, 64);
            btnVirgule.BackgroundImageLayout = ImageLayout.None;
            btnVirgule.FlatAppearance.BorderColor = Color.Black;
            btnVirgule.FlatAppearance.BorderSize = 0;
            btnVirgule.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnVirgule.FlatStyle = FlatStyle.Flat;
            btnVirgule.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVirgule.ForeColor = SystemColors.ControlLightLight;
            btnVirgule.Location = new Point(134, 430);
            btnVirgule.Name = "btnVirgule";
            btnVirgule.Size = new Size(67, 73);
            btnVirgule.TabIndex = 16;
            btnVirgule.Text = ".";
            btnVirgule.UseVisualStyleBackColor = false;
            btnVirgule.Click += clickVirgule;
            // 
            // btnEgal
            // 
            btnEgal.BackColor = Color.FromArgb(64, 64, 64);
            btnEgal.BackgroundImageLayout = ImageLayout.None;
            btnEgal.FlatAppearance.BorderColor = Color.Black;
            btnEgal.FlatAppearance.BorderSize = 0;
            btnEgal.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEgal.FlatStyle = FlatStyle.Flat;
            btnEgal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEgal.ForeColor = SystemColors.ControlLightLight;
            btnEgal.Location = new Point(201, 430);
            btnEgal.Name = "btnEgal";
            btnEgal.Size = new Size(67, 73);
            btnEgal.TabIndex = 17;
            btnEgal.Text = "=";
            btnEgal.UseVisualStyleBackColor = false;
            btnEgal.Click += clickEgal;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(64, 64, 64);
            btn0.BackgroundImageLayout = ImageLayout.None;
            btn0.FlatAppearance.BorderColor = Color.Black;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.ForeColor = SystemColors.ControlLightLight;
            btn0.Location = new Point(0, 430);
            btn0.Name = "btn0";
            btn0.Size = new Size(134, 73);
            btn0.TabIndex = 18;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += clickNumber;
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.ActiveCaptionText;
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Enabled = false;
            txtResult.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.ForeColor = SystemColors.ControlLightLight;
            txtResult.Location = new Point(0, 47);
            txtResult.MaxLength = 3245;
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(268, 71);
            txtResult.TabIndex = 19;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(245, 3);
            button1.Name = "button1";
            button1.Size = new Size(23, 21);
            button1.TabIndex = 25;
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnClose_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(216, 3);
            button2.Name = "button2";
            button2.Size = new Size(23, 21);
            button2.TabIndex = 26;
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnMaximize_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(187, 3);
            button3.Name = "button3";
            button3.Size = new Size(23, 21);
            button3.TabIndex = 27;
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnMinimize_Click;
            // 
            // btnAC
            // 
            btnAC.BackColor = SystemColors.WindowFrame;
            btnAC.BackgroundImageLayout = ImageLayout.None;
            btnAC.FlatAppearance.BorderColor = Color.Black;
            btnAC.FlatAppearance.BorderSize = 0;
            btnAC.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAC.FlatStyle = FlatStyle.Flat;
            btnAC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAC.ForeColor = SystemColors.ControlLightLight;
            btnAC.Location = new Point(0, 138);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(67, 73);
            btnAC.TabIndex = 28;
            btnAC.Text = "AC";
            btnAC.UseVisualStyleBackColor = false;
            btnAC.Click += clickAC;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(267, 501);
            ControlBox = false;
            Controls.Add(btnAC);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtResult);
            Controls.Add(btn0);
            Controls.Add(btnEgal);
            Controls.Add(btnVirgule);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btnDiv);
            Controls.Add(btnMulti);
            Controls.Add(btnMoins);
            Controls.Add(button9);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn9);
            Controls.Add(btnCE);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btnPourcent);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAc;
        private Button btnPourcent;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btnCE;
        private Button btn9;
        private Button btn3;
        private Button btn6;
        private Button button9;
        private Button btnMoins;
        private Button btnMulti;
        private Button btnDiv;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btnVirgule;
        private Button btnEgal;
        private Button btn0;
        private TextBox txtResult;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnAC;
    }
}
