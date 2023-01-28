namespace TTR_Invasion_Tracker
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.LastUpdated = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Version = new System.Windows.Forms.ToolStripStatusLabel();
            this.GithubLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllowNotifications = new System.Windows.Forms.CheckBox();
            this.setStartup = new System.Windows.Forms.CheckBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ForceFetch = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status,
            this.LastUpdated,
            this.toolStripStatusLabel2,
            this.Version,
            this.GithubLink});
            this.statusStrip1.Location = new System.Drawing.Point(0, 179);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(614, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Image = ((System.Drawing.Image)(resources.GetObject("Status.Image")));
            this.Status.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Status.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(57, 17);
            this.Status.Text = "Offline";
            // 
            // LastUpdated
            // 
            this.LastUpdated.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.LastUpdated.Name = "LastUpdated";
            this.LastUpdated.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(373, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // Version
            // 
            this.Version.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(45, 17);
            this.Version.Text = "Version";
            // 
            // GithubLink
            // 
            this.GithubLink.Image = global::TTR_Invasion_Tracker.Properties.Resources.github_mark;
            this.GithubLink.IsLink = true;
            this.GithubLink.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(89, 17);
            this.GithubLink.Text = "Github Repo";
            this.GithubLink.Click += new System.EventHandler(this.GithubLink_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllowNotifications);
            this.groupBox1.Controls.Add(this.setStartup);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // AllowNotifications
            // 
            this.AllowNotifications.AutoSize = true;
            this.AllowNotifications.Location = new System.Drawing.Point(6, 70);
            this.AllowNotifications.Name = "AllowNotifications";
            this.AllowNotifications.Size = new System.Drawing.Size(170, 34);
            this.AllowNotifications.TabIndex = 1;
            this.AllowNotifications.Text = "Notify me of new Invasions\r\nin a Popup Screen\r\n";
            this.AllowNotifications.UseVisualStyleBackColor = true;
            this.AllowNotifications.CheckedChanged += new System.EventHandler(this.AllowNotifications_CheckedChanged);
            // 
            // setStartup
            // 
            this.setStartup.AutoSize = true;
            this.setStartup.Location = new System.Drawing.Point(6, 22);
            this.setStartup.Name = "setStartup";
            this.setStartup.Size = new System.Drawing.Size(165, 34);
            this.setStartup.TabIndex = 0;
            this.setStartup.Text = "Run program on Windows\r\nStartup";
            this.setStartup.UseVisualStyleBackColor = true;
            this.setStartup.CheckedChanged += new System.EventHandler(this.setStartup_CheckedChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(201, 16);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(401, 150);
            this.dataGridView.TabIndex = 2;
            // 
            // ForceFetch
            // 
            this.ForceFetch.Location = new System.Drawing.Point(12, 128);
            this.ForceFetch.Name = "ForceFetch";
            this.ForceFetch.Size = new System.Drawing.Size(183, 38);
            this.ForceFetch.TabIndex = 3;
            this.ForceFetch.Text = "Force Fetch New Data";
            this.ForceFetch.UseVisualStyleBackColor = true;
            this.ForceFetch.Click += new System.EventHandler(this.ForceFetch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(614, 201);
            this.Controls.Add(this.ForceFetch);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TTR Invasion Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Status;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel GithubLink;
        private GroupBox groupBox1;
        private CheckBox AllowNotifications;
        private CheckBox setStartup;
        private DataGridView dataGridView;
        private ToolStripStatusLabel LastUpdated;
        private ToolStripStatusLabel Version;
        private Button ForceFetch;
    }
}