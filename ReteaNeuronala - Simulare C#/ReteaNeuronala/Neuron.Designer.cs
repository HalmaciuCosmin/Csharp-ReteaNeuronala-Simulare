namespace ReteaNeuronala
{
    partial class Neuron
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
            this.Func1 = new System.Windows.Forms.Label();
            this.Func2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.g_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.p_label = new System.Windows.Forms.Label();
            this.Outpu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NGID = new System.Windows.Forms.NumericUpDown();
            this.Output = new System.Windows.Forms.NumericUpDown();
            this.Save = new System.Windows.Forms.Button();
            this.RB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NGID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 313);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Func1
            // 
            this.Func1.AutoSize = true;
            this.Func1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Func1.Location = new System.Drawing.Point(316, 38);
            this.Func1.Name = "Func1";
            this.Func1.Size = new System.Drawing.Size(60, 24);
            this.Func1.TabIndex = 9;
            this.Func1.Text = "label1";
            // 
            // Func2
            // 
            this.Func2.AutoSize = true;
            this.Func2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Func2.Location = new System.Drawing.Point(316, 99);
            this.Func2.Name = "Func2";
            this.Func2.Size = new System.Drawing.Size(60, 24);
            this.Func2.TabIndex = 10;
            this.Func2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "g:";
            // 
            // g_label
            // 
            this.g_label.AutoSize = true;
            this.g_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g_label.Location = new System.Drawing.Point(348, 170);
            this.g_label.Name = "g_label";
            this.g_label.Size = new System.Drawing.Size(60, 24);
            this.g_label.TabIndex = 12;
            this.g_label.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "p:";
            // 
            // p_label
            // 
            this.p_label.AutoSize = true;
            this.p_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_label.Location = new System.Drawing.Point(348, 224);
            this.p_label.Name = "p_label";
            this.p_label.Size = new System.Drawing.Size(60, 24);
            this.p_label.TabIndex = 14;
            this.p_label.Text = "label6";
            // 
            // Outpu
            // 
            this.Outpu.AutoSize = true;
            this.Outpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outpu.Location = new System.Drawing.Point(316, 328);
            this.Outpu.Name = "Outpu";
            this.Outpu.Size = new System.Drawing.Size(71, 24);
            this.Outpu.TabIndex = 15;
            this.Outpu.Text = "Output:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "GID:";
            // 
            // NGID
            // 
            this.NGID.DecimalPlaces = 5;
            this.NGID.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NGID.Location = new System.Drawing.Point(393, 275);
            this.NGID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NGID.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.NGID.Name = "NGID";
            this.NGID.ReadOnly = true;
            this.NGID.Size = new System.Drawing.Size(82, 20);
            this.NGID.TabIndex = 17;
            // 
            // Output
            // 
            this.Output.DecimalPlaces = 5;
            this.Output.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Output.Location = new System.Drawing.Point(393, 328);
            this.Output.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Output.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(82, 20);
            this.Output.TabIndex = 18;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(216, 395);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(126, 42);
            this.Save.TabIndex = 19;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // RB
            // 
            this.RB.AutoSize = true;
            this.RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB.Location = new System.Drawing.Point(427, 384);
            this.RB.Name = "RB";
            this.RB.Size = new System.Drawing.Size(71, 24);
            this.RB.TabIndex = 20;
            this.RB.Text = "Output:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 313);
            this.panel1.TabIndex = 21;
            // 
            // Neuron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 458);
            this.Controls.Add(this.RB);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.NGID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Outpu);
            this.Controls.Add(this.p_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.g_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Func2);
            this.Controls.Add(this.Func1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Neuron";
            this.Text = "Neuron";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NGID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Func1;
        private System.Windows.Forms.Label Func2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label g_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label p_label;
        private System.Windows.Forms.Label Outpu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NGID;
        private System.Windows.Forms.NumericUpDown Output;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label RB;
        private System.Windows.Forms.Panel panel1;
    }
}