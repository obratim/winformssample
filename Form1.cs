namespace winformssample;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private Algorithms _algorithms = new Algorithms();

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
        var sum = _algorithms.Sum();
        ResultOfSyncCpuBoundWork.Text = $"Sum is {sum:F10}";
    }

    private async void AsyncCpuBoundWork_Click(object sender, EventArgs e)
    {
        ResultOfAsyncCpuBoundWork.Text = "Computing...";
        AsyncCpuBoundWork.Enabled = false;
        var sum = await _algorithms.SumAsync();
        ResultOfAsyncCpuBoundWork.Text = $"Sum is {sum:F10}";
        AsyncCpuBoundWork.Enabled = true;
    }

    private void SyncIOBoundWork_Click(object sender, EventArgs e)
    {
        ResultOfSyncIOBoundWork.Text = "Processing...";
        this.Refresh();
        _algorithms.SaveFiles();
        ResultOfSyncIOBoundWork.Text = $"Files saved";
    }

    private async void AsyncIOBoundWork_Click(object sender, EventArgs e)
    {
        ResultOfAsyncIOBoundWork.Text = "Processing...";
        AsyncIOBoundWork.Enabled = false;
        await _algorithms.SaveFilesAsync();
        ResultOfAsyncIOBoundWork.Text = $"Files saved";
        AsyncIOBoundWork.Enabled = true;
    }
}
