
namespace RecieveDataFromSerialConnection
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.useDTR = new System.Windows.Forms.CheckBox();
            this.baud_rate_label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SetEditableCheckBox = new System.Windows.Forms.CheckBox();
            this.AxisChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ClearChartButton = new System.Windows.Forms.Button();
            this.xrange_label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CopyImageButton = new System.Windows.Forms.Button();
            this.SaveChartImageButton = new System.Windows.Forms.Button();
            this.er_label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.environmentSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialCommunicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reLoadDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbutton = new System.Windows.Forms.Button();
            this.baudRateUDN = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AxisChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudRateUDN)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(9, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 174);
            this.textBox1.TabIndex = 4;
            // 
            // useDTR
            // 
            this.useDTR.AutoSize = true;
            this.useDTR.Location = new System.Drawing.Point(159, 26);
            this.useDTR.Margin = new System.Windows.Forms.Padding(2);
            this.useDTR.Name = "useDTR";
            this.useDTR.Size = new System.Drawing.Size(81, 16);
            this.useDTR.TabIndex = 5;
            this.useDTR.Text = "EnableDTR";
            this.useDTR.UseVisualStyleBackColor = true;
            // 
            // baud_rate_label1
            // 
            this.baud_rate_label1.AutoSize = true;
            this.baud_rate_label1.Location = new System.Drawing.Point(9, 51);
            this.baud_rate_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baud_rate_label1.Name = "baud_rate_label1";
            this.baud_rate_label1.Size = new System.Drawing.Size(55, 12);
            this.baud_rate_label1.TabIndex = 8;
            this.baud_rate_label1.Text = "BaudRate";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(9, 254);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(56, 19);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(78, 254);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(2);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(70, 18);
            this.CopyButton.TabIndex = 10;
            this.CopyButton.Text = "CopyText";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // SetEditableCheckBox
            // 
            this.SetEditableCheckBox.AutoSize = true;
            this.SetEditableCheckBox.Location = new System.Drawing.Point(159, 257);
            this.SetEditableCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.SetEditableCheckBox.Name = "SetEditableCheckBox";
            this.SetEditableCheckBox.Size = new System.Drawing.Size(82, 16);
            this.SetEditableCheckBox.TabIndex = 11;
            this.SetEditableCheckBox.Text = "SetEditable";
            this.SetEditableCheckBox.UseVisualStyleBackColor = true;
            this.SetEditableCheckBox.CheckedChanged += new System.EventHandler(this.SetEditableCheckBox_CheckedChanged);
            // 
            // AxisChart
            // 
            chartArea1.Name = "ChartArea1";
            this.AxisChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.AxisChart.Legends.Add(legend1);
            this.AxisChart.Location = new System.Drawing.Point(248, 25);
            this.AxisChart.Margin = new System.Windows.Forms.Padding(2);
            this.AxisChart.Name = "AxisChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "X";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Y";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Z";
            this.AxisChart.Series.Add(series1);
            this.AxisChart.Series.Add(series2);
            this.AxisChart.Series.Add(series3);
            this.AxisChart.Size = new System.Drawing.Size(480, 225);
            this.AxisChart.TabIndex = 12;
            this.AxisChart.Text = "chart1";
            // 
            // ClearChartButton
            // 
            this.ClearChartButton.Location = new System.Drawing.Point(248, 254);
            this.ClearChartButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearChartButton.Name = "ClearChartButton";
            this.ClearChartButton.Size = new System.Drawing.Size(86, 18);
            this.ClearChartButton.TabIndex = 13;
            this.ClearChartButton.Text = "Clear";
            this.ClearChartButton.UseVisualStyleBackColor = true;
            this.ClearChartButton.Click += new System.EventHandler(this.ClearChartButton_Click);
            // 
            // xrange_label
            // 
            this.xrange_label.AutoSize = true;
            this.xrange_label.Location = new System.Drawing.Point(338, 258);
            this.xrange_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xrange_label.Name = "xrange_label";
            this.xrange_label.Size = new System.Drawing.Size(50, 12);
            this.xrange_label.TabIndex = 14;
            this.xrange_label.Text = "X-Range";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(389, 256);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 19);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // CopyImageButton
            // 
            this.CopyImageButton.Location = new System.Drawing.Point(484, 254);
            this.CopyImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.CopyImageButton.Name = "CopyImageButton";
            this.CopyImageButton.Size = new System.Drawing.Size(122, 18);
            this.CopyImageButton.TabIndex = 16;
            this.CopyImageButton.Text = "CopyImage";
            this.CopyImageButton.UseVisualStyleBackColor = true;
            this.CopyImageButton.Click += new System.EventHandler(this.CopyImageButton_Click);
            // 
            // SaveChartImageButton
            // 
            this.SaveChartImageButton.Location = new System.Drawing.Point(610, 254);
            this.SaveChartImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveChartImageButton.Name = "SaveChartImageButton";
            this.SaveChartImageButton.Size = new System.Drawing.Size(117, 18);
            this.SaveChartImageButton.TabIndex = 17;
            this.SaveChartImageButton.Text = "SaveChartImage";
            this.SaveChartImageButton.UseVisualStyleBackColor = true;
            this.SaveChartImageButton.Click += new System.EventHandler(this.SaveChartImageButton_Click);
            // 
            // er_label3
            // 
            this.er_label3.AutoSize = true;
            this.er_label3.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.er_label3.Location = new System.Drawing.Point(244, 22);
            this.er_label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.er_label3.Name = "er_label3";
            this.er_label3.Size = new System.Drawing.Size(414, 18);
            this.er_label3.TabIndex = 18;
            this.er_label3.Text = "The received string contains non-numeric characters. ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.serialCommunicationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem,
            this.environmentSettingsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // environmentSettingsToolStripMenuItem
            // 
            this.environmentSettingsToolStripMenuItem.Name = "environmentSettingsToolStripMenuItem";
            this.environmentSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.environmentSettingsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.environmentSettingsToolStripMenuItem.Text = "Environment Settings";
            this.environmentSettingsToolStripMenuItem.Click += new System.EventHandler(this.environmentSettingsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // serialCommunicationToolStripMenuItem
            // 
            this.serialCommunicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reLoadDevicesToolStripMenuItem,
            this.drawGraphToolStripMenuItem});
            this.serialCommunicationToolStripMenuItem.Name = "serialCommunicationToolStripMenuItem";
            this.serialCommunicationToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.serialCommunicationToolStripMenuItem.Text = "SerialCommunication";
            // 
            // reLoadDevicesToolStripMenuItem
            // 
            this.reLoadDevicesToolStripMenuItem.Name = "reLoadDevicesToolStripMenuItem";
            this.reLoadDevicesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reLoadDevicesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.reLoadDevicesToolStripMenuItem.Text = "ReLoad Devices";
            this.reLoadDevicesToolStripMenuItem.Click += new System.EventHandler(this.reLoadDevicesToolStripMenuItem_Click);
            // 
            // drawGraphToolStripMenuItem
            // 
            this.drawGraphToolStripMenuItem.Checked = true;
            this.drawGraphToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.drawGraphToolStripMenuItem.Name = "drawGraphToolStripMenuItem";
            this.drawGraphToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.drawGraphToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.drawGraphToolStripMenuItem.Text = "Draw Graph";
            this.drawGraphToolStripMenuItem.Click += new System.EventHandler(this.drawGraphToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cbutton
            // 
            this.cbutton.Location = new System.Drawing.Point(159, 48);
            this.cbutton.Margin = new System.Windows.Forms.Padding(2);
            this.cbutton.Name = "cbutton";
            this.cbutton.Size = new System.Drawing.Size(74, 18);
            this.cbutton.TabIndex = 20;
            this.cbutton.Text = "Connect";
            this.cbutton.UseVisualStyleBackColor = true;
            this.cbutton.Click += new System.EventHandler(this.cbutton_Click);
            // 
            // baudRateUDN
            // 
            this.baudRateUDN.Location = new System.Drawing.Point(64, 50);
            this.baudRateUDN.Margin = new System.Windows.Forms.Padding(2);
            this.baudRateUDN.Maximum = new decimal(new int[] {
            115200,
            0,
            0,
            0});
            this.baudRateUDN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.baudRateUDN.Name = "baudRateUDN";
            this.baudRateUDN.Size = new System.Drawing.Size(90, 19);
            this.baudRateUDN.TabIndex = 21;
            this.baudRateUDN.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 289);
            this.Controls.Add(this.baudRateUDN);
            this.Controls.Add(this.cbutton);
            this.Controls.Add(this.er_label3);
            this.Controls.Add(this.SaveChartImageButton);
            this.Controls.Add(this.CopyImageButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.xrange_label);
            this.Controls.Add(this.ClearChartButton);
            this.Controls.Add(this.AxisChart);
            this.Controls.Add(this.SetEditableCheckBox);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.baud_rate_label1);
            this.Controls.Add(this.useDTR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(754, 328);
            this.MinimumSize = new System.Drawing.Size(754, 328);
            this.Name = "MainForm";
            this.Text = "RecieveDataFromSerialComunication";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AxisChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudRateUDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox useDTR;
        private System.Windows.Forms.Label baud_rate_label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.CheckBox SetEditableCheckBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart AxisChart;
        private System.Windows.Forms.Button ClearChartButton;
        private System.Windows.Forms.Label xrange_label;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button CopyImageButton;
        private System.Windows.Forms.Button SaveChartImageButton;
        private System.Windows.Forms.Label er_label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialCommunicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button cbutton;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem environmentSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reLoadDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown baudRateUDN;
        private System.Windows.Forms.ToolStripMenuItem drawGraphToolStripMenuItem;
    }
}

