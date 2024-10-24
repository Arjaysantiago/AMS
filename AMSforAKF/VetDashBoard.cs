using System;
using System.Linq;
using System.Windows.Forms;

namespace AMSforAKF
{
    public partial class VetDashBoard : Form
    {
        public VetDashBoard()
        {
            InitializeComponent();
            mdi();
        }

        private void mdi()
        {
            this.IsMdiContainer = true;
        }

        private void ShowForm<T>() where T : Form, new()
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Close();
                }
            }

            T newForm = new T
            {
                MdiParent = this,
                StartPosition = FormStartPosition.Manual
            };

            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowForm<VetHome>();
        }

        private void btnTreat_Click(object sender, EventArgs e)
        {
            ShowForm<VetTreatment>();
        }
        private void EmergencyIntake_Click(object sender, EventArgs e)
        {
            AnimalR_T rt = new AnimalR_T();
            rt.ShowDialog();
        }

        private void btnKennel_Click(object sender, EventArgs e)
        {
            ShowForm<AnimalVirtualKennel>();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
