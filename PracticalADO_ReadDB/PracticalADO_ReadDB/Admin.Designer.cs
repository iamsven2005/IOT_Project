namespace PracticalADO_ReadDB
{
    partial class Admin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleDBDataSet1 = new PracticalADO_ReadDB.SampleDBDataSet1();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.adminmsg = new System.Windows.Forms.TextBox();
            this.adminsend = new System.Windows.Forms.Button();
            this.usermgt = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.usrmgtpg = new System.Windows.Forms.TabPage();
            this.todo = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.grdUser = new System.Windows.Forms.DataGridView();
            this.toDoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleDBDataSet2 = new PracticalADO_ReadDB.SampleDBDataSet2();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.GetDate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.messagesTableAdapter = new PracticalADO_ReadDB.SampleDBDataSet1TableAdapters.MessagesTableAdapter();
            this.sampleDBDataSet = new PracticalADO_ReadDB.SampleDBDataSet();
            this.sampleDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toDoListTableAdapter = new PracticalADO_ReadDB.SampleDBDataSet2TableAdapters.ToDoListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.usermgt.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.todo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.usermgt);
            this.splitContainer1.Size = new System.Drawing.Size(1129, 450);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(265, 450);
            this.splitContainer3.SplitterDistance = 377;
            this.splitContainer3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.messagesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(265, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // messagesBindingSource
            // 
            this.messagesBindingSource.DataMember = "Messages";
            this.messagesBindingSource.DataSource = this.sampleDBDataSet1;
            // 
            // sampleDBDataSet1
            // 
            this.sampleDBDataSet1.DataSetName = "SampleDBDataSet1";
            this.sampleDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.adminmsg);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.adminsend);
            this.splitContainer4.Size = new System.Drawing.Size(265, 69);
            this.splitContainer4.SplitterDistance = 175;
            this.splitContainer4.TabIndex = 0;
            // 
            // adminmsg
            // 
            this.adminmsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminmsg.Location = new System.Drawing.Point(0, 0);
            this.adminmsg.MinimumSize = new System.Drawing.Size(50, 20);
            this.adminmsg.Multiline = true;
            this.adminmsg.Name = "adminmsg";
            this.adminmsg.Size = new System.Drawing.Size(175, 69);
            this.adminmsg.TabIndex = 0;
            this.adminmsg.Text = "Admin Msg";
            // 
            // adminsend
            // 
            this.adminsend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminsend.Location = new System.Drawing.Point(0, 0);
            this.adminsend.MinimumSize = new System.Drawing.Size(30, 20);
            this.adminsend.Name = "adminsend";
            this.adminsend.Size = new System.Drawing.Size(86, 69);
            this.adminsend.TabIndex = 0;
            this.adminsend.Text = "Send";
            this.adminsend.UseVisualStyleBackColor = true;
            // 
            // usermgt
            // 
            this.usermgt.Controls.Add(this.tabPage1);
            this.usermgt.Controls.Add(this.tabPage2);
            this.usermgt.Controls.Add(this.tabPage3);
            this.usermgt.Controls.Add(this.tabPage4);
            this.usermgt.Controls.Add(this.usrmgtpg);
            this.usermgt.Controls.Add(this.todo);
            this.usermgt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usermgt.Location = new System.Drawing.Point(0, 0);
            this.usermgt.Name = "usermgt";
            this.usermgt.SelectedIndex = 0;
            this.usermgt.Size = new System.Drawing.Size(860, 450);
            this.usermgt.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(852, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Approval";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(852, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Current Queue";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(852, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(852, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dashboard";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dashboard);
            this.splitContainer2.Size = new System.Drawing.Size(846, 415);
            this.splitContainer2.SplitterDistance = 69;
            this.splitContainer2.TabIndex = 1;
            // 
            // dashboard
            // 
            this.dashboard.Controls.Add(this.chart1);
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard.Location = new System.Drawing.Point(0, 0);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(846, 342);
            this.dashboard.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(248, 234);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // usrmgtpg
            // 
            this.usrmgtpg.Location = new System.Drawing.Point(4, 25);
            this.usrmgtpg.Name = "usrmgtpg";
            this.usrmgtpg.Padding = new System.Windows.Forms.Padding(3);
            this.usrmgtpg.Size = new System.Drawing.Size(852, 421);
            this.usrmgtpg.TabIndex = 4;
            this.usrmgtpg.Text = "User Management Page";
            this.usrmgtpg.UseVisualStyleBackColor = true;
            // 
            // todo
            // 
            this.todo.Controls.Add(this.splitContainer5);
            this.todo.Location = new System.Drawing.Point(4, 25);
            this.todo.Name = "todo";
            this.todo.Padding = new System.Windows.Forms.Padding(3);
            this.todo.Size = new System.Drawing.Size(852, 421);
            this.todo.TabIndex = 5;
            this.todo.Text = "To-do-list";
            this.todo.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.grdUser);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer5.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer5_Panel2_Paint);
            this.splitContainer5.Size = new System.Drawing.Size(846, 415);
            this.splitContainer5.SplitterDistance = 286;
            this.splitContainer5.TabIndex = 1;
            // 
            // grdUser
            // 
            this.grdUser.AllowUserToOrderColumns = true;
            this.grdUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUser.Location = new System.Drawing.Point(0, 0);
            this.grdUser.Name = "grdUser";
            this.grdUser.RowTemplate.Height = 24;
            this.grdUser.Size = new System.Drawing.Size(846, 286);
            this.grdUser.TabIndex = 0;
            this.grdUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUser_CellContentClick);
            // 
            // toDoListBindingSource
            // 
            this.toDoListBindingSource.DataMember = "ToDoList";
            this.toDoListBindingSource.DataSource = this.sampleDBDataSet2;
            // 
            // sampleDBDataSet2
            // 
            this.sampleDBDataSet2.DataSetName = "SampleDBDataSet2";
            this.sampleDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer6.Panel1.Controls.Add(this.GetDate);
            this.splitContainer6.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer6.Size = new System.Drawing.Size(846, 125);
            this.splitContainer6.SplitterDistance = 287;
            this.splitContainer6.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // GetDate
            // 
            this.GetDate.Location = new System.Drawing.Point(3, 61);
            this.GetDate.Name = "GetDate";
            this.GetDate.Size = new System.Drawing.Size(75, 23);
            this.GetDate.TabIndex = 2;
            this.GetDate.Text = "Get Date";
            this.GetDate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // messagesTableAdapter
            // 
            this.messagesTableAdapter.ClearBeforeFill = true;
            // 
            // sampleDBDataSet
            // 
            this.sampleDBDataSet.DataSetName = "SampleDBDataSet";
            this.sampleDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sampleDBDataSetBindingSource
            // 
            this.sampleDBDataSetBindingSource.DataSource = this.sampleDBDataSet;
            this.sampleDBDataSetBindingSource.Position = 0;
            // 
            // toDoListTableAdapter
            // 
            this.toDoListTableAdapter.ClearBeforeFill = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDBDataSet1)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.usermgt.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.todo.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDBDataSet2)).EndInit();
            this.splitContainer6.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TextBox adminmsg;
        private System.Windows.Forms.Button adminsend;
        private System.Windows.Forms.TabControl usermgt;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel dashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private SampleDBDataSet1 sampleDBDataSet1;
        private System.Windows.Forms.BindingSource messagesBindingSource;
        private SampleDBDataSet1TableAdapters.MessagesTableAdapter messagesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage usrmgtpg;
        private System.Windows.Forms.TabPage todo;
        private System.Windows.Forms.DataGridView grdUser;
        private SampleDBDataSet sampleDBDataSet;
        private System.Windows.Forms.BindingSource sampleDBDataSetBindingSource;
        private SampleDBDataSet2 sampleDBDataSet2;
        private System.Windows.Forms.BindingSource toDoListBindingSource;
        private SampleDBDataSet2TableAdapters.ToDoListTableAdapter toDoListTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Button GetDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.SplitContainer splitContainer6;
    }
}