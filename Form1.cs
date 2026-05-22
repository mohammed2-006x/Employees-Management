using Employees_Management.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Employees_Management
{
    public partial class Form1 : Form
    {

        static private int _IDForCurrentEmployee = 1001;
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                lblID.Text = listView1.SelectedItems[0].Text;
                lblName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                lblPhone.Text = listView1.SelectedItems[0].SubItems[2].Text;
                lblAge.Text = listView1.SelectedItems[0].SubItems[3].Text;
                lblWorkingPeriod.Text = listView1.SelectedItems[0].SubItems[4].Text;
                lblEmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
                lblGender.Text = (listView1.SelectedItems[0].SubItems[6].Text == "M") ? "ذكر" : "أنثى";
                lblSalary.Text = listView1.SelectedItems[0].SubItems[7].Text;
                pbEmployee.Image = (listView1.SelectedItems[0].ImageIndex == 0) ? Resources.Man : Resources.Woman;
            }
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

            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text) || mtxtFrom.MaskFull == false || mtxtTo.MaskFull == false || mtxtSalary.MaskCompleted == false )
            {
                return;
            }


            ListViewItem item = new ListViewItem((_IDForCurrentEmployee++).ToString());

            item.SubItems.Add(txtFullName.Text);
            item.SubItems.Add(txtPhone.Text);
            item.SubItems.Add(CalcEmployeeAge(dtpBirthDay.Value) + " سنة");
            TimeSpan WorkingSpan = DailyWorkingHours();
            string strWorkingSpan;

            strWorkingSpan = WorkingSpan.Hours.ToString() + " ساعة";

            if (WorkingSpan.Minutes > 0)
            {
                strWorkingSpan += " و " + WorkingSpan.Minutes.ToString() + " دقيقة";
            }

            item.SubItems.Add(strWorkingSpan);
            item.SubItems.Add(txtEmail.Text);
            item.SubItems.Add(rbMale.Checked ? "M" : "F");
            item.SubItems.Add(mtxtSalary.Text + "د.ل");
            item.ImageIndex = rbMale.Checked ? 0 : 1;


            listView1.Items.Add(item);

            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            mtxtFrom.Clear();
            mtxtTo.Clear();
            mtxtSalary.Clear();
            rbMale.Checked = true;
            dtpBirthDay.Text = DateTime.Parse("01/01/2000").ToString();
            txtFullName.Focus();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listView1.View = View.SmallIcon;
                return;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listView1.View = View.LargeIcon;
                return;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                listView1.View = View.Details;
                return;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                listView1.View = View.List;
                return;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                listView1.View = View.Tile;
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }

        private InputLanguage oldLanguage;

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            oldLanguage = InputLanguage.CurrentInputLanguage;

            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.TwoLetterISOLanguageName == "ar")
                {
                    InputLanguage.CurrentInputLanguage = lang;
                    break;
                }
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (oldLanguage != null)
                InputLanguage.CurrentInputLanguage = oldLanguage;
        }

        private void ResetInfoCard()
        {
            lblID.Text = "UNDEFINED";
            lblName.Text = "UNDEFINED";
            lblPhone.Text = "UNDEFINED";
            lblAge.Text = "UNDEFINED";
            lblWorkingPeriod.Text = "UNDEFINED";
            lblEmail.Text = "UNDEFINED";
            lblGender.Text = "UNDEFINED";
            pbEmployee.Image = null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (btnCheckEmployees.Tag.ToString() == "1")
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("من فضلك قم بتحديد الموظفين المراد حذفهم من القائمة", "خطأ في الحدف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    foreach (ListViewItem Item in listView1.SelectedItems)
                    {
                        Item.Remove();

                    }

                    bool IsEmployeeDeleted1 = true;

                    foreach (ListViewItem Item in listView1.Items)
                    {
                        if (Item.Text==lblID.Text)
                        {
                            IsEmployeeDeleted1 = false;
                            return;
                        }

                    }

                    if(IsEmployeeDeleted1)
                        ResetInfoCard();


                    return;
                }
            }



            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("من فضلك قم بتحديد الموظفين المراد حذفهم من القائمة", "خطأ في الحدف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem Item in listView1.CheckedItems)
            {
                Item.Remove();

            }

            bool IsEmployeeDeleted2 = true;

            foreach (ListViewItem Item in listView1.Items)
            {
                if (Item.Text == lblID.Text)
                {
                    IsEmployeeDeleted2 = false;
                    return;
                }

            }

            if (IsEmployeeDeleted2)
                ResetInfoCard();


        }

        private void btnCheckEmployees_Click(object sender, EventArgs e)
        {
            if (btnCheckEmployees.Tag.ToString() == "1")
            {
                listView1.CheckBoxes = true;
                btnCheckEmployees.Text = "إلغاء التحديد العناصر";
                btnCheckEmployees.Tag = "0";
            }
            else if (btnCheckEmployees.Tag.ToString() == "0")
            {
                listView1.CheckBoxes = false;
                btnCheckEmployees.Text = "تحديد العناصر";
                btnCheckEmployees.Tag = "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==0)
            {
                 MessageBox.Show("من فضلك قم بتحديد الموظف المراد تعديل بياناته من القائمة", "خطأ في التعديل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmEditEmployee F2 = new frmEditEmployee(listView1.SelectedItems[0]);

            F2.ShowDialog();

            listView1.Refresh();

        }
    }

}
