using Lab2_6.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace Lab2_6
{
    public partial class fAddStudent : Form
    {
        public fAddStudent()
        {
            InitializeComponent();

            LoadCourseToComboBox(cbCourseStudent);
        }

        void LoadCourseToComboBox(ComboBox cb)
        {
            cb.DataSource = CourseDAO.Instance.LoadListCourse();
            cb.DisplayMember = "Name";
        }

        void ClearInput()
        {
            txbIDStudent.Clear();
            txbNameStudent.Clear();
            cbCourseStudent.SelectedIndex = 0;
            txbMath.Clear();
            txbLiterature.Clear();
            txbEnglish.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txbIDStudent.Text;
            string name = txbNameStudent.Text;
            string idCourse = (cbCourseStudent.SelectedValue as DataRowView).Row[0].ToString();
            double math = Convert.ToDouble(txbMath.Text);
            double literature = Convert.ToDouble(txbLiterature.Text);
            double english = Convert.ToDouble(txbEnglish.Text);

            if (StudentDAO.Instance.AddStudent(id, name, idCourse, math, literature, english))
            {
                MessageBox.Show("Thêm sinh viên thành công", "Cập nhật sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Thêm sinh viên lỗi", "Cập nhật sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
