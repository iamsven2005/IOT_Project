using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;
using System.Data.SqlClient;
namespace PracticalADO_ReadDB
{
    public partial class Charts : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        private void loadData()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "Select * from MonthlyStatistics Where EventType='HighTemp'";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(strCommandText, myConnect);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Console.WriteLine("DataSet Rows = " + ds.Tables[0].Rows.Count);
                chart1.DataSource = ds;
                chart1.Series[0].XValueMember = "DateTimeLastUpdate";
                chart1.Series[0].YValueMembers = "TotalMonthlyCount";
                chart1.DataBind();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString());
            }
            finally
            {
                myConnect.Close();
            }
        }
        public Charts()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private Color getColor(int r, int g, int b, int transparent = 255)
        {
            return System.Drawing.Color.FromArgb(transparent, r, g, b);
        }
        private DateTime getDateTime(int year, int month, int day, int hour, int min, int sec, int miliesecs = 0)
        {
            DateTime dt = new DateTime(year, month, day, hour, min, sec, miliesecs);
            Console.WriteLine(dt.ToString("MM/dd/yyyy hh:mm:ss.fff"));
            return dt;
        }
        private void setXAxisDisplayRange(Chart cht, DateTime dtStart, DateTime dtEnd)
        {
            DateTime minDate = dtStart.AddSeconds(-1);
            DateTime maxDate = dtEnd;
            Console.WriteLine("Setting AxisX.Minimum =" + minDate.ToOADate());
            Console.WriteLine("Setting AxisX.Minimum =" + maxDate.ToOADate());
            cht.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            cht.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
            cht.Series[0].IsXValueIndexed = false;

        }
        private void initChartProperties()
        {
            chart1.BackColor = getColor(243, 223, 193);
            chart1.BackGradientStyle = GradientStyle.TopBottom;
            chart1.BorderlineColor = getColor(181, 64, 1);
            chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            Title title1 = new Title();
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.Text = "Time Base Chart";
            chart1.Titles.Add(title1);
            Font labelFont = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            Legend legend1 = chart1.Legends[0];
            legend1.BackColor = Color.Transparent;
            legend1.Enabled = true;
            legend1.Font = labelFont;
            // Chart Area is the
            Color colorGridLines = getColor(64, 64, 64, 64);
            ChartArea chartArea1 = chart1.ChartAreas[0];
            chartArea1.BackColor = Color.OldLace;
            chartArea1.BackGradientStyle = GradientStyle.TopBottom;
            chartArea1.BorderColor = colorGridLines;
            chartArea1.BorderDashStyle = ChartDashStyle.Solid;
            chartArea1.ShadowColor = Color.Transparent;
            chartArea1.AxisX.LabelStyle.Font = labelFont;
            chartArea1.AxisX.LineColor = colorGridLines;
            chartArea1.AxisX.MajorGrid.LineColor = colorGridLines;
            chartArea1.AxisX.IntervalType = DateTimeIntervalType.Minutes;
            chartArea1.AxisX.Interval = 1;
            DateTime minDate = getDateTime(2016, 10, 12, 15, 0, 0);
            DateTime maxDate = getDateTime(2016, 10, 12, 15, 10, 0);
            setXAxisDisplayRange(chart1, minDate, maxDate);
            chartArea1.AxisX.LabelStyle.Format = "MMM dd HH:mm";
            chartArea1.AxisY.LabelStyle.Font = labelFont;
            chartArea1.AxisY.LineColor = colorGridLines;
            chartArea1.AxisY.MajorGrid.LineColor = colorGridLines;
            chartArea1.AxisY.Interval = 10;
            chartArea1.AxisY.IsStartedFromZero = true;
            Series series1 = chart1.Series[0];
            series1.Name = "Temp";
            Color lineColor = getColor(26, 59, 105, 180);
            series1.BorderColor = lineColor;
            series1.ChartType = SeriesChartType.Spline;
            series1.XValueType = ChartValueType.DateTime;
            series1.YValueType = ChartValueType.Double;
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.MarkerSize = 6;
            series1.MarkerBorderColor = lineColor;
            series1.MarkerColor = lineColor;
            series1.ToolTip = "Timestamp : #VALX{d MM yyyy H:mm:ss} , Value : #VAL";


        }

        private void Charts_Load(object sender, EventArgs e)
        {
            initChartProperties();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
