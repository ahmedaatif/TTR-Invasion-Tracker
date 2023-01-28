using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.Win32;
using System.ComponentModel;
using System.DirectoryServices;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TTR_Invasion_Tracker.Classes;
using Timer = System.Windows.Forms.Timer;

namespace TTR_Invasion_Tracker
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Invasions? invasions;
        private ListSortDirection sortDirection = ListSortDirection.Ascending;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            APICall(sender, null);
            InitDataGridView();
            InitTimer();
            Version.Text = Application.ProductVersion;
            if (checkIfStartupIsSet())
            {
                setStartup.Checked = true;
            }
            AllowNotifications.Checked = Properties.Settings.Default.ShowNotifications;
        }

        private void InitTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(APICall);
            timer.Interval = 30000; // in miliseconds
            timer.Start();
        }

        private void InitDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Add("Key", "District");
            //dataGridView.Columns.Add("asOf", "Since");
            dataGridView.Columns.Add("type", "Type");
            dataGridView.Columns.Add("progress", "Progress");
            dataGridView.Sort(dataGridView.Columns[2], sortDirection);

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private async void APICall(object? sender, EventArgs? e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://www.toontownrewritten.com/");

                HttpResponseMessage response = await client.GetAsync("api/invasions");
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();

                    Invasions? result = JsonSerializer.Deserialize<Invasions>(responseContent);

                    if (result != null)
                    {
                        if (AllowNotifications.Checked == true) //check if user has allowed notifications
                        {
                            if (invasions != null) // Check if invasions has been initialzed for the first time, if not do not go through
                            {
                                var addedElements = result.invasions.Keys.Except(invasions.invasions.Keys);

                                foreach (var item in addedElements)
                                {
                                    new ToastContentBuilder()
                                        .AddText("A new invasion has begun!")
                                        .AddText("An invasion of " + RemoveSpecialCharacters(result.invasions[item].type) + " has begun in " + RemoveSpecialCharacters(item))
                                        .Show();
                                }

                                var removedElements = invasions.invasions.Keys.Except(result.invasions.Keys);

                                foreach (var item in removedElements)
                                {
                                    new ToastContentBuilder()
                                        .AddText("An invasion has ended!")
                                        .AddText("The invasion of " + RemoveSpecialCharacters(invasions.invasions[item].type) + " has just ended in " + RemoveSpecialCharacters(item))
                                        .Show();
                                }
                            }
                        }

                        //set invasions from API
                        invasions = result;

                        Status.Text = "Online";
                        Status.Image = Properties.Resources.online;
                    }
                    else
                    {
                        Status.Text = "Offline";
                        Status.Image = Properties.Resources.offline;
                    }

                    if (invasions != null)
                    {
                        dataGridView.Rows.Clear();

                        foreach (var district in invasions.invasions)
                        {
                            var row = new string[] {
                                RemoveSpecialCharacters(district.Key),
                                //DateTimeOffset.FromUnixTimeSeconds(district.Value.asOf).ToLocalTime().ToString("dd/MM/yyyy h:mm tt"),
                                RemoveSpecialCharacters(district.Value.type),
                                district.Value.progress
                            };
                            dataGridView.Rows.Add(row);
                        }

                        dataGridView.Sort(dataGridView.Columns[2], sortDirection);

                        LastUpdated.Text = "Last Fetched At: " + DateTimeOffset.FromUnixTimeSeconds(invasions.lastUpdated).ToLocalTime().ToString("dd/MM/yyyy h:mm tt");
                    }
                }
            }
            else
            {
                Status.Text = "Offline";
                Status.Image = Properties.Resources.offline;
            }
        }

        private void GithubLink_Click(object sender, EventArgs e)
        {
            var uri = "https://github.com/ahmedaatif";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void setStartup_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (setStartup.Checked)
                rk.SetValue("Toontown Rewritten Invasion Tracker", Application.ExecutablePath);
            else
                rk.DeleteValue("Toontown Rewritten Invasion Tracker", false);
        }

        private static bool checkIfStartupIsSet()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if(rk != null)
            {
                return (rk.GetValueNames().Contains("Toontown Rewritten Invasion Tracker"));
            }
            else { return false; }
        }

        //Since the API sometimes returns an unknown character, so I have decided to use a remove special characters function
        private static string RemoveSpecialCharacters(string str)
        {
            try
            {
                return Regex.Replace(str, @"[^\w\.@-]", " ",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }

        private void AllowNotifications_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowNotifications = AllowNotifications.Checked;
            Properties.Settings.Default.Save();
        }

        private void ForceFetch_Click(object sender, EventArgs e)
        {
            APICall(sender, e);
        }
    }
}