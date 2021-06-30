using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoom_Visitor_s_statistic.JSONS;

namespace Zoom_Visitor_s_statistic.Statistic
{
    public partial class StatForm : Form
    {
        private readonly UserData userdata;
        MeetingList meetingList;
        public StatForm(UserData data)
        {
            this.userdata = data;
            InitializeComponent();
        }

        private void StatForm_Load(object sender, EventArgs e)
        {
            meetingList = new MeetingList();
            using (var request = new HttpRequest())
            {
                request.AddHeader("Authorization", $"Bearer {userdata.AccessToken}");
                var reqParams = new RequestParams();

                string content = request.Get(
                    $"https://api.zoom.us/v2//report/users/{userdata.Id}/meetings", reqParams).ToString();

                meetingList = MeetingList.FromJson(content);
            }
            MeetingsTable.Columns.Add("MeetingId", "Meeting id");
            MeetingsTable.Columns.Add("StartTime", "Start time");
            for (int i = 0; i < meetingList.Meetings.Count(); i++)
            {
                MeetingsTable.Rows.Add(meetingList.Meetings[i].Id, meetingList.Meetings[i].CreatedAt);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisitorsStat visitorStat = new VisitorsStat();
            try
            {
                using (var request = new HttpRequest())
                {
                    request.AddHeader("Authorization", $"Bearer {userdata.AccessToken}");
                    var reqParams = new RequestParams();

                    string content = request.Get(
                        $"https://api.zoom.us/v2/report/meetings/{meetingid.Text}/participants", reqParams).ToString();

                    visitorStat = VisitorsStat.FromJson(content);
                }
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = $"Ошибка. Возможно неверно введен id.\nКод ошибки {ex.Message}";
                this.Refresh();
            }

            VisitorsTable.Columns.Clear();
            VisitorsTable.Columns.Add("User", "User");
            VisitorsTable.Columns.Add("Email", "Email");
            VisitorsTable.Columns.Add("EntryTime", "Entry Time");
            VisitorsTable.Columns.Add("ExitTime", "Exit Time");
            VisitorsTable.Columns.Add("Duration", "Duration");
            VisitorsTable.Rows.Clear();

            for (int i = 0; i < visitorStat.Participants.Count(); i++)
            {
                VisitorsTable.Rows.Add(visitorStat.Participants[i].Name,
                    visitorStat.Participants[i].UserEmail,
                    visitorStat.Participants[i].JoinTime,
                    visitorStat.Participants[i].LeaveTime,
                    $"{Convert.ToInt32(visitorStat.Participants[i].Duration) / 60} minutes");
            }
        }
    }
}
