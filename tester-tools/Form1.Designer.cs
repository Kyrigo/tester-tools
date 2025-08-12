namespace tester_tools
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TINTextbox = new TextBox();
            TINLabel = new Label();
            generateGroupBox = new GroupBox();
            phoneGenerateCopy = new Button();
            phoneGenerateButton = new Button();
            phoneGenerateTextbox = new TextBox();
            phoneGenerateLabel = new Label();
            symbolsGenerateCopy = new Button();
            KPPCopy = new Button();
            SNILSCopy = new Button();
            OGRNCopy = new Button();
            TINCopy = new Button();
            symbolsGenerateButton = new Button();
            symbolsGenerateLabel = new Label();
            symbolsGenerateTextbox = new RichTextBox();
            KPPButton = new Button();
            KPPTextbox = new TextBox();
            KPPLabel = new Label();
            SNILSButton = new Button();
            OGRNButton = new Button();
            TINButton = new Button();
            SNILSTextbox = new TextBox();
            SNILSLabel = new Label();
            OGRNTextbox = new TextBox();
            OGRNLabel = new Label();
            optionsGroupbox = new GroupBox();
            optionFileGenerateGroupbox = new GroupBox();
            optionFileGenerateShowGroupbox = new GroupBox();
            optionFileGenerateShowNo = new RadioButton();
            optionFileGenerateShowYes = new RadioButton();
            optionFileGenerateFormatTextbox = new MaskedTextBox();
            optionFileGenerateSizeNumeric = new NumericUpDown();
            optionFileGenerateGB = new RadioButton();
            optionFileGenerateMB = new RadioButton();
            optionFileGenerateKB = new RadioButton();
            optionFileGenerateSizeLabel = new Label();
            optionFileGenerateFormatLabel = new Label();
            optionSymbolsCountGroupbox = new GroupBox();
            optionTextGenerateFileGroupbox = new GroupBox();
            optionTextGenerateFilePathButton = new Button();
            optionTextGenerateFilePath = new TextBox();
            optionTextGenerateFilePathOpen = new GroupBox();
            optionTextGenerateFilePathOpenNo = new RadioButton();
            optionTextGenerateFilePathOpenYes = new RadioButton();
            symbolsCountNumeric = new NumericUpDown();
            symbolsCountInfo = new Label();
            optionCheckTINGroupbox = new GroupBox();
            checkTINFalse = new RadioButton();
            checkTINTrue = new RadioButton();
            optionTINCountGroupbox = new GroupBox();
            TINTenSymbols = new RadioButton();
            TINTwelveSymbols = new RadioButton();
            checkTINGroupbox = new GroupBox();
            checkTINButton = new Button();
            checkTINLabel = new Label();
            checkTINTextbox = new TextBox();
            fileGenerateGroupbox = new GroupBox();
            fileGenerateBrowseFolder = new Button();
            fileGeneratePathLabel = new Label();
            fileGeneratePath = new TextBox();
            fileGenerateButton = new Button();
            copyTooltip = new ToolTip(components);
            folderBrowseDialog = new FolderBrowserDialog();
            generateGroupBox.SuspendLayout();
            optionsGroupbox.SuspendLayout();
            optionFileGenerateGroupbox.SuspendLayout();
            optionFileGenerateShowGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)optionFileGenerateSizeNumeric).BeginInit();
            optionSymbolsCountGroupbox.SuspendLayout();
            optionTextGenerateFileGroupbox.SuspendLayout();
            optionTextGenerateFilePathOpen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)symbolsCountNumeric).BeginInit();
            optionCheckTINGroupbox.SuspendLayout();
            optionTINCountGroupbox.SuspendLayout();
            checkTINGroupbox.SuspendLayout();
            fileGenerateGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // TINTextbox
            // 
            TINTextbox.Location = new Point(64, 44);
            TINTextbox.Name = "TINTextbox";
            TINTextbox.PlaceholderText = "ИНН";
            TINTextbox.ReadOnly = true;
            TINTextbox.Size = new Size(315, 23);
            TINTextbox.TabIndex = 0;
            // 
            // TINLabel
            // 
            TINLabel.AutoSize = true;
            TINLabel.Location = new Point(6, 47);
            TINLabel.Name = "TINLabel";
            TINLabel.Size = new Size(34, 15);
            TINLabel.TabIndex = 1;
            TINLabel.Text = "ИНН";
            // 
            // generateGroupBox
            // 
            generateGroupBox.Controls.Add(phoneGenerateCopy);
            generateGroupBox.Controls.Add(phoneGenerateButton);
            generateGroupBox.Controls.Add(phoneGenerateTextbox);
            generateGroupBox.Controls.Add(phoneGenerateLabel);
            generateGroupBox.Controls.Add(symbolsGenerateCopy);
            generateGroupBox.Controls.Add(KPPCopy);
            generateGroupBox.Controls.Add(SNILSCopy);
            generateGroupBox.Controls.Add(OGRNCopy);
            generateGroupBox.Controls.Add(TINCopy);
            generateGroupBox.Controls.Add(symbolsGenerateButton);
            generateGroupBox.Controls.Add(symbolsGenerateLabel);
            generateGroupBox.Controls.Add(symbolsGenerateTextbox);
            generateGroupBox.Controls.Add(KPPButton);
            generateGroupBox.Controls.Add(KPPTextbox);
            generateGroupBox.Controls.Add(KPPLabel);
            generateGroupBox.Controls.Add(SNILSButton);
            generateGroupBox.Controls.Add(OGRNButton);
            generateGroupBox.Controls.Add(TINButton);
            generateGroupBox.Controls.Add(SNILSTextbox);
            generateGroupBox.Controls.Add(SNILSLabel);
            generateGroupBox.Controls.Add(OGRNTextbox);
            generateGroupBox.Controls.Add(OGRNLabel);
            generateGroupBox.Controls.Add(TINTextbox);
            generateGroupBox.Controls.Add(TINLabel);
            generateGroupBox.Location = new Point(12, 12);
            generateGroupBox.Name = "generateGroupBox";
            generateGroupBox.Size = new Size(550, 407);
            generateGroupBox.TabIndex = 2;
            generateGroupBox.TabStop = false;
            generateGroupBox.Text = "Генерация значений";
            // 
            // phoneGenerateCopy
            // 
            phoneGenerateCopy.BackgroundImage = Properties.Resources._1621635;
            phoneGenerateCopy.BackgroundImageLayout = ImageLayout.Stretch;
            phoneGenerateCopy.Location = new Point(385, 365);
            phoneGenerateCopy.Name = "phoneGenerateCopy";
            phoneGenerateCopy.Size = new Size(25, 23);
            phoneGenerateCopy.TabIndex = 23;
            phoneGenerateCopy.UseVisualStyleBackColor = true;
            phoneGenerateCopy.Click += phoneGenerateCopy_Click;
            // 
            // phoneGenerateButton
            // 
            phoneGenerateButton.Location = new Point(416, 366);
            phoneGenerateButton.Name = "phoneGenerateButton";
            phoneGenerateButton.Size = new Size(100, 23);
            phoneGenerateButton.TabIndex = 22;
            phoneGenerateButton.Text = "Сгенерировать";
            phoneGenerateButton.UseVisualStyleBackColor = true;
            phoneGenerateButton.Click += phoneGenerateButton_Click;
            // 
            // phoneGenerateTextbox
            // 
            phoneGenerateTextbox.Location = new Point(64, 366);
            phoneGenerateTextbox.Name = "phoneGenerateTextbox";
            phoneGenerateTextbox.PlaceholderText = "Телефон";
            phoneGenerateTextbox.ReadOnly = true;
            phoneGenerateTextbox.Size = new Size(315, 23);
            phoneGenerateTextbox.TabIndex = 20;
            // 
            // phoneGenerateLabel
            // 
            phoneGenerateLabel.AutoSize = true;
            phoneGenerateLabel.Location = new Point(6, 369);
            phoneGenerateLabel.Name = "phoneGenerateLabel";
            phoneGenerateLabel.Size = new Size(55, 15);
            phoneGenerateLabel.TabIndex = 21;
            phoneGenerateLabel.Text = "Телефон";
            // 
            // symbolsGenerateCopy
            // 
            symbolsGenerateCopy.BackgroundImage = Properties.Resources._1621635;
            symbolsGenerateCopy.BackgroundImageLayout = ImageLayout.Stretch;
            symbolsGenerateCopy.Location = new Point(385, 275);
            symbolsGenerateCopy.Name = "symbolsGenerateCopy";
            symbolsGenerateCopy.Size = new Size(25, 23);
            symbolsGenerateCopy.TabIndex = 19;
            symbolsGenerateCopy.UseVisualStyleBackColor = true;
            symbolsGenerateCopy.Click += symbolsGenerateCopy_Click;
            // 
            // KPPCopy
            // 
            KPPCopy.BackgroundImage = Properties.Resources._1621635;
            KPPCopy.BackgroundImageLayout = ImageLayout.Stretch;
            KPPCopy.Location = new Point(385, 176);
            KPPCopy.Name = "KPPCopy";
            KPPCopy.Size = new Size(25, 23);
            KPPCopy.TabIndex = 18;
            KPPCopy.UseVisualStyleBackColor = true;
            KPPCopy.Click += KPPCopy_Click;
            // 
            // SNILSCopy
            // 
            SNILSCopy.BackgroundImage = Properties.Resources._1621635;
            SNILSCopy.BackgroundImageLayout = ImageLayout.Stretch;
            SNILSCopy.Location = new Point(385, 132);
            SNILSCopy.Name = "SNILSCopy";
            SNILSCopy.Size = new Size(25, 23);
            SNILSCopy.TabIndex = 17;
            SNILSCopy.UseVisualStyleBackColor = true;
            SNILSCopy.Click += SNILSCopy_Click;
            // 
            // OGRNCopy
            // 
            OGRNCopy.BackgroundImage = Properties.Resources._1621635;
            OGRNCopy.BackgroundImageLayout = ImageLayout.Stretch;
            OGRNCopy.Location = new Point(385, 89);
            OGRNCopy.Name = "OGRNCopy";
            OGRNCopy.Size = new Size(25, 23);
            OGRNCopy.TabIndex = 16;
            OGRNCopy.UseVisualStyleBackColor = true;
            OGRNCopy.Click += OGRNCopy_Click;
            // 
            // TINCopy
            // 
            TINCopy.BackgroundImage = Properties.Resources._1621635;
            TINCopy.BackgroundImageLayout = ImageLayout.Stretch;
            TINCopy.Location = new Point(385, 43);
            TINCopy.Name = "TINCopy";
            TINCopy.Size = new Size(25, 23);
            TINCopy.TabIndex = 15;
            TINCopy.UseVisualStyleBackColor = true;
            TINCopy.Click += TINCopy_Click;
            // 
            // symbolsGenerateButton
            // 
            symbolsGenerateButton.Location = new Point(416, 276);
            symbolsGenerateButton.Name = "symbolsGenerateButton";
            symbolsGenerateButton.Size = new Size(100, 23);
            symbolsGenerateButton.TabIndex = 14;
            symbolsGenerateButton.Text = "Сгенерировать";
            symbolsGenerateButton.UseVisualStyleBackColor = true;
            symbolsGenerateButton.Click += symbolsGenerateButton_Click;
            // 
            // symbolsGenerateLabel
            // 
            symbolsGenerateLabel.AutoSize = true;
            symbolsGenerateLabel.Location = new Point(6, 280);
            symbolsGenerateLabel.Name = "symbolsGenerateLabel";
            symbolsGenerateLabel.Size = new Size(36, 15);
            symbolsGenerateLabel.TabIndex = 13;
            symbolsGenerateLabel.Text = "Текст";
            // 
            // symbolsGenerateTextbox
            // 
            symbolsGenerateTextbox.Enabled = false;
            symbolsGenerateTextbox.Location = new Point(64, 216);
            symbolsGenerateTextbox.Name = "symbolsGenerateTextbox";
            symbolsGenerateTextbox.ReadOnly = true;
            symbolsGenerateTextbox.Size = new Size(315, 136);
            symbolsGenerateTextbox.TabIndex = 12;
            symbolsGenerateTextbox.Text = "";
            // 
            // KPPButton
            // 
            KPPButton.Location = new Point(416, 176);
            KPPButton.Name = "KPPButton";
            KPPButton.Size = new Size(100, 23);
            KPPButton.TabIndex = 11;
            KPPButton.Text = "Сгенерировать";
            KPPButton.UseVisualStyleBackColor = true;
            KPPButton.Click += KPPButton_Click;
            // 
            // KPPTextbox
            // 
            KPPTextbox.Location = new Point(64, 176);
            KPPTextbox.Name = "KPPTextbox";
            KPPTextbox.PlaceholderText = "КПП";
            KPPTextbox.ReadOnly = true;
            KPPTextbox.Size = new Size(315, 23);
            KPPTextbox.TabIndex = 9;
            // 
            // KPPLabel
            // 
            KPPLabel.AutoSize = true;
            KPPLabel.Location = new Point(6, 179);
            KPPLabel.Name = "KPPLabel";
            KPPLabel.Size = new Size(32, 15);
            KPPLabel.TabIndex = 10;
            KPPLabel.Text = "КПП";
            // 
            // SNILSButton
            // 
            SNILSButton.Location = new Point(416, 132);
            SNILSButton.Name = "SNILSButton";
            SNILSButton.Size = new Size(100, 23);
            SNILSButton.TabIndex = 8;
            SNILSButton.Text = "Сгенерировать";
            SNILSButton.UseVisualStyleBackColor = true;
            SNILSButton.Click += SNILSButton_Click;
            // 
            // OGRNButton
            // 
            OGRNButton.Location = new Point(416, 89);
            OGRNButton.Name = "OGRNButton";
            OGRNButton.Size = new Size(100, 23);
            OGRNButton.TabIndex = 7;
            OGRNButton.Text = "Сгенерировать";
            OGRNButton.UseVisualStyleBackColor = true;
            OGRNButton.Click += OGRNButton_Click;
            // 
            // TINButton
            // 
            TINButton.Location = new Point(416, 44);
            TINButton.Name = "TINButton";
            TINButton.Size = new Size(100, 23);
            TINButton.TabIndex = 6;
            TINButton.Text = "Сгенерировать";
            TINButton.UseVisualStyleBackColor = true;
            TINButton.Click += TINButton_Click;
            // 
            // SNILSTextbox
            // 
            SNILSTextbox.Location = new Point(64, 133);
            SNILSTextbox.Name = "SNILSTextbox";
            SNILSTextbox.PlaceholderText = "СНИЛС";
            SNILSTextbox.ReadOnly = true;
            SNILSTextbox.Size = new Size(315, 23);
            SNILSTextbox.TabIndex = 4;
            // 
            // SNILSLabel
            // 
            SNILSLabel.AutoSize = true;
            SNILSLabel.Location = new Point(6, 136);
            SNILSLabel.Name = "SNILSLabel";
            SNILSLabel.Size = new Size(49, 15);
            SNILSLabel.TabIndex = 5;
            SNILSLabel.Text = "СНИЛС";
            // 
            // OGRNTextbox
            // 
            OGRNTextbox.Location = new Point(64, 89);
            OGRNTextbox.Name = "OGRNTextbox";
            OGRNTextbox.PlaceholderText = "ОГРН";
            OGRNTextbox.ReadOnly = true;
            OGRNTextbox.Size = new Size(315, 23);
            OGRNTextbox.TabIndex = 2;
            // 
            // OGRNLabel
            // 
            OGRNLabel.AutoSize = true;
            OGRNLabel.Location = new Point(6, 92);
            OGRNLabel.Name = "OGRNLabel";
            OGRNLabel.Size = new Size(38, 15);
            OGRNLabel.TabIndex = 3;
            OGRNLabel.Text = "ОГРН";
            // 
            // optionsGroupbox
            // 
            optionsGroupbox.Controls.Add(optionFileGenerateGroupbox);
            optionsGroupbox.Controls.Add(optionSymbolsCountGroupbox);
            optionsGroupbox.Controls.Add(optionCheckTINGroupbox);
            optionsGroupbox.Controls.Add(optionTINCountGroupbox);
            optionsGroupbox.Location = new Point(568, 12);
            optionsGroupbox.Name = "optionsGroupbox";
            optionsGroupbox.Size = new Size(284, 595);
            optionsGroupbox.TabIndex = 3;
            optionsGroupbox.TabStop = false;
            optionsGroupbox.Text = "Опции";
            // 
            // optionFileGenerateGroupbox
            // 
            optionFileGenerateGroupbox.Controls.Add(optionFileGenerateShowGroupbox);
            optionFileGenerateGroupbox.Controls.Add(optionFileGenerateFormatTextbox);
            optionFileGenerateGroupbox.Controls.Add(optionFileGenerateSizeNumeric);
            optionFileGenerateGroupbox.Controls.Add(optionFileGenerateGB);
            optionFileGenerateGroupbox.Controls.Add(optionFileGenerateMB);
            optionFileGenerateGroupbox.Controls.Add(optionFileGenerateKB);
            optionFileGenerateGroupbox.Controls.Add(optionFileGenerateSizeLabel);
            optionFileGenerateGroupbox.Controls.Add(optionFileGenerateFormatLabel);
            optionFileGenerateGroupbox.Location = new Point(6, 390);
            optionFileGenerateGroupbox.Name = "optionFileGenerateGroupbox";
            optionFileGenerateGroupbox.Size = new Size(272, 194);
            optionFileGenerateGroupbox.TabIndex = 6;
            optionFileGenerateGroupbox.TabStop = false;
            optionFileGenerateGroupbox.Text = "Параметры файла";
            // 
            // optionFileGenerateShowGroupbox
            // 
            optionFileGenerateShowGroupbox.Controls.Add(optionFileGenerateShowNo);
            optionFileGenerateShowGroupbox.Controls.Add(optionFileGenerateShowYes);
            optionFileGenerateShowGroupbox.Location = new Point(6, 115);
            optionFileGenerateShowGroupbox.Name = "optionFileGenerateShowGroupbox";
            optionFileGenerateShowGroupbox.Size = new Size(260, 52);
            optionFileGenerateShowGroupbox.TabIndex = 9;
            optionFileGenerateShowGroupbox.TabStop = false;
            optionFileGenerateShowGroupbox.Text = "Открыть местоположение?";
            // 
            // optionFileGenerateShowNo
            // 
            optionFileGenerateShowNo.AutoSize = true;
            optionFileGenerateShowNo.Checked = true;
            optionFileGenerateShowNo.Location = new Point(51, 22);
            optionFileGenerateShowNo.Name = "optionFileGenerateShowNo";
            optionFileGenerateShowNo.Size = new Size(45, 19);
            optionFileGenerateShowNo.TabIndex = 1;
            optionFileGenerateShowNo.TabStop = true;
            optionFileGenerateShowNo.Text = "Нет";
            optionFileGenerateShowNo.UseVisualStyleBackColor = true;
            // 
            // optionFileGenerateShowYes
            // 
            optionFileGenerateShowYes.AutoSize = true;
            optionFileGenerateShowYes.Location = new Point(6, 22);
            optionFileGenerateShowYes.Name = "optionFileGenerateShowYes";
            optionFileGenerateShowYes.Size = new Size(39, 19);
            optionFileGenerateShowYes.TabIndex = 0;
            optionFileGenerateShowYes.Text = "Да";
            optionFileGenerateShowYes.UseVisualStyleBackColor = true;
            // 
            // optionFileGenerateFormatTextbox
            // 
            optionFileGenerateFormatTextbox.Location = new Point(62, 27);
            optionFileGenerateFormatTextbox.Mask = "AAAAAAAAAA";
            optionFileGenerateFormatTextbox.Name = "optionFileGenerateFormatTextbox";
            optionFileGenerateFormatTextbox.Size = new Size(204, 23);
            optionFileGenerateFormatTextbox.TabIndex = 8;
            optionFileGenerateFormatTextbox.Click += optionFileGenerateFormatTextbox_Click;
            // 
            // optionFileGenerateSizeNumeric
            // 
            optionFileGenerateSizeNumeric.Location = new Point(62, 61);
            optionFileGenerateSizeNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            optionFileGenerateSizeNumeric.Name = "optionFileGenerateSizeNumeric";
            optionFileGenerateSizeNumeric.Size = new Size(204, 23);
            optionFileGenerateSizeNumeric.TabIndex = 7;
            optionFileGenerateSizeNumeric.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // optionFileGenerateGB
            // 
            optionFileGenerateGB.AutoSize = true;
            optionFileGenerateGB.Location = new Point(152, 90);
            optionFileGenerateGB.Name = "optionFileGenerateGB";
            optionFileGenerateGB.Size = new Size(38, 19);
            optionFileGenerateGB.TabIndex = 6;
            optionFileGenerateGB.Text = "ГБ";
            optionFileGenerateGB.UseVisualStyleBackColor = true;
            optionFileGenerateGB.Click += optionFileGenerateGB_Click;
            // 
            // optionFileGenerateMB
            // 
            optionFileGenerateMB.AutoSize = true;
            optionFileGenerateMB.Location = new Point(107, 90);
            optionFileGenerateMB.Name = "optionFileGenerateMB";
            optionFileGenerateMB.Size = new Size(43, 19);
            optionFileGenerateMB.TabIndex = 5;
            optionFileGenerateMB.Text = "МБ";
            optionFileGenerateMB.UseVisualStyleBackColor = true;
            optionFileGenerateMB.Click += optionFileGenerateMB_Click;
            // 
            // optionFileGenerateKB
            // 
            optionFileGenerateKB.AutoSize = true;
            optionFileGenerateKB.Checked = true;
            optionFileGenerateKB.Location = new Point(62, 90);
            optionFileGenerateKB.Name = "optionFileGenerateKB";
            optionFileGenerateKB.Size = new Size(39, 19);
            optionFileGenerateKB.TabIndex = 4;
            optionFileGenerateKB.TabStop = true;
            optionFileGenerateKB.Text = "КБ";
            optionFileGenerateKB.UseVisualStyleBackColor = true;
            optionFileGenerateKB.Click += optionFileGenerateKB_Click;
            // 
            // optionFileGenerateSizeLabel
            // 
            optionFileGenerateSizeLabel.AutoSize = true;
            optionFileGenerateSizeLabel.Location = new Point(6, 64);
            optionFileGenerateSizeLabel.Name = "optionFileGenerateSizeLabel";
            optionFileGenerateSizeLabel.Size = new Size(47, 15);
            optionFileGenerateSizeLabel.TabIndex = 2;
            optionFileGenerateSizeLabel.Text = "Размер";
            // 
            // optionFileGenerateFormatLabel
            // 
            optionFileGenerateFormatLabel.AutoSize = true;
            optionFileGenerateFormatLabel.Location = new Point(6, 30);
            optionFileGenerateFormatLabel.Name = "optionFileGenerateFormatLabel";
            optionFileGenerateFormatLabel.Size = new Size(50, 15);
            optionFileGenerateFormatLabel.TabIndex = 0;
            optionFileGenerateFormatLabel.Text = "Формат";
            // 
            // optionSymbolsCountGroupbox
            // 
            optionSymbolsCountGroupbox.Controls.Add(optionTextGenerateFileGroupbox);
            optionSymbolsCountGroupbox.Controls.Add(optionTextGenerateFilePathOpen);
            optionSymbolsCountGroupbox.Controls.Add(symbolsCountNumeric);
            optionSymbolsCountGroupbox.Controls.Add(symbolsCountInfo);
            optionSymbolsCountGroupbox.Location = new Point(6, 142);
            optionSymbolsCountGroupbox.Name = "optionSymbolsCountGroupbox";
            optionSymbolsCountGroupbox.Size = new Size(272, 242);
            optionSymbolsCountGroupbox.TabIndex = 5;
            optionSymbolsCountGroupbox.TabStop = false;
            optionSymbolsCountGroupbox.Text = "Количество символов для генерации";
            // 
            // optionTextGenerateFileGroupbox
            // 
            optionTextGenerateFileGroupbox.Controls.Add(optionTextGenerateFilePathButton);
            optionTextGenerateFileGroupbox.Controls.Add(optionTextGenerateFilePath);
            optionTextGenerateFileGroupbox.Location = new Point(6, 81);
            optionTextGenerateFileGroupbox.Name = "optionTextGenerateFileGroupbox";
            optionTextGenerateFileGroupbox.Size = new Size(266, 87);
            optionTextGenerateFileGroupbox.TabIndex = 11;
            optionTextGenerateFileGroupbox.TabStop = false;
            optionTextGenerateFileGroupbox.Text = "Путь к файлу";
            // 
            // optionTextGenerateFilePathButton
            // 
            optionTextGenerateFilePathButton.Location = new Point(6, 51);
            optionTextGenerateFilePathButton.Name = "optionTextGenerateFilePathButton";
            optionTextGenerateFilePathButton.Size = new Size(254, 23);
            optionTextGenerateFilePathButton.TabIndex = 19;
            optionTextGenerateFilePathButton.Text = "Обзор";
            optionTextGenerateFilePathButton.UseVisualStyleBackColor = true;
            optionTextGenerateFilePathButton.Click += optionTextGenerateFilePathButton_Click;
            // 
            // optionTextGenerateFilePath
            // 
            optionTextGenerateFilePath.Location = new Point(6, 22);
            optionTextGenerateFilePath.Name = "optionTextGenerateFilePath";
            optionTextGenerateFilePath.Size = new Size(254, 23);
            optionTextGenerateFilePath.TabIndex = 19;
            // 
            // optionTextGenerateFilePathOpen
            // 
            optionTextGenerateFilePathOpen.Controls.Add(optionTextGenerateFilePathOpenNo);
            optionTextGenerateFilePathOpen.Controls.Add(optionTextGenerateFilePathOpenYes);
            optionTextGenerateFilePathOpen.Location = new Point(6, 174);
            optionTextGenerateFilePathOpen.Name = "optionTextGenerateFilePathOpen";
            optionTextGenerateFilePathOpen.Size = new Size(260, 52);
            optionTextGenerateFilePathOpen.TabIndex = 10;
            optionTextGenerateFilePathOpen.TabStop = false;
            optionTextGenerateFilePathOpen.Text = "Открыть местоположение?";
            // 
            // optionTextGenerateFilePathOpenNo
            // 
            optionTextGenerateFilePathOpenNo.AutoSize = true;
            optionTextGenerateFilePathOpenNo.Checked = true;
            optionTextGenerateFilePathOpenNo.Location = new Point(51, 22);
            optionTextGenerateFilePathOpenNo.Name = "optionTextGenerateFilePathOpenNo";
            optionTextGenerateFilePathOpenNo.Size = new Size(45, 19);
            optionTextGenerateFilePathOpenNo.TabIndex = 1;
            optionTextGenerateFilePathOpenNo.TabStop = true;
            optionTextGenerateFilePathOpenNo.Text = "Нет";
            optionTextGenerateFilePathOpenNo.UseVisualStyleBackColor = true;
            // 
            // optionTextGenerateFilePathOpenYes
            // 
            optionTextGenerateFilePathOpenYes.AutoSize = true;
            optionTextGenerateFilePathOpenYes.Location = new Point(6, 22);
            optionTextGenerateFilePathOpenYes.Name = "optionTextGenerateFilePathOpenYes";
            optionTextGenerateFilePathOpenYes.Size = new Size(39, 19);
            optionTextGenerateFilePathOpenYes.TabIndex = 0;
            optionTextGenerateFilePathOpenYes.Text = "Да";
            optionTextGenerateFilePathOpenYes.UseVisualStyleBackColor = true;
            // 
            // symbolsCountNumeric
            // 
            symbolsCountNumeric.Location = new Point(6, 22);
            symbolsCountNumeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            symbolsCountNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            symbolsCountNumeric.Name = "symbolsCountNumeric";
            symbolsCountNumeric.Size = new Size(260, 23);
            symbolsCountNumeric.TabIndex = 2;
            symbolsCountNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // symbolsCountInfo
            // 
            symbolsCountInfo.AutoSize = true;
            symbolsCountInfo.Location = new Point(6, 48);
            symbolsCountInfo.Name = "symbolsCountInfo";
            symbolsCountInfo.Size = new Size(203, 30);
            symbolsCountInfo.TabIndex = 1;
            symbolsCountInfo.Text = "Количество символов более 1000 \r\nбудет сохранено в отдельный файл";
            // 
            // optionCheckTINGroupbox
            // 
            optionCheckTINGroupbox.Controls.Add(checkTINFalse);
            optionCheckTINGroupbox.Controls.Add(checkTINTrue);
            optionCheckTINGroupbox.Location = new Point(6, 81);
            optionCheckTINGroupbox.Name = "optionCheckTINGroupbox";
            optionCheckTINGroupbox.Size = new Size(272, 55);
            optionCheckTINGroupbox.TabIndex = 4;
            optionCheckTINGroupbox.TabStop = false;
            optionCheckTINGroupbox.Text = "Проверка ИНН после генерации";
            // 
            // checkTINFalse
            // 
            checkTINFalse.AutoSize = true;
            checkTINFalse.Checked = true;
            checkTINFalse.Location = new Point(49, 22);
            checkTINFalse.Name = "checkTINFalse";
            checkTINFalse.Size = new Size(45, 19);
            checkTINFalse.TabIndex = 4;
            checkTINFalse.TabStop = true;
            checkTINFalse.Text = "Нет";
            checkTINFalse.UseVisualStyleBackColor = true;
            // 
            // checkTINTrue
            // 
            checkTINTrue.AutoSize = true;
            checkTINTrue.Location = new Point(6, 22);
            checkTINTrue.Name = "checkTINTrue";
            checkTINTrue.Size = new Size(39, 19);
            checkTINTrue.TabIndex = 3;
            checkTINTrue.Text = "Да";
            checkTINTrue.UseVisualStyleBackColor = true;
            // 
            // optionTINCountGroupbox
            // 
            optionTINCountGroupbox.Controls.Add(TINTenSymbols);
            optionTINCountGroupbox.Controls.Add(TINTwelveSymbols);
            optionTINCountGroupbox.Location = new Point(6, 22);
            optionTINCountGroupbox.Name = "optionTINCountGroupbox";
            optionTINCountGroupbox.Size = new Size(272, 53);
            optionTINCountGroupbox.TabIndex = 3;
            optionTINCountGroupbox.TabStop = false;
            optionTINCountGroupbox.Text = "Количество символов ИНН";
            // 
            // TINTenSymbols
            // 
            TINTenSymbols.AutoSize = true;
            TINTenSymbols.Checked = true;
            TINTenSymbols.Location = new Point(6, 22);
            TINTenSymbols.Name = "TINTenSymbols";
            TINTenSymbols.Size = new Size(37, 19);
            TINTenSymbols.TabIndex = 0;
            TINTenSymbols.TabStop = true;
            TINTenSymbols.Text = "10";
            TINTenSymbols.UseVisualStyleBackColor = true;
            // 
            // TINTwelveSymbols
            // 
            TINTwelveSymbols.AutoSize = true;
            TINTwelveSymbols.Location = new Point(49, 22);
            TINTwelveSymbols.Name = "TINTwelveSymbols";
            TINTwelveSymbols.Size = new Size(37, 19);
            TINTwelveSymbols.TabIndex = 1;
            TINTwelveSymbols.Text = "12";
            TINTwelveSymbols.UseVisualStyleBackColor = true;
            // 
            // checkTINGroupbox
            // 
            checkTINGroupbox.Controls.Add(checkTINButton);
            checkTINGroupbox.Controls.Add(checkTINLabel);
            checkTINGroupbox.Controls.Add(checkTINTextbox);
            checkTINGroupbox.Location = new Point(12, 425);
            checkTINGroupbox.Name = "checkTINGroupbox";
            checkTINGroupbox.Size = new Size(550, 79);
            checkTINGroupbox.TabIndex = 4;
            checkTINGroupbox.TabStop = false;
            checkTINGroupbox.Text = "Проверка значений";
            // 
            // checkTINButton
            // 
            checkTINButton.Location = new Point(394, 29);
            checkTINButton.Name = "checkTINButton";
            checkTINButton.Size = new Size(100, 23);
            checkTINButton.TabIndex = 11;
            checkTINButton.Text = "Проверить";
            checkTINButton.UseVisualStyleBackColor = true;
            checkTINButton.Click += checkTINButton_Click;
            // 
            // checkTINLabel
            // 
            checkTINLabel.AutoSize = true;
            checkTINLabel.Location = new Point(6, 32);
            checkTINLabel.Name = "checkTINLabel";
            checkTINLabel.Size = new Size(34, 15);
            checkTINLabel.TabIndex = 10;
            checkTINLabel.Text = "ИНН";
            // 
            // checkTINTextbox
            // 
            checkTINTextbox.Location = new Point(64, 29);
            checkTINTextbox.Name = "checkTINTextbox";
            checkTINTextbox.PlaceholderText = "ИНН вставлять сюда, если что";
            checkTINTextbox.Size = new Size(315, 23);
            checkTINTextbox.TabIndex = 9;
            // 
            // fileGenerateGroupbox
            // 
            fileGenerateGroupbox.Controls.Add(fileGenerateBrowseFolder);
            fileGenerateGroupbox.Controls.Add(fileGeneratePathLabel);
            fileGenerateGroupbox.Controls.Add(fileGeneratePath);
            fileGenerateGroupbox.Controls.Add(fileGenerateButton);
            fileGenerateGroupbox.Location = new Point(12, 510);
            fileGenerateGroupbox.Name = "fileGenerateGroupbox";
            fileGenerateGroupbox.Size = new Size(550, 95);
            fileGenerateGroupbox.TabIndex = 5;
            fileGenerateGroupbox.TabStop = false;
            fileGenerateGroupbox.Text = "Генерация файла";
            // 
            // fileGenerateBrowseFolder
            // 
            fileGenerateBrowseFolder.Location = new Point(155, 66);
            fileGenerateBrowseFolder.Name = "fileGenerateBrowseFolder";
            fileGenerateBrowseFolder.Size = new Size(100, 23);
            fileGenerateBrowseFolder.TabIndex = 18;
            fileGenerateBrowseFolder.Text = "Обзор";
            fileGenerateBrowseFolder.UseVisualStyleBackColor = true;
            fileGenerateBrowseFolder.Click += FileGenerateBrowseFolder_Click;
            // 
            // fileGeneratePathLabel
            // 
            fileGeneratePathLabel.AutoSize = true;
            fileGeneratePathLabel.Location = new Point(6, 39);
            fileGeneratePathLabel.Name = "fileGeneratePathLabel";
            fileGeneratePathLabel.Size = new Size(80, 15);
            fileGeneratePathLabel.TabIndex = 17;
            fileGeneratePathLabel.Text = "Путь к файлу";
            // 
            // fileGeneratePath
            // 
            fileGeneratePath.Location = new Point(92, 36);
            fileGeneratePath.Name = "fileGeneratePath";
            fileGeneratePath.Size = new Size(452, 23);
            fileGeneratePath.TabIndex = 16;
            // 
            // fileGenerateButton
            // 
            fileGenerateButton.Enabled = false;
            fileGenerateButton.Location = new Point(370, 66);
            fileGenerateButton.Name = "fileGenerateButton";
            fileGenerateButton.Size = new Size(100, 23);
            fileGenerateButton.TabIndex = 15;
            fileGenerateButton.Text = "Сгенерировать";
            fileGenerateButton.UseVisualStyleBackColor = true;
            fileGenerateButton.Click += fileGenerateButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 617);
            Controls.Add(fileGenerateGroupbox);
            Controls.Add(checkTINGroupbox);
            Controls.Add(optionsGroupbox);
            Controls.Add(generateGroupBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "tester-tools v0.2";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            generateGroupBox.ResumeLayout(false);
            generateGroupBox.PerformLayout();
            optionsGroupbox.ResumeLayout(false);
            optionFileGenerateGroupbox.ResumeLayout(false);
            optionFileGenerateGroupbox.PerformLayout();
            optionFileGenerateShowGroupbox.ResumeLayout(false);
            optionFileGenerateShowGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)optionFileGenerateSizeNumeric).EndInit();
            optionSymbolsCountGroupbox.ResumeLayout(false);
            optionSymbolsCountGroupbox.PerformLayout();
            optionTextGenerateFileGroupbox.ResumeLayout(false);
            optionTextGenerateFileGroupbox.PerformLayout();
            optionTextGenerateFilePathOpen.ResumeLayout(false);
            optionTextGenerateFilePathOpen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)symbolsCountNumeric).EndInit();
            optionCheckTINGroupbox.ResumeLayout(false);
            optionCheckTINGroupbox.PerformLayout();
            optionTINCountGroupbox.ResumeLayout(false);
            optionTINCountGroupbox.PerformLayout();
            checkTINGroupbox.ResumeLayout(false);
            checkTINGroupbox.PerformLayout();
            fileGenerateGroupbox.ResumeLayout(false);
            fileGenerateGroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TINTextbox;
        private Label TINLabel;
        private GroupBox generateGroupBox;
        private TextBox SNILSTextbox;
        private Label SNILSLabel;
        private TextBox OGRNTextbox;
        private Label OGRNLabel;
        private Button SNILSButton;
        private Button OGRNButton;
        private Button TINButton;
        private GroupBox optionsGroupbox;
        private RadioButton TINTwelveSymbols;
        private RadioButton TINTenSymbols;
        private GroupBox checkTINGroupbox;
        private Button checkTINButton;
        private Label checkTINLabel;
        private TextBox checkTINTextbox;
        private Button KPPButton;
        private TextBox KPPTextbox;
        private Label KPPLabel;
        private RadioButton optionFileGenerateKB;
        private RadioButton optionFileGenerateMB;
        private RadioButton optionFileGenerateGB;
        private GroupBox optionTINCountGroupbox;
        private GroupBox optionCheckTINGroupbox;
        private RadioButton checkTINFalse;
        private RadioButton checkTINTrue;
        private Button symbolsGenerateButton;
        private Label symbolsGenerateLabel;
        private RichTextBox symbolsGenerateTextbox;
        private GroupBox optionSymbolsCountGroupbox;
        private Label symbolsCountInfo;
        private GroupBox fileGenerateGroupbox;
        private GroupBox optionFileGenerateGroupbox;
        private Label optionFileGenerateSizeLabel;
        private Label optionFileGenerateFormatLabel;
        private Button fileGenerateButton;
        private Label fileGeneratePathLabel;
        private TextBox fileGeneratePath;
        private Button fileGenerateBrowseFolder;
        private MaskedTextBox optionFileGenerateFormatTextbox;
        private NumericUpDown optionFileGenerateSizeNumeric;
        private NumericUpDown symbolsCountNumeric;
        private Button symbolsGenerateCopy;
        private Button KPPCopy;
        private Button SNILSCopy;
        private Button OGRNCopy;
        private Button TINCopy;
        private ToolTip copyTooltip;
        private FolderBrowserDialog folderBrowseDialog;
        private GroupBox optionFileGenerateShowGroupbox;
        private RadioButton optionFileGenerateShowNo;
        private RadioButton optionFileGenerateShowYes;
        private GroupBox optionTextGenerateFileGroupbox;
        private GroupBox optionTextGenerateFilePathOpen;
        private RadioButton optionTextGenerateFilePathOpenNo;
        private RadioButton optionTextGenerateFilePathOpenYes;
        private Button optionTextGenerateFilePathButton;
        private TextBox optionTextGenerateFilePath;
        private Button phoneGenerateCopy;
        private Button phoneGenerateButton;
        private TextBox phoneGenerateTextbox;
        private Label phoneGenerateLabel;
    }
}
