using Lab2_6.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace Lab2_6
{
    public partial class fManageStudent : Form
    {
        BindingSource StudentBind = new BindingSource();

        public fManageStudent()
        {
            InitializeComponent();

            dgvStudent.DataSource = StudentBind;

            LoadInfoStudent();
            LoadCourseToComboBox(cbCourseStudent);
            AddBindStudent();


        }

        #region Method

        void LoadInfoStudent()
        {
            StudentBind.DataSource = InfoStudentDAO.Instance.LoadInfoStudent();

        }

        void AddBindStudent()
        {
            txbIDStudent.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "MSSV", true, DataSourceUpdateMode.Never));
            txbNameStudent.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "Tên", true, DataSourceUpdateMode.Never));
            txbMath.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "Điểm Toán", true, DataSourceUpdateMode.Never));
            txbLiterature.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "Điểm Văn", true, DataSourceUpdateMode.Never));
            txbEnglish.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "Điểm Anh", true, DataSourceUpdateMode.Never));
            txbAverage.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "ĐTB", true, DataSourceUpdateMode.Never));
        }

        void LoadCourseToComboBox(ComboBox cb)
        {
            cb.DataSource = CourseDAO.Instance.LoadListCourse();
            cb.DisplayMember = "Name";
        }

        #endregion

        #region Event


        private void txbIDStudent_TextChanged(object sender, System.EventArgs e)
        {
            if (dgvStudent.SelectedCells.Count > 0)
            {
                string idCourse = dgvStudent.SelectedCells[0].OwningRow.Cells["Mã lớp"].Value.ToString();

                foreach (DataRowView item in cbCourseStudent.Items)
                {
                    if (idCourse == item.Row[0].ToString())
                    {
                        cbCourseStudent.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnEditStudent_Click(object sender, System.EventArgs e)
        {
            string id = txbIDStudent.Text;
            string name = txbNameStudent.Text;
            string idCourse = (cbCourseStudent.SelectedValue as DataRowView).Row[0].ToString();
            double math = Convert.ToDouble(txbMath.Text);
            double literature = Convert.ToDouble(txbLiterature.Text);
            double english = Convert.ToDouble(txbEnglish.Text);


            if (StudentDAO.Instance.UpdateStudent(id, name, idCourse, math, literature, english))
            {
                MessageBox.Show("Cập nhật sinh viên thành công", "Cập nhật sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật sinh viên lỗi", "Cập nhật sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadInfoStudent();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            string id = txbIDStudent.Text;

            if (StudentDAO.Instance.DeleteStudent(id))
            {
                MessageBox.Show("Xóa sinh viên thành công", "Cập nhật sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa sinh viên lỗi", "Cập nhật sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadInfoStudent();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            fAddStudent fAddStudent = new fAddStudent();
            fAddStudent.ShowDialog();

            LoadInfoStudent();
        }

        #endregion


    }
}
