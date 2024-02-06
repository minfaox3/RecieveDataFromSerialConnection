
namespace RecieveDataFromSerialCommunication
{
    partial class EnvironmentSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnvironmentSettingsForm));
            this.language_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.splitcharacter_label = new System.Windows.Forms.Label();
            this.splitCharacter_TextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // language_label
            // 
            this.language_label.AutoSize = true;
            this.language_label.Location = new System.Drawing.Point(9, 7);
            this.language_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.language_label.Name = "language_label";
            this.language_label.Size = new System.Drawing.Size(53, 12);
            this.language_label.TabIndex = 0;
            this.language_label.Text = "Language";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English",
            "日本語"});
            this.comboBox1.Location = new System.Drawing.Point(64, 5);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "English";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // splitcharacter_label
            // 
            this.splitcharacter_label.AutoSize = true;
            this.splitcharacter_label.Location = new System.Drawing.Point(9, 35);
            this.splitcharacter_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.splitcharacter_label.Name = "splitcharacter_label";
            this.splitcharacter_label.Size = new System.Drawing.Size(78, 12);
            this.splitcharacter_label.TabIndex = 2;
            this.splitcharacter_label.Text = "SplitCharacter";
            // 
            // splitCharacter_TextBox
            // 
            this.splitCharacter_TextBox.Location = new System.Drawing.Point(86, 33);
            this.splitCharacter_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitCharacter_TextBox.MaxLength = 1;
            this.splitCharacter_TextBox.Name = "splitCharacter_TextBox";
            this.splitCharacter_TextBox.Size = new System.Drawing.Size(69, 19);
            this.splitCharacter_TextBox.TabIndex = 3;
            this.splitCharacter_TextBox.TextChanged += new System.EventHandler(this.splitCharacter_TextBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(159, 33);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(82, 18);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DefaultButton
            // 
            this.DefaultButton.Location = new System.Drawing.Point(159, 5);
            this.DefaultButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(82, 18);
            this.DefaultButton.TabIndex = 5;
            this.DefaultButton.Text = "Default";
            this.DefaultButton.UseVisualStyleBackColor = true;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // EnvironmentSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 66);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.splitCharacter_TextBox);
            this.Controls.Add(this.splitcharacter_label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.language_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(253, 77);
            this.Name = "EnvironmentSettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "Environment Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnvironmentSettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.EnvironmentSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label language_label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label splitcharacter_label;
        private System.Windows.Forms.TextBox splitCharacter_TextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DefaultButton;
    }
}