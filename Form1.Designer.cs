namespace winformssample;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        AvailabilityLabel = new Label();
        Timer = new System.Windows.Forms.Timer(components);
        this.SyncCpuBoundWork = new Button();
        this.AsyncCpuBoundWork = new Button();
        this.SyncIOBoundWork = new Button();
        this.AsyncIOBoundWork = new Button();
        SuspendLayout();
        // 
        // AvailabilityLabel
        // 
        AvailabilityLabel.AutoSize = true;
        AvailabilityLabel.BorderStyle = BorderStyle.FixedSingle;
        AvailabilityLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        AvailabilityLabel.Location = new Point(663, 30);
        AvailabilityLabel.Name = "AvailabilityLabel";
        AvailabilityLabel.Size = new Size(53, 22);
        AvailabilityLabel.TabIndex = 0;
        AvailabilityLabel.Text = "label1";
        // 
        // Timer
        // 
        Timer.Enabled = true;
        Timer.Tick += Timer_Tick;
        // 
        // SyncCpuBoundWork
        // 
        this.SyncCpuBoundWork.Location = new Point(12, 10);
        this.SyncCpuBoundWork.Name = "SyncCpuBoundWork";
        this.SyncCpuBoundWork.Size = new Size(158, 23);
        this.SyncCpuBoundWork.TabIndex = 1;
        this.SyncCpuBoundWork.Text = "SyncCpuBoundWork";
        this.SyncCpuBoundWork.UseVisualStyleBackColor = true;
        // 
        // AsyncCpuBoundWork
        // 
        this.AsyncCpuBoundWork.Location = new Point(12, 51);
        this.AsyncCpuBoundWork.Name = "AsyncCpuBoundWork";
        this.AsyncCpuBoundWork.Size = new Size(158, 23);
        this.AsyncCpuBoundWork.TabIndex = 2;
        this.AsyncCpuBoundWork.Text = "AsyncCpuBoundWork";
        this.AsyncCpuBoundWork.UseVisualStyleBackColor = true;
        // 
        // SyncIOBoundWork
        // 
        this.SyncIOBoundWork.Location = new Point(12, 92);
        this.SyncIOBoundWork.Name = "SyncIOBoundWork";
        this.SyncIOBoundWork.Size = new Size(158, 23);
        this.SyncIOBoundWork.TabIndex = 3;
        this.SyncIOBoundWork.Text = "SyncIOBoundWork";
        this.SyncIOBoundWork.UseVisualStyleBackColor = true;
        // 
        // AsyncIOBoundWork
        // 
        this.AsyncIOBoundWork.Location = new Point(12, 133);
        this.AsyncIOBoundWork.Name = "AsyncIOBoundWork";
        this.AsyncIOBoundWork.Size = new Size(158, 23);
        this.AsyncIOBoundWork.TabIndex = 4;
        this.AsyncIOBoundWork.Text = "AsyncIOBoundWork";
        this.AsyncIOBoundWork.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(this.AsyncIOBoundWork);
        Controls.Add(this.SyncIOBoundWork);
        Controls.Add(this.AsyncCpuBoundWork);
        Controls.Add(this.SyncCpuBoundWork);
        Controls.Add(AvailabilityLabel);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label AvailabilityLabel;
    private System.Windows.Forms.Timer Timer;
    private Button SyncIOBoundWork;
    private Button AsyncIOBoundWork;
    private Button SyncCpuBoundWork;
    private Button AsyncCpuBoundWork;
}
