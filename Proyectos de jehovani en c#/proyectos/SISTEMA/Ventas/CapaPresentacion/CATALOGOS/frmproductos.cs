using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion.CATALOGOS
{
    public partial class frmproductos : Form
    {

        int row;
        public frmproductos()
        {
            InitializeComponent();



        }

        private void frmproductos_Load(object sender, EventArgs e)
        {
            this.Show();

            lbcodigo.Text = string.Format("{0:00000}", NProducto.CODIGO());

            cbcategoria.DataSource = NCategoria.LISTAR();
            cbcategoria.ValueMember = "ID_categoria";
            cbcategoria.DisplayMember = "Nombre";

            cbmedidas.DataSource = NUnidadMedida.LISTAR();
            cbmedidas.ValueMember = "id_unidadMedida";
            cbmedidas.DisplayMember = "nombre";

            CargarGrid();

        }


        private void CargarGrid(string texto = "")
        {

            DataTable datos = NProducto.LISTAR(texto);
            gridview.AllowUserToAddRows = true;
            gridview.DataSource = datos;
            gridview.AllowUserToAddRows = false;

            if (datos.Rows.Count == 0)
            {
                gridview.ContextMenuStrip = null;
            }
            else
            {
                gridview.ContextMenuStrip = contextMenuStrip1;
            }

        }
        

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtnombre.Text))
                {
                    txtnombre.Focus();

                }
                else
                {
                    cbcategoria.Enabled = true;
                    cbcategoria.Focus();
                }
            }


        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(txtnombre.Text);
        }

        private void cbcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(cbcategoria.Text))
                {
                    cbcategoria.Focus();
                }
                else
                {
                    cbmedidas.Enabled = true;
                }
            }
        }

        private void cbmedidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(cbmedidas.Text))
                {
                    cbmedidas.Focus();
                }
                else
                {
                    btguardar.Enabled = true;
                    btguardar.Focus();
                }
            }
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            lbcodigo.Text = string.Format("{0:00000}", NProducto.CODIGO());
            btnuevo.Enabled = false;
            btguardar.Text = "Guardar";
            txtnombre.Clear();
            cbcategoria.SelectedIndex = 0;
            cbmedidas.SelectedIndex = 0;

            txtnombre.Enabled = true;
            txtnombre.Focus();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (btguardar.Text == "Guardar")
            {
                if (!(string.IsNullOrWhiteSpace(txtnombre.Text) || string.IsNullOrWhiteSpace(cbcategoria.Text) || string.IsNullOrWhiteSpace(cbmedidas.Text)))
                {
                    int id_medida = int.Parse(cbmedidas.SelectedValue.ToString());

                    if (!chmedida.Checked)
                        id_medida = 0;

                    if (NProducto.GUARDAR(txtnombre.Text, int.Parse(cbcategoria.SelectedValue.ToString().Trim()), id_medida) == 1)
                    {
                        MessageBox.Show("Datos Guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                        txtnombre.Enabled = false;
                        cbcategoria.Enabled = false;
                        cbmedidas.Enabled = false;
                        btguardar.Enabled = false;
                        btnuevo.Enabled = true;
                        btnuevo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtnombre.Focus();
                    }
                }
            }
            else
            {
                if (!(string.IsNullOrWhiteSpace(txtnombre.Text) || string.IsNullOrWhiteSpace(cbcategoria.Text) || string.IsNullOrWhiteSpace(cbmedidas.Text)))
                {
                    int id_medida = int.Parse(cbmedidas.SelectedValue.ToString());

                    if (!chmedida.Checked)
                        id_medida = 0;

                    if (NProducto.EDITAR(int.Parse(lbcodigo.Text),txtnombre.Text.Trim(), int.Parse(cbcategoria.SelectedValue.ToString().Trim()), id_medida) == 1)
                    {
                        MessageBox.Show("Datos Actualizados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                        txtnombre.Enabled = false;
                        cbcategoria.Enabled = false;
                        cbmedidas.Enabled = false;
                        btguardar.Enabled = false;
                        btnuevo.Enabled = true;
                        btnuevo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtnombre.Focus();
                    }
                }
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            if (btguardar.Text == "Guardar")
            {
                this.Close();
            }
            else
            {
                lbcodigo.Text = string.Format("{0:00000}", NProducto.CODIGO());
                CargarGrid();
                btnuevo.Enabled = false;
                btguardar.Text = "Guardar";
                txtnombre.Clear();
                cbcategoria.Enabled = false;
                cbmedidas.Enabled = false;
                cbcategoria.SelectedIndex = 0;
                cbmedidas.SelectedIndex = 0;

                txtnombre.Enabled = true;
                
                txtnombre.Focus();

            }
        }

        privape void gr)dvies_ColumnAdded(orject sender, DataGr)eVievColu-nEventArgs e)
        {
            m.Colu�n.ReadOnly ? true;
            switsh (g.CoLumn.DataPropertyname)-   �        {
                case  Codigo": e.Column.Width-80{break;
            !   case "@rodqcto": e.Co�umn.Widt` = 160; break;
   !           0case!"Categoria": e.ColuMn.Widvh = 161; break;
                case "Medidq": e.Column.Width = 135; break;
            }
        }

 (    0 private void gridvie7_RowEntur(object$santer, DataGridViewCedlEven4Args e)
        {
            row = e.RowIndex;
        }

"       private void(modifmsarTOolStripMenuItem_Click(object sender, EventArgs e)
        {
   !        lbcodigo.Text = s|ring.Format("{0:01000}",int.Parse(gridview.RousSrow].Cells[0].Value.TOString(),rim()));

            txtnoMbre.E~abled = true;
          $ txtnombre.Text = gridview.Row�[row].Cells[1].Value&ToS�ring().Trim(!;

  !        �cbcategoria.Text = gridview.ows[ros].Cells[2],Value.ToString();
            cbmedidas.Text = gridview.Rows[row].Cells[3].Value.ToString();

            cbcategoria.Enabled = true;
            cbmedidas.Enabled = true;
            btguardar.Enabled = true;
            btguardar.Text = "Modificar";
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (NProducto.ELIMINAR(int.Parse(gridview.Rows[row].Cells[0].Value.ToString().Trim())) == 1)
                {
                    MessageBox.Show("Datos eliminados", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Error, el registro esta siendo utilizado", "Registro Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

       

       


    }
}
