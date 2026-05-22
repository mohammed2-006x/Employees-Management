using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employees_Management
{
    public partial class frmEditEmployee : Form
    {

        private ListViewItem _item;
        public frmEditEmployee(ListViewItem item)
        {
            InitializeComponent();
            _item = item;
            txtID.Text = item.Text;
            txtFullName.Text = item.SubItems[1].Text;
            txtPhone.Text = item.SubItems[2].Text;
            txtEmail.Text = item.SubItems[5].Text;
            mtxtSalary.Text = item.SubItems[7].Text;
            rbFemale.Checked = (item.SubItems[6].Text == "F") ? true : false;
        }


        short CalcEmployeeAge(DateTime EmpBirthDay)
        {
            short EmployeeAgeInYears = (short)(DateTime.Now.Year - EmpBirthDay.Year);
            if (DateTime.Now.Month < EmpBirthDay.Month || (DateTime.Now.Month == EmpBirthDay.Month && DateTime.Now.Day < EmpBirthDay.Day))
            {
                EmployeeAgeInYears--;
            }

            return EmployeeAgeInYears;
        }

        TimeSpan DailyWorkingHours()
        {
            TimeSpan WorkingSpan;

            if (DateTime.Compare(DateTime.Parse(mtxtFrom.Text), DateTime.Parse(mtxtTo.Text)) < 0)
            {
                WorkingSpan = DateTime.Parse(mtxtTo.Text) - DateTime.Parse(mtxtFrom.Text);
            }
            else
            {
                WorkingSpan = (DateTime.Parse("23:59") - DateTime.Parse(mtxtFrom.Text)) + (DateTime.Parse(mtxtTo.Text) - DateTime.Parse("00:00"));

            }

            return WorkingSpan;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text) || mtxtFrom.MaskFull == false || mtxtTo.MaskFull == false || mtxtSalary.MaskCompleted == false)
            {
                return;
            }

            _item.SubItems[1].Text=txtFullName.Text;
            _item.SubItems[2].Text=txtPhone.Text;
            _item.SubItems[3].Text=CalcEmployeeAge(dtpBirthDay.Value) + " سنة";
            TimeSpan WorkingSpan = DailyWorkingHours();
            string strWorkingSpan;

            strWorkingSpan = WorkingSpan.Hours.ToString() + " ساعة";

            if (WorkingSpan.Minutes > 0)
            {
                strWorkingSpan += " و " + WorkingSpan.Minutes.ToString() + " دقيقة";
            }

            _item.SubItems[4].Text=strWorkingSpan;
            _item.SubItems[5].Text=txtEmail.Text;
            _item.SubItems[6].Text=rbMale.Checked ? "M" : "F";
            _item.SubItems[7].Text=mtxtSalary.Text + "د.ل";
            _item.ImageIndex = rbMale.Checked ? 0 : 1;


            this.Close();


        }
    }
}
