using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForms
{
    public partial class Form1 : Form
    {
        Students uni;

        private Form parent;
        public Form1(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            uni = new Students();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtNumber.Text != "")
            {
                string gender = rbtnE.Checked ? "E" : "K";

                Student std = new Student(txtName.Text, txtNumber.Text, dtpBirthDate.Value, gender);

                bool result = uni.addStudent(std);

                if (result)
                    MessageBox.Show("This student has been added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("This student couldn't be added!", "Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtName.Text = "";
                txtNumber.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete!", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {

                bool result = uni.deleteStudent(cbxNumbersDelete.SelectedItem.ToString());

                if (result)
                {
                    cbxNumbersDelete.Items.RemoveAt(cbxNumbersDelete.SelectedIndex);
                    MessageBox.Show("This student has been deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("This student couldn't be deleted!", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (cbxNumbersDelete.Items.Count != 0)
                    cbxNumbersDelete.SelectedIndex = 0;
            }

        }

        private void tbcStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcStudents.SelectedIndex == 1)
            {
                cbxNumbersDelete.Items.Clear();

                DataSet ds = uni.getAllStudentNumber();

                int len = ds.Tables[0].Rows.Count;

                for (int i = 0; i < len; i++)
                {
                    cbxNumbersDelete.Items.Add(ds.Tables[0].Rows[i]["Number"].ToString());
                }

                if (cbxNumbersDelete.Items.Count != 0)
                    cbxNumbersDelete.SelectedIndex = 0;
            }
            else if (tbcStudents.SelectedIndex == 2)
            {

                DataSet ds = uni.getAllStudents();

                dgvStudents.DataSource = ds.Tables[0];


            }
            else if (tbcStudents.SelectedIndex == 3)
            {
                cbxLessonsAddOperaton.Enabled = false;
                cbxNumberLessonsOperation.Items.Clear();

                DataSet ds = uni.getAllStudentNumber();

                int len = ds.Tables[0].Rows.Count;

                for (int i = 0; i < len; i++)
                {
                    cbxNumberLessonsOperation.Items.Add(ds.Tables[0].Rows[i]["Number"].ToString());
                }

                if (cbxNumberLessonsOperation.Items.Count != 0)
                    cbxNumberLessonsOperation.SelectedIndex = 0;

            }
            else if (tbcStudents.SelectedIndex == 4)
            {
                cbxLessonDelete.Enabled = false;
                cbxNumberLessonDelete.Items.Clear();


                DataSet ds = uni.getAllStudentNumber();

                int len = ds.Tables[0].Rows.Count;

                for (int i = 0; i < len; i++)
                {
                    cbxNumberLessonDelete.Items.Add(ds.Tables[0].Rows[i]["Number"].ToString());
                }


                if (cbxNumberLessonDelete.Items.Count != 0)
                    cbxNumberLessonDelete.SelectedIndex = 0;

            }
            else if (tbcStudents.SelectedIndex == 5)
            {
                cbxNumbersForLesson.Items.Clear();

                DataSet ds = uni.getAllStudentNumber();

                int len = ds.Tables[0].Rows.Count;

                for (int i = 0; i < len; i++)
                {
                    cbxNumbersForLesson.Items.Add(ds.Tables[0].Rows[i]["Number"].ToString());
                }

                if (cbxNumbersForLesson.Items.Count > 0)
                    cbxNumbersForLesson.SelectedIndex = 0;
            }
        }

        private void btnAddLessonToStudent_Click(object sender, EventArgs e)
        {
            bool result = uni.addLessonToStudent(cbxLessonsAddOperaton.SelectedItem.ToString(), cbxNumberLessonsOperation.SelectedItem.ToString());

            if (result)
                MessageBox.Show("This lesson has been added to this student!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("This lesson couldn't be added!", "Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);


            cbxLessonsAddOperaton.Items.RemoveAt(cbxLessonsAddOperaton.SelectedIndex);

            if (cbxLessonsAddOperaton.Items.Count > 0)
                cbxLessonsAddOperaton.SelectedIndex = 0;
        }

        private void cbxNumberLessonsOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxLessonsAddOperaton.Items.Clear();

            DataSet dsTakenLessons = uni.getLessonsOfStudent(cbxNumberLessonsOperation.SelectedItem.ToString());
            DataSet dsAllLessons = uni.getAllLessonCode();

            int lenAllLessons = dsAllLessons.Tables[0].Rows.Count;
            int lenTakenLessons = dsTakenLessons.Tables[0].Rows.Count;

            for (int i = 0; i < lenAllLessons; i++)
            {
                cbxLessonsAddOperaton.Items.Add(dsAllLessons.Tables[0].Rows[i]["Code_"].ToString());
            }

            for (int i = 0; i < lenTakenLessons; i++)
            {
                cbxLessonsAddOperaton.Items.Remove(dsTakenLessons.Tables[0].Rows[i]["Code_"].ToString());
            }

            if (cbxLessonsAddOperaton.Items.Count != 0)
            {
                cbxLessonsAddOperaton.Enabled = true;
                cbxLessonsAddOperaton.SelectedIndex = 0;
            }

        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete!", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                bool result = uni.deleteLessonFromStudent(cbxNumberLessonDelete.SelectedItem.ToString(), cbxLessonDelete.SelectedItem.ToString());

                if (result)
                {
                    cbxLessonDelete.Items.RemoveAt(cbxLessonDelete.SelectedIndex);

                    if (cbxLessonDelete.Items.Count > 0)
                        cbxLessonDelete.SelectedIndex = 0;
                    else
                        cbxLessonDelete.Text = "";

                    MessageBox.Show("This lesson has been deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                    MessageBox.Show("This lesson couldn't be deleted!", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void cbxLessonDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxNumberLessonDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxLessonDelete.Items.Clear();

            DataSet dsTakenLessons = uni.getLessonsOfStudent(cbxNumberLessonDelete.SelectedItem.ToString());

            int len = dsTakenLessons.Tables[0].Rows.Count;

            for (int i = 0; i < len; i++)
            {
                cbxLessonDelete.Items.Add(dsTakenLessons.Tables[0].Rows[i]["Code_"].ToString());
            }


            if (cbxLessonDelete.Items.Count != 0)
            {
                cbxLessonDelete.Enabled = true;
                cbxLessonDelete.SelectedIndex = 0;
            }
        }

        private void cbxNumbersForLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = uni.listLessonsOfStudents(cbxNumbersForLesson.SelectedItem.ToString());
            dgvLessons.DataSource = ds.Tables[0];
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.Visible = true;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = ((DataTable) dgvStudents.DataSource).Rows[e.RowIndex];
            txtNameUpdate.Text = dr["Name"].ToString();
            txtNumberUpdate.Text = dr["Number"].ToString();
            dtpUpdateBirthDate.Value = Convert.ToDateTime(dr["BirthDate"].ToString());
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            bool result = uni.updateStudent(txtNameUpdate.Text, txtNumberUpdate.Text, dtpUpdateBirthDate.Value);

            if (result)
            {
                dgvStudents.DataSource = uni.getAllStudents().Tables[0];
                MessageBox.Show("This student has been update!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("This student couldn't be updates!", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
