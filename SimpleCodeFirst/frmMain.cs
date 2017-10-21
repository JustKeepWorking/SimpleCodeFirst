using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCodeFirst
{
    public partial class FrmMain : Form
    {
        private SchoolDbContext ctx;

        public FrmMain()
        {
            ctx = new SchoolDbContext();
            InitializeComponent();
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.RefreshDataGrid();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAdd.Text))
            {
                Student student = new Student() { StudentName = txtAdd.Text };
                ctx.Students.Add(student);

                ctx.SaveChanges();

                txtAdd.Text = "";
                this.RefreshDataGrid();
            }
        }

        private void RefreshDataGrid()
        {
            dgvStudent.DataSource = ctx.Students?.ToList();
        }
    }
}
