using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json;
using System.Threading;

namespace QQGroupSign
{
    public partial class FormMain : Form
    {
        const string LoginUrl = "http://ui.ptlogin2.qq.com/cgi-bin/login?appid=549000912&style=12&s_url=http://qun.qzone.qq.com/group";
        const string SignUrl = "http://qiandao.qun.qq.com/cgi-bin/sign";
        private string _cookieString;
        private Dictionary<string, string> _cookieDictionary;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            wb.Navigate(LoginUrl);
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.OriginalString.StartsWith("http://qun.qzone.qq.com/group", StringComparison.OrdinalIgnoreCase))
            {
                wb.Hide();
                panelMain.Show();

                _cookieString = wb.Document.Cookie;
                _cookieDictionary = CookieToDictionary(_cookieString);

                GetQQGroups();

                btnSign.Enabled = txtLocation.Enabled = true;
            }
        }

        private void GetQQGroups()
        {
            var uid = _cookieDictionary["uin_cookie"];
            var skey = _cookieDictionary["skey"];
            var gtk = GetGtk(skey);

            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Cookie", _cookieString);
                var json = Encoding.UTF8.GetString(client.DownloadData($"http://qun.qzone.qq.com/cgi-bin/get_group_list?uin={uid}&g_tk={gtk}"));
                json = json.Substring(10).TrimEnd(new[] { ';', ')' });
                var qqGroups = JsonConvert.DeserializeAnonymousType(json, new { data = new { group = new List<QQGroup>() } }).data.group;
                foreach (var group in qqGroups)
                {
                    groupList.Items.Add(group);
                }
            }
        }

        private Dictionary<string, string> CookieToDictionary(string cookie)
        {
            var dic = new Dictionary<string, string>();
            var sp = cookie.Split(';');
            foreach(var line in sp)
            {
                var columns = line.Split('=');
                if (columns.Length != 2)
                    continue;
                dic.Add(columns[0].Trim(), columns[1].Trim());
            }
            return dic;
        }
        private string GetGtk(string str)
        {
            var hash = 5381;
            for (int i = 0, len = str.Length; i < len; ++i)
            {
                hash += (hash << 5) + (int)str[i];
            }
            return (hash & 0x7fffffff).ToString();
        }

        private async void btnSign_Click(object sender, EventArgs e)
        {
            if (groupList.CheckedItems.Count == 0)
            {
                MessageBox.Show("请选择需要签到的群", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnSign.Enabled = false;

            var location = chkCustomLocation.Checked ? txtLocation.Text : null;
            //List<Task> tasks = new List<Task>();
            foreach (var qqGroup in groupList.CheckedItems.Cast<QQGroup>())
            {
                txtResult.AppendText(PostSign(qqGroup, location));
                //tasks.Add(new Task(async () => { txtResult.AppendText(await PostSign(qqGroup)); }));
            }
            //tasks.ForEach(x => x.Start());
            //Task.WaitAll(tasks.ToArray());
            await Task.FromResult(0);
            btnSign.Enabled = true;
        }

        private string PostSign(QQGroup qqGroup, string location)
        {
            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                client.Headers.Add("Cookie", _cookieString);
                if(string.IsNullOrEmpty(location))
                    return client.UploadString(SignUrl, $"gc={qqGroup.GroupId}&is_sign=0&bkn={GetGtk(_cookieDictionary["skey"])}");
                else
                    return client.UploadString(SignUrl, $"gc={qqGroup.GroupId}&is_sign=0&bkn={GetGtk(_cookieDictionary["skey"])}&poi={location}");
            }
        }

        private void chkCustomLocation_CheckedChanged(object sender, EventArgs e)
        {
            txtLocation.Enabled = chkCustomLocation.Checked;
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < groupList.Items.Count; i++)
            {
                groupList.SetItemChecked(i, chkAll.Checked);
            }
        }

    }
}
