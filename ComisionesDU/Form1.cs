using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ComisionesDU
{
    public partial class Form1 : Form
    {
        Conexion c = new Conexion();
        public Form1()
        {
            InitializeComponent();
        }
        int indexRow;
           
        private void Form1_Load(object sender, EventArgs e)
        {
            c.actualizar();
            c.cargarComisiones(DgvComisiones);
            DgvComisiones.AllowUserToResizeColumns = true;
            DgvComisiones.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvComisiones.Columns[0].Resizable = DataGridViewTriState.True;
            DgvComisiones.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvComisiones.Columns[1].Resizable = DataGridViewTriState.True;
            DgvComisiones.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvComisiones.Columns[2].Resizable = DataGridViewTriState.True;
            DgvComisiones.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvComisiones.Columns[3].Resizable = DataGridViewTriState.True;
            DgvComisiones.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvComisiones.Columns[4].Resizable = DataGridViewTriState.True;
            DgvComisiones.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvComisiones.Columns[5].Resizable = DataGridViewTriState.True;

           
          

        }

        private void DgvComisiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

            indexRow = e.RowIndex;
            DataGridViewRow row = DgvComisiones.Rows[indexRow];
            textid.Text = row.Cells[0].Value.ToString();
            textCasa.Text = row.Cells[1].Value.ToString();
            textPorcCobroDentroPeriodo.Text = row.Cells[2].Value.ToString();
            textDiasCobroDentroPeriodo.Text = row.Cells[3].Value.ToString();
            textPorcCobroFueraPeriodo.Text = row.Cells[4].Value.ToString();
            textDiasCobroFueraPeriodo.Text= row.Cells[5].Value.ToString();
           // textCasa.Text = row.Cells[0].Value.ToString();
        }

        private void textPorcCobroDentroPeriodo_Validated(object sender, EventArgs e)
        {
           
        }

        private void textPorcCobroDentroPeriodo_Validating(object sender, CancelEventArgs e)
        {

           
            decimal var_rango;
            if (textPorcCobroDentroPeriodo.Text != String.Empty)
            {
                
                var_rango = decimal.Parse(this.textPorcCobroDentroPeriodo.Text);
            }
            else
            {
                var_rango = 0;
            }
                                   
            if (var_rango > 100 )
            {
                 e.Cancel = true;
                MessageBox.Show("Ingresar Porcentaje entre 0-100");
            }
            else
            {
                e.Cancel = false;
            }
            
        
        }

        private void textPorcCobroDentroPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validar.NumerosDecimal(e);

        }

        private void textPorcCobroDentroPeriodo_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void textPorcCobroFueraPeriodo_Validating(object sender, CancelEventArgs e)
        {
            decimal var_rango;
            if (textPorcCobroFueraPeriodo.Text != String.Empty)
            {

                var_rango = decimal.Parse(this.textPorcCobroFueraPeriodo.Text);
            }
            else
            {
                var_rango = 0;
            }

            if (var_rango > 100)
            {
                e.Cancel = true;
                MessageBox.Show("Ingresar Porcentaje entre 0-100");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void textPorcCobroFueraPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumerosDecimal(e);
        }

        private void textDiasCobroDentroPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumerosEneteros(e);
        }

        private void textDiasCobroFueraPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumerosEneteros(e);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(textid.Text);
            decimal d01 = (Convert.ToDecimal(textPorcCobroDentroPeriodo.Text)/100);
            decimal d02 = Convert.ToDecimal(textDiasCobroDentroPeriodo.Text);
            decimal d03 = (Convert.ToDecimal(textPorcCobroFueraPeriodo.Text)/100);
            decimal d04 = Convert.ToDecimal(textDiasCobroFueraPeriodo.Text);
            c.guardar( id,d01,d02,d03,d04);
            c.actualizar();
            c.cargarComisiones(DgvComisiones);
            textCasa.Text = "";
            textid.Text = "";
            textPorcCobroDentroPeriodo.Text = "0";
            textDiasCobroDentroPeriodo.Text = "0";
            textPorcCobroFueraPeriodo.Text = "0";
            textDiasCobroFueraPeriodo.Text = "0";
            DgvComisiones.Focus();

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
