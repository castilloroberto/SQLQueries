
namespace SQLQueries
{
    partial class ProductosView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.txt_nuevaCategoria = new System.Windows.Forms.TextBox();
            this.cb_categorias = new System.Windows.Forms.ComboBox();
            this.btn_addCategoria = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(415, 184);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 24;
            this.dgv_productos.Size = new System.Drawing.Size(793, 365);
            this.dgv_productos.TabIndex = 0;
            // 
            // txt_nuevaCategoria
            // 
            this.txt_nuevaCategoria.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nuevaCategoria.Location = new System.Drawing.Point(57, 184);
            this.txt_nuevaCategoria.Name = "txt_nuevaCategoria";
            this.txt_nuevaCategoria.Size = new System.Drawing.Size(207, 34);
            this.txt_nuevaCategoria.TabIndex = 1;
            // 
            // cb_categorias
            // 
            this.cb_categorias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_categorias.FormattingEnabled = true;
            this.cb_categorias.Location = new System.Drawing.Point(999, 120);
            this.cb_categorias.Name = "cb_categorias";
            this.cb_categorias.Size = new System.Drawing.Size(209, 36);
            this.cb_categorias.TabIndex = 2;
            // 
            // btn_addCategoria
            // 
            this.btn_addCategoria.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCategoria.Location = new System.Drawing.Point(57, 250);
            this.btn_addCategoria.Name = "btn_addCategoria";
            this.btn_addCategoria.Size = new System.Drawing.Size(207, 37);
            this.btn_addCategoria.TabIndex = 3;
            this.btn_addCategoria.Text = "Agregar";
            this.btn_addCategoria.UseVisualStyleBackColor = true;
            this.btn_addCategoria.Click += new System.EventHandler(this.btn_addCategoria_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(415, 120);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(207, 34);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nueva Categoria";
            // 
            // ProductosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addCategoria);
            this.Controls.Add(this.cb_categorias);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_nuevaCategoria);
            this.Controls.Add(this.dgv_productos);
            this.Name = "ProductosView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.TextBox txt_nuevaCategoria;
        private System.Windows.Forms.ComboBox cb_categorias;
        private System.Windows.Forms.Button btn_addCategoria;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
    }
}

