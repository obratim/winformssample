using System.Diagnostics;

namespace winformssample;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        _sw.Reset();
    }

    private Algorithms _algorithms = new Algorithms();
    private Stopwatch _sw = new Stopwatch();

    private void Timer_Tick(object sender, EventArgs e)
    {
        var now = DateTime.Now;
        AvailabilityLabel.Text = $"{now:HH:mm:ss.f}";
        var colorModifier = now.Ticks / 300_000;
        AvailabilityLabel.ForeColor = Color.FromArgb(
            (byte)((colorModifier - 1) % 100 + 20)
            , (byte)((colorModifier - 70) % 100 + 20)
            , (byte)((colorModifier - 90) % 100 + 20)
        );
    }

    private void SyncCpuBoundWork_Click(object sender, EventArgs e)
    {
        ResultOfSyncCpuBoundWork.Text = "Computing...";
        this.Refresh();
        _sw.Restart();
        var sum = _algorithms.Sum();
        _sw.Stop();
        ResultOfSyncCpuBoundWork.Text = $"Sum is {sum:F10}, duration: {_sw.Elapsed}";
    }

    private async void AsyncCpuBoundWork_Click(object sender, EventArgs e)
    {
        ResultOfAsyncCpuBoundWork.Text = "Computing...";
        AsyncCpuBoundWork.Enabled = false;
        _sw.Restart();
        var sum = await _algorithms.SumAsync();
        _sw.Stop();
        ResultOfAsyncCpuBoundWork.Text = $"Sum is {sum:F10}, duration: {_sw.Elapsed}";
        AsyncCpuBoundWork.Enabled = true;
    }

    private void SyncIOBoundWork_Click(object sender, EventArgs e)
    {
        ResultOfSyncIOBoundWork.Text = "Processing...";
        this.Refresh();
        _sw.Restart();
        _algorithms.SaveFiles();
        _sw.Stop();
        ResultOfSyncIOBoundWork.Text = $"Files saved, duration: {_sw.Elapsed}";
    }

    private async void AsyncIOBoundWork_Click(object sender, EventArgs e)
    {
        ResultOfAsyncIOBoundWork.Text = "Processing...";
        AsyncIOBoundWork.Enabled = false;
        _sw.Restart();
        await Task.Run(() => _algorithms.SaveFilesAsync());
        _sw.Stop();
        ResultOfAsyncIOBoundWork.Text = $"Files saved, duration: {_sw.Elapsed}";
        AsyncIOBoundWork.Enabled = true;
    }
}
