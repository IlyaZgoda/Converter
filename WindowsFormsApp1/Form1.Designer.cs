namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fromSysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.toSysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberTextBox2 = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromSysNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toSysNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 412);
            this.panel1.TabIndex = 0;
            // 
            // tPanel
            // 
            this.tPanel.ColumnCount = 1;
            this.tPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tPanel.Location = new System.Drawing.Point(12, 12);
            this.tPanel.Name = "tPanel";
            this.tPanel.RowCount = 1;
            this.tPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tPanel.Size = new System.Drawing.Size(673, 394);
            this.tPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numberTextBox2);
            this.panel2.Controls.Add(this.toSysNumericUpDown);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1372, 433);
            this.panel2.TabIndex = 1;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Enabled = false;
            this.numberTextBox.Location = new System.Drawing.Point(367, 47);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.ReadOnly = true;
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ClearButton);
            this.panel3.Controls.Add(this.numberTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.fromSysNumericUpDown);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 433);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите систему считсления";
            // 
            // fromSysNumericUpDown
            // 
            this.fromSysNumericUpDown.Location = new System.Drawing.Point(12, 48);
            this.fromSysNumericUpDown.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.fromSysNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fromSysNumericUpDown.Name = "fromSysNumericUpDown";
            this.fromSysNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.fromSysNumericUpDown.TabIndex = 0;
            this.fromSysNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fromSysNumericUpDown.ValueChanged += new System.EventHandler(this.fromSysNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(702, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите вторичную систему считсления";
            // 
            // toSysNumericUpDown
            // 
            this.toSysNumericUpDown.Location = new System.Drawing.Point(701, 49);
            this.toSysNumericUpDown.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.toSysNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.toSysNumericUpDown.Name = "toSysNumericUpDown";
            this.toSysNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.toSysNumericUpDown.TabIndex = 2;
            this.toSysNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.toSysNumericUpDown.ValueChanged += new System.EventHandler(this.toSysNumericUpDown_ValueChanged);
            // 
            // numberTextBox2
            // 
            this.numberTextBox2.Enabled = false;
            this.numberTextBox2.Location = new System.Drawing.Point(1107, 48);
            this.numberTextBox2.Name = "numberTextBox2";
            this.numberTextBox2.ReadOnly = true;
            this.numberTextBox2.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox2.TabIndex = 1;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(16, 84);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 845);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Преобразователь для систм счистления";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromSysNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toSysNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tPanel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown fromSysNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown toSysNumericUpDown;
        private System.Windows.Forms.TextBox numberTextBox2;
        private System.Windows.Forms.Button ClearButton;
    }
}

