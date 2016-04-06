namespace Renamer
{
    partial class FormRenamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRenamer));
            this.buttonRename = new System.Windows.Forms.Button();
            this.tabPageCapsStyle = new System.Windows.Forms.TabPage();
            this.labelUnderLine2 = new System.Windows.Forms.Label();
            this.radioButtonCammelCase = new System.Windows.Forms.RadioButton();
            this.radioButtonAllLowerCase = new System.Windows.Forms.RadioButton();
            this.radioButtonFirstLetterCaps = new System.Windows.Forms.RadioButton();
            this.tabPageSpacingStyle = new System.Windows.Forms.TabPage();
            this.labelUnderLine1 = new System.Windows.Forms.Label();
            this.radioButtonNoSpacing = new System.Windows.Forms.RadioButton();
            this.radioButtonNormalSpacing = new System.Windows.Forms.RadioButton();
            this.radioButtonUnderScoreSpacing = new System.Windows.Forms.RadioButton();
            this.tabControlFormatSettings = new System.Windows.Forms.TabControl();
            this.groupBoxFormatStyleFor = new System.Windows.Forms.GroupBox();
            this.radioButtonFolders = new System.Windows.Forms.RadioButton();
            this.radioButtonFiles = new System.Windows.Forms.RadioButton();
            this.buttonConformFormat = new System.Windows.Forms.Button();
            this.groupBoxInclusionExclusionRenamingOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxIncludeSoftware = new System.Windows.Forms.CheckBox();
            this.checkBoxExcludeFolders = new System.Windows.Forms.CheckBox();
            this.checkBoxExcludeDocuments = new System.Windows.Forms.CheckBox();
            this.checkBoxExcludeImages = new System.Windows.Forms.CheckBox();
            this.checkBoxIncludeAllNonExcluded = new System.Windows.Forms.CheckBox();
            this.checkBoxIncludeCurrentFolder = new System.Windows.Forms.CheckBox();
            this.toolTipIncludeAllNonExcluded = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExcludeSoftwareFiles = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxFindFolder = new System.Windows.Forms.TextBox();
            this.buttonFindFolder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxCurrentFolderAndContents = new System.Windows.Forms.GroupBox();
            this.treeViewContentsOfSelected = new System.Windows.Forms.TreeView();
            this.imageListTreeView1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.pictureBoxLanguage = new System.Windows.Forms.PictureBox();
            this.labelNotice = new System.Windows.Forms.Label();
            this.tabPageCapsStyle.SuspendLayout();
            this.tabPageSpacingStyle.SuspendLayout();
            this.tabControlFormatSettings.SuspendLayout();
            this.groupBoxFormatStyleFor.SuspendLayout();
            this.groupBoxInclusionExclusionRenamingOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxCurrentFolderAndContents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(22, 315);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(94, 31);
            this.buttonRename.TabIndex = 4;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // tabPageCapsStyle
            // 
            this.tabPageCapsStyle.Controls.Add(this.labelUnderLine2);
            this.tabPageCapsStyle.Controls.Add(this.radioButtonCammelCase);
            this.tabPageCapsStyle.Controls.Add(this.radioButtonAllLowerCase);
            this.tabPageCapsStyle.Controls.Add(this.radioButtonFirstLetterCaps);
            this.tabPageCapsStyle.Location = new System.Drawing.Point(4, 22);
            this.tabPageCapsStyle.Name = "tabPageCapsStyle";
            this.tabPageCapsStyle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCapsStyle.Size = new System.Drawing.Size(445, 97);
            this.tabPageCapsStyle.TabIndex = 1;
            this.tabPageCapsStyle.Text = "Caps Style";
            this.tabPageCapsStyle.UseVisualStyleBackColor = true;
            // 
            // labelUnderLine2
            // 
            this.labelUnderLine2.AutoSize = true;
            this.labelUnderLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnderLine2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelUnderLine2.Location = new System.Drawing.Point(79, 0);
            this.labelUnderLine2.Name = "labelUnderLine2";
            this.labelUnderLine2.Size = new System.Drawing.Size(57, 13);
            this.labelUnderLine2.TabIndex = 4;
            this.labelUnderLine2.Text = "**********";
            // 
            // radioButtonCammelCase
            // 
            this.radioButtonCammelCase.AutoSize = true;
            this.radioButtonCammelCase.Enabled = false;
            this.radioButtonCammelCase.Location = new System.Drawing.Point(6, 62);
            this.radioButtonCammelCase.Name = "radioButtonCammelCase";
            this.radioButtonCammelCase.Size = new System.Drawing.Size(199, 17);
            this.radioButtonCammelCase.TabIndex = 1;
            this.radioButtonCammelCase.Text = "Cammal Case ( i.e. myExampleName)";
            this.radioButtonCammelCase.UseVisualStyleBackColor = true;
            this.radioButtonCammelCase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SetFalseRadioButton_MouseDown);
            // 
            // radioButtonAllLowerCase
            // 
            this.radioButtonAllLowerCase.AutoSize = true;
            this.radioButtonAllLowerCase.Location = new System.Drawing.Point(6, 39);
            this.radioButtonAllLowerCase.Name = "radioButtonAllLowerCase";
            this.radioButtonAllLowerCase.Size = new System.Drawing.Size(208, 17);
            this.radioButtonAllLowerCase.TabIndex = 3;
            this.radioButtonAllLowerCase.Text = "All Lower Case ( i.e. my example name)";
            this.radioButtonAllLowerCase.UseVisualStyleBackColor = true;
            this.radioButtonAllLowerCase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SetFalseRadioButton_MouseDown);
            // 
            // radioButtonFirstLetterCaps
            // 
            this.radioButtonFirstLetterCaps.AutoSize = true;
            this.radioButtonFirstLetterCaps.Location = new System.Drawing.Point(6, 16);
            this.radioButtonFirstLetterCaps.Name = "radioButtonFirstLetterCaps";
            this.radioButtonFirstLetterCaps.Size = new System.Drawing.Size(218, 17);
            this.radioButtonFirstLetterCaps.TabIndex = 2;
            this.radioButtonFirstLetterCaps.Text = "First Letter Caps ( i.e. My Example Name)";
            this.radioButtonFirstLetterCaps.UseVisualStyleBackColor = true;
            this.radioButtonFirstLetterCaps.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SetFalseRadioButton_MouseDown);
            // 
            // tabPageSpacingStyle
            // 
            this.tabPageSpacingStyle.Controls.Add(this.labelUnderLine1);
            this.tabPageSpacingStyle.Controls.Add(this.radioButtonNoSpacing);
            this.tabPageSpacingStyle.Controls.Add(this.radioButtonNormalSpacing);
            this.tabPageSpacingStyle.Controls.Add(this.radioButtonUnderScoreSpacing);
            this.tabPageSpacingStyle.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpacingStyle.Name = "tabPageSpacingStyle";
            this.tabPageSpacingStyle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpacingStyle.Size = new System.Drawing.Size(445, 97);
            this.tabPageSpacingStyle.TabIndex = 0;
            this.tabPageSpacingStyle.Text = "Spacing Style";
            this.tabPageSpacingStyle.UseVisualStyleBackColor = true;
            // 
            // labelUnderLine1
            // 
            this.labelUnderLine1.AutoSize = true;
            this.labelUnderLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnderLine1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelUnderLine1.Location = new System.Drawing.Point(4, 0);
            this.labelUnderLine1.Name = "labelUnderLine1";
            this.labelUnderLine1.Size = new System.Drawing.Size(67, 13);
            this.labelUnderLine1.TabIndex = 0;
            this.labelUnderLine1.Text = "************";
            // 
            // radioButtonNoSpacing
            // 
            this.radioButtonNoSpacing.AutoSize = true;
            this.radioButtonNoSpacing.Location = new System.Drawing.Point(6, 62);
            this.radioButtonNoSpacing.Name = "radioButtonNoSpacing";
            this.radioButtonNoSpacing.Size = new System.Drawing.Size(192, 17);
            this.radioButtonNoSpacing.TabIndex = 3;
            this.radioButtonNoSpacing.Text = "No Spacing ( i.e. MyExampleName)";
            this.radioButtonNoSpacing.UseVisualStyleBackColor = true;
            this.radioButtonNoSpacing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SetFalseRadioButton_MouseDown);
            // 
            // radioButtonNormalSpacing
            // 
            this.radioButtonNormalSpacing.AutoSize = true;
            this.radioButtonNormalSpacing.Location = new System.Drawing.Point(6, 16);
            this.radioButtonNormalSpacing.Name = "radioButtonNormalSpacing";
            this.radioButtonNormalSpacing.Size = new System.Drawing.Size(217, 17);
            this.radioButtonNormalSpacing.TabIndex = 1;
            this.radioButtonNormalSpacing.Text = "Normal Spacing ( i.e. My Example Name)";
            this.radioButtonNormalSpacing.UseVisualStyleBackColor = true;
            this.radioButtonNormalSpacing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SetFalseRadioButton_MouseDown);
            // 
            // radioButtonUnderScoreSpacing
            // 
            this.radioButtonUnderScoreSpacing.AutoSize = true;
            this.radioButtonUnderScoreSpacing.Location = new System.Drawing.Point(6, 39);
            this.radioButtonUnderScoreSpacing.Name = "radioButtonUnderScoreSpacing";
            this.radioButtonUnderScoreSpacing.Size = new System.Drawing.Size(250, 17);
            this.radioButtonUnderScoreSpacing.TabIndex = 2;
            this.radioButtonUnderScoreSpacing.Text = "Under Score Spacing ( i.e. My_Example_Name)";
            this.radioButtonUnderScoreSpacing.UseVisualStyleBackColor = true;
            this.radioButtonUnderScoreSpacing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SetFalseRadioButton_MouseDown);
            // 
            // tabControlFormatSettings
            // 
            this.tabControlFormatSettings.Controls.Add(this.tabPageSpacingStyle);
            this.tabControlFormatSettings.Controls.Add(this.tabPageCapsStyle);
            this.tabControlFormatSettings.ItemSize = new System.Drawing.Size(77, 18);
            this.tabControlFormatSettings.Location = new System.Drawing.Point(22, 186);
            this.tabControlFormatSettings.Name = "tabControlFormatSettings";
            this.tabControlFormatSettings.SelectedIndex = 0;
            this.tabControlFormatSettings.Size = new System.Drawing.Size(453, 123);
            this.tabControlFormatSettings.TabIndex = 3;
            // 
            // groupBoxFormatStyleFor
            // 
            this.groupBoxFormatStyleFor.Controls.Add(this.radioButtonFolders);
            this.groupBoxFormatStyleFor.Controls.Add(this.radioButtonFiles);
            this.groupBoxFormatStyleFor.Location = new System.Drawing.Point(22, 129);
            this.groupBoxFormatStyleFor.Name = "groupBoxFormatStyleFor";
            this.groupBoxFormatStyleFor.Size = new System.Drawing.Size(453, 51);
            this.groupBoxFormatStyleFor.TabIndex = 2;
            this.groupBoxFormatStyleFor.TabStop = false;
            this.groupBoxFormatStyleFor.Text = "Format Style For:";
            // 
            // radioButtonFolders
            // 
            this.radioButtonFolders.AutoSize = true;
            this.radioButtonFolders.Checked = true;
            this.radioButtonFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFolders.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonFolders.Image")));
            this.radioButtonFolders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonFolders.Location = new System.Drawing.Point(6, 19);
            this.radioButtonFolders.Name = "radioButtonFolders";
            this.radioButtonFolders.Size = new System.Drawing.Size(88, 20);
            this.radioButtonFolders.TabIndex = 0;
            this.radioButtonFolders.TabStop = true;
            this.radioButtonFolders.Text = "Folders";
            this.radioButtonFolders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonFolders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButtonFolders.UseVisualStyleBackColor = true;
            this.radioButtonFolders.Click += new System.EventHandler(this.radioButtonFolders_Click);
            // 
            // radioButtonFiles
            // 
            this.radioButtonFiles.AutoSize = true;
            this.radioButtonFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFiles.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonFiles.Image")));
            this.radioButtonFiles.Location = new System.Drawing.Point(100, 19);
            this.radioButtonFiles.Name = "radioButtonFiles";
            this.radioButtonFiles.Size = new System.Drawing.Size(71, 20);
            this.radioButtonFiles.TabIndex = 1;
            this.radioButtonFiles.Text = "Files";
            this.radioButtonFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButtonFiles.UseVisualStyleBackColor = true;
            this.radioButtonFiles.Click += new System.EventHandler(this.radioButtonFiles_Click);
            // 
            // buttonConformFormat
            // 
            this.buttonConformFormat.Enabled = false;
            this.buttonConformFormat.Location = new System.Drawing.Point(125, 315);
            this.buttonConformFormat.Name = "buttonConformFormat";
            this.buttonConformFormat.Size = new System.Drawing.Size(124, 31);
            this.buttonConformFormat.TabIndex = 5;
            this.buttonConformFormat.Text = "Conform Format";
            this.buttonConformFormat.UseVisualStyleBackColor = true;
            // 
            // groupBoxInclusionExclusionRenamingOptions
            // 
            this.groupBoxInclusionExclusionRenamingOptions.Controls.Add(this.checkBoxIncludeSoftware);
            this.groupBoxInclusionExclusionRenamingOptions.Controls.Add(this.checkBoxExcludeFolders);
            this.groupBoxInclusionExclusionRenamingOptions.Controls.Add(this.checkBoxExcludeDocuments);
            this.groupBoxInclusionExclusionRenamingOptions.Controls.Add(this.checkBoxExcludeImages);
            this.groupBoxInclusionExclusionRenamingOptions.Controls.Add(this.checkBoxIncludeAllNonExcluded);
            this.groupBoxInclusionExclusionRenamingOptions.Controls.Add(this.checkBoxIncludeCurrentFolder);
            this.groupBoxInclusionExclusionRenamingOptions.Enabled = false;
            this.groupBoxInclusionExclusionRenamingOptions.Location = new System.Drawing.Point(22, 56);
            this.groupBoxInclusionExclusionRenamingOptions.Name = "groupBoxInclusionExclusionRenamingOptions";
            this.groupBoxInclusionExclusionRenamingOptions.Size = new System.Drawing.Size(453, 67);
            this.groupBoxInclusionExclusionRenamingOptions.TabIndex = 1;
            this.groupBoxInclusionExclusionRenamingOptions.TabStop = false;
            this.groupBoxInclusionExclusionRenamingOptions.Text = "Inclusion/ Exclusion Renaming Options:";
            // 
            // checkBoxIncludeSoftware
            // 
            this.checkBoxIncludeSoftware.AutoSize = true;
            this.checkBoxIncludeSoftware.Enabled = false;
            this.checkBoxIncludeSoftware.Location = new System.Drawing.Point(157, 44);
            this.checkBoxIncludeSoftware.Name = "checkBoxIncludeSoftware";
            this.checkBoxIncludeSoftware.Size = new System.Drawing.Size(106, 17);
            this.checkBoxIncludeSoftware.TabIndex = 4;
            this.checkBoxIncludeSoftware.Text = "Include Software";
            this.toolTipExcludeSoftwareFiles.SetToolTip(this.checkBoxIncludeSoftware, "Examples of \"Software Files\" include: .exe, .bat, .dll, .js, .json, .xml, .html, " +
        "...and more of the like.");
            this.checkBoxIncludeSoftware.UseVisualStyleBackColor = true;
            // 
            // checkBoxExcludeFolders
            // 
            this.checkBoxExcludeFolders.AutoSize = true;
            this.checkBoxExcludeFolders.Location = new System.Drawing.Point(296, 20);
            this.checkBoxExcludeFolders.Name = "checkBoxExcludeFolders";
            this.checkBoxExcludeFolders.Size = new System.Drawing.Size(101, 17);
            this.checkBoxExcludeFolders.TabIndex = 2;
            this.checkBoxExcludeFolders.Text = "Exclude Folders";
            this.checkBoxExcludeFolders.UseVisualStyleBackColor = true;
            // 
            // checkBoxExcludeDocuments
            // 
            this.checkBoxExcludeDocuments.AutoSize = true;
            this.checkBoxExcludeDocuments.Location = new System.Drawing.Point(296, 44);
            this.checkBoxExcludeDocuments.Name = "checkBoxExcludeDocuments";
            this.checkBoxExcludeDocuments.Size = new System.Drawing.Size(121, 17);
            this.checkBoxExcludeDocuments.TabIndex = 5;
            this.checkBoxExcludeDocuments.Text = "Exclude Documents";
            this.checkBoxExcludeDocuments.UseVisualStyleBackColor = true;
            // 
            // checkBoxExcludeImages
            // 
            this.checkBoxExcludeImages.AutoSize = true;
            this.checkBoxExcludeImages.Enabled = false;
            this.checkBoxExcludeImages.Location = new System.Drawing.Point(157, 20);
            this.checkBoxExcludeImages.Name = "checkBoxExcludeImages";
            this.checkBoxExcludeImages.Size = new System.Drawing.Size(101, 17);
            this.checkBoxExcludeImages.TabIndex = 1;
            this.checkBoxExcludeImages.Text = "Exclude Images";
            this.checkBoxExcludeImages.UseVisualStyleBackColor = true;
            // 
            // checkBoxIncludeAllNonExcluded
            // 
            this.checkBoxIncludeAllNonExcluded.AutoSize = true;
            this.checkBoxIncludeAllNonExcluded.Enabled = false;
            this.checkBoxIncludeAllNonExcluded.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBoxIncludeAllNonExcluded.Location = new System.Drawing.Point(7, 20);
            this.checkBoxIncludeAllNonExcluded.Name = "checkBoxIncludeAllNonExcluded";
            this.checkBoxIncludeAllNonExcluded.Size = new System.Drawing.Size(145, 17);
            this.checkBoxIncludeAllNonExcluded.TabIndex = 0;
            this.checkBoxIncludeAllNonExcluded.Text = "Include All Non-Excluded";
            this.toolTipIncludeAllNonExcluded.SetToolTip(this.checkBoxIncludeAllNonExcluded, "Option allows file types not effected by selected options to be included in renam" +
        "ing.");
            this.checkBoxIncludeAllNonExcluded.UseVisualStyleBackColor = true;
            // 
            // checkBoxIncludeCurrentFolder
            // 
            this.checkBoxIncludeCurrentFolder.AutoSize = true;
            this.checkBoxIncludeCurrentFolder.Location = new System.Drawing.Point(7, 44);
            this.checkBoxIncludeCurrentFolder.Name = "checkBoxIncludeCurrentFolder";
            this.checkBoxIncludeCurrentFolder.Size = new System.Drawing.Size(130, 17);
            this.checkBoxIncludeCurrentFolder.TabIndex = 3;
            this.checkBoxIncludeCurrentFolder.Text = "Include Current Folder";
            this.checkBoxIncludeCurrentFolder.UseVisualStyleBackColor = true;
            // 
            // toolTipIncludeAllNonExcluded
            // 
            this.toolTipIncludeAllNonExcluded.ToolTipTitle = "Include All Non-Excluded";
            // 
            // toolTipExcludeSoftwareFiles
            // 
            this.toolTipExcludeSoftwareFiles.AutoPopDelay = 7000;
            this.toolTipExcludeSoftwareFiles.InitialDelay = 500;
            this.toolTipExcludeSoftwareFiles.ReshowDelay = 100;
            this.toolTipExcludeSoftwareFiles.ToolTipTitle = "Exclude Software Files";
            // 
            // textBoxFindFolder
            // 
            this.textBoxFindFolder.Location = new System.Drawing.Point(0, 4);
            this.textBoxFindFolder.MaxLength = 66;
            this.textBoxFindFolder.Name = "textBoxFindFolder";
            this.textBoxFindFolder.ReadOnly = true;
            this.textBoxFindFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxFindFolder.Size = new System.Drawing.Size(359, 20);
            this.textBoxFindFolder.TabIndex = 0;
            this.textBoxFindFolder.Text = "///Select folder via button -->///";
            this.textBoxFindFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonFindFolder
            // 
            this.buttonFindFolder.Location = new System.Drawing.Point(358, 3);
            this.buttonFindFolder.Name = "buttonFindFolder";
            this.buttonFindFolder.Size = new System.Drawing.Size(95, 22);
            this.buttonFindFolder.TabIndex = 1;
            this.buttonFindFolder.Text = "Find Folder";
            this.buttonFindFolder.UseVisualStyleBackColor = true;
            this.buttonFindFolder.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxFindFolder);
            this.panel1.Controls.Add(this.buttonFindFolder);
            this.panel1.Location = new System.Drawing.Point(22, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 27);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxCurrentFolderAndContents
            // 
            this.groupBoxCurrentFolderAndContents.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxCurrentFolderAndContents.Controls.Add(this.treeViewContentsOfSelected);
            this.groupBoxCurrentFolderAndContents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCurrentFolderAndContents.Location = new System.Drawing.Point(493, 56);
            this.groupBoxCurrentFolderAndContents.Name = "groupBoxCurrentFolderAndContents";
            this.groupBoxCurrentFolderAndContents.Size = new System.Drawing.Size(200, 249);
            this.groupBoxCurrentFolderAndContents.TabIndex = 7;
            this.groupBoxCurrentFolderAndContents.TabStop = false;
            this.groupBoxCurrentFolderAndContents.Text = "Current Folder and Contents";
            // 
            // treeViewContentsOfSelected
            // 
            this.treeViewContentsOfSelected.Location = new System.Drawing.Point(7, 20);
            this.treeViewContentsOfSelected.Name = "treeViewContentsOfSelected";
            this.treeViewContentsOfSelected.ShowPlusMinus = false;
            this.treeViewContentsOfSelected.Size = new System.Drawing.Size(187, 223);
            this.treeViewContentsOfSelected.StateImageList = this.imageListTreeView1;
            this.treeViewContentsOfSelected.TabIndex = 0;
            this.treeViewContentsOfSelected.TabStop = false;
            this.treeViewContentsOfSelected.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewContentsOfSelected_AfterSelect);
            // 
            // imageListTreeView1
            // 
            this.imageListTreeView1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeView1.ImageStream")));
            this.imageListTreeView1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTreeView1.Images.SetKeyName(0, "IconFolder.ico");
            this.imageListTreeView1.Images.SetKeyName(1, "IconFile.ico");
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.Enabled = false;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "Afrikaans",
            "Albanian",
            "Arabic",
            "Armenian",
            "Azerbaijani",
            "Basque",
            "Belarusion",
            "Bengali",
            "Bosnian",
            "Bulgarian",
            "Catalan",
            "Cebuano",
            "Chichewa",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Esperanto",
            "Estonian",
            "Filipino",
            "Finnish",
            "Galician",
            "Georgian",
            "/*place holder*/",
            "German",
            "Greek",
            "Gujarati ",
            "Haitian Creole",
            "Hausa",
            "Hebrew",
            "Hindi",
            "Hmong",
            "Hungarian",
            "Icelandic",
            "Igbo",
            "Indonesian",
            "Irish",
            "Italian",
            "Japanese",
            "Javanese",
            "Kannada",
            "Kazakh",
            "Khmer",
            "Korean",
            "Lao",
            "Latin",
            "Latvian",
            "Lithuanian",
            "Macedonian",
            "Malagasy",
            "Malay",
            "Malayalam",
            "Maltese",
            "Maori",
            "Marathi",
            "Mongolian",
            "Myanmar (Burmese)",
            "Nepali",
            "Norwegian",
            "Persian",
            "Polish",
            "Portuguese",
            "Punjabi ",
            "Romanian",
            "Russian",
            "Serbian",
            "Sesotho",
            "Sinhala",
            "Slovak",
            "Slovenian",
            "Somali",
            "Spanish",
            "Sundanese",
            "Swahili",
            "Swedish",
            "Tajik",
            "Tamil",
            "Telugu",
            "Thai",
            "Turkish",
            "Ukrainian",
            "Urdu",
            "Uzbek",
            "Vietnamese",
            "Welsh",
            "Yiddish",
            "Yoruba",
            "Zulu"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(565, 27);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxLanguage.Size = new System.Drawing.Size(128, 21);
            this.comboBoxLanguage.TabIndex = 6;
            this.comboBoxLanguage.Text = "*******Language*******";
            // 
            // pictureBoxLanguage
            // 
            this.pictureBoxLanguage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLanguage.Image")));
            this.pictureBoxLanguage.Location = new System.Drawing.Point(535, 28);
            this.pictureBoxLanguage.Name = "pictureBoxLanguage";
            this.pictureBoxLanguage.Size = new System.Drawing.Size(24, 18);
            this.pictureBoxLanguage.TabIndex = 17;
            this.pictureBoxLanguage.TabStop = false;
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.BackColor = System.Drawing.SystemColors.MenuText;
            this.labelNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotice.ForeColor = System.Drawing.Color.Red;
            this.labelNotice.Location = new System.Drawing.Point(19, 351);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(499, 18);
            this.labelNotice.TabIndex = 18;
            this.labelNotice.Text = "NOTICE: For saftey reasons, renaming is restricted to personal \'User\' files.";
            this.labelNotice.Visible = false;
            // 
            // FormRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 378);
            this.Controls.Add(this.labelNotice);
            this.Controls.Add(this.buttonConformFormat);
            this.Controls.Add(this.pictureBoxLanguage);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.groupBoxCurrentFolderAndContents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxInclusionExclusionRenamingOptions);
            this.Controls.Add(this.groupBoxFormatStyleFor);
            this.Controls.Add(this.tabControlFormatSettings);
            this.Controls.Add(this.buttonRename);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRenamer";
            this.Text = "Renamer";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            this.Load += new System.EventHandler(this.FormRenamer_Load);
            this.tabPageCapsStyle.ResumeLayout(false);
            this.tabPageCapsStyle.PerformLayout();
            this.tabPageSpacingStyle.ResumeLayout(false);
            this.tabPageSpacingStyle.PerformLayout();
            this.tabControlFormatSettings.ResumeLayout(false);
            this.groupBoxFormatStyleFor.ResumeLayout(false);
            this.groupBoxFormatStyleFor.PerformLayout();
            this.groupBoxInclusionExclusionRenamingOptions.ResumeLayout(false);
            this.groupBoxInclusionExclusionRenamingOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxCurrentFolderAndContents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.TabPage tabPageCapsStyle;
        private System.Windows.Forms.TabPage tabPageSpacingStyle;
        private System.Windows.Forms.TabControl tabControlFormatSettings;
        private System.Windows.Forms.RadioButton radioButtonFolders;
        private System.Windows.Forms.RadioButton radioButtonFiles;
        private System.Windows.Forms.GroupBox groupBoxFormatStyleFor;
        private System.Windows.Forms.GroupBox groupBoxInclusionExclusionRenamingOptions;
        private System.Windows.Forms.CheckBox checkBoxIncludeAllNonExcluded;
        public System.Windows.Forms.RadioButton radioButtonNormalSpacing;
        public System.Windows.Forms.RadioButton radioButtonNoSpacing;
        public System.Windows.Forms.RadioButton radioButtonUnderScoreSpacing;
        public System.Windows.Forms.RadioButton radioButtonFirstLetterCaps;
        public System.Windows.Forms.RadioButton radioButtonCammelCase;
        public System.Windows.Forms.RadioButton radioButtonAllLowerCase;
        private System.Windows.Forms.Label labelUnderLine2;
        private System.Windows.Forms.Label labelUnderLine1;
        private System.Windows.Forms.CheckBox checkBoxExcludeImages;
        private System.Windows.Forms.CheckBox checkBoxIncludeSoftware;
        private System.Windows.Forms.ToolTip toolTipIncludeAllNonExcluded;
        private System.Windows.Forms.ToolTip toolTipExcludeSoftwareFiles;
        private System.Windows.Forms.TextBox textBoxFindFolder;
        private System.Windows.Forms.Button buttonFindFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxCurrentFolderAndContents;
        private System.Windows.Forms.TreeView treeViewContentsOfSelected;
        private System.Windows.Forms.Button buttonConformFormat;
        protected internal System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageListTreeView1;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.PictureBox pictureBoxLanguage;
        private System.Windows.Forms.CheckBox checkBoxIncludeCurrentFolder;
        private System.Windows.Forms.CheckBox checkBoxExcludeFolders;
        private System.Windows.Forms.CheckBox checkBoxExcludeDocuments;
        private System.Windows.Forms.Label labelNotice;
    }
}

