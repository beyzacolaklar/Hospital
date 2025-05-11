using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void patientManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        private void doctorManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
                DoctorForm doctorForm = new DoctorForm();
                doctorForm.Show();
            }

        private void doctorManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           AppointmentForm appointmentForm = new AppointmentForm();
                appointmentForm.Show();
            }

        private void medicalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MedicalRecordsForm medicalForm = new MedicalRecordsForm();
                medicalForm.Show();
            }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }
    }
    }
    
    

