using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Display : Form
    {
        private Books.BooksEntities dbcontext = new Books.BooksEntities();
        public Display()
        {
            InitializeComponent();
        }

        private void btnSort1_Click(object sender, EventArgs e)
        {
            var question1 = from table1 in dbcontext.Titles
                            from table2 in table1.Authors
                            orderby table1.Title1
                            select new { table1.Title1, table2.FirstName, table2.LastName };

            authorDataGridView.DataSource = question1.ToList();
        }

        private void btnSort2_Click(object sender, EventArgs e)
        {
            var question2 = from table1 in dbcontext.Titles
                            from table2 in table1.Authors
                            orderby table1.Title1, table2.LastName, table2.FirstName
                            select new { table1.Title1, table2.FirstName, table2.LastName };
            authorDataGridView.DataSource = question2.ToList();
        }

        private void btnSort3_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            var viewall = from table1 in dbcontext.Titles
                          from table2 in table1.Authors
                          orderby table1.Title1
                          select new { table1.ISBN, table1.Title1, table1.EditionNumber,table2.FirstName,table2.LastName};

            authorDataGridView.DataSource = viewall.ToList();
        }
    }
}
