namespace KB14100_WinFormsApp1;

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
        ultraTimelineView1 = new Infragistics.Win.UltraWinSchedule.UltraTimelineView();
        button1 = new Button();
        ultraCalendarInfo1 = new Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(components);
        ultraCalendarLook1 = new Infragistics.Win.UltraWinSchedule.UltraCalendarLook(components);
        ((System.ComponentModel.ISupportInitialize)ultraTimelineView1).BeginInit();
        SuspendLayout();
        // 
        // ultraTimelineView1
        // 
        ultraTimelineView1.Location = new Point(12, 12);
        ultraTimelineView1.Name = "ultraTimelineView1";
        ultraTimelineView1.Size = new Size(776, 338);
        ultraTimelineView1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new Point(12, 375);
        button1.Name = "button1";
        button1.Size = new Size(464, 63);
        button1.TabIndex = 1;
        button1.Text = "先頭行にスクロール";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // ultraCalendarInfo1
        // 
        ultraCalendarInfo1.DataBindingsForAppointments.BindingContextControl = this;
        ultraCalendarInfo1.DataBindingsForOwners.BindingContextControl = this;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button1);
        Controls.Add(ultraTimelineView1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)ultraTimelineView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Infragistics.Win.UltraWinSchedule.UltraTimelineView ultraTimelineView1;
    private Button button1;
    private Infragistics.Win.UltraWinSchedule.UltraCalendarInfo ultraCalendarInfo1;
    private Infragistics.Win.UltraWinSchedule.UltraCalendarLook ultraCalendarLook1;
}
