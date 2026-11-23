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
        SyncCpuBoundWork = new Button();
        AsyncCpuBoundWork = new Button();
        SyncIOBoundWork = new Button();
        AsyncIOBoundWork = new Button();
        ResultOfSyncCpuBoundWork = new Label();
        ResultOfAsyncCpuBoundWork = new Label();
        ResultOfSyncIOBoundWork = new Label();
        ResultOfAsyncIOBoundWork = new Label();
        SuspendLayout();
        // 
        // AvailabilityLabel
        // 
        AvailabilityLabel.AutoSize = true;
        AvailabilityLabel.BorderStyle = BorderStyle.FixedSingle;
        AvailabilityLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        AvailabilityLabel.Location = new Point(638, 31);
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
        SyncCpuBoundWork.Location = new Point(12, 113);
        SyncCpuBoundWork.Name = "SyncCpuBoundWork";
        SyncCpuBoundWork.Size = new Size(158, 23);
        SyncCpuBoundWork.TabIndex = 1;
        SyncCpuBoundWork.Text = "SyncCpuBoundWork";
        SyncCpuBoundWork.UseVisualStyleBackColor = true;
        // 
        // AsyncCpuBoundWork
        // 
        AsyncCpuBoundWork.Location = new Point(12, 154);
        AsyncCpuBoundWork.Name = "AsyncCpuBoundWork";
        AsyncCpuBoundWork.Size = new Size(158, 23);
        AsyncCpuBoundWork.TabIndex = 2;
        AsyncCpuBoundWork.Text = "AsyncCpuBoundWork";
        AsyncCpuBoundWork.UseVisualStyleBackColor = true;
        // 
        // SyncIOBoundWork
        // 
        SyncIOBoundWork.Location = new Point(12, 195);
        SyncIOBoundWork.Name = "SyncIOBoundWork";
        SyncIOBoundWork.Size = new Size(158, 23);
        SyncIOBoundWork.TabIndex = 3;
        SyncIOBoundWork.Text = "SyncIOBoundWork";
        SyncIOBoundWork.UseVisualStyleBackColor = true;
        // 
        // AsyncIOBoundWork
        // 
        AsyncIOBoundWork.Location = new Point(12, 236);
        AsyncIOBoundWork.Name = "AsyncIOBoundWork";
        AsyncIOBoundWork.Size = new Size(158, 23);
        AsyncIOBoundWork.TabIndex = 4;
        AsyncIOBoundWork.Text = "AsyncIOBoundWork";
        AsyncIOBoundWork.UseVisualStyleBackColor = true;
        // 
        // ResultOfSyncCpuBoundWork
        // 
        ResultOfSyncCpuBoundWork.AutoSize = true;
        ResultOfSyncCpuBoundWork.Location = new Point(225, 117);
        ResultOfSyncCpuBoundWork.Name = "ResultOfSyncCpuBoundWork";
        ResultOfSyncCpuBoundWork.Size = new Size(162, 15);
        ResultOfSyncCpuBoundWork.TabIndex = 5;
        ResultOfSyncCpuBoundWork.Text = "ResultOfSyncCpuBoundWork";
        // 
        // ResultOfAsyncCpuBoundWork
        // 
        ResultOfAsyncCpuBoundWork.AutoSize = true;
        ResultOfAsyncCpuBoundWork.Location = new Point(225, 158);
        ResultOfAsyncCpuBoundWork.Name = "ResultOfAsyncCpuBoundWork";
        ResultOfAsyncCpuBoundWork.Size = new Size(169, 15);
        ResultOfAsyncCpuBoundWork.TabIndex = 6;
        ResultOfAsyncCpuBoundWork.Text = "ResultOfAsyncCpuBoundWork";
        // 
        // ResultOfSyncIOBoundWork
        // 
        ResultOfSyncIOBoundWork.AutoSize = true;
        ResultOfSyncIOBoundWork.Location = new Point(225, 199);
        ResultOfSyncIOBoundWork.Name = "ResultOfSyncIOBoundWork";
        ResultOfSyncIOBoundWork.Size = new Size(152, 15);
        ResultOfSyncIOBoundWork.TabIndex = 7;
        ResultOfSyncIOBoundWork.Text = "ResultOfSyncIOBoundWork";
        // 
        // ResultOfAsyncIOBoundWork
        // 
        ResultOfAsyncIOBoundWork.AutoSize = true;
        ResultOfAsyncIOBoundWork.Location = new Point(225, 240);
        ResultOfAsyncIOBoundWork.Name = "ResultOfAsyncIOBoundWork";
        ResultOfAsyncIOBoundWork.Size = new Size(159, 15);
        ResultOfAsyncIOBoundWork.TabIndex = 8;
        ResultOfAsyncIOBoundWork.Text = "ResultOfAsyncIOBoundWork";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(ResultOfAsyncIOBoundWork);
        Controls.Add(ResultOfSyncIOBoundWork);
        Controls.Add(ResultOfAsyncCpuBoundWork);
        Controls.Add(ResultOfSyncCpuBoundWork);
        Controls.Add(AsyncIOBoundWork);
        Controls.Add(SyncIOBoundWork);
        Controls.Add(AsyncCpuBoundWork);
        Controls.Add(SyncCpuBoundWork);
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
    private Label ResultOfSyncCpuBoundWork;
    private Label ResultOfAsyncCpuBoundWork;
    private Label ResultOfSyncIOBoundWork;
    private Label ResultOfAsyncIOBoundWork;
}
