namespace CourseWork
{
    partial class FormWithResults
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
            this.groupBoxWorst = new System.Windows.Forms.GroupBox();
            this.dataGridViewWorst = new System.Windows.Forms.DataGridView();
            this.groupBoxWorst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorst)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxWorst
            // 
            this.groupBoxWorst.Controls.Add(this.dataGridViewWorst);
            this.groupBoxWorst.Location = new System.Drawing.Point(12, 12);
            this.groupBoxWorst.Name = "groupBoxWorst";
            this.groupBoxWorst.Size = new System.Drawing.Size(254, 378);
            this.groupBoxWorst.TabIndex = 0;
            this.groupBoxWorst.TabStop = false;
            this.groupBoxWorst.Text = "Худший случай";
            // 
            // dataGridViewWorst
            // 
            this.dataGridViewWorst.AllowUserToAddRows = false;
            this.dataGridViewWorst.AllowUserToDeleteRows = false;
            this.dataGridViewWorst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridViewWorst.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewWorst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorst.ColumnHeadersVisible = false;
            this.dataGridViewWorst.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewWorst.Name = "dataGridViewWorst";
            this.dataGridViewWorst.Size = new System.Drawing.Size(242, 58);
            this.dataGridViewWorst.TabIndex = 1;
            // 
            // FormWithResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 398);
            this.Controls.Add(this.groupBoxWorst);
            this.Name = "FormWithResults";
            this.Text = "FormWithResults";
            this.Load += new System.EventHandler(this.FormWithResults_Load);
            this.groupBoxWorst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWorst;
        private System.Windows.Forms.DataGridView dataGridViewWorst;
    }
}