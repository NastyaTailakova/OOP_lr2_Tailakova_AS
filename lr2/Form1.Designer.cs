
namespace lr2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chkMilk = new System.Windows.Forms.CheckBox();
            this.chkSugar = new System.Windows.Forms.CheckBox();
            this.cmbCoffeeType = new System.Windows.Forms.ComboBox();
            this.txtCups = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(49, 302);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(50, 17);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "Итого:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalculate.Location = new System.Drawing.Point(130, 245);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 30);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // chkMilk
            // 
            this.chkMilk.AutoSize = true;
            this.chkMilk.Location = new System.Drawing.Point(52, 193);
            this.chkMilk.Name = "chkMilk";
            this.chkMilk.Size = new System.Drawing.Size(137, 21);
            this.chkMilk.TabIndex = 13;
            this.chkMilk.Text = "Молоко / сливки";
            this.chkMilk.UseVisualStyleBackColor = true;
            // 
            // chkSugar
            // 
            this.chkSugar.AutoSize = true;
            this.chkSugar.Location = new System.Drawing.Point(52, 146);
            this.chkSugar.Name = "chkSugar";
            this.chkSugar.Size = new System.Drawing.Size(69, 21);
            this.chkSugar.TabIndex = 12;
            this.chkSugar.Text = "Сахар";
            this.chkSugar.UseVisualStyleBackColor = true;
            // 
            // cmbCoffeeType
            // 
            this.cmbCoffeeType.FormattingEnabled = true;
            this.cmbCoffeeType.Items.AddRange(new object[] {
            "Американо",
            "Эспрессо",
            "Латте",
            "Капучино",
            "Мокачино"});
            this.cmbCoffeeType.Location = new System.Drawing.Point(130, 93);
            this.cmbCoffeeType.Name = "cmbCoffeeType";
            this.cmbCoffeeType.Size = new System.Drawing.Size(171, 24);
            this.cmbCoffeeType.TabIndex = 11;
            // 
            // txtCups
            // 
            this.txtCups.Location = new System.Drawing.Point(201, 48);
            this.txtCups.Name = "txtCups";
            this.txtCups.Size = new System.Drawing.Size(100, 22);
            this.txtCups.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Тип кофе:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Количество чашек:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkMilk);
            this.Controls.Add(this.chkSugar);
            this.Controls.Add(this.cmbCoffeeType);
            this.Controls.Add(this.txtCups);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chkMilk;
        private System.Windows.Forms.CheckBox chkSugar;
        private System.Windows.Forms.ComboBox cmbCoffeeType;
        private System.Windows.Forms.TextBox txtCups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

