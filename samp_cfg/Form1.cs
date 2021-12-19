using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FileConfigManager;

namespace samp_cfg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FCM config = new FCM();
        const string configfile = "server.cfg";
        const int maxamx = 16;
        string[] name = { "r", "K", "i", "s", "u", "t" };

        //To Form2
        public string[] gmode = new string[16];
        public string[] fscript = new string[16];
        public string[] plugin = new string[16];
        public int buttoncmd = -1;

        bool issave = false;

        //Global values to less memory leak
        int tmpint = 0;
        string tmpstr = null;

        //Fix errors with min-max
        private int SetBetweenMinMax(int value, int min, int max)
        {
            return (value >= min && value <= max) ?
                value :
                (value < min) ?
                min : max;
        }

        private bool StringTrueFalse(string input)
        {
            return input == "1" ? true : false;
        }

        private string CheckToNumber(bool input)
        {
            return input == true ? "1" : "0";
        }

        //Faster loading, increases CPU useage a bit
        private void bg_load_DoWork(object sender, DoWorkEventArgs e)
        {
            if (issave)
            {
                FileStream fs = new FileStream("server.cfg",
                    File.Exists("server.cfg") ? FileMode.Truncate : FileMode.CreateNew,
                    FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("echo Executing Server Config...");
                sw.Close();
                fs.Close();
                config.SetMark(" ");
                config.WriteData(configfile,"lanmode",CheckToNumber(data_lan.Checked));
                config.WriteData(configfile, "rcon_password", data_rconpass.Text);
                if(data_serverpass.Text.Length > 0)
                    config.WriteData(configfile, "password", data_serverpass.Text);
                config.WriteData(configfile, "maxplayers", data_maxplayers.Value.ToString());
                config.WriteData(configfile, "port", data_port.Value.ToString());
                config.WriteData(configfile, "hostname", data_hostname.Text);
                for (int i = 0; i < data_gmode.Items.Count; i++)
                {
                    config.WriteData(configfile, "gamemode" + i, data_gmode.Items[i].ToString());
                }
                for (int i = 0; i < data_fscript.Items.Count; i++)
                {
                    tmpstr += data_fscript.Items[i] +
                        ((i == data_fscript.Items.Count-1) ? null : " ");
                }
                config.WriteData(configfile, "filterscripts", tmpstr);
                tmpstr = null;
                for (int i = 0; i < data_plugin.Items.Count; i++)
                {
                    tmpstr += data_plugin.Items[i] +
                        ((i == data_plugin.Items.Count - 1) ? null : " ");
                }
                config.WriteData(configfile, "plugins", tmpstr);
                config.WriteData(configfile, "announce", CheckToNumber(data_announce.Checked));
                config.WriteData(configfile, "query", CheckToNumber(data_query.Checked));
                config.WriteData(configfile, "weburl",
                    (data_web.Text.Length > 0) ? data_web.Text : "www.sa-mp.com");
                config.WriteData(configfile, "onfoot_rate", data_ronfoot.Value.ToString());
                config.WriteData(configfile, "incar_rate", data_rincar.Value.ToString());
                config.WriteData(configfile, "weapon_rate", data_rweapon.Value.ToString());
                config.WriteData(configfile, "stream_distance", data_streamdis.Value.ToString() + ".0");
                config.WriteData(configfile, "stream_rate", data_rstream.Value.ToString());
                config.WriteData(configfile, "maxnpc", data_maxnpc.Value.ToString());
                config.WriteData(configfile, "logtimeformat", data_logtime.Text);
                config.WriteData(configfile, "timestamp", CheckToNumber(data_timestamp.Checked));
                if(data_mapname.Text.Length > 0)
                    config.WriteData(configfile, "mapname", data_mapname.Text);
                MessageBox.Show("server.cfg saved succesfully!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (File.Exists("server.cfg"))
                {        
                    data_gmode.Items.Clear();
                    data_fscript.Items.Clear();
                    data_plugin.Items.Clear();
                    config.SetMark(" ");
                    data_lan.Checked = StringTrueFalse(config.ReadData(configfile, "lanmode"));
                    data_serverpass.Text = config.ReadData(configfile, "password");
                    data_rconpass.Text = config.ReadData(configfile, "rcon_password");
                    data_maxplayers.Value =
                        SetBetweenMinMax(Convert.ToInt32(config.ReadData(configfile, "maxplayers")),
                        (int)data_maxplayers.Minimum, (int)data_maxplayers.Maximum);
                    data_port.Value =
                        SetBetweenMinMax(Convert.ToInt32(config.ReadData(configfile, "port")),
                        (int)data_port.Minimum, (int)data_port.Maximum);
                    data_hostname.Text = config.ReadData(configfile, "hostname");
                    for (int i = 0; i < maxamx; i++)
                    {
                        tmpstr = config.ReadData(configfile, "gamemode" + i);
                        if (tmpstr != null) data_gmode.Items.Add(tmpstr);
                    }
                    tmpstr = config.ReadData(configfile, "filterscripts");
                    if (tmpstr != null)
                    {
                        foreach (string data in tmpstr.Split(' '))
                        {
                            if (tmpint == 16) break;
                            data_fscript.Items.Add(data);
                            tmpint += 1;
                        }
                    }
                    tmpstr = config.ReadData(configfile, "plugins");
                    if (tmpstr != null)
                    {
                        foreach (string data in tmpstr.Split(' '))
                        {
                            if (tmpint == 16) break;
                            data_plugin.Items.Add(data);
                            tmpint += 1;
                        }
                    }
                    if (data_gmode.Items.Count > 0) data_gmode.SelectedIndex = 0;
                    if (data_fscript.Items.Count > 0) data_fscript.SelectedIndex = 0;
                    if (data_plugin.Items.Count > 0) data_plugin.SelectedIndex = 0;
                    data_announce.Checked = StringTrueFalse(config.ReadData(configfile, "announce"));
                    data_query.Checked = StringTrueFalse(config.ReadData(configfile, "query"));
                    data_web.Text = config.ReadData(configfile, "weburl");
                    data_ronfoot.Value =
                        SetBetweenMinMax(Convert.ToInt32(config.ReadData(configfile, "onfoot_rate")),
                        (int)data_ronfoot.Minimum, (int)data_ronfoot.Maximum);
                    data_rincar.Value =
                        SetBetweenMinMax(Convert.ToInt32(config.ReadData(configfile, "incar_rate")),
                        (int)data_rincar.Minimum, (int)data_rincar.Maximum);
                    data_rweapon.Value =
                        SetBetweenMinMax(Convert.ToInt32(config.ReadData(configfile, "weapon_rate")),
                        (int)data_rweapon.Minimum, (int)data_rweapon.Maximum);
                    data_rstream.Value =
                        SetBetweenMinMax(Convert.ToInt32(config.ReadData(configfile, "stream_rate")),
                        (int)data_rstream.Minimum, (int)data_rstream.Maximum);
                    data_streamdis.Value =
                        SetBetweenMinMax((int)Convert.ToDouble(config.ReadData(configfile, "stream_distance").Replace(".", ",")),
                        (int)data_streamdis.Minimum, (int)data_streamdis.Maximum);
                    data_maxnpc.Value =
                        SetBetweenMinMax(Convert.ToInt32(config.ReadData(configfile, "maxnpc")),
                        (int)data_maxnpc.Minimum, (int)data_maxnpc.Maximum);
                    data_logtime.Text = config.ReadData(configfile, "logtimeformat");
                    data_timestamp.Checked = StringTrueFalse(config.ReadData(configfile, "timestamp"));
                    data_mapname.Text = config.ReadData(configfile, "mapname");
                    MessageBox.Show("server.cfg loaded succesfully!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Couldn't load server.cfg, file not found!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //Clear the global values
            tmpstr = null;
            tmpint = 0;
        }

        private void bt_setgmode_Click(object sender, EventArgs e)
        {
            buttoncmd = 1;
            Form2 frm = new Form2(this);
            frm.ShowDialog();
            frm.Dispose();
            buttoncmd = -1;
        }

        private void bt_setfscript_Click(object sender, EventArgs e)
        {
            buttoncmd = 2;
            Form2 frm = new Form2(this);
            frm.ShowDialog();
            frm.Dispose();
            buttoncmd = -1;
        }

        private void bt_setplugin_Click(object sender, EventArgs e)
        {
            buttoncmd = 3;
            Form2 frm = new Form2(this);
            frm.ShowDialog();
            frm.Dispose();
            buttoncmd = -1;
        }

        private void bt_loadcfg_Click(object sender, EventArgs e)
        {
            if (!bg_load.IsBusy)
            {
                issave = false;
                bg_load.RunWorkerAsync();
            }
        }

        private void bt_savecfg_Click(object sender, EventArgs e)
        {
            if (!bg_load.IsBusy)
            {
                //Error messages
                if (data_gmode.Items.Count <= 0)
                    MessageBox.Show("No game mode has added, server can't run without one.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (data_hostname.Text.Length <= 0)
                    MessageBox.Show("No hostname has given, server can't run.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (data_hostname.Text.Length <= 0)
                    MessageBox.Show("No hostname has given, server can't run.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (data_rconpass.Text.Length <= 0 || data_rconpass.Text == "changeme")
                    MessageBox.Show("No/default RCON password has given, server can't run.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Error messages end
                else
                {
                    issave = true;
                    bg_load.RunWorkerAsync();
                }
            }
        }

        internal void SaveGMode(Form2 form2)
        {
            data_gmode.Items.Clear();
            for (int i = 0; i < form2.server_list.Items.Count; i++)
                data_gmode.Items.Add(form2.server_list.Items[i]);
            if (data_gmode.Items.Count > 0) data_gmode.SelectedIndex = 0;
            form2.Dispose();
            buttoncmd = -1;
        }

        internal void SaveFScript(Form2 form2)
        {
            data_fscript.Items.Clear();
            for (int i = 0; i < form2.server_list.Items.Count; i++)
                data_fscript.Items.Add(form2.server_list.Items[i]);
            if (data_fscript.Items.Count > 0) data_fscript.SelectedIndex = 0;
            form2.Dispose();
            buttoncmd = -1;
        }

        internal void SavePlugin(Form2 form2)
        {
            data_plugin.Items.Clear();
            for (int i = 0; i < form2.server_list.Items.Count; i++)
                data_plugin.Items.Add(form2.server_list.Items[i]);
            if(data_plugin.Items.Count > 0) data_plugin.SelectedIndex = 0;
            form2.Dispose();
            buttoncmd = -1;
        }

        private void bt_about_Click(object sender, EventArgs e)
        {
            tmpstr = name[1] + name[4] + name[0] + name[5] + name[2] + name[3];
            MessageBox.Show(
                "Program written by " + tmpstr + " (2012)\n\n\n" +
                "HU\n" +
                "Remélem hasznára válik valakinek, teljessen felhasználóbarát\n" +
                "felületre törekedtem, remélem sikerült olyasmit létrehoznom.\n\n" +
                "EN\n" +
                "I hope this will be useful to someone, I tried to do a totally\n" +
                "user-friend interface, I hope I created something like that.\n\n" +
                "Written in Visual C# 2008 Express Edition (.NET 2.0)",
                "SA-MP Server Configuration Generator",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            tmpstr = null;
        }

        private void help_lan_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.Red;
        }

        private void help_lan_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.Black;
        }

        private void help_lan_MouseClick(object sender, MouseEventArgs e)
        {
            ((Control)sender).ForeColor = Color.Black;
            if (sender == help_lan)
                ShowInfoBox(
                    "HU: Helyi Hálózati szerver (LAN) be/ki (javíthat az internetes játékon)\n\n" +
                    "EN: Local Area Network server (LAN) on/off (can improve on internet gaming)",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_password)
                ShowInfoBox(
                    "HU: Szerver jelszó, ha le akarod zárni a szervert jelszóval\n\n" +
                    "EN: Server password, if you want to lock your server with password",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_rcon)
                ShowInfoBox(
                    "HU: RCON admin jelszava, ezzel tudod kezelni a szervert, ha kell\n\n" +
                    "EN: RCON admin password, you can manage your server with this",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_maxplayers)
                ShowInfoBox(
                    "HU: Maximum játékosok száma, amennyi játékos maximum lehet a szervereden\n\n" +
                    "EN: Maximum number of players that can be on your server at a time",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_port)
                ShowInfoBox(
                    "HU: Szerver portszáma, akkor fontos ha korlátozott számú nyitott portod van (pl. csak a 7778-as nyitott)\n\n" +
                    "EN: Server's port number, only important when you have restricted number of open ports (for ex. only the 7778 port is opened)",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_hostname)
                ShowInfoBox(
                    "HU: Szervered neve, ami megjelenik majd a kliensek böngészőjében\n\n" +
                    "EN: Your server's name that will appear in the clients browser",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_gmode)
                ShowInfoBox(
                    "HU: A szervered alap játékmódja, e nélkül nem képes futni a szerver\n\n" +
                    "EN: Your server's main mode, without it the server can't run",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_fscript)
                ShowInfoBox(
                    "HU: Kiegészítő dolgok a szerveredre, nem feltétlen szükséges a szerverhez\n\n" +
                    "EN: Some expanding things for your server, it's not necessary needed for your server",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_plugin)
                ShowInfoBox(
                    "HU: Scriptekkel/gamemodekkal van összekötve, mindenképp töltsd be ha szükséges egy scripthez\n\n" +
                    "EN: It's connected to a script/gamemode, always load it when it's needed by a script",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_announce)
                ShowInfoBox(
                    "HU: Látható a szerver az Internet fülnél be/ki\n\n" +
                    "EN: Server is visible in the Internet tab on/off",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_query)
                ShowInfoBox(
                    "HU: Szerver adatok megjelenítése be/ki\n\n" +
                    "EN: Show server data on/off",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_weburl)
                ShowInfoBox(
                    "HU: Szerver weboldala (ha van)\n\n" +
                    "EN: Server's websize (if exist)",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_rates)
                ShowInfoBox(
                    "HU: A játékosok milyen gyakran legyenek frissítve ezredmásodpercekben (gyalog, kocsival, fegyver, tömörítés)\n\n" +
                    "EN: How frequently will be the players refreshed in milliseconds (on foot, in car, weapon, stream)",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_streamdis)
                ShowInfoBox(
                    "HU: Játékos tömörítési távolsága (csak haladó felhasználók piszkálják)\n\n" +
                    "EN: Player's stream distance (only advanced users change it)",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_maxnpc)
                ShowInfoBox(
                    "HU: Növeld az értéket ha a szervered használ NPC-t (gamemode/script)\n\n" +
                    "EN: Increase the value if your server uses NPCs (gamemode/script)",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_logtime)
                ShowInfoBox(
                    "HU: Naplóidő formátum (óra:perc:másodperc)\n\n" +
                    "EN: Server log time format (hour:minute:second)",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_mapname)
                ShowInfoBox(
                    "HU: Akkor érdemes piszkálni, ha a gamemode például csak egy kisebb pályarészre épül (pl. Las Venturas)\n\n" +
                    "EN: Only worth the changing, when the gamemode is based on a smaller part of the map (for ex. Las Venturas)",
                    ((Control)sender).Text.Replace(":", ""));
            if (sender == help_timestamp)
                ShowInfoBox(
                    "HU: Időponttal ellátott naplózás be/ki\n\n" +
                    "EN: Log with timestamps on/off",
                    ((Control)sender).Text.Replace(":", ""));
        }

        private void ShowInfoBox(string text, string top)
        {
            MessageBox.Show(text,top,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}