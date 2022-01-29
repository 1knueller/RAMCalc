using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAMCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcbutton1_Click(object sender, EventArgs e)
        {
            var vm = new GeneratorViewmodel
            {
                CLMin = (int)this.cl_min_numericUpDown3.Value,
                CLMax = (int)this.cl_max_numericUpDown4.Value,
                MTSMax = (int)this.mts_max_numericUpDown2.Value,
                MTSMin = Convert.ToInt32(mts_min_numericUpDown1.Value),
                NSMax = Convert.ToDouble(ns_max_numericUpDown6.Value),
                NSMin = (double)ns_min_numericUpDown5.Value,
            };

            var cfgs = RAMMath.GenerateConfigs(vm);

            this.dataGridView1.DataSource = cfgs;
            this.dataGridView1.AutoResizeColumns();

        }
    }
}
