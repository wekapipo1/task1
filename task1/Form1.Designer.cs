namespace task1
{
    partial class frmGraphics
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.cbGraphics = new System.Windows.Forms.ComboBox();
            this.txtZnach = new System.Windows.Forms.TextBox();
            this.chkSin = new System.Windows.Forms.CheckBox();
            this.chkCos = new System.Windows.Forms.CheckBox();
            this.chkCos2 = new System.Windows.Forms.CheckBox();
            this.chkFunc1 = new System.Windows.Forms.CheckBox();
            this.chkFunc2 = new System.Windows.Forms.CheckBox();
            this.btCount = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraph.Legends.Add(legend1);
            this.chartGraph.Location = new System.Drawing.Point(12, 13);
            this.chartGraph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartGraph.Name = "chartGraph";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series1.Legend = "Legend1";
            series1.Name = "sin(x)";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series2.Legend = "Legend1";
            series2.Name = "cos(x)";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series3.Legend = "Legend1";
            series3.Name = "cos(x)+2x";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series4.Legend = "Legend1";
            series4.Name = "кв. корінь(х)";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series5.Legend = "Legend1";
            series5.Name = "4+x+x^2";
            this.chartGraph.Series.Add(series1);
            this.chartGraph.Series.Add(series2);
            this.chartGraph.Series.Add(series3);
            this.chartGraph.Series.Add(series4);
            this.chartGraph.Series.Add(series5);
            this.chartGraph.Size = new System.Drawing.Size(538, 637);
            this.chartGraph.TabIndex = 0;
            this.chartGraph.Text = "Графіки";
            this.chartGraph.Click += new System.EventHandler(this.chartGraph_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStep);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(556, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(261, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Початкові дані:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkFunc2);
            this.groupBox2.Controls.Add(this.chkFunc1);
            this.groupBox2.Controls.Add(this.chkCos2);
            this.groupBox2.Controls.Add(this.chkCos);
            this.groupBox2.Controls.Add(this.chkSin);
            this.groupBox2.Location = new System.Drawing.Point(556, 225);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(261, 359);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Побудова графіків:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtZnach);
            this.groupBox3.Controls.Add(this.cbGraphics);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(823, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(253, 571);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Значення графіка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть Xmin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введіть Xmax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введіть крок:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 70);
            this.label4.TabIndex = 0;
            this.label4.Text = "Виберіть функцію, значення якої треба показати:";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(141, 49);
            this.txtMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(95, 26);
            this.txtMin.TabIndex = 3;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(141, 101);
            this.txtMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(95, 26);
            this.txtMax.TabIndex = 4;
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(141, 152);
            this.txtStep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(95, 26);
            this.txtStep.TabIndex = 5;
            // 
            // cbGraphics
            // 
            this.cbGraphics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGraphics.FormattingEnabled = true;
            this.cbGraphics.Location = new System.Drawing.Point(24, 107);
            this.cbGraphics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGraphics.Name = "cbGraphics";
            this.cbGraphics.Size = new System.Drawing.Size(207, 28);
            this.cbGraphics.TabIndex = 1;
            // 
            // txtZnach
            // 
            this.txtZnach.Location = new System.Drawing.Point(24, 172);
            this.txtZnach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtZnach.Multiline = true;
            this.txtZnach.Name = "txtZnach";
            this.txtZnach.Size = new System.Drawing.Size(207, 349);
            this.txtZnach.TabIndex = 2;
            this.txtZnach.TextChanged += new System.EventHandler(this.txtZnach_TextChanged);
            // 
            // chkSin
            // 
            this.chkSin.AutoSize = true;
            this.chkSin.Location = new System.Drawing.Point(14, 37);
            this.chkSin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSin.Name = "chkSin";
            this.chkSin.Size = new System.Drawing.Size(241, 24);
            this.chkSin.TabIndex = 0;
            this.chkSin.Text = "Побудувати графік sin(x)";
            this.chkSin.UseVisualStyleBackColor = true;
            // 
            // chkCos
            // 
            this.chkCos.AutoSize = true;
            this.chkCos.Location = new System.Drawing.Point(14, 82);
            this.chkCos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCos.Name = "chkCos";
            this.chkCos.Size = new System.Drawing.Size(246, 24);
            this.chkCos.TabIndex = 1;
            this.chkCos.Text = "Побудувати графік cos(x)";
            this.chkCos.UseVisualStyleBackColor = true;
            this.chkCos.CheckedChanged += new System.EventHandler(this.chkCos_CheckedChanged);
            // 
            // chkCos2
            // 
            this.chkCos2.BackColor = System.Drawing.SystemColors.Control;
            this.chkCos2.Location = new System.Drawing.Point(14, 129);
            this.chkCos2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCos2.Name = "chkCos2";
            this.chkCos2.Size = new System.Drawing.Size(241, 47);
            this.chkCos2.TabIndex = 2;
            this.chkCos2.Text = "Побудувати графік cos(x)+2x";
            this.chkCos2.UseVisualStyleBackColor = false;
            // 
            // chkFunc1
            // 
            this.chkFunc1.Location = new System.Drawing.Point(14, 198);
            this.chkFunc1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFunc1.Name = "chkFunc1";
            this.chkFunc1.Size = new System.Drawing.Size(232, 45);
            this.chkFunc1.TabIndex = 3;
            this.chkFunc1.Text = "Побудувати графік кв. корінь(х)";
            this.chkFunc1.UseVisualStyleBackColor = true;
            // 
            // chkFunc2
            // 
            this.chkFunc2.Location = new System.Drawing.Point(14, 264);
            this.chkFunc2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFunc2.Name = "chkFunc2";
            this.chkFunc2.Size = new System.Drawing.Size(232, 45);
            this.chkFunc2.TabIndex = 4;
            this.chkFunc2.Text = "Побудувати графік 4+х+х^2";
            this.chkFunc2.UseVisualStyleBackColor = true;
            // 
            // btCount
            // 
            this.btCount.Location = new System.Drawing.Point(570, 592);
            this.btCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCount.Name = "btCount";
            this.btCount.Size = new System.Drawing.Size(143, 58);
            this.btCount.TabIndex = 4;
            this.btCount.Text = "Розрахунок";
            this.btCount.UseVisualStyleBackColor = true;
            this.btCount.Click += new System.EventHandler(this.btCount_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(749, 592);
            this.btClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(147, 58);
            this.btClear.TabIndex = 5;
            this.btClear.Text = "Очистити графіки";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(929, 592);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(147, 58);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 662);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCount);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartGraph);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGraphics";
            this.Text = "Графіки";
            this.Load += new System.EventHandler(this.frmGraphics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkFunc2;
        private System.Windows.Forms.CheckBox chkFunc1;
        private System.Windows.Forms.CheckBox chkCos2;
        private System.Windows.Forms.CheckBox chkCos;
        private System.Windows.Forms.CheckBox chkSin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtZnach;
        private System.Windows.Forms.ComboBox cbGraphics;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCount;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btExit;
    }
}

