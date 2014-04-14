namespace CourseWork
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation verticalLineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.SortGroupBox = new System.Windows.Forms.GroupBox();
            this.HeapSortButton = new System.Windows.Forms.RadioButton();
            this.QuickSortButton = new System.Windows.Forms.RadioButton();
            this.BubbleSortButton = new System.Windows.Forms.RadioButton();
            this.BuildChartButton = new System.Windows.Forms.Button();
            this.backgroundWorkerForTesting = new System.ComponentModel.BackgroundWorker();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ShowResultsButton = new System.Windows.Forms.Button();
            this.NextTipButton = new System.Windows.Forms.Button();
            this.TipsLabel = new System.Windows.Forms.Label();
            this.TipsTextBox = new System.Windows.Forms.RichTextBox();
            this.labelTestingProgress = new System.Windows.Forms.Label();
            this.progressBarTestingProgress = new System.Windows.Forms.ProgressBar();
            this.CasesGroupBox = new System.Windows.Forms.GroupBox();
            this.BestCaseBox = new System.Windows.Forms.CheckBox();
            this.AverageCaseBox = new System.Windows.Forms.CheckBox();
            this.WorstCaseBox = new System.Windows.Forms.CheckBox();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxSortAnimation = new System.Windows.Forms.PictureBox();
            this.SortGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.CasesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSortAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // SortGroupBox
            // 
            this.SortGroupBox.Controls.Add(this.HeapSortButton);
            this.SortGroupBox.Controls.Add(this.QuickSortButton);
            this.SortGroupBox.Controls.Add(this.BubbleSortButton);
            this.SortGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SortGroupBox.Name = "SortGroupBox";
            this.SortGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SortGroupBox.Size = new System.Drawing.Size(572, 140);
            this.SortGroupBox.TabIndex = 1;
            this.SortGroupBox.TabStop = false;
            this.SortGroupBox.Text = "Выберите сортировку";
            // 
            // HeapSortButton
            // 
            this.HeapSortButton.AutoSize = true;
            this.HeapSortButton.Location = new System.Drawing.Point(6, 100);
            this.HeapSortButton.Name = "HeapSortButton";
            this.HeapSortButton.Size = new System.Drawing.Size(155, 22);
            this.HeapSortButton.TabIndex = 2;
            this.HeapSortButton.TabStop = true;
            this.HeapSortButton.Text = "Сортировка Кучей";
            this.HeapSortButton.UseVisualStyleBackColor = true;
            // 
            // QuickSortButton
            // 
            this.QuickSortButton.AutoSize = true;
            this.QuickSortButton.Location = new System.Drawing.Point(6, 72);
            this.QuickSortButton.Name = "QuickSortButton";
            this.QuickSortButton.Size = new System.Drawing.Size(171, 22);
            this.QuickSortButton.TabIndex = 1;
            this.QuickSortButton.TabStop = true;
            this.QuickSortButton.Text = "Быстрая сортировка";
            this.QuickSortButton.UseVisualStyleBackColor = true;
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.AutoSize = true;
            this.BubbleSortButton.Location = new System.Drawing.Point(6, 44);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(205, 22);
            this.BubbleSortButton.TabIndex = 0;
            this.BubbleSortButton.TabStop = true;
            this.BubbleSortButton.Text = "Пузырьковая сортировка";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            // 
            // BuildChartButton
            // 
            this.BuildChartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildChartButton.Location = new System.Drawing.Point(597, 21);
            this.BuildChartButton.Name = "BuildChartButton";
            this.BuildChartButton.Size = new System.Drawing.Size(166, 131);
            this.BuildChartButton.TabIndex = 2;
            this.BuildChartButton.Text = "Начать тестирование!";
            this.BuildChartButton.UseVisualStyleBackColor = true;
            this.BuildChartButton.Click += new System.EventHandler(this.BuildChartButton_Click);
            // 
            // backgroundWorkerForTesting
            // 
            this.backgroundWorkerForTesting.WorkerReportsProgress = true;
            this.backgroundWorkerForTesting.WorkerSupportsCancellation = true;
            this.backgroundWorkerForTesting.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerForTesting_DoWork);
            this.backgroundWorkerForTesting.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerForTesting_ProgressChanged);
            this.backgroundWorkerForTesting.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerForTesting_RunWorkerCompleted);
            // 
            // Chart1
            // 
            lineAnnotation1.Name = "LineAnnotation1";
            verticalLineAnnotation1.Name = "VerticalLineAnnotation1";
            this.Chart1.Annotations.Add(lineAnnotation1);
            this.Chart1.Annotations.Add(verticalLineAnnotation1);
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(16, 179);
            this.Chart1.Name = "Chart1";
            this.Chart1.Size = new System.Drawing.Size(567, 240);
            this.Chart1.TabIndex = 3;
            this.Chart1.Visible = false;
            // 
            // ShowResultsButton
            // 
            this.ShowResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowResultsButton.Location = new System.Drawing.Point(591, 366);
            this.ShowResultsButton.Name = "ShowResultsButton";
            this.ShowResultsButton.Size = new System.Drawing.Size(172, 82);
            this.ShowResultsButton.TabIndex = 17;
            this.ShowResultsButton.Text = "Перейти к результатам!";
            this.ShowResultsButton.UseVisualStyleBackColor = true;
            this.ShowResultsButton.Visible = false;
            this.ShowResultsButton.Click += new System.EventHandler(this.ShowResultsButton_Click);
            // 
            // NextTipButton
            // 
            this.NextTipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextTipButton.Location = new System.Drawing.Point(246, 155);
            this.NextTipButton.Name = "NextTipButton";
            this.NextTipButton.Size = new System.Drawing.Size(165, 38);
            this.NextTipButton.TabIndex = 16;
            this.NextTipButton.Text = "Следующий факт";
            this.NextTipButton.UseVisualStyleBackColor = true;
            this.NextTipButton.Visible = false;
            this.NextTipButton.Click += new System.EventHandler(this.NextTipButton_Click);
            // 
            // TipsLabel
            // 
            this.TipsLabel.AutoSize = true;
            this.TipsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TipsLabel.Location = new System.Drawing.Point(8, 169);
            this.TipsLabel.Name = "TipsLabel";
            this.TipsLabel.Size = new System.Drawing.Size(174, 24);
            this.TipsLabel.TabIndex = 15;
            this.TipsLabel.Text = "Немного фактов...";
            this.TipsLabel.Visible = false;
            // 
            // TipsTextBox
            // 
            this.TipsTextBox.Location = new System.Drawing.Point(12, 196);
            this.TipsTextBox.Name = "TipsTextBox";
            this.TipsTextBox.ReadOnly = true;
            this.TipsTextBox.Size = new System.Drawing.Size(744, 152);
            this.TipsTextBox.TabIndex = 14;
            this.TipsTextBox.Text = "";
            this.TipsTextBox.Visible = false;
            this.TipsTextBox.Click += new System.EventHandler(this.TipsTextBox_Click);
            // 
            // labelTestingProgress
            // 
            this.labelTestingProgress.AutoSize = true;
            this.labelTestingProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTestingProgress.Location = new System.Drawing.Point(6, 357);
            this.labelTestingProgress.Name = "labelTestingProgress";
            this.labelTestingProgress.Size = new System.Drawing.Size(262, 33);
            this.labelTestingProgress.TabIndex = 13;
            this.labelTestingProgress.Text = "Тестирование: 0%";
            this.labelTestingProgress.Visible = false;
            // 
            // progressBarTestingProgress
            // 
            this.progressBarTestingProgress.Location = new System.Drawing.Point(12, 393);
            this.progressBarTestingProgress.MarqueeAnimationSpeed = 1;
            this.progressBarTestingProgress.Name = "progressBarTestingProgress";
            this.progressBarTestingProgress.Size = new System.Drawing.Size(565, 56);
            this.progressBarTestingProgress.Step = 1;
            this.progressBarTestingProgress.TabIndex = 12;
            this.progressBarTestingProgress.Visible = false;
            // 
            // CasesGroupBox
            // 
            this.CasesGroupBox.Controls.Add(this.BestCaseBox);
            this.CasesGroupBox.Controls.Add(this.AverageCaseBox);
            this.CasesGroupBox.Controls.Add(this.WorstCaseBox);
            this.CasesGroupBox.Location = new System.Drawing.Point(591, 182);
            this.CasesGroupBox.Name = "CasesGroupBox";
            this.CasesGroupBox.Size = new System.Drawing.Size(165, 166);
            this.CasesGroupBox.TabIndex = 11;
            this.CasesGroupBox.TabStop = false;
            this.CasesGroupBox.Text = "Отображать";
            this.CasesGroupBox.Visible = false;
            // 
            // BestCaseBox
            // 
            this.BestCaseBox.AutoSize = true;
            this.BestCaseBox.Checked = true;
            this.BestCaseBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BestCaseBox.Location = new System.Drawing.Point(7, 69);
            this.BestCaseBox.Name = "BestCaseBox";
            this.BestCaseBox.Size = new System.Drawing.Size(104, 17);
            this.BestCaseBox.TabIndex = 2;
            this.BestCaseBox.Text = "Лучший случай ";
            this.BestCaseBox.UseVisualStyleBackColor = true;
            this.BestCaseBox.CheckedChanged += new System.EventHandler(this.BestCaseBox_CheckedChanged);
            // 
            // AverageCaseBox
            // 
            this.AverageCaseBox.AutoSize = true;
            this.AverageCaseBox.Checked = true;
            this.AverageCaseBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AverageCaseBox.Location = new System.Drawing.Point(7, 46);
            this.AverageCaseBox.Name = "AverageCaseBox";
            this.AverageCaseBox.Size = new System.Drawing.Size(106, 17);
            this.AverageCaseBox.TabIndex = 1;
            this.AverageCaseBox.Text = "Средний случай";
            this.AverageCaseBox.UseVisualStyleBackColor = true;
            this.AverageCaseBox.CheckedChanged += new System.EventHandler(this.AverageCaseBox_CheckedChanged);
            // 
            // WorstCaseBox
            // 
            this.WorstCaseBox.AutoSize = true;
            this.WorstCaseBox.Checked = true;
            this.WorstCaseBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WorstCaseBox.Location = new System.Drawing.Point(7, 23);
            this.WorstCaseBox.Name = "WorstCaseBox";
            this.WorstCaseBox.Size = new System.Drawing.Size(104, 17);
            this.WorstCaseBox.TabIndex = 0;
            this.WorstCaseBox.Text = "Худший случай ";
            this.WorstCaseBox.UseVisualStyleBackColor = true;
            this.WorstCaseBox.CheckedChanged += new System.EventHandler(this.WorstCaseBox_CheckedChanged);
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart.Legends.Add(legend2);
            this.Chart.Location = new System.Drawing.Point(6, 196);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(572, 234);
            this.Chart.TabIndex = 10;
            this.Chart.Text = "График";
            this.Chart.Visible = false;
            // 
            // pictureBoxSortAnimation
            // 
            this.pictureBoxSortAnimation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSortAnimation.Location = new System.Drawing.Point(597, 12);
            this.pictureBoxSortAnimation.Name = "pictureBoxSortAnimation";
            this.pictureBoxSortAnimation.Size = new System.Drawing.Size(166, 147);
            this.pictureBoxSortAnimation.TabIndex = 18;
            this.pictureBoxSortAnimation.TabStop = false;
            this.pictureBoxSortAnimation.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 454);
            this.Controls.Add(this.pictureBoxSortAnimation);
            this.Controls.Add(this.NextTipButton);
            this.Controls.Add(this.ShowResultsButton);
            this.Controls.Add(this.TipsLabel);
            this.Controls.Add(this.TipsTextBox);
            this.Controls.Add(this.labelTestingProgress);
            this.Controls.Add(this.progressBarTestingProgress);
            this.Controls.Add(this.CasesGroupBox);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.BuildChartButton);
            this.Controls.Add(this.SortGroupBox);
            this.Name = "MainForm";
            this.Text = "Время работы сортировок";
            this.SortGroupBox.ResumeLayout(false);
            this.SortGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.CasesGroupBox.ResumeLayout(false);
            this.CasesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSortAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SortGroupBox;
        private System.Windows.Forms.RadioButton HeapSortButton;
        private System.Windows.Forms.RadioButton QuickSortButton;
        private System.Windows.Forms.RadioButton BubbleSortButton;
        private System.Windows.Forms.Button BuildChartButton;
        private System.ComponentModel.BackgroundWorker backgroundWorkerForTesting;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.Button ShowResultsButton;
        private System.Windows.Forms.Button NextTipButton;
        private System.Windows.Forms.Label TipsLabel;
        private System.Windows.Forms.RichTextBox TipsTextBox;
        private System.Windows.Forms.Label labelTestingProgress;
        private System.Windows.Forms.ProgressBar progressBarTestingProgress;
        private System.Windows.Forms.GroupBox CasesGroupBox;
        private System.Windows.Forms.CheckBox BestCaseBox;
        private System.Windows.Forms.CheckBox AverageCaseBox;
        private System.Windows.Forms.CheckBox WorstCaseBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.PictureBox pictureBoxSortAnimation;
    }
}

