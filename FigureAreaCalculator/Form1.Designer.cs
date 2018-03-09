namespace FigureAreaCalculator
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
            this.comboBoxFigures = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.valueHigth = new System.Windows.Forms.TextBox();
            this.valueWidth = new System.Windows.Forms.TextBox();
            this.valueRadius = new System.Windows.Forms.TextBox();
            this.valueLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxFigures
            // 
            this.comboBoxFigures.FormattingEnabled = true;
            this.comboBoxFigures.Location = new System.Drawing.Point(115, 51);
            this.comboBoxFigures.Name = "comboBoxFigures";
            this.comboBoxFigures.Size = new System.Drawing.Size(276, 21);
            this.comboBoxFigures.TabIndex = 0;
            this.comboBoxFigures.SelectedIndexChanged += new System.EventHandler(this.comboBoxFigures_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фигура";
            // 
            // valueHigth
            // 
            this.valueHigth.Location = new System.Drawing.Point(513, 52);
            this.valueHigth.Name = "valueHigth";
            this.valueHigth.Size = new System.Drawing.Size(100, 20);
            this.valueHigth.TabIndex = 2;
            this.valueHigth.TextChanged += new System.EventHandler(this.valueHigth_TextChanged);
            // 
            // valueWidth
            // 
            this.valueWidth.Location = new System.Drawing.Point(513, 102);
            this.valueWidth.Name = "valueWidth";
            this.valueWidth.Size = new System.Drawing.Size(100, 20);
            this.valueWidth.TabIndex = 3;
            this.valueWidth.TextChanged += new System.EventHandler(this.valueWidth_TextChanged);
            // 
            // valueRadius
            // 
            this.valueRadius.Location = new System.Drawing.Point(513, 146);
            this.valueRadius.Name = "valueRadius";
            this.valueRadius.Size = new System.Drawing.Size(100, 20);
            this.valueRadius.TabIndex = 4;
            this.valueRadius.TextChanged += new System.EventHandler(this.valueRadius_TextChanged);
            // 
            // valueLength
            // 
            this.valueLength.Location = new System.Drawing.Point(513, 198);
            this.valueLength.Name = "valueLength";
            this.valueLength.Size = new System.Drawing.Size(100, 20);
            this.valueLength.TabIndex = 5;
            this.valueLength.TextChanged += new System.EventHandler(this.valueLength_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Высота";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ширина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Радиус";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(441, 201);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(40, 13);
            this.length.TabIndex = 9;
            this.length.Text = "Длина";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(34, 102);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(357, 116);
            this.textBoxResult.TabIndex = 10;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(223, 243);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(229, 33);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "Расчитать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 288);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.length);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueLength);
            this.Controls.Add(this.valueRadius);
            this.Controls.Add(this.valueWidth);
            this.Controls.Add(this.valueHigth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFigures);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFigures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueHigth;
        private System.Windows.Forms.TextBox valueWidth;
        private System.Windows.Forms.TextBox valueRadius;
        private System.Windows.Forms.TextBox valueLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonStart;
    }
}

