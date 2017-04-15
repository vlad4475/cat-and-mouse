namespace Cat_and_Mouse
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.inputC = new System.Windows.Forms.TextBox();
            this.inputD = new System.Windows.Forms.TextBox();
            this.bDrowGraph = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputCountWolf = new System.Windows.Forms.TextBox();
            this.inputCountSheep = new System.Windows.Forms.TextBox();
            this.lisError = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ненужноеСтрашноеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.примерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пример1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пример2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пример3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.tLenghtTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 30);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Жертвы";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Хищники";
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(571, 606);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1088, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1088, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1088, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "c =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1088, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "d = ";
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(1130, 37);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(100, 20);
            this.inputA.TabIndex = 5;
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(1130, 65);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(100, 20);
            this.inputB.TabIndex = 6;
            // 
            // inputC
            // 
            this.inputC.Location = new System.Drawing.Point(1130, 92);
            this.inputC.Name = "inputC";
            this.inputC.Size = new System.Drawing.Size(100, 20);
            this.inputC.TabIndex = 7;
            // 
            // inputD
            // 
            this.inputD.Location = new System.Drawing.Point(1130, 119);
            this.inputD.Name = "inputD";
            this.inputD.Size = new System.Drawing.Size(100, 20);
            this.inputD.TabIndex = 8;
            // 
            // bDrowGraph
            // 
            this.bDrowGraph.Location = new System.Drawing.Point(1091, 277);
            this.bDrowGraph.Name = "bDrowGraph";
            this.bDrowGraph.Size = new System.Drawing.Size(92, 83);
            this.bDrowGraph.TabIndex = 9;
            this.bDrowGraph.Text = "Строить график";
            this.bDrowGraph.UseCompatibleTextRendering = true;
            this.bDrowGraph.UseVisualStyleBackColor = true;
            this.bDrowGraph.Click += new System.EventHandler(this.DrowGraph_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1088, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Хищники = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1088, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Жертвы = ";
            // 
            // inputCountWolf
            // 
            this.inputCountWolf.Location = new System.Drawing.Point(1160, 179);
            this.inputCountWolf.Name = "inputCountWolf";
            this.inputCountWolf.Size = new System.Drawing.Size(100, 20);
            this.inputCountWolf.TabIndex = 12;
            // 
            // inputCountSheep
            // 
            this.inputCountSheep.Location = new System.Drawing.Point(1155, 150);
            this.inputCountSheep.Name = "inputCountSheep";
            this.inputCountSheep.Size = new System.Drawing.Size(100, 20);
            this.inputCountSheep.TabIndex = 13;
            // 
            // lisError
            // 
            this.lisError.AutoSize = true;
            this.lisError.Location = new System.Drawing.Point(1088, 363);
            this.lisError.Name = "lisError";
            this.lisError.Size = new System.Drawing.Size(114, 13);
            this.lisError.TabIndex = 14;
            this.lisError.Text = "Ожидается действие";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.примерыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1305, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ненужноеСтрашноеОкноToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ненужноеСтрашноеОкноToolStripMenuItem
            // 
            this.ненужноеСтрашноеОкноToolStripMenuItem.Name = "ненужноеСтрашноеОкноToolStripMenuItem";
            this.ненужноеСтрашноеОкноToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ненужноеСтрашноеОкноToolStripMenuItem.Text = "Статистика";
            this.ненужноеСтрашноеОкноToolStripMenuItem.Click += new System.EventHandler(this.ненужноеСтрашноеОкноToolStripMenuItem_Click);
            // 
            // примерыToolStripMenuItem
            // 
            this.примерыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пример1ToolStripMenuItem,
            this.пример2ToolStripMenuItem,
            this.пример3ToolStripMenuItem});
            this.примерыToolStripMenuItem.Name = "примерыToolStripMenuItem";
            this.примерыToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.примерыToolStripMenuItem.Text = "Примеры";
            // 
            // пример1ToolStripMenuItem
            // 
            this.пример1ToolStripMenuItem.Name = "пример1ToolStripMenuItem";
            this.пример1ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.пример1ToolStripMenuItem.Text = "Пример 1";
            this.пример1ToolStripMenuItem.Click += new System.EventHandler(this.пример1ToolStripMenuItem_Click);
            // 
            // пример2ToolStripMenuItem
            // 
            this.пример2ToolStripMenuItem.Name = "пример2ToolStripMenuItem";
            this.пример2ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.пример2ToolStripMenuItem.Text = "Пример 2";
            this.пример2ToolStripMenuItem.Click += new System.EventHandler(this.пример2ToolStripMenuItem_Click);
            // 
            // пример3ToolStripMenuItem
            // 
            this.пример3ToolStripMenuItem.Name = "пример3ToolStripMenuItem";
            this.пример3ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.пример3ToolStripMenuItem.Text = "Пример 3";
            this.пример3ToolStripMenuItem.Click += new System.EventHandler(this.пример3ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1190, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 83);
            this.button1.TabIndex = 16;
            this.button1.Text = "Строить фазовый портрет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(598, 30);
            this.chart2.Name = "chart2";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Фаза";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "Series2";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "Series3";
            this.chart2.Series.Add(series8);
            this.chart2.Series.Add(series9);
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(474, 606);
            this.chart2.TabIndex = 17;
            this.chart2.Text = "chart2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1088, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Кол-во поколений = ";
            // 
            // tLenghtTime
            // 
            this.tLenghtTime.Location = new System.Drawing.Point(1204, 212);
            this.tLenghtTime.Name = "tLenghtTime";
            this.tLenghtTime.Size = new System.Drawing.Size(67, 20);
            this.tLenghtTime.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 648);
            this.Controls.Add(this.tLenghtTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lisError);
            this.Controls.Add(this.inputCountSheep);
            this.Controls.Add(this.inputCountWolf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bDrowGraph);
            this.Controls.Add(this.inputD);
            this.Controls.Add(this.inputC);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.TextBox inputC;
        private System.Windows.Forms.TextBox inputD;
        private System.Windows.Forms.Button bDrowGraph;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputCountWolf;
        private System.Windows.Forms.TextBox inputCountSheep;
        private System.Windows.Forms.Label lisError;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem примерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пример1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пример2ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ToolStripMenuItem пример3ToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tLenghtTime;
        private System.Windows.Forms.ToolStripMenuItem ненужноеСтрашноеОкноToolStripMenuItem;
    }
}

