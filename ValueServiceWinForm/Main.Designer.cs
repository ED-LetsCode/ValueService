namespace ValueServiceWinForm
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Button();
            this.WithoutPostfactor = new System.Windows.Forms.TextBox();
            this.ComboBoxPostFactor = new System.Windows.Forms.ComboBox();
            this.Precision = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.WithPostfactor = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precision)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(376, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Value converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "without postfactor";
            // 
            // Convert
            // 
            this.Convert.BackColor = System.Drawing.Color.White;
            this.Convert.Location = new System.Drawing.Point(150, 568);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(107, 23);
            this.Convert.TabIndex = 3;
            this.Convert.Text = "convert";
            this.Convert.UseVisualStyleBackColor = false;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // WithoutPostfactor
            // 
            this.WithoutPostfactor.Location = new System.Drawing.Point(12, 389);
            this.WithoutPostfactor.Name = "WithoutPostfactor";
            this.WithoutPostfactor.Size = new System.Drawing.Size(208, 23);
            this.WithoutPostfactor.TabIndex = 4;
            this.WithoutPostfactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WithoutPostfactor.Click += new System.EventHandler(this.WithoutPostfactor_Click);
            this.WithoutPostfactor.TextChanged += new System.EventHandler(this.WithoutPostfactor_TextChanged);
            // 
            // ComboBoxPostFactor
            // 
            this.ComboBoxPostFactor.FormattingEnabled = true;
            this.ComboBoxPostFactor.Location = new System.Drawing.Point(226, 389);
            this.ComboBoxPostFactor.Name = "ComboBoxPostFactor";
            this.ComboBoxPostFactor.Size = new System.Drawing.Size(101, 23);
            this.ComboBoxPostFactor.TabIndex = 5;
            // 
            // Precision
            // 
            this.Precision.Location = new System.Drawing.Point(333, 389);
            this.Precision.Name = "Precision";
            this.Precision.Size = new System.Drawing.Size(55, 23);
            this.Precision.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(333, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "precision";
            // 
            // WithPostfactor
            // 
            this.WithPostfactor.Location = new System.Drawing.Point(12, 454);
            this.WithPostfactor.Name = "WithPostfactor";
            this.WithPostfactor.Size = new System.Drawing.Size(376, 23);
            this.WithPostfactor.TabIndex = 8;
            this.WithPostfactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WithPostfactor.Click += new System.EventHandler(this.WithPostfactor_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 519);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(376, 23);
            this.Output.TabIndex = 9;
            this.Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "with postfactor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "output";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(400, 603);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.WithPostfactor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Precision);
            this.Controls.Add(this.ComboBoxPostFactor);
            this.Controls.Add(this.WithoutPostfactor);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Value Service";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button Convert;
        private TextBox WithoutPostfactor;
        private ComboBox ComboBoxPostFactor;
        private NumericUpDown Precision;
        private Label label3;
        private TextBox WithPostfactor;
        private TextBox Output;
        private Label label4;
        private Label label5;
    }
}