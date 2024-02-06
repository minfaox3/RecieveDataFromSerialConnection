using RecieveDataFromSerialConnection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecieveDataFromSerialCommunication
{
    public partial class EnvironmentSettingsForm : Form
    {
        private string splitc;
        private int selectedi;
        private List<string> languages;

        public EnvironmentSettingsForm(int i, string s, List<string> l)
        {
            InitializeComponent();
            selectedi = i;
            splitc = s;
            languages = l;

        }

        private void EnvironmentSettingsForm_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Clear();
            foreach(string language in languages)
            {
                comboBox1.Items.Add(language);
            }
            comboBox1.SelectedIndex = selectedi;
            splitCharacter_TextBox.Text = splitc;
            ReloadItemsText();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (splitCharacter_TextBox.Text.Length == 1)
            {
                ((MainForm)this.Owner).selected_language_index = comboBox1.SelectedIndex;
                ((MainForm)this.Owner).split_char = splitCharacter_TextBox.Text[0];
                ((MainForm)this.Owner).ChangeLanguage();
                ReloadItemsText();
            }
            else
            {
                MessageBox.Show(((MainForm)this.Owner).GetValueFromLanguageDictionary("error_slm1"), ((MainForm)this.Owner).GetValueFromLanguageDictionary("error_title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void splitCharacter_TextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Text = ((MainForm)this.Owner).GetValueFromLanguageDictionary("save_n");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveButton.Text = ((MainForm)this.Owner).GetValueFromLanguageDictionary("save_n");
        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            splitCharacter_TextBox.Text = ",";
            SaveButton.Text = ((MainForm)this.Owner).GetValueFromLanguageDictionary("save_n");
        }

        private void EnvironmentSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.Owner).esettings_visible = false;
        }

        private void ReloadItemsText()
        {
            this.Text = ((MainForm)this.Owner).GetValueFromLanguageDictionary("title_environment_settings");
            this.language_label.Text = ((MainForm)this.Owner).GetValueFromLanguageDictionary("language");
            this.splitcharacter_label.Text = ((MainForm)this.Owner).GetValueFromLanguageDictionary("split_character");
            this.DefaultButton.Text = ((MainForm)this.Owner).GetValueFromLanguageDictionary("default");
            this.SaveButton.Text = ((MainForm)this.Owner).GetValueFromLanguageDictionary("save");
        }
    }
}
