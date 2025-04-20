using System.Data;
using DemoEFCore.Models;

namespace DemoEFCore
{
    public partial class Form1 : Form
    {
        private readonly StudentManagementContext _context;

        public Form1()
        {
            InitializeComponent();
            _context = new StudentManagementContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Students
                .Select(p => new
                {
                    p.StudentId,
                    p.Name,
                    p.ClassId
                })
                .ToList();
            dataGridView1.Columns["Name"].Width = 150;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Students
                .Where(p => p.Name.Contains(txtTim.Text.Trim()))
               .Select(p => new
               {
                   p.StudentId,
                   p.Name,
                   p.ClassId
               })
               .ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student
                {
                    StudentId = txtStudentID.Text.Trim(),
                    Name = txtStudentName.Text.Trim(),
                    ClassId = txtClassID.Text.Trim()
                };

                var exists = _context.Students.Any(s => s.StudentId == student.StudentId);
                if (exists)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    return;
                }
                _context.Add(student);
                _context.SaveChanges();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            dataGridView1.DataSource = _context.Students
                .Select(p => new
                {
                    p.StudentId,
                    p.Name,
                    p.ClassId
                })
                .ToList();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var id = dataGridView1.CurrentRow.Cells["StudentId"].Value.ToString();
                var student = _context.Students.FirstOrDefault(s => s.StudentId == id);
                if (student != null)
                {
                    student.Name = txtStudentName.Text.Trim();
                    student.ClassId = txtClassID.Text.Trim();
                    _context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công");
                    LoadStudents();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var id = dataGridView1.CurrentRow.Cells["StudentId"].Value.ToString();
                var student = _context.Students.FirstOrDefault(s => s.StudentId == id);
                if (student != null)
                {
                    var result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        _context.Students.Remove(student);
                        _context.SaveChanges();
                        MessageBox.Show("Xóa thành công");
                        LoadStudents();
                    }
                }
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtStudentName.Text = dataGridView1.CurrentRow.Cells["Name"].Value?.ToString();
                txtStudentID.Text = dataGridView1.CurrentRow.Cells["StudentId"].Value?.ToString();
                txtClassID.Text = dataGridView1.CurrentRow.Cells["ClassId"].Value?.ToString();

            }
        }
    }
}
