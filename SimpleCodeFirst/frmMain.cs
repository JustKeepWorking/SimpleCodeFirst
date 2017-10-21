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
    public partial class frmMain : Form
    {
        private SchoolDbContext ctx;

        public frmMain()
        {
            InitializeComponent();

            Database.SetInitializer(new DropCreateDatabaseAlways<SchoolDbContext>());
            ctx = new SchoolDbContext();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAdd.Text))
            {
                Student student = new Student() { StudentName = txtAdd.Text };
                ctx.Students.Add(student);

                ctx.SaveChanges();

                txtAdd.Text = "";
                this.refresh();
            }
        }

        private void refresh()
        {
            dgvStudent.DataSource = ctx.Students.ToList();
        }
    }
}
