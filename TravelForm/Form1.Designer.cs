namespace TravelForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.daysNumber = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceValue = new System.Windows.Forms.Label();
            this.buttonSummer = new System.Windows.Forms.RadioButton();
            this.buttonWinter = new System.Windows.Forms.RadioButton();
            this.checkBoxGuide = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.peopleNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Країна:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кількість днів:";
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountries.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Items.AddRange(new object[] {
            "Болгарія",
            "Німеччина",
            "Польща"});
            this.comboBoxCountries.Location = new System.Drawing.Point(173, 36);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(178, 32);
            this.comboBoxCountries.TabIndex = 2;
            // 
            // daysNumber
            // 
            this.daysNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daysNumber.Location = new System.Drawing.Point(173, 89);
            this.daysNumber.Name = "daysNumber";
            this.daysNumber.Size = new System.Drawing.Size(96, 30);
            this.daysNumber.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(391, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Розрахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(388, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сезон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(37, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вартість:";
            // 
            // priceValue
            // 
            this.priceValue.AutoSize = true;
            this.priceValue.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceValue.ForeColor = System.Drawing.Color.Firebrick;
            this.priceValue.Location = new System.Drawing.Point(143, 227);
            this.priceValue.Name = "priceValue";
            this.priceValue.Size = new System.Drawing.Size(0, 27);
            this.priceValue.TabIndex = 7;
            // 
            // buttonSummer
            // 
            this.buttonSummer.AutoSize = true;
            this.buttonSummer.Checked = true;
            this.buttonSummer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSummer.Location = new System.Drawing.Point(391, 64);
            this.buttonSummer.Name = "buttonSummer";
            this.buttonSummer.Size = new System.Drawing.Size(62, 28);
            this.buttonSummer.TabIndex = 8;
            this.buttonSummer.TabStop = true;
            this.buttonSummer.Text = "Літо";
            this.buttonSummer.UseVisualStyleBackColor = true;
            // 
            // buttonWinter
            // 
            this.buttonWinter.AutoSize = true;
            this.buttonWinter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWinter.Location = new System.Drawing.Point(391, 91);
            this.buttonWinter.Name = "buttonWinter";
            this.buttonWinter.Size = new System.Drawing.Size(70, 28);
            this.buttonWinter.TabIndex = 9;
            this.buttonWinter.Text = "Зима";
            this.buttonWinter.UseVisualStyleBackColor = true;
            // 
            // checkBoxGuide
            // 
            this.checkBoxGuide.AutoSize = true;
            this.checkBoxGuide.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxGuide.Location = new System.Drawing.Point(393, 140);
            this.checkBoxGuide.Name = "checkBoxGuide";
            this.checkBoxGuide.Size = new System.Drawing.Size(175, 28);
            this.checkBoxGuide.TabIndex = 10;
            this.checkBoxGuide.Text = "Індивідуальний гід";
            this.checkBoxGuide.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(431, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дольна О.І., гр. СН-21";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(38, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Кількість осіб:";
            // 
            // peopleNumber
            // 
            this.peopleNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.peopleNumber.Location = new System.Drawing.Point(173, 144);
            this.peopleNumber.Name = "peopleNumber";
            this.peopleNumber.Size = new System.Drawing.Size(96, 30);
            this.peopleNumber.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 325);
            this.Controls.Add(this.peopleNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxGuide);
            this.Controls.Add(this.buttonWinter);
            this.Controls.Add(this.buttonSummer);
            this.Controls.Add(this.priceValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.daysNumber);
            this.Controls.Add(this.comboBoxCountries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(799, 487);
            this.MinimumSize = new System.Drawing.Size(656, 372);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тур на відпочинок";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daysNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.NumericUpDown daysNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label priceValue;
        private System.Windows.Forms.RadioButton buttonSummer;
        private System.Windows.Forms.RadioButton buttonWinter;
        private System.Windows.Forms.CheckBox checkBoxGuide;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown peopleNumber;
    }
}

