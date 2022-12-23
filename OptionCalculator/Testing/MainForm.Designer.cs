namespace Options
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRiscInc = new System.Windows.Forms.Button();
            this.btnVolInc = new System.Windows.Forms.Button();
            this.btnBAInc = new System.Windows.Forms.Button();
            this.btnDayInc = new System.Windows.Forms.Button();
            this.btnRiscDesc = new System.Windows.Forms.Button();
            this.btnBADesc = new System.Windows.Forms.Button();
            this.btnDayDesc = new System.Windows.Forms.Button();
            this.btnVolDesc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRisk = new System.Windows.Forms.TextBox();
            this.txtVolat = new System.Windows.Forms.TextBox();
            this.txtPriceBA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCondDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpOptExp = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStrike = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOtpType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bnCalculate = new System.Windows.Forms.Button();
            this.lbRo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbTheta = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbVega = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbGamma = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbDelta = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTheorPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRiscInc);
            this.groupBox1.Controls.Add(this.btnVolInc);
            this.groupBox1.Controls.Add(this.btnBAInc);
            this.groupBox1.Controls.Add(this.btnDayInc);
            this.groupBox1.Controls.Add(this.btnRiscDesc);
            this.groupBox1.Controls.Add(this.btnBADesc);
            this.groupBox1.Controls.Add(this.btnDayDesc);
            this.groupBox1.Controls.Add(this.btnVolDesc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRisk);
            this.groupBox1.Controls.Add(this.txtVolat);
            this.groupBox1.Controls.Add(this.txtPriceBA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpCondDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условия расчета";
            // 
            // btnRiscInc
            // 
            this.btnRiscInc.Location = new System.Drawing.Point(300, 105);
            this.btnRiscInc.Name = "btnRiscInc";
            this.btnRiscInc.Size = new System.Drawing.Size(30, 24);
            this.btnRiscInc.TabIndex = 6;
            this.btnRiscInc.Text = "+";
            this.btnRiscInc.UseVisualStyleBackColor = true;
            this.btnRiscInc.Click += new System.EventHandler(this.btnRiscInc_Click);
            // 
            // btnVolInc
            // 
            this.btnVolInc.Location = new System.Drawing.Point(300, 76);
            this.btnVolInc.Name = "btnVolInc";
            this.btnVolInc.Size = new System.Drawing.Size(30, 24);
            this.btnVolInc.TabIndex = 6;
            this.btnVolInc.Text = "+";
            this.btnVolInc.UseVisualStyleBackColor = true;
            this.btnVolInc.Click += new System.EventHandler(this.btnVolInc_Click);
            // 
            // btnBAInc
            // 
            this.btnBAInc.Location = new System.Drawing.Point(300, 46);
            this.btnBAInc.Name = "btnBAInc";
            this.btnBAInc.Size = new System.Drawing.Size(30, 24);
            this.btnBAInc.TabIndex = 6;
            this.btnBAInc.Text = "+";
            this.btnBAInc.UseVisualStyleBackColor = true;
            this.btnBAInc.Click += new System.EventHandler(this.btnBAInc_Click);
            // 
            // btnDayInc
            // 
            this.btnDayInc.Location = new System.Drawing.Point(300, 19);
            this.btnDayInc.Name = "btnDayInc";
            this.btnDayInc.Size = new System.Drawing.Size(30, 24);
            this.btnDayInc.TabIndex = 6;
            this.btnDayInc.Text = "+";
            this.btnDayInc.UseVisualStyleBackColor = true;
            this.btnDayInc.Click += new System.EventHandler(this.btnDayInc_Click);
            // 
            // btnRiscDesc
            // 
            this.btnRiscDesc.Location = new System.Drawing.Point(262, 105);
            this.btnRiscDesc.Name = "btnRiscDesc";
            this.btnRiscDesc.Size = new System.Drawing.Size(30, 24);
            this.btnRiscDesc.TabIndex = 5;
            this.btnRiscDesc.Text = "-";
            this.btnRiscDesc.UseVisualStyleBackColor = true;
            this.btnRiscDesc.Click += new System.EventHandler(this.btnRiscDesc_Click);
            // 
            // btnBADesc
            // 
            this.btnBADesc.Location = new System.Drawing.Point(262, 47);
            this.btnBADesc.Name = "btnBADesc";
            this.btnBADesc.Size = new System.Drawing.Size(30, 24);
            this.btnBADesc.TabIndex = 5;
            this.btnBADesc.Text = "-";
            this.btnBADesc.UseVisualStyleBackColor = true;
            this.btnBADesc.Click += new System.EventHandler(this.btnBADesc_Click);
            // 
            // btnDayDesc
            // 
            this.btnDayDesc.Location = new System.Drawing.Point(262, 19);
            this.btnDayDesc.Name = "btnDayDesc";
            this.btnDayDesc.Size = new System.Drawing.Size(30, 24);
            this.btnDayDesc.TabIndex = 5;
            this.btnDayDesc.Text = "-";
            this.btnDayDesc.UseVisualStyleBackColor = true;
            this.btnDayDesc.Click += new System.EventHandler(this.btnDayDesc_Click);
            // 
            // btnVolDesc
            // 
            this.btnVolDesc.Location = new System.Drawing.Point(262, 76);
            this.btnVolDesc.Name = "btnVolDesc";
            this.btnVolDesc.Size = new System.Drawing.Size(30, 24);
            this.btnVolDesc.TabIndex = 5;
            this.btnVolDesc.Text = "-";
            this.btnVolDesc.UseVisualStyleBackColor = true;
            this.btnVolDesc.Click += new System.EventHandler(this.btnVolDesc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Безриск.ставка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Волатильность";
            // 
            // txtRisk
            // 
            this.txtRisk.Location = new System.Drawing.Point(112, 106);
            this.txtRisk.Name = "txtRisk";
            this.txtRisk.Size = new System.Drawing.Size(141, 23);
            this.txtRisk.TabIndex = 3;
            this.txtRisk.Text = "7,5";
            // 
            // txtVolat
            // 
            this.txtVolat.Location = new System.Drawing.Point(112, 77);
            this.txtVolat.Name = "txtVolat";
            this.txtVolat.Size = new System.Drawing.Size(141, 23);
            this.txtVolat.TabIndex = 3;
            this.txtVolat.Text = "20";
            // 
            // txtPriceBA
            // 
            this.txtPriceBA.Location = new System.Drawing.Point(112, 48);
            this.txtPriceBA.Name = "txtPriceBA";
            this.txtPriceBA.Size = new System.Drawing.Size(141, 23);
            this.txtPriceBA.TabIndex = 3;
            this.txtPriceBA.Text = "10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена БА";
            // 
            // dtpCondDate
            // 
            this.dtpCondDate.Location = new System.Drawing.Point(112, 19);
            this.dtpCondDate.Name = "dtpCondDate";
            this.dtpCondDate.Size = new System.Drawing.Size(141, 23);
            this.dtpCondDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpOptExp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtStrike);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbOtpType);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Опцион";
            // 
            // dtpOptExp
            // 
            this.dtpOptExp.Location = new System.Drawing.Point(112, 74);
            this.dtpOptExp.Name = "dtpOptExp";
            this.dtpOptExp.Size = new System.Drawing.Size(141, 23);
            this.dtpOptExp.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Дата истечения";
            // 
            // txtStrike
            // 
            this.txtStrike.Location = new System.Drawing.Point(112, 45);
            this.txtStrike.Name = "txtStrike";
            this.txtStrike.Size = new System.Drawing.Size(109, 23);
            this.txtStrike.TabIndex = 4;
            this.txtStrike.Text = "10000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Страйк";
            // 
            // cmbOtpType
            // 
            this.cmbOtpType.FormattingEnabled = true;
            this.cmbOtpType.Items.AddRange(new object[] {
            "CALL",
            "PUT"});
            this.cmbOtpType.Location = new System.Drawing.Point(112, 16);
            this.cmbOtpType.Name = "cmbOtpType";
            this.cmbOtpType.Size = new System.Drawing.Size(109, 23);
            this.cmbOtpType.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Тип";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bnCalculate);
            this.groupBox3.Controls.Add(this.lbRo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lbTheta);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lbVega);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lbGamma);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lbDelta);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lbTheorPrice);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(370, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 255);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результаты";
            // 
            // bnCalculate
            // 
            this.bnCalculate.Location = new System.Drawing.Point(130, 163);
            this.bnCalculate.Name = "bnCalculate";
            this.bnCalculate.Size = new System.Drawing.Size(88, 23);
            this.bnCalculate.TabIndex = 13;
            this.bnCalculate.Text = "Рассчитать";
            this.bnCalculate.UseVisualStyleBackColor = true;
            this.bnCalculate.Click += new System.EventHandler(this.bnCalculate_Click);
            // 
            // lbRo
            // 
            this.lbRo.AutoSize = true;
            this.lbRo.Location = new System.Drawing.Point(167, 126);
            this.lbRo.Name = "lbRo";
            this.lbRo.Size = new System.Drawing.Size(38, 15);
            this.lbRo.TabIndex = 12;
            this.lbRo.Text = "label9";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 15);
            this.label15.TabIndex = 11;
            this.label15.Text = "Ro";
            // 
            // lbTheta
            // 
            this.lbTheta.AutoSize = true;
            this.lbTheta.Location = new System.Drawing.Point(167, 111);
            this.lbTheta.Name = "lbTheta";
            this.lbTheta.Size = new System.Drawing.Size(38, 15);
            this.lbTheta.TabIndex = 10;
            this.lbTheta.Text = "label9";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Theta";
            // 
            // lbVega
            // 
            this.lbVega.AutoSize = true;
            this.lbVega.Location = new System.Drawing.Point(167, 96);
            this.lbVega.Name = "lbVega";
            this.lbVega.Size = new System.Drawing.Size(38, 15);
            this.lbVega.TabIndex = 8;
            this.lbVega.Text = "label9";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Vega";
            // 
            // lbGamma
            // 
            this.lbGamma.AutoSize = true;
            this.lbGamma.Location = new System.Drawing.Point(167, 82);
            this.lbGamma.Name = "lbGamma";
            this.lbGamma.Size = new System.Drawing.Size(38, 15);
            this.lbGamma.TabIndex = 6;
            this.lbGamma.Text = "label9";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Gamma";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Греки";
            // 
            // lbDelta
            // 
            this.lbDelta.AutoSize = true;
            this.lbDelta.Location = new System.Drawing.Point(167, 67);
            this.lbDelta.Name = "lbDelta";
            this.lbDelta.Size = new System.Drawing.Size(38, 15);
            this.lbDelta.TabIndex = 3;
            this.lbDelta.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Delta";
            // 
            // lbTheorPrice
            // 
            this.lbTheorPrice.AutoSize = true;
            this.lbTheorPrice.Location = new System.Drawing.Point(167, 19);
            this.lbTheorPrice.Name = "lbTheorPrice";
            this.lbTheorPrice.Size = new System.Drawing.Size(38, 15);
            this.lbTheorPrice.TabIndex = 1;
            this.lbTheorPrice.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Теоретич.цена";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 290);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpCondDate;
        private Label label1;
        private Button btnRiscInc;
        private Button btnVolInc;
        private Button btnBAInc;
        private Button btnDayInc;
        private Button btnRiscDesc;
        private Button btnBADesc;
        private Button btnDayDesc;
        private Button btnVolDesc;
        private Label label4;
        private Label label3;
        private TextBox txtRisk;
        private TextBox txtVolat;
        private TextBox txtPriceBA;
        private Label label2;
        private GroupBox groupBox2;
        private DateTimePicker dtpOptExp;
        private Label label7;
        private TextBox txtStrike;
        private Label label6;
        private ComboBox cmbOtpType;
        private Label label5;
        private GroupBox groupBox3;
        private Label label11;
        private Label lbDelta;
        private Label label10;
        private Label lbTheorPrice;
        private Label label8;
        private Label lbRo;
        private Label label15;
        private Label lbTheta;
        private Label label14;
        private Label lbVega;
        private Label label13;
        private Label lbGamma;
        private Label label12;
        private Button bnCalculate;
    }
}