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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.session = new System.Windows.Forms.TextBox();
            this.Messages = new System.Windows.Forms.TextBox();
            this.adminmsg = new System.Windows.Forms.TextBox();
            this.adminsend = new System.Windows.Forms.Button();
            this.usermgt = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.syslogLB = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label15 = new System.Windows.Forms.Label();
            this.lblUltrasonic = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.motionLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.doorLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.degcelLbl = new System.Windows.Forms.Label();
            this.moistureLbl = new System.Windows.Forms.Label();
            this.lblMoisture = new System.Windows.Forms.Label();
            this.tempLBL = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.Temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Moisture = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.usrmgtpg = new System.Windows.Forms.TabPage();
            this.todo = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.roomStatus = new System.Windows.Forms.TextBox();
            this.lightValueTB = new System.Windows.Forms.TextBox();
            this.stopLightBtn = new System.Windows.Forms.Button();
            this.sendLight = new System.Windows.Forms.Button();
            this.tbNRICMd = new System.Windows.Forms.TextBox();
            this.ContactTitle = new System.Windows.Forms.Label();
            this.tbRFIDMd = new System.Windows.Forms.TextBox();
            this.tbAddMd = new System.Windows.Forms.TextBox();
            this.ContactUsername = new System.Windows.Forms.TextBox();
            this.ContactResult = new System.Windows.Forms.TextBox();
            this.tbNameMd = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.MFA2 = new System.Windows.Forms.TextBox();
            this.lblUniqueUserID = new System.Windows.Forms.Label();
            this.editlbl = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.modifylbl = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.GetContact = new System.Windows.Forms.Button();
            this.tbCountryOfBirthMd = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.AddTitle = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.grdUser = new System.Windows.Forms.DataGridView();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbContactMd = new System.Windows.Forms.TextBox();
            this.btnGetUserID = new System.Windows.Forms.Button();
            this.tbNRIC = new System.Windows.Forms.TextBox();
            this.tbPasswordMd = new System.Windows.Forms.TextBox();
            this.scanCardBtn = new System.Windows.Forms.Button();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.stopScanBtn = new System.Windows.Forms.Button();
            this.MFA = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.usermgt.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moisture)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // session
            // 
            this.session.Location = new System.Drawing.Point(407, 122);
            this.session.Margin = new System.Windows.Forms.Padding(2);
            this.session.Name = "session";
            this.session.Size = new System.Drawing.Size(76, 38);
            this.session.TabIndex = 1;
            this.session.Visible = false;
            // 
            // Messages
            // 
            this.Messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Messages.Location = new System.Drawing.Point(0, 0);
            this.Messages.Margin = new System.Windows.Forms.Padding(2);
            this.Messages.Multiline = true;
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(186, 453);
            this.Messages.TabIndex = 0;
            // 
            // adminmsg
            // 
            this.adminmsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminmsg.Location = new System.Drawing.Point(0, 515);
            this.adminmsg.Margin = new System.Windows.Forms.Padding(2);
            this.adminmsg.MinimumSize = new System.Drawing.Size(38, 17);
            this.adminmsg.Multiline = true;
            this.adminmsg.Name = "adminmsg";
            this.adminmsg.Size = new System.Drawing.Size(186, 62);
            this.adminmsg.TabIndex = 0;
            this.adminmsg.Text = "Admin Msg";
            // 
            // adminsend
            // 
            this.adminsend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminsend.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.adminsend.Location = new System.Drawing.Point(0, 453);
            this.adminsend.Margin = new System.Windows.Forms.Padding(2);
            this.adminsend.MinimumSize = new System.Drawing.Size(22, 16);
            this.adminsend.Name = "adminsend";
            this.adminsend.Size = new System.Drawing.Size(186, 62);
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
            this.usermgt.Controls.Add(this.usrmgtpg);
            this.usermgt.Controls.Add(this.todo);
            this.usermgt.Controls.Add(this.tabPage5);
            this.usermgt.Controls.Add(this.tabPage6);
            this.usermgt.Location = new System.Drawing.Point(203, 69);
            this.usermgt.Margin = new System.Windows.Forms.Padding(2);
            this.usermgt.Name = "usermgt";
            this.usermgt.SelectedIndex = 0;
            this.usermgt.Size = new System.Drawing.Size(584, 374);
            this.usermgt.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(576, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Approval";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(789, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Current Queue";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.syslogLB);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(789, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logs";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(23, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "System Log";
            // 
            // syslogLB
            // 
            this.syslogLB.FormattingEnabled = true;
            this.syslogLB.Location = new System.Drawing.Point(19, 49);
            this.syslogLB.Margin = new System.Windows.Forms.Padding(2);
            this.syslogLB.Name = "syslogLB";
            this.syslogLB.Size = new System.Drawing.Size(755, 277);
            this.syslogLB.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(576, 348);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dashboard";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(2, 2);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer2.Panel1.Controls.Add(this.session);
            this.splitContainer2.Panel1.Controls.Add(this.label15);
            this.splitContainer2.Panel1.Controls.Add(this.lblUltrasonic);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.motionLbl);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.doorLbl);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.degcelLbl);
            this.splitContainer2.Panel1.Controls.Add(this.moistureLbl);
            this.splitContainer2.Panel1.Controls.Add(this.lblMoisture);
            this.splitContainer2.Panel1.Controls.Add(this.tempLBL);
            this.splitContainer2.Panel1.Controls.Add(this.lblTemp);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dashboard);
            this.splitContainer2.Size = new System.Drawing.Size(572, 344);
            this.splitContainer2.SplitterDistance = 168;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.GhostWhite;
            this.label15.Location = new System.Drawing.Point(439, 46);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Water amount";
            // 
            // lblUltrasonic
            // 
            this.lblUltrasonic.AutoSize = true;
            this.lblUltrasonic.BackColor = System.Drawing.Color.Black;
            this.lblUltrasonic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUltrasonic.Location = new System.Drawing.Point(436, 65);
            this.lblUltrasonic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUltrasonic.Name = "lblUltrasonic";
            this.lblUltrasonic.Size = new System.Drawing.Size(108, 31);
            this.lblUltrasonic.TabIndex = 14;
            this.lblUltrasonic.Text = "label10";
            this.lblUltrasonic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.GhostWhite;
            this.label12.Location = new System.Drawing.Point(282, 110);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Intrusion Detected?";
            // 
            // motionLbl
            // 
            this.motionLbl.AutoSize = true;
            this.motionLbl.BackColor = System.Drawing.Color.Black;
            this.motionLbl.ForeColor = System.Drawing.Color.Green;
            this.motionLbl.Location = new System.Drawing.Point(278, 122);
            this.motionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.motionLbl.Name = "motionLbl";
            this.motionLbl.Size = new System.Drawing.Size(51, 31);
            this.motionLbl.TabIndex = 12;
            this.motionLbl.Text = "No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.GhostWhite;
            this.label11.Location = new System.Drawing.Point(281, 46);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Door is:";
            // 
            // doorLbl
            // 
            this.doorLbl.AutoSize = true;
            this.doorLbl.BackColor = System.Drawing.Color.Black;
            this.doorLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.doorLbl.Location = new System.Drawing.Point(279, 58);
            this.doorLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doorLbl.Name = "doorLbl";
            this.doorLbl.Size = new System.Drawing.Size(108, 31);
            this.doorLbl.TabIndex = 10;
            this.doorLbl.Text = "label10";
            this.doorLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.GhostWhite;
            this.label10.Location = new System.Drawing.Point(131, 122);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "lb/ft3";
            // 
            // degcelLbl
            // 
            this.degcelLbl.AutoSize = true;
            this.degcelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degcelLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.degcelLbl.Location = new System.Drawing.Point(131, 58);
            this.degcelLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.degcelLbl.Name = "degcelLbl";
            this.degcelLbl.Size = new System.Drawing.Size(96, 13);
            this.degcelLbl.TabIndex = 8;
            this.degcelLbl.Text = "degrees Celsius";
            // 
            // moistureLbl
            // 
            this.moistureLbl.AutoSize = true;
            this.moistureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moistureLbl.ForeColor = System.Drawing.Color.Ivory;
            this.moistureLbl.Location = new System.Drawing.Point(28, 100);
            this.moistureLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moistureLbl.Name = "moistureLbl";
            this.moistureLbl.Size = new System.Drawing.Size(90, 13);
            this.moistureLbl.TabIndex = 7;
            this.moistureLbl.Text = "Moisture Level";
            // 
            // lblMoisture
            // 
            this.lblMoisture.AutoSize = true;
            this.lblMoisture.BackColor = System.Drawing.Color.Black;
            this.lblMoisture.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMoisture.Location = new System.Drawing.Point(26, 122);
            this.lblMoisture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoisture.Name = "lblMoisture";
            this.lblMoisture.Size = new System.Drawing.Size(108, 31);
            this.lblMoisture.TabIndex = 6;
            this.lblMoisture.Text = "label10";
            this.lblMoisture.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMoisture.TextChanged += new System.EventHandler(this.lblMoisture_TextChanged);
            // 
            // tempLBL
            // 
            this.tempLBL.AutoSize = true;
            this.tempLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLBL.ForeColor = System.Drawing.Color.Ivory;
            this.tempLBL.Location = new System.Drawing.Point(28, 46);
            this.tempLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tempLBL.Name = "tempLBL";
            this.tempLBL.Size = new System.Drawing.Size(76, 13);
            this.tempLBL.TabIndex = 5;
            this.tempLBL.Text = "Temperature";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.Black;
            this.lblTemp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTemp.Location = new System.Drawing.Point(26, 58);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(108, 31);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "label10";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10);
            this.label9.Size = new System.Drawing.Size(103, 36);
            this.label9.TabIndex = 2;
            this.label9.Text = "DashBoard";
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.Black;
            this.dashboard.Controls.Add(this.Temperature);
            this.dashboard.Controls.Add(this.Moisture);
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard.Location = new System.Drawing.Point(0, 0);
            this.dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(572, 173);
            this.dashboard.TabIndex = 0;
            // 
            // Temperature
            // 
            chartArea7.Name = "ChartArea1";
            this.Temperature.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.Temperature.Legends.Add(legend7);
            this.Temperature.Location = new System.Drawing.Point(2, 2);
            this.Temperature.Margin = new System.Windows.Forms.Padding(2);
            this.Temperature.Name = "Temperature";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.Temperature.Series.Add(series7);
            this.Temperature.Size = new System.Drawing.Size(370, 162);
            this.Temperature.TabIndex = 0;
            this.Temperature.Text = "Temperature";
            title7.Name = "Temperature";
            title7.Text = "Temperature";
            this.Temperature.Titles.Add(title7);
            // 
            // Moisture
            // 
            chartArea8.Name = "ChartArea1";
            this.Moisture.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.Moisture.Legends.Add(legend8);
            this.Moisture.Location = new System.Drawing.Point(2, 168);
            this.Moisture.Margin = new System.Windows.Forms.Padding(2);
            this.Moisture.Name = "Moisture";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.Moisture.Series.Add(series8);
            this.Moisture.Size = new System.Drawing.Size(328, 162);
            this.Moisture.TabIndex = 1;
            this.Moisture.Text = "Moisture";
            title8.Name = "Moisture";
            title8.Text = "Moisture";
            this.Moisture.Titles.Add(title8);
            // 
            // usrmgtpg
            // 
            this.usrmgtpg.Location = new System.Drawing.Point(4, 22);
            this.usrmgtpg.Margin = new System.Windows.Forms.Padding(2);
            this.usrmgtpg.Name = "usrmgtpg";
            this.usrmgtpg.Padding = new System.Windows.Forms.Padding(2);
            this.usrmgtpg.Size = new System.Drawing.Size(576, 348);
            this.usrmgtpg.TabIndex = 4;
            this.usrmgtpg.Text = "User Management Page";
            this.usrmgtpg.UseVisualStyleBackColor = true;
            // 
            // todo
            // 
            this.todo.Location = new System.Drawing.Point(4, 22);
            this.todo.Margin = new System.Windows.Forms.Padding(2);
            this.todo.Name = "todo";
            this.todo.Padding = new System.Windows.Forms.Padding(2);
            this.todo.Size = new System.Drawing.Size(576, 348);
            this.todo.TabIndex = 5;
            this.todo.Text = "To-do-list";
            this.todo.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.LightGray;
            this.tabPage6.Controls.Add(this.roomStatus);
            this.tabPage6.Controls.Add(this.lightValueTB);
            this.tabPage6.Controls.Add(this.stopLightBtn);
            this.tabPage6.Controls.Add(this.sendLight);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(576, 348);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "lightValue";
            // 
            // roomStatus
            // 
            this.roomStatus.Location = new System.Drawing.Point(54, 53);
            this.roomStatus.Margin = new System.Windows.Forms.Padding(2);
            this.roomStatus.Name = "roomStatus";
            this.roomStatus.ReadOnly = true;
            this.roomStatus.Size = new System.Drawing.Size(205, 20);
            this.roomStatus.TabIndex = 3;
            // 
            // lightValueTB
            // 
            this.lightValueTB.Location = new System.Drawing.Point(54, 20);
            this.lightValueTB.Margin = new System.Windows.Forms.Padding(2);
            this.lightValueTB.Name = "lightValueTB";
            this.lightValueTB.ReadOnly = true;
            this.lightValueTB.Size = new System.Drawing.Size(205, 20);
            this.lightValueTB.TabIndex = 0;
            // 
            // stopLightBtn
            // 
            this.stopLightBtn.Location = new System.Drawing.Point(367, 13);
            this.stopLightBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stopLightBtn.Name = "stopLightBtn";
            this.stopLightBtn.Size = new System.Drawing.Size(72, 24);
            this.stopLightBtn.TabIndex = 2;
            this.stopLightBtn.Text = "Stop Light";
            this.stopLightBtn.UseVisualStyleBackColor = true;
            // 
            // sendLight
            // 
            this.sendLight.Location = new System.Drawing.Point(282, 13);
            this.sendLight.Margin = new System.Windows.Forms.Padding(2);
            this.sendLight.Name = "sendLight";
            this.sendLight.Size = new System.Drawing.Size(72, 24);
            this.sendLight.TabIndex = 1;
            this.sendLight.Text = "Send Light";
            this.sendLight.UseVisualStyleBackColor = true;
            this.sendLight.Click += new System.EventHandler(this.sendLight_Click);
            // 
            // tbNRICMd
            // 
            this.tbNRICMd.Location = new System.Drawing.Point(485, 127);
            this.tbNRICMd.Margin = new System.Windows.Forms.Padding(2);
            this.tbNRICMd.Name = "tbNRICMd";
            this.tbNRICMd.Size = new System.Drawing.Size(117, 20);
            this.tbNRICMd.TabIndex = 12;
            // 
            // ContactTitle
            // 
            this.ContactTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactTitle.AutoSize = true;
            this.ContactTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.ContactTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ContactTitle.Location = new System.Drawing.Point(34, 160);
            this.ContactTitle.Margin = new System.Windows.Forms.Padding(10);
            this.ContactTitle.Name = "ContactTitle";
            this.ContactTitle.Padding = new System.Windows.Forms.Padding(10);
            this.ContactTitle.Size = new System.Drawing.Size(145, 36);
            this.ContactTitle.TabIndex = 0;
            this.ContactTitle.Text = "Get User Contact";
            // 
            // tbRFIDMd
            // 
            this.tbRFIDMd.Location = new System.Drawing.Point(485, 103);
            this.tbRFIDMd.Margin = new System.Windows.Forms.Padding(2);
            this.tbRFIDMd.Name = "tbRFIDMd";
            this.tbRFIDMd.Size = new System.Drawing.Size(117, 20);
            this.tbRFIDMd.TabIndex = 10;
            // 
            // tbAddMd
            // 
            this.tbAddMd.Location = new System.Drawing.Point(485, 156);
            this.tbAddMd.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddMd.Name = "tbAddMd";
            this.tbAddMd.Size = new System.Drawing.Size(117, 20);
            this.tbAddMd.TabIndex = 13;
            // 
            // ContactUsername
            // 
            this.ContactUsername.AllowDrop = true;
            this.ContactUsername.Location = new System.Drawing.Point(76, 193);
            this.ContactUsername.Name = "ContactUsername";
            this.ContactUsername.Size = new System.Drawing.Size(100, 20);
            this.ContactUsername.TabIndex = 3;
            // 
            // ContactResult
            // 
            this.ContactResult.Location = new System.Drawing.Point(76, 218);
            this.ContactResult.Name = "ContactResult";
            this.ContactResult.ReadOnly = true;
            this.ContactResult.Size = new System.Drawing.Size(100, 20);
            this.ContactResult.TabIndex = 4;
            // 
            // tbNameMd
            // 
            this.tbNameMd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbNameMd.Location = new System.Drawing.Point(485, 79);
            this.tbNameMd.Margin = new System.Windows.Forms.Padding(2);
            this.tbNameMd.Name = "tbNameMd";
            this.tbNameMd.Size = new System.Drawing.Size(80, 20);
            this.tbNameMd.TabIndex = 9;
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username.AutoSize = true;
            this.Username.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Username.Location = new System.Drawing.Point(15, 196);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 65);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username\r\n\r\nContact\r\n\r\nMFA";
            // 
            // tbUserID
            // 
            this.tbUserID.BackColor = System.Drawing.SystemColors.Window;
            this.tbUserID.Location = new System.Drawing.Point(485, 55);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(83, 20);
            this.tbUserID.TabIndex = 7;
            // 
            // MFA2
            // 
            this.MFA2.Location = new System.Drawing.Point(76, 244);
            this.MFA2.Name = "MFA2";
            this.MFA2.ReadOnly = true;
            this.MFA2.Size = new System.Drawing.Size(100, 20);
            this.MFA2.TabIndex = 7;
            // 
            // lblUniqueUserID
            // 
            this.lblUniqueUserID.AutoSize = true;
            this.lblUniqueUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUniqueUserID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUniqueUserID.Location = new System.Drawing.Point(404, 65);
            this.lblUniqueUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUniqueUserID.Name = "lblUniqueUserID";
            this.lblUniqueUserID.Size = new System.Drawing.Size(77, 247);
            this.lblUniqueUserID.TabIndex = 1;
            this.lblUniqueUserID.Text = "UniqueUserID:\r\n\r\nName:\r\n\r\nRFID:\r\n\r\nNRIC:\r\n\r\nAddress:\r\n\r\nContact:\r\n\r\nPassword:\r\n\r\n" +
    "Country:\r\n\r\nMFA:\r\n\r\nDOB:";
            // 
            // editlbl
            // 
            this.editlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editlbl.AutoSize = true;
            this.editlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.editlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editlbl.Location = new System.Drawing.Point(34, 23);
            this.editlbl.Margin = new System.Windows.Forms.Padding(10);
            this.editlbl.Name = "editlbl";
            this.editlbl.Padding = new System.Windows.Forms.Padding(10);
            this.editlbl.Size = new System.Drawing.Size(172, 36);
            this.editlbl.TabIndex = 1;
            this.editlbl.Text = "Edit User Information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblName.Location = new System.Drawing.Point(200, 192);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 143);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name:\r\n\r\nPassword:\r\n\r\nRFID:\r\n\r\nNRIC:\r\n\r\nAddress:\r\n\r\nContact:";
            // 
            // modifylbl
            // 
            this.modifylbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modifylbl.AutoSize = true;
            this.modifylbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.modifylbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modifylbl.Location = new System.Drawing.Point(393, 23);
            this.modifylbl.Margin = new System.Windows.Forms.Padding(10);
            this.modifylbl.Name = "modifylbl";
            this.modifylbl.Padding = new System.Windows.Forms.Padding(10);
            this.modifylbl.Size = new System.Drawing.Size(191, 36);
            this.modifylbl.TabIndex = 2;
            this.modifylbl.Text = "Modify User Information";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(248, 58);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 26);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GetContact
            // 
            this.GetContact.Location = new System.Drawing.Point(29, 270);
            this.GetContact.Name = "GetContact";
            this.GetContact.Size = new System.Drawing.Size(79, 30);
            this.GetContact.TabIndex = 5;
            this.GetContact.Text = "Get Contact";
            this.GetContact.UseVisualStyleBackColor = true;
            this.GetContact.Click += new System.EventHandler(this.GetContact_Click);
            // 
            // tbCountryOfBirthMd
            // 
            this.tbCountryOfBirthMd.Location = new System.Drawing.Point(485, 255);
            this.tbCountryOfBirthMd.Margin = new System.Windows.Forms.Padding(2);
            this.tbCountryOfBirthMd.Name = "tbCountryOfBirthMd";
            this.tbCountryOfBirthMd.Size = new System.Drawing.Size(52, 20);
            this.tbCountryOfBirthMd.TabIndex = 18;
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(614, 48);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(58, 23);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // AddTitle
            // 
            this.AddTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTitle.AutoSize = true;
            this.AddTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.AddTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddTitle.Location = new System.Drawing.Point(245, 146);
            this.AddTitle.Margin = new System.Windows.Forms.Padding(10);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Padding = new System.Windows.Forms.Padding(10);
            this.AddTitle.Size = new System.Drawing.Size(93, 36);
            this.AddTitle.TabIndex = 1;
            this.AddTitle.Text = "Add User";
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(273, 226);
            this.tbPwd.Margin = new System.Windows.Forms.Padding(2);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(132, 20);
            this.tbPwd.TabIndex = 14;
            // 
            // grdUser
            // 
            this.grdUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUser.Location = new System.Drawing.Point(18, 58);
            this.grdUser.Margin = new System.Windows.Forms.Padding(2);
            this.grdUser.Name = "grdUser";
            this.grdUser.RowTemplate.Height = 24;
            this.grdUser.Size = new System.Drawing.Size(197, 78);
            this.grdUser.TabIndex = 1;
            this.grdUser.Click += new System.EventHandler(this.grdUser_Click);
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(273, 250);
            this.tbRFID.Margin = new System.Windows.Forms.Padding(2);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.ReadOnly = true;
            this.tbRFID.Size = new System.Drawing.Size(75, 20);
            this.tbRFID.TabIndex = 16;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(273, 200);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(132, 20);
            this.tbName.TabIndex = 15;
            // 
            // tbContactMd
            // 
            this.tbContactMd.Location = new System.Drawing.Point(485, 189);
            this.tbContactMd.Margin = new System.Windows.Forms.Padding(2);
            this.tbContactMd.Name = "tbContactMd";
            this.tbContactMd.Size = new System.Drawing.Size(43, 20);
            this.tbContactMd.TabIndex = 12;
            // 
            // btnGetUserID
            // 
            this.btnGetUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetUserID.Location = new System.Drawing.Point(614, 78);
            this.btnGetUserID.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetUserID.Name = "btnGetUserID";
            this.btnGetUserID.Size = new System.Drawing.Size(63, 19);
            this.btnGetUserID.TabIndex = 20;
            this.btnGetUserID.Text = "Get User";
            this.btnGetUserID.UseVisualStyleBackColor = true;
            this.btnGetUserID.Click += new System.EventHandler(this.btnGetUserID_Click);
            // 
            // tbNRIC
            // 
            this.tbNRIC.Location = new System.Drawing.Point(273, 274);
            this.tbNRIC.Margin = new System.Windows.Forms.Padding(2);
            this.tbNRIC.Name = "tbNRIC";
            this.tbNRIC.Size = new System.Drawing.Size(92, 20);
            this.tbNRIC.TabIndex = 17;
            // 
            // tbPasswordMd
            // 
            this.tbPasswordMd.Location = new System.Drawing.Point(485, 223);
            this.tbPasswordMd.Margin = new System.Windows.Forms.Padding(2);
            this.tbPasswordMd.Name = "tbPasswordMd";
            this.tbPasswordMd.Size = new System.Drawing.Size(59, 20);
            this.tbPasswordMd.TabIndex = 15;
            // 
            // scanCardBtn
            // 
            this.scanCardBtn.Location = new System.Drawing.Point(352, 255);
            this.scanCardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.scanCardBtn.Name = "scanCardBtn";
            this.scanCardBtn.Size = new System.Drawing.Size(38, 19);
            this.scanCardBtn.TabIndex = 20;
            this.scanCardBtn.Text = "Scan Card";
            this.scanCardBtn.UseVisualStyleBackColor = true;
            this.scanCardBtn.Click += new System.EventHandler(this.scanCardBtn_Click);
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(273, 298);
            this.tbAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(94, 20);
            this.tbAdd.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(248, 36);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // stopScanBtn
            // 
            this.stopScanBtn.Location = new System.Drawing.Point(394, 256);
            this.stopScanBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stopScanBtn.Name = "stopScanBtn";
            this.stopScanBtn.Size = new System.Drawing.Size(35, 19);
            this.stopScanBtn.TabIndex = 21;
            this.stopScanBtn.Text = "Stop Scan";
            this.stopScanBtn.UseVisualStyleBackColor = true;
            this.stopScanBtn.Click += new System.EventHandler(this.stopScanBtn_Click);
            // 
            // MFA
            // 
            this.MFA.Location = new System.Drawing.Point(485, 279);
            this.MFA.Margin = new System.Windows.Forms.Padding(2);
            this.MFA.Name = "MFA";
            this.MFA.Size = new System.Drawing.Size(44, 20);
            this.MFA.TabIndex = 22;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(281, 320);
            this.tbContact.Margin = new System.Windows.Forms.Padding(2);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(84, 20);
            this.tbContact.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(378, 308);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 28);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage5.Controls.Add(this.btnSave);
            this.tabPage5.Controls.Add(this.tbContact);
            this.tabPage5.Controls.Add(this.MFA);
            this.tabPage5.Controls.Add(this.stopScanBtn);
            this.tabPage5.Controls.Add(this.btnUpdate);
            this.tabPage5.Controls.Add(this.tbAdd);
            this.tabPage5.Controls.Add(this.scanCardBtn);
            this.tabPage5.Controls.Add(this.tbPasswordMd);
            this.tabPage5.Controls.Add(this.tbNRIC);
            this.tabPage5.Controls.Add(this.btnGetUserID);
            this.tabPage5.Controls.Add(this.tbContactMd);
            this.tabPage5.Controls.Add(this.tbName);
            this.tabPage5.Controls.Add(this.tbRFID);
            this.tabPage5.Controls.Add(this.grdUser);
            this.tabPage5.Controls.Add(this.tbPwd);
            this.tabPage5.Controls.Add(this.AddTitle);
            this.tabPage5.Controls.Add(this.btnModify);
            this.tabPage5.Controls.Add(this.tbCountryOfBirthMd);
            this.tabPage5.Controls.Add(this.GetContact);
            this.tabPage5.Controls.Add(this.btnDelete);
            this.tabPage5.Controls.Add(this.modifylbl);
            this.tabPage5.Controls.Add(this.lblName);
            this.tabPage5.Controls.Add(this.editlbl);
            this.tabPage5.Controls.Add(this.lblUniqueUserID);
            this.tabPage5.Controls.Add(this.MFA2);
            this.tabPage5.Controls.Add(this.tbUserID);
            this.tabPage5.Controls.Add(this.Username);
            this.tabPage5.Controls.Add(this.tbNameMd);
            this.tabPage5.Controls.Add(this.ContactResult);
            this.tabPage5.Controls.Add(this.ContactUsername);
            this.tabPage5.Controls.Add(this.tbAddMd);
            this.tabPage5.Controls.Add(this.tbRFIDMd);
            this.tabPage5.Controls.Add(this.ContactTitle);
            this.tabPage5.Controls.Add(this.tbNRICMd);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(576, 348);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Check Info";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.Messages);
            this.panel1.Controls.Add(this.adminsend);
            this.panel1.Controls.Add(this.adminmsg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(434, 24);
            this.Title.MaximumSize = new System.Drawing.Size(2000, 200);
            this.Title.MinimumSize = new System.Drawing.Size(200, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(271, 20);
            this.Title.TabIndex = 1;
            this.Title.Text = "Server Environment Monitoring System";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.UseWaitCursor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usermgt);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.usermgt.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moisture)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}