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
            this.tabControlCases = new System.Windows.Forms.TabControl();
            this.tabPageWorst = new System.Windows.Forms.TabPage();
            this.dataGridViewWorst = new System.Windows.Forms.DataGridView();
            this.tabPageAverage = new System.Windows.Forms.TabPage();
            this.dataGridViewAverage = new System.Windows.Forms.DataGridView();
            this.tabPageBest = new System.Windows.Forms.TabPage();
            this.dataGridViewBest = new System.Windows.Forms.DataGridView();
            this.labelWorst = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelBest = new System.Windows.Forms.Label();
            this.tabControlCases.SuspendLayout();
            this.tabPageWorst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorst)).BeginInit();
            this.tabPageAverage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAverage)).BeginInit();
            this.tabPageBest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBest)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCases
            // 
            this.tabControlCases.Controls.Add(this.tabPageWorst);
            this.tabControlCases.Controls.Add(this.tabPageAverage);
            this.tabControlCases.Controls.Add(this.tabPageBest);
            this.tabControlCases.Location = new System.Drawing.Point(12, 12);
            this.tabControlCases.Name = "tabControlCases";
            this.tabControlCases.SelectedIndex = 0;
            this.tabControlCases.Size = new System.Drawing.Size(843, 374);
            this.tabControlCases.TabIndex = 0;
            // 
            // tabPageWorst
            // 
            this.tabPageWorst.Controls.Add(this.labelWorst);
            this.tabPageWorst.Controls.Add(this.dataGridViewWorst);
            this.tabPageWorst.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorst.Name = "tabPageWorst";
            this.tabPageWorst.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorst.Size = new System.Drawing.Size(835, 348);
            this.tabPageWorst.TabIndex = 0;
            this.tabPageWorst.Text = "Худший случай";
            this.tabPageWorst.UseVisualStyleBackColor = true;
            this.tabPageWorst.Click += new System.EventHandler(this.tabPageWorst_Click);
            // 
            // dataGridViewWorst
            // 
            this.dataGridViewWorst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorst.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewWorst.Name = "dataGridViewWorst";
            this.dataGridViewWorst.RowHeadersWidth = 150;
            this.dataGridViewWorst.Size = new System.Drawing.Size(823, 86);
            this.dataGridViewWorst.TabIndex = 0;
            // 
            // tabPageAverage
            // 
            this.tabPageAverage.Controls.Add(this.labelAverage);
            this.tabPageAverage.Controls.Add(this.dataGridViewAverage);
            this.tabPageAverage.Location = new System.Drawing.Point(4, 22);
            this.tabPageAverage.Name = "tabPageAverage";
            this.tabPageAverage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAverage.Size = new System.Drawing.Size(835, 348);
            this.tabPageAverage.TabIndex = 1;
            this.tabPageAverage.Text = "Средний случай";
            this.tabPageAverage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAverage
            // 
            this.dataGridViewAverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAverage.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAverage.Name = "dataGridViewAverage";
            this.dataGridViewAverage.RowHeadersWidth = 150;
            this.dataGridViewAverage.Size = new System.Drawing.Size(823, 86);
            this.dataGridViewAverage.TabIndex = 1;
            // 
            // tabPageBest
            // 
            this.tabPageBest.Controls.Add(this.labelBest);
            this.tabPageBest.Controls.Add(this.dataGridViewBest);
            this.tabPageBest.Location = new System.Drawing.Point(4, 22);
            this.tabPageBest.Name = "tabPageBest";
            this.tabPageBest.Size = new System.Drawing.Size(835, 348);
            this.tabPageBest.TabIndex = 2;
            this.tabPageBest.Text = "Лучший случай";
            this.tabPageBest.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBest
            // 
            this.dataGridViewBest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBest.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBest.Name = "dataGridViewBest";
            this.dataGridViewBest.RowHeadersWidth = 150;
            this.dataGridViewBest.Size = new System.Drawing.Size(823, 86);
            this.dataGridViewBest.TabIndex = 1;
            // 
            // labelWorst
            // 
            this.labelWorst.AutoSize = true;
            this.labelWorst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorst.Location = new System.Drawing.Point(3, 92);
            this.labelWorst.Name = "labelWorst";
            this.labelWorst.Size = new System.Drawing.Size(70, 25);
            this.labelWorst.TabIndex = 1;
            this.labelWorst.Text = "label1";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAverage.Location = new System.Drawing.Point(3, 92);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(70, 26);
            this.labelAverage.TabIndex = 2;
            this.labelAverage.Text = "label1";
            // 
            // labelBest
            // 
            this.labelBest.AutoSize = true;
            this.labelBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBest.Location = new System.Drawing.Point(3, 92);
            this.labelBest.Name = "labelBest";
            this.labelBest.Size = new System.Drawing.Size(70, 26);
            this.labelBest.TabIndex = 2;
            this.labelBest.Text = "label1";
            // 
            // FormWithResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 398);
            this.Controls.Add(this.tabControlCases);
            this.Name = "FormWithResults";
            this.Text = "FormWithResults";
            this.Load += new System.EventHandler(this.FormWithResults_Load);
            this.tabControlCases.ResumeLayout(false);
            this.tabPageWorst.ResumeLayout(false);
            this.tabPageWorst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorst)).EndInit();
            this.tabPageAverage.ResumeLayout(false);
            this.tabPageAverage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAverage)).EndInit();
            this.tabPageBest.ResumeLayout(false);
            this.tabPageBest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCases;
        private System.Windows.Forms.TabPage tabPageWorst;
        private System.Windows.Forms.TabPage tabPageAverage;
        private System.Windows.Forms.DataGridView dataGridViewWorst;
        private System.Windows.Forms.TabPage tabPageBest;
        private System.Windows.Forms.DataGridView dataGridViewAverage;
        private System.Windows.Forms.DataGridView dataGridViewBest;
        private System.Windows.Forms.Label labelWorst;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelBest;

    }
}