namespace WebCrawlerTester
{
    partial class Main
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
            this.lblPage = new System.Windows.Forms.Label();
            this.cmdGet = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblResults = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.gmdGetMore = new System.Windows.Forms.Button();
            this.cmdGetLess = new System.Windows.Forms.Button();
            this.cmdGetAll = new System.Windows.Forms.Button();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(12, 9);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(216, 13);
            this.lblPage.TabIndex = 0;
            this.lblPage.Text = "Web Page: https://news.ycombinator.com/ ";
            // 
            // cmdGet
            // 
            this.cmdGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGet.Location = new System.Drawing.Point(501, 4);
            this.cmdGet.Name = "cmdGet";
            this.cmdGet.Size = new System.Drawing.Size(140, 23);
            this.cmdGet.TabIndex = 1;
            this.cmdGet.Text = "Get Data";
            this.cmdGet.UseVisualStyleBackColor = true;
            this.cmdGet.Click += new System.EventHandler(this.cmdGet_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToOrderColumns = true;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 164);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(629, 178);
            this.dgvResults.TabIndex = 2;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(12, 148);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(42, 13);
            this.lblResults.TabIndex = 3;
            this.lblResults.Text = "Results";
            // 
            // grpFilter
            // 
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilter.Controls.Add(this.txtSearch);
            this.grpFilter.Controls.Add(this.cmdSearch);
            this.grpFilter.Controls.Add(this.cmdGetAll);
            this.grpFilter.Controls.Add(this.cmdGetLess);
            this.grpFilter.Controls.Add(this.gmdGetMore);
            this.grpFilter.Location = new System.Drawing.Point(15, 37);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(626, 108);
            this.grpFilter.TabIndex = 4;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filters";
            // 
            // gmdGetMore
            // 
            this.gmdGetMore.Location = new System.Drawing.Point(6, 19);
            this.gmdGetMore.Name = "gmdGetMore";
            this.gmdGetMore.Size = new System.Drawing.Size(260, 23);
            this.gmdGetMore.TabIndex = 2;
            this.gmdGetMore.Text = "Get entries with more than five words";
            this.gmdGetMore.UseVisualStyleBackColor = true;
            this.gmdGetMore.Click += new System.EventHandler(this.gmdGetMore_Click);
            // 
            // cmdGetLess
            // 
            this.cmdGetLess.Location = new System.Drawing.Point(6, 48);
            this.cmdGetLess.Name = "cmdGetLess";
            this.cmdGetLess.Size = new System.Drawing.Size(260, 23);
            this.cmdGetLess.TabIndex = 3;
            this.cmdGetLess.Text = "Get entries with less than or equal to five words";
            this.cmdGetLess.UseVisualStyleBackColor = true;
            this.cmdGetLess.Click += new System.EventHandler(this.cmdGetLess_Click);
            // 
            // cmdGetAll
            // 
            this.cmdGetAll.Location = new System.Drawing.Point(6, 77);
            this.cmdGetAll.Name = "cmdGetAll";
            this.cmdGetAll.Size = new System.Drawing.Size(260, 23);
            this.cmdGetAll.TabIndex = 4;
            this.cmdGetAll.Text = "Get all entries";
            this.cmdGetAll.UseVisualStyleBackColor = true;
            this.cmdGetAll.Click += new System.EventHandler(this.cmdGetAll_Click);
            // 
            // cmdSearch
            // 
            this.cmdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSearch.Location = new System.Drawing.Point(360, 48);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(260, 23);
            this.cmdSearch.TabIndex = 5;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(360, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 354);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.cmdGet);
            this.Controls.Add(this.lblPage);
            this.Name = "Main";
            this.Text = "Web Crawler Tester";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button cmdGet;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button cmdGetAll;
        private System.Windows.Forms.Button cmdGetLess;
        private System.Windows.Forms.Button gmdGetMore;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

