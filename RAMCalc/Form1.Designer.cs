
namespace RAMCalc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mts_max_numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cllabel2 = new System.Windows.Forms.Label();
            this.ramspeed_label1 = new System.Windows.Forms.Label();
            this.ns_max_numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.ns_min_numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.calcbutton1 = new System.Windows.Forms.Button();
            this.cl_max_numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.cl_min_numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.mts_min_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mts_max_numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ns_max_numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ns_min_numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_max_numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_min_numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mts_min_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mts_max_numericUpDown2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cllabel2);
            this.panel1.Controls.Add(this.ramspeed_label1);
            this.panel1.Controls.Add(this.ns_max_numericUpDown6);
            this.panel1.Controls.Add(this.ns_min_numericUpDown5);
            this.panel1.Controls.Add(this.calcbutton1);
            this.panel1.Controls.Add(this.cl_max_numericUpDown4);
            this.panel1.Controls.Add(this.cl_min_numericUpDown3);
            this.panel1.Controls.Add(this.mts_min_numericUpDown1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 85);
            this.panel1.TabIndex = 0;
            // 
            // mts_max_numericUpDown2
            // 
            this.mts_max_numericUpDown2.Location = new System.Drawing.Point(4, 58);
            this.mts_max_numericUpDown2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mts_max_numericUpDown2.Name = "mts_max_numericUpDown2";
            this.mts_max_numericUpDown2.Size = new System.Drawing.Size(120, 23);
            this.mts_max_numericUpDown2.TabIndex = 10;
            this.mts_max_numericUpDown2.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "ns";
            // 
            // cllabel2
            // 
            this.cllabel2.AutoSize = true;
            this.cllabel2.Location = new System.Drawing.Point(129, 8);
            this.cllabel2.Name = "cllabel2";
            this.cllabel2.Size = new System.Drawing.Size(16, 15);
            this.cllabel2.TabIndex = 8;
            this.cllabel2.Text = "cl";
            // 
            // ramspeed_label1
            // 
            this.ramspeed_label1.AutoSize = true;
            this.ramspeed_label1.Location = new System.Drawing.Point(4, 8);
            this.ramspeed_label1.Name = "ramspeed_label1";
            this.ramspeed_label1.Size = new System.Drawing.Size(30, 15);
            this.ramspeed_label1.TabIndex = 7;
            this.ramspeed_label1.Text = "mhz";
            // 
            // ns_max_numericUpDown6
            // 
            this.ns_max_numericUpDown6.DecimalPlaces = 2;
            this.ns_max_numericUpDown6.Location = new System.Drawing.Point(255, 58);
            this.ns_max_numericUpDown6.Name = "ns_max_numericUpDown6";
            this.ns_max_numericUpDown6.Size = new System.Drawing.Size(120, 23);
            this.ns_max_numericUpDown6.TabIndex = 6;
            this.ns_max_numericUpDown6.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // ns_min_numericUpDown5
            // 
            this.ns_min_numericUpDown5.DecimalPlaces = 2;
            this.ns_min_numericUpDown5.Location = new System.Drawing.Point(255, 29);
            this.ns_min_numericUpDown5.Name = "ns_min_numericUpDown5";
            this.ns_min_numericUpDown5.Size = new System.Drawing.Size(120, 23);
            this.ns_min_numericUpDown5.TabIndex = 5;
            this.ns_min_numericUpDown5.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // calcbutton1
            // 
            this.calcbutton1.Location = new System.Drawing.Point(381, 29);
            this.calcbutton1.Name = "calcbutton1";
            this.calcbutton1.Size = new System.Drawing.Size(103, 52);
            this.calcbutton1.TabIndex = 4;
            this.calcbutton1.Text = "CALC";
            this.calcbutton1.UseVisualStyleBackColor = true;
            this.calcbutton1.Click += new System.EventHandler(this.calcbutton1_Click);
            // 
            // cl_max_numericUpDown4
            // 
            this.cl_max_numericUpDown4.Location = new System.Drawing.Point(129, 58);
            this.cl_max_numericUpDown4.Name = "cl_max_numericUpDown4";
            this.cl_max_numericUpDown4.Size = new System.Drawing.Size(120, 23);
            this.cl_max_numericUpDown4.TabIndex = 3;
            this.cl_max_numericUpDown4.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // cl_min_numericUpDown3
            // 
            this.cl_min_numericUpDown3.Location = new System.Drawing.Point(129, 29);
            this.cl_min_numericUpDown3.Name = "cl_min_numericUpDown3";
            this.cl_min_numericUpDown3.Size = new System.Drawing.Size(120, 23);
            this.cl_min_numericUpDown3.TabIndex = 2;
            this.cl_min_numericUpDown3.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // mts_min_numericUpDown1
            // 
            this.mts_min_numericUpDown1.Location = new System.Drawing.Point(3, 29);
            this.mts_min_numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mts_min_numericUpDown1.Name = "mts_min_numericUpDown1";
            this.mts_min_numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.mts_min_numericUpDown1.TabIndex = 0;
            this.mts_min_numericUpDown1.Value = new decimal(new int[] {
            2800,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(616, 359);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 444);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mts_max_numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ns_max_numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ns_min_numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_max_numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_min_numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mts_min_numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown mts_max_numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cllabel2;
        private System.Windows.Forms.Label ramspeed_label1;
        private System.Windows.Forms.NumericUpDown ns_max_numericUpDown6;
        private System.Windows.Forms.NumericUpDown ns_min_numericUpDown5;
        private System.Windows.Forms.Button calcbutton1;
        private System.Windows.Forms.NumericUpDown cl_max_numericUpDown4;
        private System.Windows.Forms.NumericUpDown cl_min_numericUpDown3;
        private System.Windows.Forms.NumericUpDown mts_min_numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

