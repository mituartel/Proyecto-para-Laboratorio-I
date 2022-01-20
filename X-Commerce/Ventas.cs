using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using X_Commerce.Entidades;
using X_Commerce.Servicios;

namespace X_Commerce
{
    public partial class Ventas : Form
    {
        private long clienteId;

        private Empleado _empleado;

        private bool apretoEnter = false;

        private List<DetalleFactura> prueba = new List<DetalleFactura>(); 

        
        
        public Cliente clienteBuscado;

        private List<DetalleFactura> detalleFacturass = new List<DetalleFactura>();

        private DetalleFactura productoCargado = new DetalleFactura();

        private DetalleFactura productoSeleccionado = new DetalleFactura();

        public Ventas(Empleado empleado)
        {

            InitializeComponent();
            DoubleBuffered = false;

            _empleado = empleado;
            
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            PoblarGrilla(dgvVentas);
            FacturaServicio.ObtenerDatosDelArchivo();

            if (FacturaServicio.Facturas == null)
            {
                txtNumeroFactura.Text = 1.ToString();
            }
            else
            {
                var facturas = FacturaServicio.Facturas;
                long numeroFacturaActual = 0; 

                foreach (var movFactura in facturas)
                {
                    if (movFactura.NumeroFactura > numeroFacturaActual)
                    {
                        numeroFacturaActual = movFactura.NumeroFactura;
                    }
                }

                txtNumeroFactura.Text = (numeroFacturaActual + 1).ToString();
            }
            dtpFecha.Text = DateTime.Now.ToString();
        }

        public void PoblarGrilla(DataGridView dgv)
        {
            dgvVentas.DataSource = prueba;
            dgvVentas.DataSource = detalleFacturass.ToList();

            FormatearGrilla(dgvVentas);
            actualizarTotal();
        }

        public void FormatearGrilla(DataGridView dgv)
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;
            }
            dgv.Columns["DescripcionProducto"].Visible = true;
            dgv.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["DescripcionProducto"].HeaderText = "Producto";
            dgv.Columns["DescripcionProducto"].DisplayIndex = 0;


            dgv.Columns["CodigoProducto"].Visible = true;
            dgv.Columns["CodigoProducto"].HeaderText = "Codigo del Producto";
            dgv.Columns["CodigoProducto"].Width = 100;
            dgv.Columns["CodigoProducto"].DisplayIndex = 1;

            dgv.Columns["PrecioUnitario"].Visible = true;
            dgv.Columns["PrecioUnitario"].Width = 100;
            dgv.Columns["PrecioUnitario"].HeaderText = "Precio";
            dgv.Columns["PrecioUnitario"].DisplayIndex = 2;

            dgv.Columns["Cantidad"].Visible = true;
            dgv.Columns["Cantidad"].HeaderText = "Cantidad";
            dgv.Columns["Cantidad"].Width = 150;
            dgv.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Cantidad"].DisplayIndex = 3;

            dgv.Columns["SubTotal"].Visible = true;
            dgv.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["SubTotal"].HeaderText = "SubTotal";
            dgv.Columns["SubTotal"].DisplayIndex = 4;

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            var fNuevoCliente = new NuevoCliente();
            fNuevoCliente.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            var fLookUpCliente = new ClientesLookUp();
            fLookUpCliente.ShowDialog();

            if (fLookUpCliente.cliente != null)
            {
                txtCodigoCliente.Text = fLookUpCliente.cliente.Codigo.ToString();
                txtNombreCliente.Text = fLookUpCliente.cliente.ApyNom;

                clienteId = fLookUpCliente.cliente.Id;
                clienteBuscado = fLookUpCliente.cliente;
            }       
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            eliminar(productoSeleccionado);
            PoblarGrilla(dgvVentas);
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (cmbFacturas.Text == "")
            {
                MessageBox.Show("Seleccione un tipo de factura");
            }
            else
            {
                Factura factura = new Factura();
                factura.ApyNomCliente = txtNombreCliente.Text;
                factura.ApyNomEmpleado = _empleado.ApyNom;
                factura.EmpleadoId = _empleado.Id;
                factura.ClienteId = clienteId;
                factura.Descuento = nudDescuento.Value;
                factura.Items = detalleFacturass;
                factura.NumeroFactura = int.Parse(txtNumeroFactura.Text);
                factura.TipoFactura = cmbFacturas.Text;
                factura.Fecha = DateTime.Now;

                var fFacturar = new Facturar(detalleFacturass, factura, clienteBuscado);
                fFacturar.ShowDialog();

                if (fFacturar.seFacturo == true)
                {
                    int numF = int.Parse(txtNumeroFactura.Text);
                    numF++;

                    txtNumeroFactura.Text = numF.ToString();

                    detalleFacturass.Clear();
                    txtCodigoCliente.Clear();
                    txtNombreCliente.Clear();
                    txtCodigo.Clear();
                    txtDescripcion.Clear();
                    txtPrecio.Text = "0";
                    nudCantidad.Value = 0;
                    txtSubTotal.Clear();
                    nudDescuento.Value = 0;
                    txtTotal.Clear();

                    PoblarGrilla(dgvVentas);
                }
            }



            
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoCliente.Text))
            {
                MessageBox.Show("Seleccione cliente antes de realizar la compra");
            }
            else
            {
                if (apretoEnter == false)
                {
                    MessageBox.Show("Al seleccionar el codigo presione la tecla ENTER ");
                }
                else
                {
                    productoCargado.Cantidad = nudCantidad.Value;
                    //productoCargado.Id = idDetalle;
                    //idDetalle++;

                    if (!repetido(productoCargado))
                    {
                        detalleFacturass.Add(productoCargado);
                    }

                    productoCargado = new DetalleFactura();
                    PoblarGrilla(dgvVentas);

                    apretoEnter = false;
                }
            }          
        }

        private void btnActivarCantidad_Click(object sender, EventArgs e)
        {
            var fActivarCantidad = new CambiarCantidad(productoSeleccionado.Cantidad, productoSeleccionado.CodigoProducto);
            fActivarCantidad.ShowDialog();

            if (fActivarCantidad.cant != 0)
            {
                foreach (var mov in detalleFacturass)
                {
                    if (mov.CodigoProducto == fActivarCantidad.cod)
                    {
                        mov.Cantidad = fActivarCantidad.cant;
                    }
                }

                PoblarGrilla(dgvVentas);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    var producto = ProductoServicio.ObtenerPorCodigo(txtCodigo.Text);

                    if (producto == null)
                    {
                        MessageBox.Show("El codigo ingresado no esta asociado a un producto disponible");
                        return;
                    }

                    txtDescripcion.Text = producto.Descripcion;
                    txtPrecio.Text = producto.Precio.ToString();
                    nudCantidad.Value = 1;
                    nudSubTotal.Value = producto.Precio;

                    productoCargado.CodigoProducto = producto.Codigo;
                    productoCargado.DescripcionProducto = producto.Descripcion;
                    productoCargado.PrecioUnitario = producto.Precio;
                    productoCargado.NumeroFactura = int.Parse(txtNumeroFactura.Text);

                    apretoEnter = true;
                   
                   
        
                }
            }
            e.Handled = false;
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            nudSubTotal.Value = int.Parse(txtPrecio.Text) * nudCantidad.Value;
        }

        private void dgvVentas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.Rows.Count > 0)
            {
                productoSeleccionado = (DetalleFactura)dgvVentas.Rows[e.RowIndex].DataBoundItem;



            }
            else
            {
                productoSeleccionado = null;
            }

        }
        


        private bool repetido(DetalleFactura productoNuevo)
        {
            bool laBandera = false;

            foreach (var mov in detalleFacturass)
            {
                if (mov.CodigoProducto == productoNuevo.CodigoProducto)
                {
                    MessageBox.Show(mov.CodigoProducto.ToString());
                    MessageBox.Show(productoNuevo.CodigoProducto.ToString());
                    mov.Cantidad += productoNuevo.Cantidad;
                    laBandera = true;
                }
            }

            return laBandera;
        }

        private void eliminar(DetalleFactura productoEliminado)
        {
            if (MessageBox.Show("eliminar el Producto?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {              
                List<DetalleFactura> temporal = new List<DetalleFactura>();

                foreach (var mov in detalleFacturass)
                {
                    if (!(mov.CodigoProducto == productoEliminado.CodigoProducto))
                    {
                        temporal.Add(mov);
                    }
                }

                detalleFacturass = temporal;
            }
            
        }

        private void actualizarTotal()
        {
            decimal subTotal = 0;
            decimal total = 0;
            int porCiento = (int)nudDescuento.Value;

            foreach (var mov in detalleFacturass)
            {
                subTotal += mov.SubTotal;
                
            }
            decimal descuento = (porCiento * subTotal) / 100;
            total = subTotal - descuento;

            txtSubTotal.Text = subTotal.ToString();
            txtTotal.Text = total.ToString();
        }

        private void nudDescuento_ValueChanged(object sender, EventArgs e)
        {
            decimal descuento = (((int)nudDescuento.Value * decimal.Parse(txtSubTotal.Text) / 100));
            txtTotal.Text = (decimal.Parse(txtSubTotal.Text) - descuento).ToString();

        }
    }
}
