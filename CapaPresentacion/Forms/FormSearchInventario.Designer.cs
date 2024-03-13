namespace CapaPresentacion.Forms
{
    partial class FormSearchInventario
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
            this.TituloDelete = new System.Windows.Forms.Label();
            this.PanelbusquedaDELETE = new System.Windows.Forms.Panel();
            this.ButtonSearch = new FontAwesome.Sharp.IconButton();
            this.TextBoxSearch = new ZBobb.AlphaBlendTextBox();
            this.panel_search_load = new System.Windows.Forms.Panel();
            this.Label_Price_find = new System.Windows.Forms.Label();
            this.Label_Decription_find = new System.Windows.Forms.Label();
            this.Label_stock_find = new System.Windows.Forms.Label();
            this.Label_Name_find = new System.Windows.Forms.Label();
            this.labelTitlePrice = new System.Windows.Forms.Label();
            this.labelTitleStock = new System.Windows.Forms.Label();
            this.labelTitleDescripcion = new System.Windows.Forms.Label();
            this.labelTitleName = new System.Windows.Forms.Label();
            this.PanelbusquedaDELETE.SuspendLayout();
            this.panel_search_load.SuspendLayout();
            this.SuspendLayout();
            // 
            // TituloDelete
            // 
            this.TituloDelete.AutoSize = true;
            this.TituloDelete.BackColor = System.Drawing.Color.Transparent;
            this.TituloDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.TituloDelete.Location = new System.Drawing.Point(44, 92);
            this.TituloDelete.Name = "TituloDelete";
            this.TituloDelete.Size = new System.Drawing.Size(275, 25);
            this.TituloDelete.TabIndex = 0;
            this.TituloDelete.Text = "Busquedad de productos.";
            this.TituloDelete.Click += new System.EventHandler(this.TituloDelete_Click);
            // 
            // PanelbusquedaDELETE
            // 
            this.PanelbusquedaDELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(124)))));
            this.PanelbusquedaDELETE.Controls.Add(this.ButtonSearch);
            this.PanelbusquedaDELETE.Controls.Add(this.TextBoxSearch);
            this.PanelbusquedaDELETE.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelbusquedaDELETE.Location = new System.Drawing.Point(0, 0);
            this.PanelbusquedaDELETE.Name = "PanelbusquedaDELETE";
            this.PanelbusquedaDELETE.Size = new System.Drawing.Size(1034, 173);
            this.PanelbusquedaDELETE.TabIndex = 3;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.FlatAppearance.BorderSize = 0;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ButtonSearch.IconColor = System.Drawing.Color.White;
            this.ButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSearch.IconSize = 30;
            this.ButtonSearch.Location = new System.Drawing.Point(816, 63);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(56, 35);
            this.ButtonSearch.TabIndex = 1;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BackAlpha = 0;
            this.TextBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.ForeColor = System.Drawing.Color.White;
            this.TextBoxSearch.Location = new System.Drawing.Point(119, 63);
            this.TextBoxSearch.Multiline = true;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(680, 35);
            this.TextBoxSearch.TabIndex = 0;
            // 
            // panel_search_load
            // 
            this.panel_search_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(87)))), ((int)(((byte)(176)))));
            this.panel_search_load.Controls.Add(this.Label_Price_find);
            this.panel_search_load.Controls.Add(this.Label_Decription_find);
            this.panel_search_load.Controls.Add(this.TituloDelete);
            this.panel_search_load.Controls.Add(this.Label_stock_find);
            this.panel_search_load.Controls.Add(this.Label_Name_find);
            this.panel_search_load.Controls.Add(this.labelTitlePrice);
            this.panel_search_load.Controls.Add(this.labelTitleStock);
            this.panel_search_load.Controls.Add(this.labelTitleDescripcion);
            this.panel_search_load.Controls.Add(this.labelTitleName);
            this.panel_search_load.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_search_load.Location = new System.Drawing.Point(0, 128);
            this.panel_search_load.Name = "panel_search_load";
            this.panel_search_load.Size = new System.Drawing.Size(1034, 525);
            this.panel_search_load.TabIndex = 2;
            this.panel_search_load.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_search_load_Paint);
            // 
            // Label_Price_find
            // 
            this.Label_Price_find.AutoSize = true;
            this.Label_Price_find.BackColor = System.Drawing.Color.Transparent;
            this.Label_Price_find.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Price_find.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Price_find.Location = new System.Drawing.Point(460, 381);
            this.Label_Price_find.Name = "Label_Price_find";
            this.Label_Price_find.Size = new System.Drawing.Size(24, 19);
            this.Label_Price_find.TabIndex = 8;
            this.Label_Price_find.Text = "...";
            this.Label_Price_find.Click += new System.EventHandler(this.label3_Click);
            // 
            // Label_Decription_find
            // 
            this.Label_Decription_find.AutoSize = true;
            this.Label_Decription_find.BackColor = System.Drawing.Color.Transparent;
            this.Label_Decription_find.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Decription_find.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Decription_find.Location = new System.Drawing.Point(460, 221);
            this.Label_Decription_find.Name = "Label_Decription_find";
            this.Label_Decription_find.Size = new System.Drawing.Size(24, 19);
            this.Label_Decription_find.TabIndex = 7;
            this.Label_Decription_find.Text = "...";
            this.Label_Decription_find.Click += new System.EventHandler(this.label2_Click);
            // 
            // Label_stock_find
            // 
            this.Label_stock_find.AutoSize = true;
            this.Label_stock_find.BackColor = System.Drawing.Color.Transparent;
            this.Label_stock_find.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_stock_find.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_stock_find.Location = new System.Drawing.Point(49, 381);
            this.Label_stock_find.Name = "Label_stock_find";
            this.Label_stock_find.Size = new System.Drawing.Size(24, 19);
            this.Label_stock_find.TabIndex = 6;
            this.Label_stock_find.Text = "...";
            this.Label_stock_find.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_Name_find
            // 
            this.Label_Name_find.AutoSize = true;
            this.Label_Name_find.BackColor = System.Drawing.Color.Transparent;
            this.Label_Name_find.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name_find.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Name_find.Location = new System.Drawing.Point(49, 233);
            this.Label_Name_find.Name = "Label_Name_find";
            this.Label_Name_find.Size = new System.Drawing.Size(24, 19);
            this.Label_Name_find.TabIndex = 5;
            this.Label_Name_find.Text = "...";
            this.Label_Name_find.Click += new System.EventHandler(this.Name_label_search_Click);
            // 
            // labelTitlePrice
            // 
            this.labelTitlePrice.AutoSize = true;
            this.labelTitlePrice.BackColor = System.Drawing.Color.Transparent;
            this.labelTitlePrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlePrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitlePrice.Location = new System.Drawing.Point(459, 338);
            this.labelTitlePrice.Name = "labelTitlePrice";
            this.labelTitlePrice.Size = new System.Drawing.Size(81, 25);
            this.labelTitlePrice.TabIndex = 4;
            this.labelTitlePrice.Text = "Precio:";
            this.labelTitlePrice.Click += new System.EventHandler(this.labelTitlePrice_Click);
            // 
            // labelTitleStock
            // 
            this.labelTitleStock.AutoSize = true;
            this.labelTitleStock.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleStock.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleStock.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitleStock.Location = new System.Drawing.Point(44, 338);
            this.labelTitleStock.Name = "labelTitleStock";
            this.labelTitleStock.Size = new System.Drawing.Size(73, 25);
            this.labelTitleStock.TabIndex = 3;
            this.labelTitleStock.Text = "Stock:";
            this.labelTitleStock.Click += new System.EventHandler(this.labelTitleStock_Click);
            // 
            // labelTitleDescripcion
            // 
            this.labelTitleDescripcion.AutoSize = true;
            this.labelTitleDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleDescripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleDescripcion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitleDescripcion.Location = new System.Drawing.Point(459, 184);
            this.labelTitleDescripcion.Name = "labelTitleDescripcion";
            this.labelTitleDescripcion.Size = new System.Drawing.Size(275, 25);
            this.labelTitleDescripcion.TabIndex = 2;
            this.labelTitleDescripcion.Text = "Descripcion del producto:";
            this.labelTitleDescripcion.Click += new System.EventHandler(this.labelTitleDescripcion_Click);
            // 
            // labelTitleName
            // 
            this.labelTitleName.AutoSize = true;
            this.labelTitleName.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitleName.Location = new System.Drawing.Point(44, 184);
            this.labelTitleName.Name = "labelTitleName";
            this.labelTitleName.Size = new System.Drawing.Size(238, 25);
            this.labelTitleName.TabIndex = 1;
            this.labelTitleName.Text = "Nombre del producto:";
            this.labelTitleName.Click += new System.EventHandler(this.labelTitleName_Click);
            // 
            // FormSearchInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 653);
            this.Controls.Add(this.PanelbusquedaDELETE);
            this.Controls.Add(this.panel_search_load);
            this.Name = "FormSearchInventario";
            this.Text = "FormSearchInventario";
            this.Load += new System.EventHandler(this.FormSearchInventario_Load);
            this.PanelbusquedaDELETE.ResumeLayout(false);
            this.PanelbusquedaDELETE.PerformLayout();
            this.panel_search_load.ResumeLayout(false);
            this.panel_search_load.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TituloDelete;
        private System.Windows.Forms.Panel PanelbusquedaDELETE;
        private FontAwesome.Sharp.IconButton ButtonSearch;
        private ZBobb.AlphaBlendTextBox TextBoxSearch;
        private System.Windows.Forms.Panel panel_search_load;
        private System.Windows.Forms.Label Label_Price_find;
        private System.Windows.Forms.Label Label_Decription_find;
        private System.Windows.Forms.Label Label_stock_find;
        private System.Windows.Forms.Label Label_Name_find;
        private System.Windows.Forms.Label labelTitlePrice;
        private System.Windows.Forms.Label labelTitleStock;
        private System.Windows.Forms.Label labelTitleDescripcion;
        private System.Windows.Forms.Label labelTitleName;
    }
}