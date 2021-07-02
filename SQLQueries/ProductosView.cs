using SQLQueries.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLQueries
{
    public partial class ProductosView : Form
    {
        ConsultasProductos productos = new ConsultasProductos();
        ConsultasCategorias categorias = new ConsultasCategorias();
        DataTable listaProductos;
        public ProductosView()
        {
            InitializeComponent();

            listaProductos = productos.GetProductos();
            CargarProductos(listaProductos);

            CargarCategorias();
        }

        private void CargarCategorias()
        {
            cb_categorias.DataSource = categorias.GetCategorias();
            cb_categorias.DisplayMember = "CategoryName";
            cb_categorias.ValueMember = "CategoryID";
        }
        private void CargarProductos(DataTable dataTable)
        {
            dgv_productos.DataSource = null;
            dgv_productos.DataSource = dataTable;
        }
        private void btn_addCategoria_Click(object sender, EventArgs e)
        {
            bool ok = categorias.InsertarCategoria(txt_nuevaCategoria.Text);
            if (ok)
            {
                MessageBox.Show("Se inserto la categoria con exito", "Categoria insertada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCategorias();

            }
            else
            {
                MessageBox.Show("No se pudo insertar la categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            string buscar = txt_search.Text;

            var filtrados = listaProductos.AsEnumerable().Where(x =>
            {

               return x.Field<string>("Producto").ToLower().StartsWith(buscar);


            });
            DataTable dataTable = filtrados.AsDataView().ToTable();
            CargarProductos(dataTable);


        }
    }
}
