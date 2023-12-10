namespace PracticalADO_ReadDB
{
    partial class Admin
    {

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.session = new System.Windows.Forms.TextBox();
            this.Messages = new System.Windows.Forms.TextBox();
            this.adminmsg = new System.Windows.Forms.TextBox();
            this.adminsend = new System.Windows.Forms.Button();
            this.usermgt = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Approval_list = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Queue = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.syslogLB = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lockdownStatus = new System.Windows.Forms.Label();
            this.resetAlmBtn = new System.Windows.Forms.Button();
            this.motionCountLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.motionLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMoisture = new System.Windows.Forms.Label();
            this.moistureLbl = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTemp = new System.Windows.Forms.Label();
            this.tempLBL = new System.Windows.Forms.Label();
            this.degcelLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblUltrasonic = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.doorLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.Temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Moisture = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.potentio_alarm_val = new System.Windows.Forms.NumericUpDown();
            this.alarm_potentio_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.moisture_alarm_val = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.moisture_warning_val = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.temp_alarm_val = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.temp_warning_val = new System.Windows.Forms.NumericUpDown();
            this.temp_Threshold_lbl = new System.Windows.Forms.Label();
            this.warning_thres_label = new System.Windows.Forms.Label();
            this.saveChanges_btn = new System.Windows.Forms.Button();
            this.usrmgtpg = new System.Windows.Forms.TabPage();
            this.todo = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EditSplit = new System.Windows.Forms.SplitContainer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.editlbl = new System.Windows.Forms.Label();
            this.grdUser = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.modifylbl = new System.Windows.Forms.Label();
            this.lblUniqueUserID = new System.Windows.Forms.Label();
            this.btnGetUserID = new System.Windows.Forms.Button();
            this.tbDOBMd = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.MFA = new System.Windows.Forms.TextBox();
            this.tbNameMd = new System.Windows.Forms.TextBox();
            this.tbPasswordMd = new System.Windows.Forms.TextBox();
            this.tbRFIDMd = new System.Windows.Forms.TextBox();
            this.tbCountryOfBirthMd = new System.Windows.Forms.TextBox();
            this.tbNRICMd = new System.Windows.Forms.TextBox();
            this.tbContactMd = new System.Windows.Forms.TextBox();
            this.tbAddMd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GetContact = new System.Windows.Forms.Button();
            this.ContactTitle = new System.Windows.Forms.Label();
            this.MFA2 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.ContactResult = new System.Windows.Forms.TextBox();
            this.ContactUsername = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.AddTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.scanCardBtn = new System.Windows.Forms.Button();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.stopScanBtn = new System.Windows.Forms.Button();
            this.tbNRIC = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.roomStatus = new System.Windows.Forms.TextBox();
            this.lightValueTB = new System.Windows.Forms.TextBox();
            this.stopLightBtn = new System.Windows.Forms.Button();
            this.sendLight = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Systems = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.usermgt.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moisture)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potentio_alarm_val)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moisture_alarm_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moisture_warning_val)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_alarm_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_warning_val)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditSplit)).BeginInit();
            this.EditSplit.Panel1.SuspendLayout();
            this.EditSplit.Panel2.SuspendLayout();
            this.EditSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // session
            // 
            this.session.Enabled = false;
            this.session.Location = new System.Drawing.Point(4, 34);
            this.session.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.session.Name = "session";
            this.session.Size = new System.Drawing.Size(100, 22);
            this.session.TabIndex = 1;
            this.session.Text = "Admin";
            // 
            // Messages
            // 
            this.Messages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Messages.Enabled = false;
            this.Messages.ForeColor = System.Drawing.Color.White;
            this.Messages.Location = new System.Drawing.Point(0, 72);
            this.Messages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Messages.Multiline = true;
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(364, 527);
            this.Messages.TabIndex = 0;
            // 
            // adminmsg
            // 
            this.adminmsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminmsg.Location = new System.Drawing.Point(0, 599);
            this.adminmsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminmsg.MinimumSize = new System.Drawing.Size(49, 20);
            this.adminmsg.Multiline = true;
            this.adminmsg.Name = "adminmsg";
            this.adminmsg.Size = new System.Drawing.Size(364, 75);
            this.adminmsg.TabIndex = 0;
            this.adminmsg.Text = "Admin Msg";
            // 
            // adminsend
            // 
            this.adminsend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminsend.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.adminsend.Location = new System.Drawing.Point(0, 674);
            this.adminsend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminsend.MinimumSize = new System.Drawing.Size(29, 20);
            this.adminsend.Name = "adminsend";
            this.adminsend.Size = new System.Drawing.Size(364, 76);
            this.adminsend.TabIndex = 0;
            this.adminsend.Text = "Send";
            this.adminsend.UseVisualStyleBackColor = true;
            this.adminsend.Click += new System.EventHandler(this.adminsend_Click);
            // 
            // usermgt
            // 
            this.usermgt.Controls.Add(this.tabPage1);
            this.usermgt.Controls.Add(this.tabPage2);
            this.usermgt.Controls.Add(this.tabPage3);
            this.usermgt.Controls.Add(this.tabPage4);
            this.usermgt.Controls.Add(this.tabPage7);
            this.usermgt.Controls.Add(this.usrmgtpg);
            this.usermgt.Controls.Add(this.todo);
            this.usermgt.Controls.Add(this.tabPage5);
            this.usermgt.Controls.Add(this.tabPage6);
            this.usermgt.Dock = System.Windows.Forms.DockStyle.Right;
            this.usermgt.Location = new System.Drawing.Point(364, 0);
            this.usermgt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usermgt.Name = "usermgt";
            this.usermgt.SelectedIndex = 0;
            this.usermgt.Size = new System.Drawing.Size(919, 753);
            this.usermgt.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Approval_list);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(911, 724);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Approval";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(3, 694);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(905, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Approve Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Approval_list
            // 
            this.Approval_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Approval_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Approval_list.ForeColor = System.Drawing.Color.White;
            this.Approval_list.FormattingEnabled = true;
            this.Approval_list.Location = new System.Drawing.Point(3, 2);
            this.Approval_list.Margin = new System.Windows.Forms.Padding(4);
            this.Approval_list.Name = "Approval_list";
            this.Approval_list.Size = new System.Drawing.Size(905, 720);
            this.Approval_list.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tabPage2.Controls.Add(this.Queue);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(911, 724);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Current Queue";
            // 
            // Queue
            // 
            this.Queue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Queue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Queue.Location = new System.Drawing.Point(3, 2);
            this.Queue.Margin = new System.Windows.Forms.Padding(4);
            this.Queue.Multiline = true;
            this.Queue.Name = "Queue";
            this.Queue.Size = new System.Drawing.Size(905, 720);
            this.Queue.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.syslogLB);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(911, 724);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logs";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(31, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "System Log";
            // 
            // syslogLB
            // 
            this.syslogLB.FormattingEnabled = true;
            this.syslogLB.ItemHeight = 16;
            this.syslogLB.Location = new System.Drawing.Point(27, 63);
            this.syslogLB.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.syslogLB.Name = "syslogLB";
            this.syslogLB.Size = new System.Drawing.Size(864, 340);
            this.syslogLB.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(911, 724);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dashboard";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 2);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.splitContainer2.Panel1.Controls.Add(this.lockdownStatus);
            this.splitContainer2.Panel1.Controls.Add(this.resetAlmBtn);
            this.splitContainer2.Panel1.Controls.Add(this.motionCountLbl);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.panel13);
            this.splitContainer2.Panel1.Controls.Add(this.panel9);
            this.splitContainer2.Panel1.Controls.Add(this.panel8);
            this.splitContainer2.Panel1.Controls.Add(this.panel7);
            this.splitContainer2.Panel1.Controls.Add(this.label15);
            this.splitContainer2.Panel1.Controls.Add(this.lblUltrasonic);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.doorLbl);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dashboard);
            this.splitContainer2.Size = new System.Drawing.Size(905, 720);
            this.splitContainer2.SplitterDistance = 440;
            this.splitContainer2.TabIndex = 1;
            // 
            // lockdownStatus
            // 
            this.lockdownStatus.AutoSize = true;
            this.lockdownStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lockdownStatus.Location = new System.Drawing.Point(281, 372);
            this.lockdownStatus.Name = "lockdownStatus";
            this.lockdownStatus.Size = new System.Drawing.Size(232, 39);
            this.lockdownStatus.TabIndex = 23;
            this.lockdownStatus.Text = "Normal mode";
            // 
            // resetAlmBtn
            // 
            this.resetAlmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAlmBtn.Location = new System.Drawing.Point(732, 372);
            this.resetAlmBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetAlmBtn.Name = "resetAlmBtn";
            this.resetAlmBtn.Size = new System.Drawing.Size(140, 39);
            this.resetAlmBtn.TabIndex = 22;
            this.resetAlmBtn.Text = "Reset alarm";
            this.resetAlmBtn.UseVisualStyleBackColor = true;
            this.resetAlmBtn.Click += new System.EventHandler(this.resetAlmBtn_Click);
            // 
            // motionCountLbl
            // 
            this.motionCountLbl.AutoSize = true;
            this.motionCountLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.motionCountLbl.Location = new System.Drawing.Point(633, 82);
            this.motionCountLbl.Name = "motionCountLbl";
            this.motionCountLbl.Size = new System.Drawing.Size(115, 39);
            this.motionCountLbl.TabIndex = 21;
            this.motionCountLbl.Text = "label8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(637, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Motion Count";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel13.Location = new System.Drawing.Point(276, 150);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(596, 182);
            this.panel13.TabIndex = 19;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel9.Controls.Add(this.motionLbl);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(21, 241);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 91);
            this.panel9.TabIndex = 18;
            // 
            // motionLbl
            // 
            this.motionLbl.AutoSize = true;
            this.motionLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.motionLbl.ForeColor = System.Drawing.Color.Green;
            this.motionLbl.Location = new System.Drawing.Point(11, 39);
            this.motionLbl.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.motionLbl.Name = "motionLbl";
            this.motionLbl.Size = new System.Drawing.Size(63, 39);
            this.motionLbl.TabIndex = 12;
            this.motionLbl.Text = "No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.GhostWhite;
            this.label12.Location = new System.Drawing.Point(12, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Intrusion Detected?";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.lblMoisture);
            this.panel8.Controls.Add(this.moistureLbl);
            this.panel8.Location = new System.Drawing.Point(21, 48);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(203, 79);
            this.panel8.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(0, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "g m -3";
            // 
            // lblMoisture
            // 
            this.lblMoisture.AutoSize = true;
            this.lblMoisture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lblMoisture.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMoisture.Location = new System.Drawing.Point(-4, 23);
            this.lblMoisture.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.lblMoisture.Name = "lblMoisture";
            this.lblMoisture.Size = new System.Drawing.Size(135, 39);
            this.lblMoisture.TabIndex = 6;
            this.lblMoisture.Text = "label10";
            this.lblMoisture.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMoisture.TextChanged += new System.EventHandler(this.lblMoisture_TextChanged);
            // 
            // moistureLbl
            // 
            this.moistureLbl.AutoSize = true;
            this.moistureLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.moistureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moistureLbl.ForeColor = System.Drawing.Color.Ivory;
            this.moistureLbl.Location = new System.Drawing.Point(0, 0);
            this.moistureLbl.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.moistureLbl.Name = "moistureLbl";
            this.moistureLbl.Size = new System.Drawing.Size(101, 15);
            this.moistureLbl.TabIndex = 7;
            this.moistureLbl.Text = "Moisture Level";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel7.Controls.Add(this.lblTemp);
            this.panel7.Controls.Add(this.tempLBL);
            this.panel7.Controls.Add(this.degcelLbl);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(21, 150);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 78);
            this.panel7.TabIndex = 16;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lblTemp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTemp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTemp.Location = new System.Drawing.Point(0, 24);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(135, 39);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "label10";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTemp.Click += new System.EventHandler(this.lblTemp_Click);
            // 
            // tempLBL
            // 
            this.tempLBL.AutoSize = true;
            this.tempLBL.Dock = System.Windows.Forms.DockStyle.Top;
            this.tempLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLBL.ForeColor = System.Drawing.Color.Ivory;
            this.tempLBL.Location = new System.Drawing.Point(0, 0);
            this.tempLBL.Margin = new System.Windows.Forms.Padding(5);
            this.tempLBL.Name = "tempLBL";
            this.tempLBL.Size = new System.Drawing.Size(89, 15);
            this.tempLBL.TabIndex = 5;
            this.tempLBL.Text = "Temperature";
            this.tempLBL.Click += new System.EventHandler(this.tempLBL_Click);
            // 
            // degcelLbl
            // 
            this.degcelLbl.AutoSize = true;
            this.degcelLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.degcelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degcelLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.degcelLbl.Location = new System.Drawing.Point(0, 63);
            this.degcelLbl.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.degcelLbl.Name = "degcelLbl";
            this.degcelLbl.Size = new System.Drawing.Size(110, 15);
            this.degcelLbl.TabIndex = 8;
            this.degcelLbl.Text = "degrees Celsius";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.GhostWhite;
            this.label10.Location = new System.Drawing.Point(161, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "lb/ft3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.GhostWhite;
            this.label15.Location = new System.Drawing.Point(475, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 15);
            this.label15.TabIndex = 15;
            this.label15.Text = "Water amount";
            // 
            // lblUltrasonic
            // 
            this.lblUltrasonic.AutoSize = true;
            this.lblUltrasonic.BackColor = System.Drawing.Color.Transparent;
            this.lblUltrasonic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUltrasonic.Location = new System.Drawing.Point(469, 82);
            this.lblUltrasonic.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.lblUltrasonic.Name = "lblUltrasonic";
            this.lblUltrasonic.Size = new System.Drawing.Size(135, 39);
            this.lblUltrasonic.TabIndex = 14;
            this.lblUltrasonic.Text = "label10";
            this.lblUltrasonic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.GhostWhite;
            this.label11.Location = new System.Drawing.Point(296, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Door is:";
            // 
            // doorLbl
            // 
            this.doorLbl.AutoSize = true;
            this.doorLbl.BackColor = System.Drawing.Color.Transparent;
            this.doorLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.doorLbl.Location = new System.Drawing.Point(292, 82);
            this.doorLbl.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.doorLbl.Name = "doorLbl";
            this.doorLbl.Size = new System.Drawing.Size(135, 39);
            this.doorLbl.TabIndex = 10;
            this.doorLbl.Text = "label10";
            this.doorLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label9.Size = new System.Drawing.Size(127, 44);
            this.label9.TabIndex = 2;
            this.label9.Text = "DashBoard";
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dashboard.Controls.Add(this.Temperature);
            this.dashboard.Controls.Add(this.Moisture);
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard.Location = new System.Drawing.Point(0, 0);
            this.dashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(905, 276);
            this.dashboard.TabIndex = 0;
            // 
            // Temperature
            // 
            chartArea3.Name = "ChartArea1";
            this.Temperature.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Temperature.Legends.Add(legend3);
            this.Temperature.Location = new System.Drawing.Point(11, 10);
            this.Temperature.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Temperature.Name = "Temperature";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Temperature";
            this.Temperature.Series.Add(series3);
            this.Temperature.Size = new System.Drawing.Size(429, 199);
            this.Temperature.TabIndex = 0;
            this.Temperature.Text = "Temperature";
            title3.Name = "Temperature";
            title3.Text = "Temperature";
            this.Temperature.Titles.Add(title3);
            // 
            // Moisture
            // 
            chartArea4.Name = "ChartArea1";
            this.Moisture.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.Moisture.Legends.Add(legend4);
            this.Moisture.Location = new System.Drawing.Point(462, 10);
            this.Moisture.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Moisture.Name = "Moisture";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Moisture";
            this.Moisture.Series.Add(series4);
            this.Moisture.Size = new System.Drawing.Size(429, 199);
            this.Moisture.TabIndex = 1;
            this.Moisture.Text = "Moisture";
            title4.Name = "Moisture";
            title4.Text = "Moisture";
            this.Moisture.Titles.Add(title4);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tabPage7.Controls.Add(this.panel12);
            this.tabPage7.Controls.Add(this.panel11);
            this.tabPage7.Controls.Add(this.panel10);
            this.tabPage7.Controls.Add(this.saveChanges_btn);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(911, 724);
            this.tabPage7.TabIndex = 8;
            this.tabPage7.Text = "Controls";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel12.Controls.Add(this.pictureBox3);
            this.panel12.Controls.Add(this.potentio_alarm_val);
            this.panel12.Controls.Add(this.alarm_potentio_label);
            this.panel12.Controls.Add(this.label4);
            this.panel12.Location = new System.Drawing.Point(28, 439);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(839, 170);
            this.panel12.TabIndex = 22;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(675, 27);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // potentio_alarm_val
            // 
            this.potentio_alarm_val.DecimalPlaces = 2;
            this.potentio_alarm_val.Location = new System.Drawing.Point(212, 82);
            this.potentio_alarm_val.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.potentio_alarm_val.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.potentio_alarm_val.Name = "potentio_alarm_val";
            this.potentio_alarm_val.Size = new System.Drawing.Size(120, 22);
            this.potentio_alarm_val.TabIndex = 7;
            // 
            // alarm_potentio_label
            // 
            this.alarm_potentio_label.AutoSize = true;
            this.alarm_potentio_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_potentio_label.ForeColor = System.Drawing.Color.White;
            this.alarm_potentio_label.Location = new System.Drawing.Point(41, 90);
            this.alarm_potentio_label.Name = "alarm_potentio_label";
            this.alarm_potentio_label.Size = new System.Drawing.Size(105, 12);
            this.alarm_potentio_label.TabIndex = 6;
            this.alarm_potentio_label.Text = "Set Alarm threshold";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(37, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(410, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Potentiometer threshold controls";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel11.Controls.Add(this.pictureBox2);
            this.panel11.Controls.Add(this.moisture_alarm_val);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.moisture_warning_val);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Location = new System.Drawing.Point(28, 242);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(839, 180);
            this.panel11.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(651, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // moisture_alarm_val
            // 
            this.moisture_alarm_val.Location = new System.Drawing.Point(212, 86);
            this.moisture_alarm_val.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moisture_alarm_val.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.moisture_alarm_val.Name = "moisture_alarm_val";
            this.moisture_alarm_val.Size = new System.Drawing.Size(120, 22);
            this.moisture_alarm_val.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Set Alarm threshold";
            // 
            // moisture_warning_val
            // 
            this.moisture_warning_val.Location = new System.Drawing.Point(212, 124);
            this.moisture_warning_val.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moisture_warning_val.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.moisture_warning_val.Name = "moisture_warning_val";
            this.moisture_warning_val.Size = new System.Drawing.Size(120, 22);
            this.moisture_warning_val.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(37, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Moisture threshold controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set Warning threshold";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel10.Controls.Add(this.pictureBox1);
            this.panel10.Controls.Add(this.temp_alarm_val);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.temp_warning_val);
            this.panel10.Controls.Add(this.temp_Threshold_lbl);
            this.panel10.Controls.Add(this.warning_thres_label);
            this.panel10.Location = new System.Drawing.Point(28, 30);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(839, 194);
            this.panel10.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(651, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // temp_alarm_val
            // 
            this.temp_alarm_val.Location = new System.Drawing.Point(212, 79);
            this.temp_alarm_val.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.temp_alarm_val.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.temp_alarm_val.Name = "temp_alarm_val";
            this.temp_alarm_val.Size = new System.Drawing.Size(120, 22);
            this.temp_alarm_val.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "Set Alarm threshold";
            // 
            // temp_warning_val
            // 
            this.temp_warning_val.Location = new System.Drawing.Point(212, 126);
            this.temp_warning_val.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.temp_warning_val.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.temp_warning_val.Name = "temp_warning_val";
            this.temp_warning_val.Size = new System.Drawing.Size(120, 22);
            this.temp_warning_val.TabIndex = 4;
            // 
            // temp_Threshold_lbl
            // 
            this.temp_Threshold_lbl.AutoSize = true;
            this.temp_Threshold_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_Threshold_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.temp_Threshold_lbl.Location = new System.Drawing.Point(37, 21);
            this.temp_Threshold_lbl.Name = "temp_Threshold_lbl";
            this.temp_Threshold_lbl.Size = new System.Drawing.Size(394, 29);
            this.temp_Threshold_lbl.TabIndex = 2;
            this.temp_Threshold_lbl.Text = "Temperature threshold controls";
            // 
            // warning_thres_label
            // 
            this.warning_thres_label.AutoSize = true;
            this.warning_thres_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_thres_label.ForeColor = System.Drawing.Color.White;
            this.warning_thres_label.Location = new System.Drawing.Point(41, 133);
            this.warning_thres_label.Name = "warning_thres_label";
            this.warning_thres_label.Size = new System.Drawing.Size(116, 12);
            this.warning_thres_label.TabIndex = 1;
            this.warning_thres_label.Text = "Set Warning threshold";
            // 
            // saveChanges_btn
            // 
            this.saveChanges_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChanges_btn.Location = new System.Drawing.Point(723, 625);
            this.saveChanges_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveChanges_btn.Name = "saveChanges_btn";
            this.saveChanges_btn.Size = new System.Drawing.Size(125, 27);
            this.saveChanges_btn.TabIndex = 0;
            this.saveChanges_btn.Text = "Save Changes";
            this.saveChanges_btn.UseVisualStyleBackColor = true;
            this.saveChanges_btn.Click += new System.EventHandler(this.saveChanges_btn_Click);
            // 
            // usrmgtpg
            // 
            this.usrmgtpg.Location = new System.Drawing.Point(4, 25);
            this.usrmgtpg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usrmgtpg.Name = "usrmgtpg";
            this.usrmgtpg.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usrmgtpg.Size = new System.Drawing.Size(911, 724);
            this.usrmgtpg.TabIndex = 4;
            this.usrmgtpg.Text = "User Management Page";
            this.usrmgtpg.UseVisualStyleBackColor = true;
            // 
            // todo
            // 
            this.todo.Location = new System.Drawing.Point(4, 25);
            this.todo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todo.Name = "todo";
            this.todo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todo.Size = new System.Drawing.Size(911, 724);
            this.todo.TabIndex = 5;
            this.todo.Text = "To-do-list";
            this.todo.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tabPage5.Controls.Add(this.flowLayoutPanel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(911, 724);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Check Info";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(903, 716);
            this.flowLayoutPanel1.TabIndex = 24;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.EditSplit);
            this.panel3.Controls.Add(this.editlbl);
            this.panel3.Controls.Add(this.grdUser);
            this.panel3.Location = new System.Drawing.Point(11, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 446);
            this.panel3.TabIndex = 26;
            // 
            // EditSplit
            // 
            this.EditSplit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditSplit.Location = new System.Drawing.Point(0, 46);
            this.EditSplit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditSplit.Name = "EditSplit";
            // 
            // EditSplit.Panel1
            // 
            this.EditSplit.Panel1.Controls.Add(this.btnDelete);
            // 
            // EditSplit.Panel2
            // 
            this.EditSplit.Panel2.Controls.Add(this.btnUpdate);
            this.EditSplit.Size = new System.Drawing.Size(495, 48);
            this.EditSplit.SplitterDistance = 229;
            this.EditSplit.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(229, 48);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(262, 48);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // editlbl
            // 
            this.editlbl.AutoSize = true;
            this.editlbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.editlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.editlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editlbl.Location = new System.Drawing.Point(0, 0);
            this.editlbl.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.editlbl.Name = "editlbl";
            this.editlbl.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.editlbl.Size = new System.Drawing.Size(209, 44);
            this.editlbl.TabIndex = 1;
            this.editlbl.Text = "Edit User Information";
            // 
            // grdUser
            // 
            this.grdUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdUser.Location = new System.Drawing.Point(0, 94);
            this.grdUser.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.grdUser.Name = "grdUser";
            this.grdUser.RowTemplate.Height = 24;
            this.grdUser.Size = new System.Drawing.Size(495, 352);
            this.grdUser.TabIndex = 1;
            this.grdUser.Click += new System.EventHandler(this.grdUser_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.modifylbl);
            this.panel5.Controls.Add(this.lblUniqueUserID);
            this.panel5.Controls.Add(this.btnGetUserID);
            this.panel5.Controls.Add(this.tbDOBMd);
            this.panel5.Controls.Add(this.btnModify);
            this.panel5.Controls.Add(this.tbUserID);
            this.panel5.Controls.Add(this.MFA);
            this.panel5.Controls.Add(this.tbNameMd);
            this.panel5.Controls.Add(this.tbPasswordMd);
            this.panel5.Controls.Add(this.tbRFIDMd);
            this.panel5.Controls.Add(this.tbCountryOfBirthMd);
            this.panel5.Controls.Add(this.tbNRICMd);
            this.panel5.Controls.Add(this.tbContactMd);
            this.panel5.Controls.Add(this.tbAddMd);
            this.panel5.Location = new System.Drawing.Point(528, 10);
            this.panel5.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(361, 446);
            this.panel5.TabIndex = 25;
            // 
            // modifylbl
            // 
            this.modifylbl.AutoSize = true;
            this.modifylbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.modifylbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.modifylbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modifylbl.Location = new System.Drawing.Point(0, 0);
            this.modifylbl.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.modifylbl.Name = "modifylbl";
            this.modifylbl.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.modifylbl.Size = new System.Drawing.Size(231, 44);
            this.modifylbl.TabIndex = 2;
            this.modifylbl.Text = "Modify User Information";
            // 
            // lblUniqueUserID
            // 
            this.lblUniqueUserID.AutoSize = true;
            this.lblUniqueUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUniqueUserID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUniqueUserID.Location = new System.Drawing.Point(3, 44);
            this.lblUniqueUserID.Name = "lblUniqueUserID";
            this.lblUniqueUserID.Size = new System.Drawing.Size(100, 323);
            this.lblUniqueUserID.TabIndex = 1;
            this.lblUniqueUserID.Text = "UniqueUserID:\r\n\r\nName:\r\n\r\nRFID:\r\n\r\nNRIC:\r\n\r\nAddress:\r\n\r\nContact:\r\n\r\nPassword:\r\n\r\n" +
    "Country:\r\n\r\nMFA:\r\n\r\nDOB:";
            // 
            // btnGetUserID
            // 
            this.btnGetUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetUserID.Location = new System.Drawing.Point(133, 401);
            this.btnGetUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetUserID.Name = "btnGetUserID";
            this.btnGetUserID.Size = new System.Drawing.Size(84, 28);
            this.btnGetUserID.TabIndex = 20;
            this.btnGetUserID.Text = "Get User";
            this.btnGetUserID.UseVisualStyleBackColor = true;
            this.btnGetUserID.Click += new System.EventHandler(this.btnGetUserID_Click);
            // 
            // tbDOBMd
            // 
            this.tbDOBMd.Location = new System.Drawing.Point(109, 345);
            this.tbDOBMd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDOBMd.Name = "tbDOBMd";
            this.tbDOBMd.Size = new System.Drawing.Size(109, 22);
            this.tbDOBMd.TabIndex = 23;
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(27, 401);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(77, 28);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // tbUserID
            // 
            this.tbUserID.BackColor = System.Drawing.SystemColors.Window;
            this.tbUserID.Location = new System.Drawing.Point(109, 44);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(109, 22);
            this.tbUserID.TabIndex = 7;
            // 
            // MFA
            // 
            this.MFA.Location = new System.Drawing.Point(109, 313);
            this.MFA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MFA.Name = "MFA";
            this.MFA.Size = new System.Drawing.Size(109, 22);
            this.MFA.TabIndex = 22;
            this.MFA.TextChanged += new System.EventHandler(this.MFA_TextChanged);
            // 
            // tbNameMd
            // 
            this.tbNameMd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbNameMd.Location = new System.Drawing.Point(109, 71);
            this.tbNameMd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNameMd.Name = "tbNameMd";
            this.tbNameMd.Size = new System.Drawing.Size(109, 22);
            this.tbNameMd.TabIndex = 9;
            // 
            // tbPasswordMd
            // 
            this.tbPasswordMd.Location = new System.Drawing.Point(109, 244);
            this.tbPasswordMd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPasswordMd.Name = "tbPasswordMd";
            this.tbPasswordMd.Size = new System.Drawing.Size(109, 22);
            this.tbPasswordMd.TabIndex = 15;
            // 
            // tbRFIDMd
            // 
            this.tbRFIDMd.Location = new System.Drawing.Point(109, 105);
            this.tbRFIDMd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRFIDMd.Name = "tbRFIDMd";
            this.tbRFIDMd.Size = new System.Drawing.Size(109, 22);
            this.tbRFIDMd.TabIndex = 10;
            // 
            // tbCountryOfBirthMd
            // 
            this.tbCountryOfBirthMd.Location = new System.Drawing.Point(109, 278);
            this.tbCountryOfBirthMd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCountryOfBirthMd.Name = "tbCountryOfBirthMd";
            this.tbCountryOfBirthMd.Size = new System.Drawing.Size(109, 22);
            this.tbCountryOfBirthMd.TabIndex = 18;
            // 
            // tbNRICMd
            // 
            this.tbNRICMd.Location = new System.Drawing.Point(109, 145);
            this.tbNRICMd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNRICMd.Name = "tbNRICMd";
            this.tbNRICMd.Size = new System.Drawing.Size(109, 22);
            this.tbNRICMd.TabIndex = 12;
            // 
            // tbContactMd
            // 
            this.tbContactMd.Location = new System.Drawing.Point(109, 209);
            this.tbContactMd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContactMd.Name = "tbContactMd";
            this.tbContactMd.Size = new System.Drawing.Size(109, 22);
            this.tbContactMd.TabIndex = 12;
            // 
            // tbAddMd
            // 
            this.tbAddMd.Location = new System.Drawing.Point(109, 177);
            this.tbAddMd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddMd.Name = "tbAddMd";
            this.tbAddMd.Size = new System.Drawing.Size(109, 22);
            this.tbAddMd.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.GetContact);
            this.panel2.Controls.Add(this.ContactTitle);
            this.panel2.Controls.Add(this.MFA2);
            this.panel2.Controls.Add(this.Username);
            this.panel2.Controls.Add(this.ContactResult);
            this.panel2.Controls.Add(this.ContactUsername);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(11, 476);
            this.panel2.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 240);
            this.panel2.TabIndex = 25;
            // 
            // GetContact
            // 
            this.GetContact.Location = new System.Drawing.Point(117, 158);
            this.GetContact.Margin = new System.Windows.Forms.Padding(4);
            this.GetContact.Name = "GetContact";
            this.GetContact.Size = new System.Drawing.Size(105, 37);
            this.GetContact.TabIndex = 5;
            this.GetContact.Text = "Get Contact";
            this.GetContact.UseVisualStyleBackColor = true;
            this.GetContact.Click += new System.EventHandler(this.GetContact_Click);
            // 
            // ContactTitle
            // 
            this.ContactTitle.AutoSize = true;
            this.ContactTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.ContactTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ContactTitle.Location = new System.Drawing.Point(0, 0);
            this.ContactTitle.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.ContactTitle.Name = "ContactTitle";
            this.ContactTitle.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.ContactTitle.Size = new System.Drawing.Size(176, 44);
            this.ContactTitle.TabIndex = 0;
            this.ContactTitle.Text = "Get User Contact";
            // 
            // MFA2
            // 
            this.MFA2.Location = new System.Drawing.Point(85, 110);
            this.MFA2.Margin = new System.Windows.Forms.Padding(4);
            this.MFA2.Name = "MFA2";
            this.MFA2.ReadOnly = true;
            this.MFA2.Size = new System.Drawing.Size(132, 22);
            this.MFA2.TabIndex = 7;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Username.Location = new System.Drawing.Point(4, 50);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(73, 85);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username\r\n\r\nContact\r\n\r\nMFA";
            // 
            // ContactResult
            // 
            this.ContactResult.Location = new System.Drawing.Point(85, 79);
            this.ContactResult.Margin = new System.Windows.Forms.Padding(4);
            this.ContactResult.Name = "ContactResult";
            this.ContactResult.ReadOnly = true;
            this.ContactResult.Size = new System.Drawing.Size(132, 22);
            this.ContactResult.TabIndex = 4;
            // 
            // ContactUsername
            // 
            this.ContactUsername.AllowDrop = true;
            this.ContactUsername.Location = new System.Drawing.Point(85, 50);
            this.ContactUsername.Margin = new System.Windows.Forms.Padding(4);
            this.ContactUsername.Name = "ContactUsername";
            this.ContactUsername.Size = new System.Drawing.Size(132, 22);
            this.ContactUsername.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(7, 158);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 34);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel4.Controls.Add(this.tbName);
            this.panel4.Controls.Add(this.AddTitle);
            this.panel4.Controls.Add(this.lblName);
            this.panel4.Controls.Add(this.tbPwd);
            this.panel4.Controls.Add(this.tbContact);
            this.panel4.Controls.Add(this.tbRFID);
            this.panel4.Controls.Add(this.scanCardBtn);
            this.panel4.Controls.Add(this.tbAdd);
            this.panel4.Controls.Add(this.stopScanBtn);
            this.panel4.Controls.Add(this.tbNRIC);
            this.panel4.Location = new System.Drawing.Point(333, 476);
            this.panel4.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 240);
            this.panel4.TabIndex = 25;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(83, 43);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(208, 22);
            this.tbName.TabIndex = 15;
            // 
            // AddTitle
            // 
            this.AddTitle.AutoSize = true;
            this.AddTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.AddTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddTitle.Location = new System.Drawing.Point(0, 0);
            this.AddTitle.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.AddTitle.Size = new System.Drawing.Size(112, 44);
            this.AddTitle.TabIndex = 1;
            this.AddTitle.Text = "Add User";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblName.Location = new System.Drawing.Point(3, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 187);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name:\r\n\r\nPassword:\r\n\r\nRFID:\r\n\r\nNRIC:\r\n\r\nAddress:\r\n\r\nContact:";
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(83, 73);
            this.tbPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(208, 22);
            this.tbPwd.TabIndex = 14;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(83, 203);
            this.tbContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(208, 22);
            this.tbContact.TabIndex = 19;
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(83, 106);
            this.tbRFID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.ReadOnly = true;
            this.tbRFID.Size = new System.Drawing.Size(93, 22);
            this.tbRFID.TabIndex = 16;
            // 
            // scanCardBtn
            // 
            this.scanCardBtn.Location = new System.Drawing.Point(181, 105);
            this.scanCardBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scanCardBtn.Name = "scanCardBtn";
            this.scanCardBtn.Size = new System.Drawing.Size(56, 23);
            this.scanCardBtn.TabIndex = 20;
            this.scanCardBtn.Text = "Scan Card";
            this.scanCardBtn.UseVisualStyleBackColor = true;
            this.scanCardBtn.Click += new System.EventHandler(this.scanCardBtn_Click);
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(83, 175);
            this.tbAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(208, 22);
            this.tbAdd.TabIndex = 18;
            // 
            // stopScanBtn
            // 
            this.stopScanBtn.Location = new System.Drawing.Point(243, 103);
            this.stopScanBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopScanBtn.Name = "stopScanBtn";
            this.stopScanBtn.Size = new System.Drawing.Size(47, 23);
            this.stopScanBtn.TabIndex = 21;
            this.stopScanBtn.Text = "Stop Scan";
            this.stopScanBtn.UseVisualStyleBackColor = true;
            this.stopScanBtn.Click += new System.EventHandler(this.stopScanBtn_Click);
            // 
            // tbNRIC
            // 
            this.tbNRIC.Location = new System.Drawing.Point(83, 139);
            this.tbNRIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNRIC.Name = "tbNRIC";
            this.tbNRIC.Size = new System.Drawing.Size(208, 22);
            this.tbNRIC.TabIndex = 17;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.LightGray;
            this.tabPage6.Controls.Add(this.roomStatus);
            this.tabPage6.Controls.Add(this.lightValueTB);
            this.tabPage6.Controls.Add(this.stopLightBtn);
            this.tabPage6.Controls.Add(this.sendLight);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(911, 724);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "lightValue";
            // 
            // roomStatus
            // 
            this.roomStatus.Location = new System.Drawing.Point(72, 65);
            this.roomStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomStatus.Name = "roomStatus";
            this.roomStatus.ReadOnly = true;
            this.roomStatus.Size = new System.Drawing.Size(272, 22);
            this.roomStatus.TabIndex = 3;
            // 
            // lightValueTB
            // 
            this.lightValueTB.Location = new System.Drawing.Point(72, 25);
            this.lightValueTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lightValueTB.Name = "lightValueTB";
            this.lightValueTB.ReadOnly = true;
            this.lightValueTB.Size = new System.Drawing.Size(272, 22);
            this.lightValueTB.TabIndex = 0;
            // 
            // stopLightBtn
            // 
            this.stopLightBtn.Location = new System.Drawing.Point(489, 16);
            this.stopLightBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopLightBtn.Name = "stopLightBtn";
            this.stopLightBtn.Size = new System.Drawing.Size(96, 30);
            this.stopLightBtn.TabIndex = 2;
            this.stopLightBtn.Text = "Stop Light";
            this.stopLightBtn.UseVisualStyleBackColor = true;
            // 
            // sendLight
            // 
            this.sendLight.Location = new System.Drawing.Point(376, 16);
            this.sendLight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendLight.Name = "sendLight";
            this.sendLight.Size = new System.Drawing.Size(96, 30);
            this.sendLight.TabIndex = 1;
            this.sendLight.Text = "Send Light";
            this.sendLight.UseVisualStyleBackColor = true;
            this.sendLight.Click += new System.EventHandler(this.sendLight_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.Systems);
            this.panel1.Controls.Add(this.session);
            this.panel1.Controls.Add(this.Messages);
            this.panel1.Controls.Add(this.adminmsg);
            this.panel1.Controls.Add(this.adminsend);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 750);
            this.panel1.TabIndex = 2;
            // 
            // Systems
            // 
            this.Systems.AutoSize = true;
            this.Systems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(210)))), ((int)(((byte)(134)))));
            this.Systems.Location = new System.Drawing.Point(112, 43);
            this.Systems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Systems.Name = "Systems";
            this.Systems.Size = new System.Drawing.Size(70, 17);
            this.Systems.TabIndex = 28;
            this.Systems.Text = "Welcome ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Title);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(364, 30);
            this.panel6.TabIndex = 27;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.MaximumSize = new System.Drawing.Size(2667, 246);
            this.Title.MinimumSize = new System.Drawing.Size(267, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(326, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "Server Environment Monitoring System";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.UseWaitCursor = true;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1283, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usermgt);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.usermgt.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moisture)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potentio_alarm_val)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moisture_alarm_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moisture_warning_val)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_alarm_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_warning_val)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.EditSplit.Panel1.ResumeLayout(false);
            this.EditSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditSplit)).EndInit();
            this.EditSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TextBox adminmsg;
        private System.Windows.Forms.Button adminsend;

        private System.Windows.Forms.TabControl usermgt;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel dashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart Temperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart Moisture;
        private System.Windows.Forms.TabPage usrmgtpg;
        private System.Windows.Forms.TabPage todo;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox roomStatus;
        private System.Windows.Forms.TextBox lightValueTB;
        private System.Windows.Forms.Button stopLightBtn;
        private System.Windows.Forms.Button sendLight;
        private System.Windows.Forms.Label tempLBL;
        private System.Windows.Forms.Label moistureLbl;
        private System.Windows.Forms.Label lblMoisture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label degcelLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label doorLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label motionLbl;
        private System.Windows.Forms.ListBox syslogLB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblUltrasonic;
        private System.Windows.Forms.TextBox Messages;
        private System.Windows.Forms.TextBox session;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox MFA;
        private System.Windows.Forms.Button stopScanBtn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.Button scanCardBtn;
        private System.Windows.Forms.TextBox tbPasswordMd;
        private System.Windows.Forms.TextBox tbNRIC;
        private System.Windows.Forms.Button btnGetUserID;
        private System.Windows.Forms.TextBox tbContactMd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.DataGridView grdUser;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label AddTitle;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox tbCountryOfBirthMd;
        private System.Windows.Forms.Button GetContact;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label modifylbl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label editlbl;
        private System.Windows.Forms.Label lblUniqueUserID;
        private System.Windows.Forms.TextBox MFA2;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox tbNameMd;
        private System.Windows.Forms.TextBox ContactResult;
        private System.Windows.Forms.TextBox ContactUsername;
        private System.Windows.Forms.TextBox tbAddMd;
        private System.Windows.Forms.TextBox tbRFIDMd;
        private System.Windows.Forms.Label ContactTitle;
        private System.Windows.Forms.TextBox tbNRICMd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox tbDOBMd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.SplitContainer EditSplit;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.NumericUpDown potentio_alarm_val;
        private System.Windows.Forms.Label alarm_potentio_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.NumericUpDown moisture_alarm_val;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown moisture_warning_val;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown temp_alarm_val;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown temp_warning_val;
        private System.Windows.Forms.Label temp_Threshold_lbl;
        private System.Windows.Forms.Label warning_thres_label;
        private System.Windows.Forms.Button saveChanges_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label motionCountLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button resetAlmBtn;
        private System.Windows.Forms.Label lockdownStatus;
        private System.Windows.Forms.CheckedListBox Approval_list;
        private System.Windows.Forms.Label Systems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Queue;
    }
}