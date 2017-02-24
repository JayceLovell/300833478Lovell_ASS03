using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Exercise1 : Form
    {
        BaseballModel baseball = new BaseballModel();
        public Exercise1()
        {
            InitializeComponent();
        }

        public void FillDateGrid(object sender, EventArgs e)
        {
            var query = from baseballtable in baseball.Players
                        select baseballtable;
            DataView.DataSource = query.ToList();
            DataGridViewColumn score = DataView.Columns[3];
            score.Width = 150;
            DataGridViewColumn firstname = DataView.Columns[1];
            firstname.Width = 110;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            var query = from baseballtable in baseball.Players
                        where baseballtable.LastName == txtlastnamesearch.Text
                        select baseballtable;
            DataView.DataSource = query.ToList();
        }
    }
}