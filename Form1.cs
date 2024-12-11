using System;
using System.Windows.Forms;

namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                txtTareas.Items.Add(txtTarea.Text);
                txtTarea.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una tarea antes de agregarla.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (txtTareas.SelectedIndex != -1)
            {
                txtTareas.Items.RemoveAt(txtTareas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
