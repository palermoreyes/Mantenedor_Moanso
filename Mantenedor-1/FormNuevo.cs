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
    public partial class FormNuevo : Form
    {
        public FormNuevo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            DatabaseEmp oDatabaseEmp = new DatabaseEmp();

            try
            {
                oDatabaseEmp.Add(TextNombre.Text, int.Parse(TextDni.Text), int.Parse(TextEdad.Text), decimal.Parse(TextSueldo.Text));

            }
            catch (Exception ex)

            {
                throw new Exception("Ocurrió un error al guardar los datos" + ex.Message);
            }
          }
        }
}