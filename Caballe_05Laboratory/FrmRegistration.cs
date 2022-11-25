using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caballe_05Laboratory
{
    public partial class FrmRegistration : Form
    {
        public static string userInfo;
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string[] userInfo = {
                "Student No. :" + txtStudentNo.Text,
                "Full Name:" + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMiddleInitial.Text,
                "Program: " + comboBoxProgram.Text,
                "Gender: " + comboBoxGender.Text,
                "Age: " + txtAge.Text,
                "Birthday :" + dateBirthday.Text,
                "Contact No." + txtContactNo.Text
            };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            FrmFileName filename = new FrmFileName();
            filename.ShowDialog();

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                foreach (string info in userInfo)
                {
                    outputFile.WriteLine(info);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudentRecord studentrecord = new FrmStudentRecord();
            studentrecord.ShowDialog();
            Close();
        }
    }
}
