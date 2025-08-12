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
            copyTooltip.SetToolTip(this.TINCopy, "Скопировать в буфер обмена");
            copyTooltip.SetToolTip(this.KPPCopy, "Скопировать в буфер обмена");
            copyTooltip.SetToolTip(this.OGRNCopy, "Скопировать в буфер обмена");
            copyTooltip.SetToolTip(this.SNILSCopy, "Скопировать в буфер обмена");
            copyTooltip.SetToolTip(this.symbolsGenerateCopy, "Скопировать в буфер обмена");
            optionFileGenerateSizeNumeric.Maximum = 10000;
            optionTextGenerateFilePath.Text = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void TINCopy_Click(object sender, EventArgs e)
        {
            if (TINTextbox.Text != string.Empty)
            {
                Clipboard.SetText(TINTextbox.Text);
            }
            else
            {
                copyTooltip.Show("Сначала сгенерируй значение", TINTextbox, 3000);
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
                copyTooltip.Show("Сначала сгенерируй значение", OGRNTextbox, 3000);
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
                copyTooltip.Show("Сначала сгенерируй значение", SNILSTextbox, 3000);
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
                copyTooltip.Show("Сначала сгенерируй значение", KPPTextbox, 3000);
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
                copyTooltip.Show("Сначала сгенерируй значение", symbolsGenerateTextbox, 3000);
            }
        }

        private void phoneGenerateCopy_Click(object sender, EventArgs e)
        {
            if (phoneGenerateTextbox.Text != string.Empty)
            {
                Clipboard.SetText(phoneGenerateTextbox.Text);
            }
            else
            {
                copyTooltip.Show("Сначала сгенерируй значение", phoneGenerateTextbox, 3000);
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
            // Определяем длину ИНН на основе выбранного RadioButton
            var isTenSymbols = TINTenSymbols.Checked;
            var tinLength = isTenSymbols ? TINTenSymbols.Text : TINTwelveSymbols.Text;

            // Генерируем ИНН
            var generatedTIN = TINGenerator.GenerateTIN(tinLength);
            TINTextbox.Text = generatedTIN;

            // Проверяем ИНН, если нужно
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

        private void phoneGenerateButton_Click(object sender, EventArgs e)
        {
            phoneGenerateTextbox.Text = PhoneGenerator.Generate();
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
                var rootPath = optionTextGenerateFilePath.Text;
                var filePath = Path.Combine(rootPath, "generated_text.txt");
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                try
                {
                    File.WriteAllText(filePath, generatedtext);
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка при генерации! Проверьте указанный путь", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Превышен лимит символов для отображения в программе. Текст сохранён в файл. Путь: " + filePath, "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (optionTextGenerateFilePathOpenYes.Checked)
                {
                    Process.Start("explorer.exe", $"/select, \"{filePath}\"");
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var message = "Вы уверены что хотите выйти из приложения?";
            var caption = "Закрытие приложения";

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
                copyTooltip.Show("Сначала укажите формат файла", optionFileGenerateFormatTextbox, 3000);
                return;
            }

            var rootPath = fileGeneratePath.Text;
            var filePath = Path.Combine(
                rootPath,
                $"generated_file.{optionFileGenerateFormatTextbox.Text}");

            if (File.Exists(filePath)) File.Delete(filePath);

            // Определение выбранной единицы измерения
            string unit = optionFileGenerateKB.Checked ? optionFileGenerateKB.Text :
                         optionFileGenerateMB.Checked ? optionFileGenerateMB.Text :
                         optionFileGenerateGB.Checked ? optionFileGenerateGB.Text : throw new NotImplementedException("Как ты сюда попал? о_О");

            // Генерация файла
            try
            {
                FileGenerator.Generate(filePath, (long)optionFileGenerateSizeNumeric.Value, unit);
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка при генерации! Проверьте указанный путь", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"Файл успешно сгенерирован! Путь: {filePath}", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void optionTextGenerateFilePathButton_Click(object sender, EventArgs e)
        {
            DialogResult selectFolder = folderBrowseDialog.ShowDialog();
            if (selectFolder == DialogResult.OK)
            {
                optionTextGenerateFilePath.Text = folderBrowseDialog.SelectedPath;
            }
        }
    }
}
