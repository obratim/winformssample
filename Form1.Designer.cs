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
        SuspendLayout();
        // 
        // AvailabilityLabel
        // 
        AvailabilityLabel.AutoSize = true;
        AvailabilityLabel.BorderStyle = BorderStyle.FixedSingle;
        AvailabilityLabel.Location = new Point(720, 30);
        AvailabilityLabel.Name = "AvailabilityLabel";
        AvailabilityLabel.Size = new Size(40, 17);
        AvailabilityLabel.TabIndex = 0;
        AvailabilityLabel.Text = "label1";
        // 
        // Timer
        // 
        Timer.Enabled = true;
        Timer.Tick += Timer_Tick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(AvailabilityLabel);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label AvailabilityLabel;
    private System.Windows.Forms.Timer Timer;
}
