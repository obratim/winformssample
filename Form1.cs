namespace winformssample;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

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
    }

    private async void AsyncCpuBoundWork_Click(object sender, EventArgs e)
    {
    }
}
