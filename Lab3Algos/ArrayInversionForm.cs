using System.Diagnostics;
using ArrayInversion;

namespace Lab3Algos {
  public partial class ArrayInversionForm : Form {
    public ArrayInversionForm() {
      InitializeComponent();
      SetupDataGridView();
    }

    private void SetupDataGridView() {
      dgvResults.Columns.Clear();

      dgvResults.Columns.Add("Size", "Размер (N)");
      dgvResults.Columns.Add("TimeBF", "Время Грубый перебор (мс)");
      dgvResults.Columns.Add("OpsBF", "Опер. Грубый перебор");
      dgvResults.Columns.Add("TimeOpt", "Время Слияние (мс)");
      dgvResults.Columns.Add("OpsOpt", "Опер. Слияние");

      dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    private void StartAnalize(object sender, EventArgs e) {
      dgvResults.Rows.Clear();
      chartResults.Series["Brute Force"].Points.Clear();
      chartResults.Series["Optimized"].Points.Clear();

      int[] sizes = { 100, 500, 1_000, 2_000, 3_000, 5_000 }; // 10_000, 15_000, 30_000, 50_000, 75_000, 100_000
      Random rnd = new Random();

      foreach (int n in sizes) {
        int[] data = Enumerable.Range(0, n).Select(_ => rnd.Next(-10000, 10000)).ToArray();

        int[] dataBF = (int[])data.Clone();
        Stopwatch sw = Stopwatch.StartNew();
        var resBF = ArrayInversion.ArrayInversion.BruteForce(dataBF);
        sw.Stop();
        double timeBF = sw.Elapsed.TotalMilliseconds;

        int[] dataOpt = (int[])data.Clone();
        sw.Restart();
        var resOpt = ArrayInversion.ArrayInversion.Optimized(dataOpt);
        sw.Stop();
        double timeOpt = sw.Elapsed.TotalMilliseconds;

        dgvResults.Rows.Add(n, timeBF.ToString("F3"), resBF.Operations, timeOpt.ToString("F3"), resOpt.Operations);

        chartResults.Series["Brute Force"].Points.AddXY(n, timeBF);
        chartResults.Series["Optimized"].Points.AddXY(n, timeOpt);
      }

      chartResults.ChartAreas[0].AxisX.Title = "Размер массива (n)";
      chartResults.ChartAreas[0].AxisY.Title = "Время (мс)";
    }
  }
}
