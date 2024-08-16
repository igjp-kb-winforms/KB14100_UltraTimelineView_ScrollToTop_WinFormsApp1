using Infragistics.Win.UltraWinSchedule;

namespace KB14100_WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ultraCalendarInfo1.Owners.Add("Charlie");
        ultraCalendarInfo1.Owners.Add("Jamie");
        ultraCalendarInfo1.Owners.Add("Leah");
        ultraCalendarInfo1.Owners.Add("Maria");
        ultraCalendarInfo1.Owners.Add("Ana");
        ultraCalendarInfo1.Owners.Add("Antonio");
        ultraCalendarInfo1.Owners.Add("Thomas");
        ultraCalendarInfo1.Owners.Add("Christina");

        ultraCalendarInfo1.Owners.UnassignedOwner.Visible = false;
        ultraTimelineView1.CalendarInfo = ultraCalendarInfo1;

        ultraCalendarLook1.ViewStyle = ViewStyle.Office2007;
        ultraTimelineView1.CalendarLook = ultraCalendarLook1;

        ultraTimelineView1.OwnerSizing = Infragistics.Win.UltraWinSchedule.TimelineViewOwnerSizing.Row;
        ultraTimelineView1.MaximumOwnersInView = 3;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // https://jp.infragistics.com/help/winforms/infragistics.win.ultrawinschedule~infragistics.win.ultrawinschedule.ownerscollection~createarray(boolean,boolean)
        var visibleOwnerArray = ultraCalendarInfo1.Owners.CreateArray(true, false);
        if (visibleOwnerArray.Length > 0)
        {
            // https://jp.infragistics.com/help/winforms/infragistics.win.ultrawinschedule~infragistics.win.ultrawinschedule.ultratimelineview~ensureownervisible(owner,boolean,boolean)
            ultraTimelineView1.EnsureOwnerVisible(visibleOwnerArray[0], true, false);
        }
    }
}
