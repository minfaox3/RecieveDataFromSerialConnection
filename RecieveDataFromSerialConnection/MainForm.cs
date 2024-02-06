using System;
using System.Management;
using System.IO.Ports;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using RecieveDataFromSerialCommunication;

namespace RecieveDataFromSerialConnection
{
    public partial class MainForm : Form
    {
        private delegate void Delegate_write(string data);
        private Stopwatch stopwatch = new Stopwatch();
        private bool cbutton_state = true;
        private List<string> port_names = new List<string>();
        private bool draw_graph_state = true;
        private List<string> language_list = new List<string>();
        private List<Dictionary<string, string>> items_text = new List<Dictionary<string, string>>();

        public char split_char = ',';
        public int selected_language_index = 0;
        public bool about_visible = false;
        public bool esettings_visible = false;

        public MainForm()
        {
            InitializeComponent();
            string[] lang = RecieveDataFromSerialCommunication.Properties.Resources.lang.Split('\n');
            Dictionary<string, string> items = new Dictionary<string, string>();
            foreach(string line in lang)
            {
                string[] section = line.Split('[', ']');
                if (section.Length == 3)
                {
                    if (language_list.Count != 0)
                    {
                        items_text.Add(new Dictionary<string, string>(items));
                        items.Clear();
                    }
                    language_list.Add(section[1]);
                }
                else
                {
                    string[] item = line.Split('=');
                    items.Add(item[0], item[1]);
                }
            }
            if (items.Count != 0)
            {
                items_text.Add(new Dictionary<string, string>(items));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ManagementClass entity = new ManagementClass("Win32_PnPEntity");
            ManagementObjectCollection manageOC = entity.GetInstances();
            foreach (string portName in SerialPort.GetPortNames())
            {
                foreach (ManagementObject manageO in manageOC)
                {
                    object namePropertyValue = manageO.GetPropertyValue("Name");
                    if (namePropertyValue == null)
                    {
                        continue;
                    }
                    string name = namePropertyValue.ToString();
                    if (name.Contains(portName))
                    {
                        port_names.Add(portName);
                        comboBox1.Items.Add(name);
                        break;
                    }
                }
            }
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            er_label3.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChartImage();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reLoadDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            ManagementClass entity = new ManagementClass("Win32_PnPEntity");
            ManagementObjectCollection manageOC = entity.GetInstances();
            foreach (string portName in SerialPort.GetPortNames())
            {
                foreach (ManagementObject manageO in manageOC)
                {
                    object namePropertyValue = manageO.GetPropertyValue("Name");
                    if (namePropertyValue == null)
                    {
                        continue;
                    }
                    string name = namePropertyValue.ToString();
                    if (name.Contains(portName))
                    {
                        port_names.Add(portName);
                        comboBox1.Items.Add(name);
                        break;
                    }
                }
            }
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
        }

        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbutton_state)
            {
                MessageBox.Show(GetValueFromLanguageDictionary("error_ncd"), GetValueFromLanguageDictionary("error_title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                serialPort1.Write(Interaction.InputBox(GetValueFromLanguageDictionary("value"), GetValueFromLanguageDictionary("title_write"), "", 200, 100));
            }
        }

        private void environmentSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!esettings_visible)
            {
                esettings_visible = true;
                EnvironmentSettingsForm esf = new EnvironmentSettingsForm(selected_language_index, split_char.ToString(), language_list);
                esf.Owner = this;
                esf.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!about_visible)
            {
                about_visible = true;
                AboutForm af = new AboutForm();
                af.Owner = this;
                af.Show();
            }
        }

        private void drawGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw_graph_state = !draw_graph_state;
            drawGraphToolStripMenuItem.Checked = draw_graph_state;
        }

        private void cbutton_Click(object sender, EventArgs e)
        {
            if (cbutton_state)
            {
                if (comboBox1.SelectedIndex >= 0)
                {
                    serialPort1.PortName = port_names[comboBox1.SelectedIndex];
                    serialPort1.DtrEnable = useDTR.Checked;
                    try
                    {
                        serialPort1.BaudRate = (int)baudRateUDN.Value;
                        try
                        {
                            AxisChart.Series["X"].Points.Clear();
                            AxisChart.Series["Y"].Points.Clear();
                            AxisChart.Series["Z"].Points.Clear();
                            serialPort1.Open();
                            stopwatch.Restart();
                            er_label3.Visible = false;
                            cbutton_state = false;
                            cbutton.Text = GetValueFromLanguageDictionary("disconnect");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, GetValueFromLanguageDictionary("error_title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, GetValueFromLanguageDictionary("error_title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(GetValueFromLanguageDictionary("error_nds"), GetValueFromLanguageDictionary("error_title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                stopwatch.Stop();
                serialPort1.Close();
                er_label3.Visible = false;
                cbutton_state = true;
                cbutton.Text = GetValueFromLanguageDictionary("connect");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void SetEditableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = SetEditableCheckBox.Checked;
        }

        private void ClearChartButton_Click(object sender, EventArgs e)
        {
            AxisChart.Series["X"].Points.Clear();
            AxisChart.Series["Y"].Points.Clear();
            AxisChart.Series["Z"].Points.Clear();
            stopwatch.Restart();
        }

        private void CopyImageButton_Click(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                AxisChart.SaveImage(ms, ChartImageFormat.Bmp);
                Bitmap bm = new Bitmap(ms);
                Clipboard.SetImage(bm);
            }
        }
        private void SaveChartImageButton_Click(object sender, EventArgs e)
        {
            SaveChartImage();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort1.ReadLine();
                Action<string> act = write;
                IAsyncResult ar = BeginInvoke(act, new Object[] { data });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GetValueFromLanguageDictionary("error_title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void write(string data)
        {
            if (data != null)
            {
                textBox1.AppendText(data + Environment.NewLine);
                if (draw_graph_state)
                {
                    string[] AxisData = data.Split(split_char);
                    try
                    {
                        double[] axis = { Double.Parse(AxisData[0]), Double.Parse(AxisData[1]), Double.Parse(AxisData[2]) };
                        er_label3.Visible = false;
                        while (AxisChart.Series["X"].Points.Count > (int)numericUpDown1.Value)
                        {
                            AxisChart.Series["X"].Points.RemoveAt(0);
                        }
                        while (AxisChart.Series["Y"].Points.Count > (int)numericUpDown1.Value)
                        {
                            AxisChart.Series["Y"].Points.RemoveAt(0);
                        }
                        while (AxisChart.Series["Z"].Points.Count > (int)numericUpDown1.Value)
                        {
                            AxisChart.Series["Z"].Points.RemoveAt(0);
                        }
                        AxisChart.Series["X"].Points.AddXY((int)stopwatch.Elapsed.TotalMilliseconds, axis[0]);
                        AxisChart.Series["Y"].Points.AddXY((int)stopwatch.Elapsed.TotalMilliseconds, axis[1]);
                        AxisChart.Series["Z"].Points.AddXY((int)stopwatch.Elapsed.TotalMilliseconds, axis[2]);
                        AxisChart.ChartAreas[0].AxisX.Maximum = (int)stopwatch.Elapsed.TotalMilliseconds;
                        AxisChart.ChartAreas[0].AxisX.Minimum = Math.Max(0, (int)stopwatch.Elapsed.TotalMilliseconds - (int)numericUpDown1.Value);
                    }
                    catch
                    {
                        er_label3.Visible = true;
                    }
                }
            }
        }

        private void SaveChartImage()
        {
            stopwatch.Stop();
            serialPort1.Close();
            cbutton_state = true;
            cbutton.Text = GetValueFromLanguageDictionary("connect");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|BMP Image|*.bmp|GIF Image|*.gif";
            saveFileDialog.Title = GetValueFromLanguageDictionary("save_chart_image_title");
            saveFileDialog.FileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        if (saveFileDialog.FilterIndex == 4)
                        {
                            AxisChart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Gif);
                        }
                        else if (saveFileDialog.FilterIndex == 3)
                        {
                            AxisChart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Bmp);
                        }
                        else if (saveFileDialog.FilterIndex == 2)
                        {
                            AxisChart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                        }
                        else if (saveFileDialog.FilterIndex == 1)
                        {
                            AxisChart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                        }

                    }
                    else
                    {
                        MessageBox.Show(GetValueFromLanguageDictionary("error_cch"), GetValueFromLanguageDictionary("error_title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, GetValueFromLanguageDictionary("error_title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string GetValueFromLanguageDictionary(string key)
        {
            try
            {
                return items_text[selected_language_index][key].Replace("\r", "").Replace("\n", "");
            }
            catch
            {
                return "";
            }
        }

        public void ChangeLanguage()
        {
            this.Text = GetValueFromLanguageDictionary("title_mainform");
            this.FileToolStripMenuItem.Text = GetValueFromLanguageDictionary("file");
            this.saveImageToolStripMenuItem.Text = GetValueFromLanguageDictionary("save_image");
            this.environmentSettingsToolStripMenuItem.Text = GetValueFromLanguageDictionary("environment_settings");
            this.quitToolStripMenuItem.Text = GetValueFromLanguageDictionary("quit");
            this.serialCommunicationToolStripMenuItem.Text = GetValueFromLanguageDictionary("serial_communication");
            this.reLoadDevicesToolStripMenuItem.Text = GetValueFromLanguageDictionary("reload_devices");
            this.drawGraphToolStripMenuItem.Text = GetValueFromLanguageDictionary("draw_graph");
            this.helpToolStripMenuItem.Text = GetValueFromLanguageDictionary("help");
            this.aboutToolStripMenuItem.Text = GetValueFromLanguageDictionary("about");
            this.useDTR.Text = GetValueFromLanguageDictionary("enable_dtr");
            this.baud_rate_label1.Text = GetValueFromLanguageDictionary("baud_rate");
            if(cbutton_state)this.cbutton.Text = GetValueFromLanguageDictionary("connect");
            else this.cbutton.Text = GetValueFromLanguageDictionary("disconnect");
            this.ClearButton.Text = GetValueFromLanguageDictionary("clear_textbox");
            this.CopyButton.Text = GetValueFromLanguageDictionary("copy_text");
            this.SetEditableCheckBox.Text = GetValueFromLanguageDictionary("set_editable");
            this.ClearChartButton.Text = GetValueFromLanguageDictionary("clear_graph");
            this.xrange_label.Text = GetValueFromLanguageDictionary("x_range");
            this.CopyImageButton.Text = GetValueFromLanguageDictionary("copy_image");
            this.SaveChartImageButton.Text = GetValueFromLanguageDictionary("save_chart_image");
            this.er_label3.Text = GetValueFromLanguageDictionary("error_graph");
        }
        
    }
}
