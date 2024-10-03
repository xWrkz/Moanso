using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Aprendices
{

    public partial class A_MENÚ : Form
    {

        public struct Medicamento
        {
            public int A_codigo;
            public string A_nombre;
            public int A_cantidad;
            public decimal A_precioUnitario;


        }
        List<Medicamento> listaMedicamentos = new List<Medicamento>();
        public A_MENÚ()
        {
            InitializeComponent();
        }     

        private void Form2_Load(object sender, EventArgs e)
        {
                            
        }

        private void b_ADD_Click(object sender, EventArgs e)
        {
            // ORDENAMOS LO INGRESADO EN EL DTGV
            Medicamento A_medicamento = new Medicamento();
            A_medicamento.A_codigo = int.Parse(A_t_COD.Text);
            A_medicamento.A_nombre = A_t_NOM.Text;
            A_medicamento.A_cantidad = int.Parse(A_t_CAN.Text);
            A_medicamento.A_precioUnitario = decimal.Parse(A_t_PU.Text);

            // LIMPIAMOS CASILLAS 
            A_t_COD.Text = "";
            A_t_NOM.Text = "";
            A_t_CAN.Text = "";
            A_t_PU.Text = "";

            listaMedicamentos.Add(A_medicamento);

            A_dgv_LISTA.Rows.Clear();
            foreach (Medicamento m in listaMedicamentos)
            {
                A_dgv_LISTA.Rows.Add(m.A_codigo, m.A_nombre, m.A_cantidad, m.A_precioUnitario, m.A_cantidad * m.A_precioUnitario);
            }

            MessageBox.Show("Medicamento registrado exitosamente.");
        }
    

        private void b_CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_icd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Si la tecla presionada no es un número ni la tecla de retroceso
            {
                e.Handled = true; // No permitir que se escriba la tecla en el TextBox
            }
            A_txt_icd.Text = "";
        }
      
        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            //PERMITE BUSCAR ENTRE LAS LAS FILAS EL NOMBRE QUE COINCIDA
            string nombreBuscado = A_txt_search.Text;
            bool encontrado = false;

            foreach (DataGridViewRow fila in A_dgv_LISTA.Rows)
            {
                string nombre = Convert.ToString(fila.Cells[1].Value);

                if (nombre.Contains(nombreBuscado))
                {
                    encontrado = true;
                    fila.Selected = true;
                    A_dgv_LISTA.CurrentCell = fila.Cells[1];
                    break;
                }
            }

            if (encontrado)
            {
                MessageBox.Show("Se encontró el medicamento.");
            }
            else
            {
                MessageBox.Show("No se encontró el medicamento.");
            }           
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Evita que se escriba el caracter no deseado
            }
            A_txt_search.Text = "";
        }

        private void t_NOM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Evita que se escriba el caracter no deseado
            }
        }

        private void t_COD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Si la tecla presionada no es un número ni la tecla de retroceso
            {
                e.Handled = true; // No permitir que se escriba la tecla en el TextBox
            }
        }

        private void t_CAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Si la tecla presionada no es un número ni la tecla de retroceso
            {
                e.Handled = true; // No permitir que se escriba la tecla en el TextBox
            }
        }

        private void t_PU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Si la tecla presionada no es un número ni la tecla de retroceso
            {
                e.Handled = true; // No permitir que se escriba la tecla en el TextBox
            }
        }

        private void dgv_LISTA_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se cambió una celda en la columna 3
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                DataGridViewRow A_fila = A_dgv_LISTA.Rows[e.RowIndex];

                // Obtiene los valores de las celdas en la columna 2 y 3
                double A_valor1 = Convert.ToDouble(A_fila.Cells[2].Value);
                double A_valor2 = Convert.ToDouble(A_fila.Cells[3].Value);

                // Calcula la multiplicación
                double A_resultado = A_valor1 * A_valor2;

                // Muestra el resultado en la columna 4
                A_fila.Cells[4].Value = A_resultado;
            }
        }

        private void btn_ORDENARFILA_Click(object sender, EventArgs e)
        {
            // ORDENAMIENTO POR ALGORITMO BURBUJA  
            string[] A_columna = new string[A_dgv_LISTA.Rows.Count];

            for (int i = 0; i < A_dgv_LISTA.Rows.Count; i++)
            {
                A_columna[i] = A_dgv_LISTA.Rows[i].Cells[1].Value.ToString();
            }
            for (int i = 0; i < A_columna.Length - 1; i++)
            {
                for (int j = 0; j < A_columna.Length - i - 1; j++)
                {
                    if (string.Compare(A_columna[j], A_columna[j + 1]) > 0)
                    {
                        string temp = A_columna[j];
                        A_columna[j] = A_columna[j + 1];
                        A_columna[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < A_dgv_LISTA.Rows.Count; i++)
            {
                A_dgv_LISTA.Rows[i].Cells[1].Value = A_columna[i];
            }
        }

        private void A_dgv_LISTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewColumn col in A_dgv_LISTA.Columns)
            {         
                // PARA ELIMINAR EL OREDENAMIENTO POR DEFECTO QUE TRAE EL DTGV
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

                // PARA QUE SOLO PERMITA LEER Y NO MODIFICAR
                A_dgv_LISTA.ReadOnly = true;               
            }            
        }

        private void A_txt_icd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Si se presiona la tecla Enter
            {
                if (int.TryParse(A_txt_icd.Text, out int datoAEliminar)) // Obtener el valor numérico ingresado en el TextBox
                {
                    foreach (DataGridViewRow row in A_dgv_LISTA.Rows)
                    {
                        if (int.Parse(row.Cells[0].Value.ToString()) == datoAEliminar) // Si encuentras el dato
                        {
                            A_dgv_LISTA.Rows.Remove(row); // Elimina la fila
                            break;
                        }
                    }
                }
            }
        }
    }
}
