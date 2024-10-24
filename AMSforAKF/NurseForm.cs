using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMSforAKF
{
    public partial class NurseForm : Form
    {
        public NurseForm()
        {
            InitializeComponent();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAMS frmAMS = new frmAMS();
            frmAMS.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ServiceForm sf = new ServiceForm();
            sf.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MedicineForm medicineForm = new MedicineForm();
            medicineForm.Show();
            this.Hide();
        }
    }
}
