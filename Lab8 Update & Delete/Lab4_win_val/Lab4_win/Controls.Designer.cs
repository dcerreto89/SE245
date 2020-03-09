namespace Lab4_win
{
    partial class Controls
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
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSearchPeople = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(91, 102);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(133, 46);
            this.btnAddPerson.TabIndex = 0;
            this.btnAddPerson.Text = "Add a Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSearchPeople
            // 
            this.btnSearchPeople.Location = new System.Drawing.Point(321, 102);
            this.btnSearchPeople.Name = "btnSearchPeople";
            this.btnSearchPeople.Size = new System.Drawing.Size(133, 46);
            this.btnSearchPeople.TabIndex = 1;
            this.btnSearchPeople.Text = "Search People";
            this.btnSearchPeople.UseVisualStyleBackColor = true;
            this.btnSearchPeople.Click += new System.EventHandler(this.btnSearchPeople_Click);
            // 
            // Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 312);
            this.Controls.Add(this.btnSearchPeople);
            this.Controls.Add(this.btnAddPerson);
            this.Name = "Controls";
            this.Text = "Controls";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnSearchPeople;
    }
}