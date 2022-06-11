using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Configurations;
using System.Windows.Media;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Globalization;
using System.Windows.Controls;
using System.Threading;
using Microsoft.Win32;

namespace rrt
{
    public partial class Form3 : MaterialForm
    {
        Thread th;
        Periods currentPeriod = Periods.Week;
        public Form3()
        {
            InitializeComponent();
            InitializeData(Periods.Week);
            InitializeParameters();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.Orange600, Primary.Amber400, Accent.DeepPurple700, TextShade.WHITE);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.Blue100, Accent.DeepPurple400, TextShade.WHITE);
            //
            ChangeColumnColor(-1);
        }

        private void InitializeParameters()
        {
            InitializeStartupConfig();
        }

        private void InitializeStartupConfig()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (registryKey.GetValue("Spater") == null) swRunOnStartup.Checked = false;
            else if (registryKey.GetValue("Spater") != null) swRunOnStartup.Checked = true;
        }

        private void InitializeData(Periods period) 
        {
            timeChart.Series.Clear();
            timeChart.AxisX.Clear();
            timeChart.AxisY.Clear();
            //вынести в меню лейблы
            timeChart.AxisY.Add(new Axis
            {
                Title = "Time",
                LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromSeconds(1).Ticks)).ToString("HH:mm")
            }) ;
            /*
            timeChart.AxisY.Add(new Axis
            {
                //IsMerged = true,
                Sections = new SectionsCollection
                        {
                            new AxisSection
                            {
                                Value = 20250,
                                Stroke = System.Windows.Media.Brushes.Red,
                                StrokeThickness = 10,
                                StrokeDashArray = new System.Windows.Media.DoubleCollection(new [] {10d})

                            }
                        }
            });
            */
            switch (period)
            {
                case Periods.Week:
                    timeChart.Series = new SeriesCollection
                    {
                        new ColumnSeries
                        {
                            Values = GeneratePoints(7),
                            MaxColumnWidth = double.PositiveInfinity,
                            DataLabels = swShowDataLabels.Checked,
                            Foreground = Brushes.White
                        }
                    };
                    timeChart.AxisX.Add(new Axis
                    {
                        Labels = new[] { "Monday", "Tuesday ", "Wednesday ", "Thursday ", "Friday ", "Saturday ", "Sunday" }
                    });
                    //var PrimaryAxis = new Axis { FontWeight = FontWeights.Bold, FontSize = 11, FontFamily = new FontFamily("Calibri"), MinValue = 0, MaxValue =1 };
                    //timeChart.AxisY.Add(PrimaryAxis);
                    if (swShowAverageTime.Checked) timeChart.Series.Add(GenerateAvarageValueDots(Periods.Week, 20500));
                    currentPeriod = Periods.Week;
                    break;
                case Periods.Month:
                    timeChart.Series = new SeriesCollection
                    {
                        new ColumnSeries
                        {
                            Values = GeneratePoints(30),
                            MaxColumnWidth = double.PositiveInfinity,
                            DataLabels = swShowDataLabels.Checked,
                            Foreground = Brushes.White
                        }
                    };
                    if (swShowAverageTime.Checked) timeChart.Series.Add(GenerateAvarageValueDots(Periods.Month, 20500));
                    currentPeriod = Periods.Month;
                    break;
                case Periods.Year:
                    timeChart.Series = new SeriesCollection
                    {
                        new ColumnSeries
                        {
                            Values = GeneratePoints(12),
                            MaxColumnWidth = double.PositiveInfinity,
                            DataLabels = swShowDataLabels.Checked,
                            Foreground = Brushes.White
                        }
                    };
                    if (swShowAverageTime.Checked) timeChart.Series.Add(GenerateAvarageValueDots(Periods.Year, 20500));
                    currentPeriod = Periods.Year;
                    break;
            }
        }

        private LineSeries GenerateAvarageValueDots(Periods period, int averageValue)
        {
            LineSeries series = new LineSeries
            {
                Values = new ChartValues<int>(),
                Fill = Brushes.Transparent,
            };
            switch (period)
            {
                case Periods.Week:
                    for (int i = 0; i < 7; i++)
                        series.Values.Add(averageValue);
                    return series;
                    break;
                case Periods.Month:
                    for (int i = 0; i < 30; i++)
                        series.Values.Add(averageValue);
                    return series;
                    break;
                case Periods.Year:
                    for (int i = 0; i < 12; i++)
                        series.Values.Add(averageValue);
                    return series;
                    break;
                default:
                    return series;
            }
        }

        private ChartValues<double> GeneratePoints(int amount)
        {
            var points = new ChartValues<double>();
            Random randomSeries = new Random();
            for (int i = 0; i < amount; i++)
            {
                points.Add(randomSeries.Next(19800, 20700));
            }
            return points;
        }

        private void ChangeColumnColor(double clickedPoint)
        {
            if (clickedPoint == -1)
                switch (currentPeriod)
                {
                    case Periods.Week:
                        clickedPoint = 6;
                        break;
                    case Periods.Month:
                        clickedPoint = 29;
                        break;
                    case Periods.Year:
                        clickedPoint = 11;
                        break;
                    default :
                        clickedPoint = 6;
                        break ;
                }
            EnableAnimation(false);
            CartesianMapper<double> _dapperMapper = new CartesianMapper<double>()
            .X((value, index) => index)
            .Y((value) => value)
            .Fill((value, index) =>
                {
                    if (clickedPoint == index) return Brushes.Red;
                    else return Brushes.LightSkyBlue;
                }
            );
            timeChart.Series[0].Configuration = _dapperMapper;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cartesianChart1_DataClick(object sender, ChartPoint chartPoint)
        {
            ChangeColumnColor(chartPoint.X);
            //cartesianChart1.Series[1].Values.Add(cartesianChart1.Series[0].Values[(int)index]);
            //cartesianChart1.Series[0].Values.RemoveAt((int)index);
        }

        private void EnableAnimation(bool temp)
        {
            if (temp) timeChart.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            else timeChart.AnimationsSpeed = TimeSpan.Zero;
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            InitializeData(Periods.Week);
            ChangeColumnColor(-1);
            EnableAnimation(true);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            InitializeData(Periods.Month);
            ChangeColumnColor(-1);
            EnableAnimation(true);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            InitializeData(Periods.Year);
            ChangeColumnColor(-1);
            EnableAnimation(true);
        }

        private void OpenLoginForm()
        {
            //System.Windows.Forms.Application.Run(new Form1());
            this.Hide();
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            Console.WriteLine(Application.OpenForms.Count.ToString());
        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel14_Click(object sender, EventArgs e)
        {

        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            /*
            this.Close();
            th = new Thread(OpenLoginForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            */
            OpenLoginForm();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void renewData()
        {
            InitializeData(currentPeriod);
            ChangeColumnColor(-1);
        }

        private void swShowDataLabels_CheckedChanged(object sender, EventArgs e)
        {
            renewData();
        }

        private void swShowAverageTime_CheckedChanged(object sender, EventArgs e)
        {
            renewData();
        }

        private void swRunOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (swRunOnStartup.Checked)
            {
                if (registryKey.GetValue("Spater") == null)
                    registryKey.SetValue("Spater", Application.ExecutablePath);
            }
            else
            {
                if (registryKey.GetValue("Spater") != null)
                    registryKey.DeleteValue("Spater");
            }
        }
    }
}
