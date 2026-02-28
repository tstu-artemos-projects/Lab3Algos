using System.Windows.Forms.DataVisualization;

namespace Lab3Algos {
  partial class ArrayInversionForm {
    private System.ComponentModel.IContainer components = null;

    // Элементы управления
    private System.Windows.Forms.DataGridView dgvResults;
    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.Label lblDescription; // Новый элемент: текстовое описание
    private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent() {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();

      this.dgvResults = new System.Windows.Forms.DataGridView();
      this.btnRun = new System.Windows.Forms.Button();
      this.panelTop = new System.Windows.Forms.Panel();
      this.lblDescription = new System.Windows.Forms.Label();
      this.chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();

      ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chartResults)).BeginInit();
      this.panelTop.SuspendLayout();
      this.SuspendLayout();

      // 
      // panelTop: Верхняя панель управления
      // 
      this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
      this.panelTop.Controls.Add(this.lblDescription);
      this.panelTop.Controls.Add(this.btnRun);
      this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTop.Location = new System.Drawing.Point(0, 0);
      this.panelTop.Name = "panelTop";
      this.panelTop.Size = new System.Drawing.Size(900, 80); // Увеличили высоту для текста
      this.panelTop.TabIndex = 0;

      // 
      // lblDescription: Текстовое описание программы
      // 
      this.lblDescription.AutoSize = false; // Отключаем авторазмер для ручного позиционирования
      this.lblDescription.Location = new System.Drawing.Point(180, 12);
      this.lblDescription.Size = new System.Drawing.Size(700, 55);
      this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
      this.lblDescription.Text = "Программа предназначена для экспериментального исследования производительности " +
                          "двух алгоритмов подсчета инверсий в массиве: метода полного перебора O(n²) " +
                          "и оптимизированного метода слияния O(n log n).";
      this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

      // 
      // btnRun: Кнопка запуска
      // 
      this.btnRun.Location = new System.Drawing.Point(12, 20);
      this.btnRun.Name = "btnRun";
      this.btnRun.Size = new System.Drawing.Size(150, 40);
      this.btnRun.TabIndex = 0;
      this.btnRun.Text = "Запустить анализ";
      this.btnRun.UseVisualStyleBackColor = true;
      this.btnRun.Click += new System.EventHandler(this.StartAnalize);

      // 
      // dgvResults: Таблица
      // 
      this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvResults.Dock = System.Windows.Forms.DockStyle.Left;
      this.dgvResults.Location = new System.Drawing.Point(0, 80);
      this.dgvResults.Name = "dgvResults";
      this.dgvResults.Size = new System.Drawing.Size(400, 420);
      this.dgvResults.TabIndex = 1;

      // 
      // chartResults: График
      // 
      chartArea.Name = "MainArea";
      this.chartResults.ChartAreas.Add(chartArea);
      this.chartResults.Dock = System.Windows.Forms.DockStyle.Fill;
      legend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
      legend.Name = "Legend";
      this.chartResults.Legends.Add(legend);
      this.chartResults.Location = new System.Drawing.Point(400, 80);
      this.chartResults.Name = "chartResults";
      this.chartResults.Size = new System.Drawing.Size(500, 420);
      this.chartResults.TabIndex = 2;

      // Серия Brute Force
      series1.ChartArea = "MainArea";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series1.BorderWidth = 3;
      series1.Color = System.Drawing.Color.Red;
      series1.Legend = "Legend";
      series1.Name = "Brute Force";

      // Серия Optimized
      series2.ChartArea = "MainArea";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series2.BorderWidth = 3;
      series2.Color = System.Drawing.Color.Green;
      series2.Legend = "Legend";
      series2.Name = "Optimized";

      this.chartResults.Series.Add(series1);
      this.chartResults.Series.Add(series2);

      // 
      // ArrayInversionForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(900, 500);
      this.Controls.Add(this.chartResults);
      this.Controls.Add(this.dgvResults);
      this.Controls.Add(this.panelTop);
      this.Name = "ArrayInversionForm";
      this.Text = "Лабораторная №3: Инверсии (Вариант 12)";

      this.panelTop.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chartResults)).EndInit();
      this.ResumeLayout(false);
    }

    #endregion
  }
}
