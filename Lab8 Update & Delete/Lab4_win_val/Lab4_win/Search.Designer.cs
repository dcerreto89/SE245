namespace Lab4_win
{
    partial class Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchFName = new System.Windows.Forms.TextBox();
            this.txtSearchLName = new System.Windows.Forms.TextBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // txtSearchFName
            // 
            this.txtSearchFName.Location = new System.Drawing.Point(181, 65);
            this.txtSearchFName.Name = "txtSearchFName";
            this.txtSearchFName.Size = new System.Drawing.Size(129, 20);
            this.txtSearchFName.TabIndex = 2;
            // 
            // txtSearchLName
            // 
            this.txtSearchLName.Location = new System.Drawing.Point(506, 65);
            this.txtSearchLName.Name = "txtSearchLName";
            this.txtSearchLName.Size = new System.Drawing.Size(129, 20);
            this.txtSearchLName.TabIndex = 3;
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 207);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(770, 283);
            this.dgvResults.TabIndex = 4;
            this.dgvResults.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentDoubleClick);
            this.dgvResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(344, 144);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 502);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.txtSearchLName);
            this.Controls.Add(this.txtSearchFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchFName;
        private System.Windows.Forms.TextBox txtSearchLName;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnSearch;
    }
}