using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenedor_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();

        }
        private void Refresh()

                {
                   DatabaseEmp oDatabaseEmp = new DatabaseEmp();
                   dataGridView1.DataSource = oDatabaseEmp.Get();
                 }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNuevo frm = new FormNuevo();
            frm.ShowDialog();
            Refresh();
        }
    }
         }
