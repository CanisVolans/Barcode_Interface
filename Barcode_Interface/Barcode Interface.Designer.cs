namespace Barcode_Interface
{
    partial class BarcodeInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeInterface));
            this.com = new System.IO.Ports.SerialPort(this.components);
            this.box_com = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBox_prefix = new System.Windows.Forms.CheckBox();
            this.checkBox_suffix = new System.Windows.Forms.CheckBox();
            this.textBox_prefix = new System.Windows.Forms.TextBox();
            this.textBox_suffix = new System.Windows.Forms.TextBox();
            this.checkBox_rs_mode = new System.Windows.Forms.CheckBox();
            this.b_fix_help = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkBox_no_hyphen = new System.Windows.Forms.CheckBox();
            this.button_refresh_com_list = new System.Windows.Forms.Button();
            this.checkBox_no_rn = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // box_com
            // 
            this.box_com.FormattingEnabled = true;
            this.box_com.Location = new System.Drawing.Point(89, 75);
            this.box_com.Name = "box_com";
            this.box_com.Size = new System.Drawing.Size(121, 21);
            this.box_com.TabIndex = 0;
            this.box_com.SelectedIndexChanged += new System.EventHandler(this.box_com_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Barcode Interface";
            this.notifyIcon1.Visible = true;
            // 
            // checkBox_prefix
            // 
            this.checkBox_prefix.AutoSize = true;
            this.checkBox_prefix.Location = new System.Drawing.Point(12, 115);
            this.checkBox_prefix.Name = "checkBox_prefix";
            this.checkBox_prefix.Size = new System.Drawing.Size(52, 17);
            this.checkBox_prefix.TabIndex = 1;
            this.checkBox_prefix.Text = "Prefix";
            this.checkBox_prefix.UseVisualStyleBackColor = true;
            this.checkBox_prefix.CheckedChanged += new System.EventHandler(this.checkBox_prefix_CheckedChanged);
            // 
            // checkBox_suffix
            // 
            this.checkBox_suffix.AutoSize = true;
            this.checkBox_suffix.Location = new System.Drawing.Point(12, 141);
            this.checkBox_suffix.Name = "checkBox_suffix";
            this.checkBox_suffix.Size = new System.Drawing.Size(52, 17);
            this.checkBox_suffix.TabIndex = 2;
            this.checkBox_suffix.Text = "Suffix";
            this.checkBox_suffix.UseVisualStyleBackColor = true;
            this.checkBox_suffix.CheckedChanged += new System.EventHandler(this.checkBox_suffix_CheckedChanged);
            // 
            // textBox_prefix
            // 
            this.textBox_prefix.Location = new System.Drawing.Point(70, 113);
            this.textBox_prefix.Name = "textBox_prefix";
            this.textBox_prefix.Size = new System.Drawing.Size(140, 20);
            this.textBox_prefix.TabIndex = 3;
            this.textBox_prefix.Text = "{F5}";
            this.textBox_prefix.TextChanged += new System.EventHandler(this.textBox_prefix_TextChanged);
            // 
            // textBox_suffix
            // 
            this.textBox_suffix.Location = new System.Drawing.Point(70, 139);
            this.textBox_suffix.Name = "textBox_suffix";
            this.textBox_suffix.Size = new System.Drawing.Size(140, 20);
            this.textBox_suffix.TabIndex = 4;
            this.textBox_suffix.Text = "{ENTER}";
            this.textBox_suffix.TextChanged += new System.EventHandler(this.textBox_suffix_TextChanged);
            // 
            // checkBox_rs_mode
            // 
            this.checkBox_rs_mode.AutoSize = true;
            this.checkBox_rs_mode.Location = new System.Drawing.Point(12, 164);
            this.checkBox_rs_mode.Name = "checkBox_rs_mode";
            this.checkBox_rs_mode.Size = new System.Drawing.Size(227, 17);
            this.checkBox_rs_mode.TabIndex = 5;
            this.checkBox_rs_mode.Text = "RS-Mode (Fügt nach der 3. Stelle ein - ein)";
            this.checkBox_rs_mode.UseVisualStyleBackColor = true;
            this.checkBox_rs_mode.CheckedChanged += new System.EventHandler(this.checkBox_rs_mode_CheckedChanged);
            // 
            // b_fix_help
            // 
            this.b_fix_help.Location = new System.Drawing.Point(216, 113);
            this.b_fix_help.Name = "b_fix_help";
            this.b_fix_help.Size = new System.Drawing.Size(45, 45);
            this.b_fix_help.TabIndex = 6;
            this.b_fix_help.Text = "?";
            this.b_fix_help.UseVisualStyleBackColor = true;
            this.b_fix_help.Click += new System.EventHandler(this.b_fix_help_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // checkBox_no_hyphen
            // 
            this.checkBox_no_hyphen.AutoSize = true;
            this.checkBox_no_hyphen.Location = new System.Drawing.Point(12, 187);
            this.checkBox_no_hyphen.Name = "checkBox_no_hyphen";
            this.checkBox_no_hyphen.Size = new System.Drawing.Size(213, 17);
            this.checkBox_no_hyphen.TabIndex = 7;
            this.checkBox_no_hyphen.Text = "Farnell-Mode (Entfernt alle Bindestriche)";
            this.checkBox_no_hyphen.UseVisualStyleBackColor = true;
            this.checkBox_no_hyphen.CheckedChanged += new System.EventHandler(this.checkBox_Farnell_Mode_CheckedChanged);
            // 
            // button_refresh_com_list
            // 
            this.button_refresh_com_list.Location = new System.Drawing.Point(216, 62);
            this.button_refresh_com_list.Name = "button_refresh_com_list";
            this.button_refresh_com_list.Size = new System.Drawing.Size(45, 45);
            this.button_refresh_com_list.TabIndex = 8;
            this.button_refresh_com_list.Text = "Neu laden";
            this.button_refresh_com_list.UseVisualStyleBackColor = true;
            this.button_refresh_com_list.Click += new System.EventHandler(this.button_refresh_com_list_Click);
            // 
            // checkBox_no_rn
            // 
            this.checkBox_no_rn.AutoSize = true;
            this.checkBox_no_rn.Location = new System.Drawing.Point(12, 210);
            this.checkBox_no_rn.Name = "checkBox_no_rn";
            this.checkBox_no_rn.Size = new System.Drawing.Size(80, 17);
            this.checkBox_no_rn.TabIndex = 9;
            this.checkBox_no_rn.Text = "Ohne \\r -\\n";
            this.checkBox_no_rn.UseVisualStyleBackColor = true;
            this.checkBox_no_rn.CheckedChanged += new System.EventHandler(this.checkBox_ohnern_CheckedChanged);
            // 
            // BarcodeInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkBox_no_rn);
            this.Controls.Add(this.button_refresh_com_list);
            this.Controls.Add(this.checkBox_no_hyphen);
            this.Controls.Add(this.b_fix_help);
            this.Controls.Add(this.checkBox_rs_mode);
            this.Controls.Add(this.textBox_suffix);
            this.Controls.Add(this.textBox_prefix);
            this.Controls.Add(this.checkBox_suffix);
            this.Controls.Add(this.checkBox_prefix);
            this.Controls.Add(this.box_com);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarcodeInterface";
            this.Text = "Barcode Interface";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort com;
        private System.Windows.Forms.ComboBox box_com;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox checkBox_prefix;
        private System.Windows.Forms.CheckBox checkBox_suffix;
        private System.Windows.Forms.TextBox textBox_prefix;
        private System.Windows.Forms.TextBox textBox_suffix;
        private System.Windows.Forms.CheckBox checkBox_rs_mode;
        private System.Windows.Forms.Button b_fix_help;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox checkBox_no_hyphen;
        private System.Windows.Forms.Button button_refresh_com_list;
        private System.Windows.Forms.CheckBox checkBox_no_rn;
    }
}

