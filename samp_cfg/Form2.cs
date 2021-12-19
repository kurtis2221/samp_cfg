using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace samp_cfg
{
    public partial class Form2 : Form
    {
        Form1 outform;
        
        public Form2(Form1 inform)
        {
            InitializeComponent();
            outform = inform;
        }

        public int buttoncmd = -1;
        string tmpstr = null;

        private void Form2_Load(object sender, EventArgs e)
        {
            if (outform.buttoncmd == 1)
            {
                data_repeat.Enabled = true;
                buttoncmd = 1;
                if (Directory.Exists("gamemodes"))
                {
                    string[] tmp = Directory.GetFiles("gamemodes", "*.amx");
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        if (Directory.Exists("gamemodes"))
                        {
                            folder_list.Items.Add(tmp[i].Replace(@"gamemodes\", "").Replace(".amx", ""));
                        }
                    }
                    for (int i = 0; i < outform.data_gmode.Items.Count; i++)
                        server_list.Items.Add(outform.data_gmode.Items[i]);

                    for (int i = 0; i < server_list.Items.Count; i++)
                        for (int i2 = 0; i2 < folder_list.Items.Count; i2++)
                            if (server_list.Items[i].ToString() ==
                                folder_list.Items[i2].ToString())
                                folder_list.Items.RemoveAt(i2);
                }
            }
            else if (outform.buttoncmd == 2)
            {
                data_repeat.Enabled = false;
                buttoncmd = 2;
                if (Directory.Exists("filterscripts"))
                {
                    string[] tmp = Directory.GetFiles("filterscripts", "*.amx");
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        if (Directory.Exists("filterscripts"))
                        {
                            folder_list.Items.Add(tmp[i].Replace(@"filterscripts\", "").Replace(".amx", ""));
                        }
                    }
                    for (int i = 0; i < outform.data_fscript.Items.Count; i++)
                        server_list.Items.Add(outform.data_fscript.Items[i]);

                    for (int i = 0; i < server_list.Items.Count; i++)
                        for (int i2 = 0; i2 < folder_list.Items.Count; i2++)
                            if (server_list.Items[i].ToString() ==
                                folder_list.Items[i2].ToString())
                                folder_list.Items.RemoveAt(i2);
                }
            }
            else if (outform.buttoncmd == 3)
            {
                data_repeat.Enabled = false;
                buttoncmd = 3;
                if (Directory.Exists("plugins"))
                {
                    string[] tmp = Directory.GetFiles("plugins", "*.dll");
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        if (Directory.Exists("plugins"))
                        {
                            folder_list.Items.Add(tmp[i].Replace(@"plugins\", "").Replace(".dll", ""));
                        }
                    }
                    for (int i = 0; i < outform.data_plugin.Items.Count; i++)
                        server_list.Items.Add(outform.data_plugin.Items[i]);

                    for (int i = 0; i < server_list.Items.Count; i++)
                        for (int i2 = 0; i2 < folder_list.Items.Count; i2++)
                            if (server_list.Items[i].ToString() ==
                                folder_list.Items[i2].ToString())
                                folder_list.Items.RemoveAt(i2);
                }
            }
        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            int i = server_list.SelectedIndex;
            object o = server_list.SelectedItem;

            if (i > 0)
            {
                server_list.Items.RemoveAt(i);
                server_list.Items.Insert(i - 1, o);
                server_list.SelectedIndex = i - 1;
            }
        }

        private void bt_down_Click(object sender, EventArgs e)
        {
            int i = server_list.SelectedIndex;
            object o = server_list.SelectedItem;

            if (i < server_list.Items.Count - 1)
            {
                server_list.Items.RemoveAt(i);
                server_list.Items.Insert(i + 1, o);
                server_list.SelectedIndex = i + 1;
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (folder_list.SelectedIndex != -1 && server_list.Items.Count <= 16)
            {
                if (data_repeat.Enabled)
                    server_list.Items.Add(folder_list.SelectedItem + " " + data_repeat.Value.ToString());
                else
                    server_list.Items.Add(folder_list.SelectedItem);
                folder_list.Items.RemoveAt(folder_list.SelectedIndex);
            }
        }

        private void bt_rem_Click(object sender, EventArgs e)
        {
            if (server_list.SelectedIndex != -1 && server_list.Items.Count <= 16)
            {
                tmpstr = server_list.SelectedItem.ToString();
                if(tmpstr.Contains(" "))
                    tmpstr = tmpstr.Substring(0, tmpstr.LastIndexOf(" ", tmpstr.Length));
                folder_list.Items.Add(tmpstr);
                server_list.Items.RemoveAt(server_list.SelectedIndex);
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (buttoncmd == 1) outform.SaveGMode(this);
            if (buttoncmd == 2) outform.SaveFScript(this);
            if (buttoncmd == 3) outform.SavePlugin(this);
        }

        private void bt_manual_Click(object sender, EventArgs e)
        {
            if (data_gmode.Text.Length > 0)
                server_list.Items.Add(data_gmode.Text);
        }
    }
}