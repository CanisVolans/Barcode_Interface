using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://msdn.microsoft.com/de-de/library/system.windows.forms.sendkeys.send(v=vs.110).aspx
//https://blogs.msdn.microsoft.com/bclteam/2006/10/10/top-5-serialport-tips-kim-hamilton/

namespace Barcode_Interface
{
    public partial class BarcodeInterface : Form
    {
        private string prefix, suffix, buffer = "";
        private bool b_prefix,  b_suffix, is_rs_code, is_no_hyphen, b_no_r_n;

        public BarcodeInterface()
        {
            InitializeComponent();

            com.DataReceived += com_DataReceived;
            this.Resize += MainWindow_Resize;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;

            box_com.DropDownStyle = ComboBoxStyle.DropDownList;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

            this.Text = "Barcode Interface" + "    (V" + Application.ProductVersion + ")";

            update_com_list();
            update_keyboard_settings();
            

            com.ReceivedBytesThreshold = sizeof (byte);
        }

        private void update_com_list()
        {
            string[] ports = SerialPort.GetPortNames();

            box_com.Items.Clear();
            box_com.Items.AddRange(ports);

            //box_com ist System.Windows.Forms.ComboBox
        }

        private void send_keystrokes(string data)
        {
            if(b_prefix)
            {
                SendKeys.SendWait(prefix); 
            }

            if(is_rs_code)
            {
                data = data.Insert(3 ,"-");
            }

            if(is_no_hyphen)
            {
                while (data.IndexOf('-') >= 0)
                {
                    data = data.Remove(data.IndexOf('-'), 1);
                }
            }

            if(b_no_r_n)
            {
                while (data.IndexOf('\r') >= 0)
                {
                    data = data.Remove(data.IndexOf('\r'), 1);
                }
                while (data.IndexOf('\n') >= 0)
                {
                    data = data.Remove(data.IndexOf('\n'), 1);
                }
            }

            SendKeys.SendWait(data);

            if (b_suffix)
            {
                SendKeys.SendWait(suffix);
            }
        }

        private void update_keyboard_settings()
        {
            b_suffix = checkBox_suffix.Checked;
            b_prefix = checkBox_prefix.Checked;
            is_rs_code = checkBox_rs_mode.Checked;
            is_no_hyphen = checkBox_no_hyphen.Checked;
            b_no_r_n = checkBox_no_rn.Checked;

            prefix = textBox_prefix.Text;
            suffix = textBox_suffix.Text;
        }


        #region Events
        private void com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            buffer += sp.ReadExisting();

            if(buffer.Contains("\r\n"))
            {
                send_keystrokes(buffer);
                buffer = "";
            }            
        }

        private void box_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            com.Close();
            com.PortName = box_com.SelectedItem.ToString();
            com.Open();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                notifyIcon1.BalloonTipTitle = "";

                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {

            }
        }

        private void checkBox_rs_mode_CheckedChanged(object sender, EventArgs e)
        {
            update_keyboard_settings();     //Todo auslagern, evtl wenn ein mausklick irgendwo im fenster / com_event stattfindet
        }

        private void checkBox_Farnell_Mode_CheckedChanged(object sender, EventArgs e)
        {
            update_keyboard_settings();     //Todo auslagern, evtl wenn ein mausklick irgendwo im fenster / com_event stattfindet
        }

        private void checkBox_prefix_CheckedChanged(object sender, EventArgs e)
        {
            update_keyboard_settings();     //Todo auslagern, evtl wenn ein mausklick irgendwo im fenster / com_event stattfindet
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_ohnern_CheckedChanged(object sender, EventArgs e)
        {
            update_keyboard_settings();     //Todo auslagern, evtl wenn ein mausklick irgendwo im fenster / com_event stattfindet
        }

        private void checkBox_suffix_CheckedChanged(object sender, EventArgs e)
        {
            update_keyboard_settings();     //Todo auslagern, evtl wenn ein mausklick irgendwo im fenster / com_event stattfindet       
        }

        private void textBox_prefix_TextChanged(object sender, EventArgs e)
        {
            update_keyboard_settings();     //Todo auslagern, evtl wenn ein mausklick irgendwo im fenster / com_event stattfindet       
        }

        private void textBox_suffix_TextChanged(object sender, EventArgs e)
        {
            update_keyboard_settings();     //Todo auslagern, evtl wenn ein mausklick irgendwo im fenster / com_event stattfindet
        }

        private void b_fix_help_Click(object sender, EventArgs e)
        {
            help_pre_suffix help = new help_pre_suffix();

            help.Show();
        }

        private void button_refresh_com_list_Click(object sender, EventArgs e)
        {
            update_com_list();
        }
        #endregion        
    }
}
