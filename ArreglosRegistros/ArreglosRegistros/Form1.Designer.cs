
namespace ArreglosRegistros
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreDelProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPrecioDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porExistenciaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
             
            // 
            // menuPToolStripMenuItem
            // 
            this.menuPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDatosToolStripMenuItem,
            this.mostrarDatosToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.modificarDatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuPToolStripMenuItem.Name = "menuPToolStripMenuItem";
            this.menuPToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPToolStripMenuItem.Text = "Menu Principal";
            // 
            // agregarDatosToolStripMenuItem
            // 
            this.agregarDatosToolStripMenuItem.Name = "agregarDatosToolStripMenuItem";
            this.agregarDatosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.agregarDatosToolStripMenuItem.Text = "Agregar Datos";
            // 
            // mostrarDatosToolStripMenuItem
            // 
            this.mostrarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosDatosToolStripMenuItem,
            this.porNombreDelProductosToolStripMenuItem,
            this.porPrecioDeProductosToolStripMenuItem,
            this.porExistenciaDeProductosToolStripMenuItem});
            this.mostrarDatosToolStripMenuItem.Name = "mostrarDatosToolStripMenuItem";
            this.mostrarDatosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.mostrarDatosToolStripMenuItem.Text = "Mostrar Datos";
            // 
            // todosLosDatosToolStripMenuItem
            // 
            this.todosLosDatosToolStripMenuItem.Name = "todosLosDatosToolStripMenuItem";
            this.todosLosDatosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.todosLosDatosToolStripMenuItem.Text = "Todos los Datos";
            // 
            // porNombreDelProductosToolStripMenuItem
            // 
            this.porNombreDelProductosToolStripMenuItem.Name = "porNombreDelProductosToolStripMenuItem";
            this.porNombreDelProductosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.porNombreDelProductosToolStripMenuItem.Text = "por Nombre del Productos";
            // 
            // porPrecioDeProductosToolStripMenuItem
            // 
            this.porPrecioDeProductosToolStripMenuItem.Name = "porPrecioDeProductosToolStripMenuItem";
            this.porPrecioDeProductosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.porPrecioDeProductosToolStripMenuItem.Text = "por Precio de Productos";
            // 
            // porExistenciaDeProductosToolStripMenuItem
            // 
            this.porExistenciaDeProductosToolStripMenuItem.Name = "porExistenciaDeProductosToolStripMenuItem";
            this.porExistenciaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.porExistenciaDeProductosToolStripMenuItem.Text = "por Existencia de Productos";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar Datos";
            // 
            // modificarDatosToolStripMenuItem
            // 
            this.modificarDatosToolStripMenuItem.Name = "modificarDatosToolStripMenuItem";
            this.modificarDatosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.modificarDatosToolStripMenuItem.Text = "Modificar Datos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(154, 27);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(581, 247);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
             
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 66;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre del Prducto";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio del Producto";
            this.columnHeader3.Width = 156;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Existencia del Producto";
            this.columnHeader4.Width = 366;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
             
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreDelProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPrecioDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porExistenciaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

