namespace ReteaNeuronala
{
    partial class First
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numeric_iesire = new System.Windows.Forms.NumericUpDown();
            this.numeric_intrare = new System.Windows.Forms.NumericUpDown();
            this.numeric_Strat = new System.Windows.Forms.NumericUpDown();
            this.Creare = new System.Windows.Forms.Button();
            this.Functie1_iesire = new System.Windows.Forms.ComboBox();
            this.Functie2_iesire = new System.Windows.Forms.ComboBox();
            this.g_iesire = new System.Windows.Forms.NumericUpDown();
            this.p_iesire = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_iesire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_intrare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Strat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_iesire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_iesire)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numar neuroni stratul de iesire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numar neuroni stratul de intrare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numar straturi ascunse";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(31, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(31, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 165);
            this.panel1.TabIndex = 0;
            // 
            // numeric_iesire
            // 
            this.numeric_iesire.Location = new System.Drawing.Point(611, 81);
            this.numeric_iesire.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_iesire.Name = "numeric_iesire";
            this.numeric_iesire.Size = new System.Drawing.Size(82, 20);
            this.numeric_iesire.TabIndex = 4;
            this.numeric_iesire.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeric_intrare
            // 
            this.numeric_intrare.Location = new System.Drawing.Point(611, 37);
            this.numeric_intrare.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_intrare.Name = "numeric_intrare";
            this.numeric_intrare.Size = new System.Drawing.Size(82, 20);
            this.numeric_intrare.TabIndex = 5;
            this.numeric_intrare.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeric_Strat
            // 
            this.numeric_Strat.Location = new System.Drawing.Point(611, 127);
            this.numeric_Strat.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numeric_Strat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Strat.Name = "numeric_Strat";
            this.numeric_Strat.Size = new System.Drawing.Size(82, 20);
            this.numeric_Strat.TabIndex = 6;
            this.numeric_Strat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Strat.ValueChanged += new System.EventHandler(this.Numeric_Ascunse_ValueChanged);
            // 
            // Creare
            // 
            this.Creare.Location = new System.Drawing.Point(271, 377);
            this.Creare.Name = "Creare";
            this.Creare.Size = new System.Drawing.Size(151, 58);
            this.Creare.TabIndex = 7;
            this.Creare.Text = "Creare";
            this.Creare.UseVisualStyleBackColor = true;
            this.Creare.Click += new System.EventHandler(this.Creare_Click);
            // 
            // Functie1_iesire
            // 
            this.Functie1_iesire.FormattingEnabled = true;
            this.Functie1_iesire.Location = new System.Drawing.Point(499, 62);
            this.Functie1_iesire.Name = "Functie1_iesire";
            this.Functie1_iesire.Size = new System.Drawing.Size(96, 21);
            this.Functie1_iesire.TabIndex = 8;
            // 
            // Functie2_iesire
            // 
            this.Functie2_iesire.FormattingEnabled = true;
            this.Functie2_iesire.Location = new System.Drawing.Point(499, 102);
            this.Functie2_iesire.Name = "Functie2_iesire";
            this.Functie2_iesire.Size = new System.Drawing.Size(96, 21);
            this.Functie2_iesire.TabIndex = 9;
            // 
            // g_iesire
            // 
            this.g_iesire.DecimalPlaces = 2;
            this.g_iesire.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.g_iesire.Location = new System.Drawing.Point(350, 80);
            this.g_iesire.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.g_iesire.Name = "g_iesire";
            this.g_iesire.Size = new System.Drawing.Size(54, 20);
            this.g_iesire.TabIndex = 10;
            this.g_iesire.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // p_iesire
            // 
            this.p_iesire.DecimalPlaces = 2;
            this.p_iesire.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.p_iesire.Location = new System.Drawing.Point(427, 80);
            this.p_iesire.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.p_iesire.Name = "p_iesire";
            this.p_iesire.Size = new System.Drawing.Size(54, 20);
            this.p_iesire.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "g";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "p";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(372, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Binar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 447);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p_iesire);
            this.Controls.Add(this.g_iesire);
            this.Controls.Add(this.Functie2_iesire);
            this.Controls.Add(this.Functie1_iesire);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Creare);
            this.Controls.Add(this.numeric_Strat);
            this.Controls.Add(this.numeric_intrare);
            this.Controls.Add(this.numeric_iesire);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "First";
            this.Text = "First";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_iesire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_intrare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Strat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_iesire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_iesire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numeric_iesire;
        private System.Windows.Forms.NumericUpDown numeric_intrare;
        private System.Windows.Forms.NumericUpDown numeric_Strat;
        private System.Windows.Forms.Button Creare;
        private System.Windows.Forms.ComboBox Functie1_iesire;
        private System.Windows.Forms.ComboBox Functie2_iesire;
        private System.Windows.Forms.NumericUpDown g_iesire;
        private System.Windows.Forms.NumericUpDown p_iesire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}