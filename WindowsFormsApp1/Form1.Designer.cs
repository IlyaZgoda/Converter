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
            this.toSysClearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toSysNumberTextBox = new System.Windows.Forms.TextBox();
            this.toSysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fromSysNumberTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fromSysClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fromSysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fromSysClearLastButton = new System.Windows.Forms.Button();
            this.toSysClearLastButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toSysNumericUpDown)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromSysNumericUpDown)).BeginInit();
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
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.toSysClearLastButton);
            this.panel2.Controls.Add(this.toSysClearButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.toSysNumberTextBox);
            this.panel2.Controls.Add(this.toSysNumericUpDown);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1372, 433);
            this.panel2.TabIndex = 1;
            // 
            // toSysClearButton
            // 
            this.toSysClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toSysClearButton.Location = new System.Drawing.Point(1109, 136);
            this.toSysClearButton.Name = "toSysClearButton";
            this.toSysClearButton.Size = new System.Drawing.Size(103, 34);
            this.toSysClearButton.TabIndex = 3;
            this.toSysClearButton.Text = "Очистить";
            this.toSysClearButton.UseVisualStyleBackColor = true;
            this.toSysClearButton.Click += new System.EventHandler(this.toSysClearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(702, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите вторичную систему счистления";
            // 
            // toSysNumberTextBox
            // 
            this.toSysNumberTextBox.Enabled = false;
            this.toSysNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toSysNumberTextBox.Location = new System.Drawing.Point(1112, 63);
            this.toSysNumberTextBox.Name = "toSysNumberTextBox";
            this.toSysNumberTextBox.ReadOnly = true;
            this.toSysNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.toSysNumberTextBox.TabIndex = 1;
            // 
            // toSysNumericUpDown
            // 
            this.toSysNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toSysNumericUpDown.Location = new System.Drawing.Point(706, 64);
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
            this.toSysNumericUpDown.Size = new System.Drawing.Size(80, 26);
            this.toSysNumericUpDown.TabIndex = 2;
            this.toSysNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.toSysNumericUpDown.ValueChanged += new System.EventHandler(this.toSysNumericUpDown_ValueChanged);
            // 
            // fromSysNumberTextBox
            // 
            this.fromSysNumberTextBox.Enabled = false;
            this.fromSysNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromSysNumberTextBox.Location = new System.Drawing.Point(367, 63);
            this.fromSysNumberTextBox.Name = "fromSysNumberTextBox";
            this.fromSysNumberTextBox.ReadOnly = true;
            this.fromSysNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.fromSysNumberTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.fromSysClearLastButton);
            this.panel3.Controls.Add(this.fromSysClearButton);
            this.panel3.Controls.Add(this.fromSysNumberTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.fromSysNumericUpDown);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 433);
            this.panel3.TabIndex = 1;
            // 
            // fromSysClearButton
            // 
            this.fromSysClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromSysClearButton.Location = new System.Drawing.Point(364, 136);
            this.fromSysClearButton.Name = "fromSysClearButton";
            this.fromSysClearButton.Size = new System.Drawing.Size(103, 34);
            this.fromSysClearButton.TabIndex = 2;
            this.fromSysClearButton.Text = "Очистить";
            this.fromSysClearButton.UseVisualStyleBackColor = true;
            this.fromSysClearButton.Click += new System.EventHandler(this.fromClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите систему счистления";
            // 
            // fromSysNumericUpDown
            // 
            this.fromSysNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromSysNumericUpDown.Location = new System.Drawing.Point(12, 64);
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
            this.fromSysNumericUpDown.Size = new System.Drawing.Size(80, 26);
            this.fromSysNumericUpDown.TabIndex = 0;
            this.fromSysNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fromSysNumericUpDown.ValueChanged += new System.EventHandler(this.fromSysNumericUpDown_ValueChanged);
            // 
            // fromSysClearLastButton
            // 
            this.fromSysClearLastButton.Location = new System.Drawing.Point(462, 63);
            this.fromSysClearLastButton.Name = "fromSysClearLastButton";
            this.fromSysClearLastButton.Size = new System.Drawing.Size(46, 26);
            this.fromSysClearLastButton.TabIndex = 3;
            this.fromSysClearLastButton.Text = "<<";
            this.fromSysClearLastButton.UseVisualStyleBackColor = true;
            this.fromSysClearLastButton.Click += new System.EventHandler(this.fromSysClearLastButton_Click);
            // 
            // toSysClearLastButton
            // 
            this.toSysClearLastButton.Location = new System.Drawing.Point(1208, 63);
            this.toSysClearLastButton.Name = "toSysClearLastButton";
            this.toSysClearLastButton.Size = new System.Drawing.Size(46, 26);
            this.toSysClearLastButton.TabIndex = 4;
            this.toSysClearLastButton.Text = "<<";
            this.toSysClearLastButton.UseVisualStyleBackColor = true;
            this.toSysClearLastButton.Click += new System.EventHandler(this.toSysClearLastButton_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.toSysNumericUpDown)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromSysNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tPanel;
        private System.Windows.Forms.TextBox fromSysNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown fromSysNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown toSysNumericUpDown;
        private System.Windows.Forms.TextBox toSysNumberTextBox;
        private System.Windows.Forms.Button fromSysClearButton;
        private System.Windows.Forms.Button toSysClearButton;
        private System.Windows.Forms.Button toSysClearLastButton;
        private System.Windows.Forms.Button fromSysClearLastButton;
    }
}

