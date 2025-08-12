using System.Diagnostics;
using tester_tools.Generators;
using static tester_tools.Helpers.Helpers;

namespace tester_tools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }

        private void SetUpForm()
        {
            // prevents focus to textboxes on launch
            this.ActiveControl = TINLabel;

            // adding tooltips for copy buttons
            copyTooltip.SetToolTip(this.TINCopy, "����������� � ����� ������");
            copyTooltip.SetToolTip(this.KPPCopy, "����������� � ����� ������");
            copyTooltip.SetToolTip(this.OGRNCopy, "����������� � ����� ������");
            copyTooltip.SetToolTip(this.SNILSCopy, "����������� � ����� ������");
            copyTooltip.SetToolTip(this.symbolsGenerateCopy, "����������� � ����� ������");
            optionFileGenerateSizeNumeric.Maximum = 10000;
        }

        private void TINCopy_Click(object sender, EventArgs e)
        {
            if (TINTextbox.Text != string.Empty)
            {
                Clipboard.SetText(TINTextbox.Text);
            }
            else
            {
                copyTooltip.Show("������� ���������� ��������", TINTextbox, 3000);
            }
        }

        private void OGRNCopy_Click(object sender, EventArgs e)
        {
            if (OGRNTextbox.Text != string.Empty)
            {
                Clipboard.SetText(OGRNTextbox.Text);
            }
            else
            {
                copyTooltip.Show("������� ���������� ��������", OGRNTextbox, 3000);
            }
        }

        private void SNILSCopy_Click(object sender, EventArgs e)
        {
            if (SNILSTextbox.Text != string.Empty)
            {
                Clipboard.SetText(SNILSTextbox.Text);
            }
            else
            {
                copyTooltip.Show("������� ���������� ��������", SNILSTextbox, 3000);
            }
        }

        private void KPPCopy_Click(object sender, EventArgs e)
        {
            if (KPPTextbox.Text != string.Empty)
            {
                Clipboard.SetText(OGRNTextbox.Text);
            }
            else
            {
                copyTooltip.Show("������� ���������� ��������", KPPTextbox, 3000);
            }
        }

        private void symbolsGenerateCopy_Click(object sender, EventArgs e)
        {
            if (symbolsGenerateTextbox.Text != string.Empty)
            {
                Clipboard.SetText(symbolsGenerateTextbox.Text);
            }
            else
            {
                copyTooltip.Show("������� ���������� ��������", symbolsGenerateTextbox, 3000);
            }
        }

        private void FileGenerateBrowseFolder_Click(object sender, EventArgs e)
        {
            DialogResult selectFolder = folderBrowseDialog.ShowDialog();
            if (selectFolder == DialogResult.OK)
            {
                fileGeneratePath.Text = folderBrowseDialog.SelectedPath;
                fileGenerateButton.Enabled = true;
            }
        }

        private void TINButton_Click(object sender, EventArgs e)
        {
            // ���������� ����� ��� �� ������ ���������� RadioButton
            var isTenSymbols = TINTenSymbols.Checked;
            var tinLength = isTenSymbols ? TINTenSymbols.Text : TINTwelveSymbols.Text;

            // ���������� ���
            var generatedTIN = TINGenerator.GenerateTIN(tinLength);
            TINTextbox.Text = generatedTIN;

            // ��������� ���, ���� �����
            if (checkTINTrue.Checked)
            {
                bool isValid = TINGenerator.CheckTIN(generatedTIN);
                CheckTINMessage(isValid);
            }
        }

        private void OGRNButton_Click(object sender, EventArgs e)
        {
            OGRNTextbox.Text = OGRNGenerator.Generate();
        }

        private void KPPButton_Click(object sender, EventArgs e)
        {
            KPPTextbox.Text = KPPGenerator.Generate();
        }

        private void SNILSButton_Click(object sender, EventArgs e)
        {
            SNILSTextbox.Text = SNILSGenerator.Generate();
        }

        private void checkTINButton_Click(object sender, EventArgs e)
        {
            var checkResult = TINGenerator.CheckTIN(checkTINTextbox.Text);
            CheckTINMessage(checkResult);
        }

        private void symbolsGenerateButton_Click(object sender, EventArgs e)
        {
            var generatedtext = TextGenerator.Generate(symbolsCountNumeric.Value);
            if (symbolsCountNumeric.Value <= 1000)
            {
                symbolsGenerateTextbox.Text = generatedtext;
            }
            else
            {
                var rootPath = AppDomain.CurrentDomain.BaseDirectory;
                var filePath = Path.Combine(rootPath, "generated_text.txt");
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                File.WriteAllText(filePath, generatedtext);
                MessageBox.Show("�������� ����� �������� ��� ����������� � ���������. ����� ������� � ����. ����: " + filePath, "�������!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var message = "�� ������� ��� ������ ����� �� ����������?";
            var caption = "�������� ����������";

            var closingMessage = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (closingMessage == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void fileGenerateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(optionFileGenerateFormatTextbox.Text))
            {
                copyTooltip.Show("������� ������� ������ �����", optionFileGenerateFormatTextbox, 3000);
                return;
            }

            var rootPath = fileGeneratePath.Text;
            var filePath = Path.Combine(
                rootPath,
                $"generated_file.{optionFileGenerateFormatTextbox.Text}");

            if (File.Exists(filePath)) File.Delete(filePath);

            // ����������� ��������� ������� ���������
            string unit = optionFileGenerateKB.Checked ? optionFileGenerateKB.Text :
                         optionFileGenerateMB.Checked ? optionFileGenerateMB.Text :
                         optionFileGenerateGB.Checked ? optionFileGenerateGB.Text : "�";

            // ��������� �����
            FileGenerator.Generate(filePath, (long)optionFileGenerateSizeNumeric.Value, unit);
            MessageBox.Show($"���� ������� ������������! ����: {filePath}", "�������!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (optionFileGenerateShowYes.Checked)
            {
                Process.Start("explorer.exe", $"/select, \"{filePath}\"");
            }
        }

        private void optionFileGenerateKB_Click(object sender, EventArgs e)
        {
            optionFileGenerateSizeNumeric.ResetText();
            optionFileGenerateSizeNumeric.Maximum = 10000;
            optionFileGenerateSizeNumeric.Value = 10000;
        }

        private void optionFileGenerateMB_Click(object sender, EventArgs e)
        {
            optionFileGenerateSizeNumeric.ResetText();
            optionFileGenerateSizeNumeric.Maximum = 1000;
            optionFileGenerateSizeNumeric.Value = 1000;
        }

        private void optionFileGenerateGB_Click(object sender, EventArgs e)
        {
            optionFileGenerateSizeNumeric.ResetText();
            optionFileGenerateSizeNumeric.Maximum = 10;
            optionFileGenerateSizeNumeric.Value = 10;
        }

        private void optionFileGenerateFormatTextbox_Click(object sender, EventArgs e)
        {
            optionFileGenerateFormatTextbox.Focus();
            optionFileGenerateFormatTextbox.Select(optionFileGenerateFormatTextbox.Text.Length, 0);
            optionFileGenerateFormatTextbox.ScrollToCaret();
        }
    }
}
