﻿
namespace Gestor_Articulos
{
    partial class Marcas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DgvMarcas = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Lbltitulo = new System.Windows.Forms.Label();
            this.Gbmac = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMarcas)).BeginInit();
            this.Gbmac.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.articulosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(313, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gestionarToolStripMenuItem.Text = "Ges&tionar";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTodasToolStripMenuItem,
            this.nuevoToolStripMenuItem1});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriasToolStripMenuItem.Text = "Cat&egorias";
            // 
            // verTodasToolStripMenuItem
            // 
            this.verTodasToolStripMenuItem.Name = "verTodasToolStripMenuItem";
            this.verTodasToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.verTodasToolStripMenuItem.Text = "Ver Todas";
            this.verTodasToolStripMenuItem.Click += new System.EventHandler(this.verTodasToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.nuevoToolStripMenuItem1.Text = "Nuevo";
            this.nuevoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoToolStripMenuItem1_Click);
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTodosToolStripMenuItem,
            this.nuevoToolStripMenuItem2});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.articulosToolStripMenuItem.Text = "&Articulos";
            // 
            // verTodosToolStripMenuItem
            // 
            this.verTodosToolStripMenuItem.Name = "verTodosToolStripMenuItem";
            this.verTodosToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.verTodosToolStripMenuItem.Text = "Ver todos";
            this.verTodosToolStripMenuItem.Click += new System.EventHandler(this.verTodosToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem2
            // 
            this.nuevoToolStripMenuItem2.Name = "nuevoToolStripMenuItem2";
            this.nuevoToolStripMenuItem2.Size = new System.Drawing.Size(123, 22);
            this.nuevoToolStripMenuItem2.Text = "Nuevo";
            this.nuevoToolStripMenuItem2.Click += new System.EventHandler(this.nuevoToolStripMenuItem2_Click);
            // 
            // DgvMarcas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            this.DgvMarcas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMarcas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMarcas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvMarcas.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.DgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMarcas.Location = new System.Drawing.Point(20, 19);
            this.DgvMarcas.Name = "DgvMarcas";
            this.DgvMarcas.Size = new System.Drawing.Size(248, 90);
            this.DgvMarcas.TabIndex = 1;
            this.DgvMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMarcas_CellContentClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.Location = new System.Drawing.Point(186, 187);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(56, 187);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Lbltitulo
            // 
            this.Lbltitulo.AutoSize = true;
            this.Lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitulo.Location = new System.Drawing.Point(120, 47);
            this.Lbltitulo.Name = "Lbltitulo";
            this.Lbltitulo.Size = new System.Drawing.Size(59, 16);
            this.Lbltitulo.TabIndex = 5;
            this.Lbltitulo.Text = "Marcas";
            // 
            // Gbmac
            // 
            this.Gbmac.Controls.Add(this.DgvMarcas);
            this.Gbmac.Location = new System.Drawing.Point(12, 63);
            this.Gbmac.Name = "Gbmac";
            this.Gbmac.Size = new System.Drawing.Size(289, 118);
            this.Gbmac.TabIndex = 6;
            this.Gbmac.TabStop = false;
            // 
            // Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(313, 245);
            this.Controls.Add(this.Lbltitulo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Gbmac);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Marcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.Marcas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMarcas)).EndInit();
            this.Gbmac.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView DgvMarcas;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label Lbltitulo;
        private System.Windows.Forms.GroupBox Gbmac;
    }
}