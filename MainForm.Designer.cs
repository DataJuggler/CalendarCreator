namespace CalendarCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CreateCalendarButton = new DataJuggler.Win.Controls.Button();
            FolderPicker = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            MonthPicker = new DataJuggler.Win.Controls.LabelComboBoxControl();
            YearControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            Graph = new ProgressBar();
            StatusLabel = new Label();
            Canvas = new PictureBox();
            SaveToDiskCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            BackgroundImagePicker = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            HeaderIimagePicker = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            InfoLabel = new Label();
            InfoLabel2 = new Label();
            BaseColorComboBox = new DataJuggler.Win.Controls.LabelComboBoxControl();
            HiddenButton = new DataJuggler.Win.Controls.Button();
            HeaderColorComboBox = new DataJuggler.Win.Controls.LabelComboBoxControl();
            HeaderFontComboBox = new DataJuggler.Win.Controls.LabelComboBoxControl();
            BaseFontComboBox = new DataJuggler.Win.Controls.LabelComboBoxControl();
            HeaderFontSizeControl = new DataJuggler.Win.Controls.LabelComboBoxControl();
            BaseFontSizeControl = new DataJuggler.Win.Controls.LabelComboBoxControl();
            InfoLabel3 = new Label();
            DayRowImage = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            label1 = new Label();
            BoldCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            HeaderBoldCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            SuspendLayout();
            // 
            // CreateCalendarButton
            // 
            CreateCalendarButton.BackColor = Color.Transparent;
            CreateCalendarButton.ButtonText = "Create Calendar";
            CreateCalendarButton.FlatStyle = FlatStyle.Flat;
            CreateCalendarButton.ForeColor = Color.LemonChiffon;
            CreateCalendarButton.Location = new Point(780, 327);
            CreateCalendarButton.Margin = new Padding(4);
            CreateCalendarButton.Name = "CreateCalendarButton";
            CreateCalendarButton.Size = new Size(179, 53);
            CreateCalendarButton.TabIndex = 0;
            CreateCalendarButton.TabStop = false;
            CreateCalendarButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            CreateCalendarButton.Click += CreateCalendarButton_Click;
            // 
            // FolderPicker
            // 
            FolderPicker.BackColor = Color.Transparent;
            FolderPicker.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            FolderPicker.ButtonColor = Color.LemonChiffon;
            FolderPicker.ButtonImage = (Image)resources.GetObject("FolderPicker.ButtonImage");
            FolderPicker.ButtonWidth = 48;
            FolderPicker.DarkMode = false;
            FolderPicker.DisabledLabelColor = Color.Empty;
            FolderPicker.Editable = true;
            FolderPicker.EnabledLabelColor = Color.Empty;
            FolderPicker.Filter = null;
            FolderPicker.Font = new Font("Verdana", 12F);
            FolderPicker.HideBrowseButton = false;
            FolderPicker.LabelBottomMargin = 0;
            FolderPicker.LabelColor = Color.LemonChiffon;
            FolderPicker.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            FolderPicker.LabelText = "Output Folder:";
            FolderPicker.LabelTopMargin = 0;
            FolderPicker.LabelWidth = 140;
            FolderPicker.Location = new Point(24, 38);
            FolderPicker.Name = "FolderPicker";
            FolderPicker.OnTextChangedListener = null;
            FolderPicker.OpenCallback = null;
            FolderPicker.ScrollBars = ScrollBars.None;
            FolderPicker.SelectedPath = null;
            FolderPicker.Size = new Size(935, 32);
            FolderPicker.StartPath = null;
            FolderPicker.TabIndex = 0;
            FolderPicker.TextBoxBottomMargin = 0;
            FolderPicker.TextBoxDisabledColor = Color.Empty;
            FolderPicker.TextBoxEditableColor = Color.Empty;
            FolderPicker.TextBoxFont = new Font("Verdana", 12F);
            FolderPicker.TextBoxTopMargin = 0;
            FolderPicker.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MonthPicker
            // 
            MonthPicker.BackColor = Color.Transparent;
            MonthPicker.ComboBoxLeftMargin = 1;
            MonthPicker.ComboBoxText = "";
            MonthPicker.ComoboBoxFont = null;
            MonthPicker.Editable = true;
            MonthPicker.Font = new Font("Verdana", 12F);
            MonthPicker.HideLabel = false;
            MonthPicker.LabelBottomMargin = 0;
            MonthPicker.LabelColor = Color.LemonChiffon;
            MonthPicker.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            MonthPicker.LabelText = "Month:";
            MonthPicker.LabelTopMargin = 0;
            MonthPicker.LabelWidth = 112;
            MonthPicker.List = null;
            MonthPicker.Location = new Point(51, 352);
            MonthPicker.Name = "MonthPicker";
            MonthPicker.SelectedIndex = -1;
            MonthPicker.SelectedIndexListener = null;
            MonthPicker.Size = new Size(299, 28);
            MonthPicker.Sorted = false;
            MonthPicker.Source = null;
            MonthPicker.TabIndex = 10;
            MonthPicker.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // YearControl
            // 
            YearControl.BackColor = Color.Transparent;
            YearControl.BottomMargin = 0;
            YearControl.Editable = true;
            YearControl.Encrypted = false;
            YearControl.Font = new Font("Verdana", 12F, FontStyle.Bold);
            YearControl.Inititialized = true;
            YearControl.LabelBottomMargin = 0;
            YearControl.LabelColor = Color.LemonChiffon;
            YearControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            YearControl.LabelText = "Year:";
            YearControl.LabelTopMargin = 0;
            YearControl.LabelWidth = 140;
            YearControl.Location = new Point(447, 352);
            YearControl.MultiLine = false;
            YearControl.Name = "YearControl";
            YearControl.OnTextChangedListener = null;
            YearControl.PasswordMode = false;
            YearControl.ScrollBars = ScrollBars.None;
            YearControl.Size = new Size(299, 28);
            YearControl.TabIndex = 11;
            YearControl.TextBoxBottomMargin = 0;
            YearControl.TextBoxDisabledColor = Color.LightGray;
            YearControl.TextBoxEditableColor = Color.White;
            YearControl.TextBoxFont = new Font("Verdana", 12F);
            YearControl.TextBoxTopMargin = 0;
            YearControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // Graph
            // 
            Graph.Location = new Point(24, 763);
            Graph.Name = "Graph";
            Graph.Size = new Size(935, 23);
            Graph.TabIndex = 4;
            Graph.Visible = false;
            // 
            // StatusLabel
            // 
            StatusLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StatusLabel.ForeColor = Color.LemonChiffon;
            StatusLabel.Location = new Point(24, 736);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(935, 23);
            StatusLabel.TabIndex = 5;
            StatusLabel.Text = "Status:";
            // 
            // Canvas
            // 
            Canvas.BackgroundImage = Properties.Resources.Blank;
            Canvas.BackgroundImageLayout = ImageLayout.Stretch;
            Canvas.Location = new Point(211, 402);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(560, 320);
            Canvas.TabIndex = 6;
            Canvas.TabStop = false;
            // 
            // SaveToDiskCheckBox
            // 
            SaveToDiskCheckBox.BackColor = Color.Transparent;
            SaveToDiskCheckBox.CheckBoxHorizontalOffSet = 0;
            SaveToDiskCheckBox.CheckBoxVerticalOffSet = 3;
            SaveToDiskCheckBox.CheckChangedListener = null;
            SaveToDiskCheckBox.Checked = false;
            SaveToDiskCheckBox.Editable = true;
            SaveToDiskCheckBox.Font = new Font("Verdana", 12F);
            SaveToDiskCheckBox.LabelColor = Color.LemonChiffon;
            SaveToDiskCheckBox.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            SaveToDiskCheckBox.LabelText = "Save To Disk:";
            SaveToDiskCheckBox.LabelWidth = 140;
            SaveToDiskCheckBox.Location = new Point(24, 4);
            SaveToDiskCheckBox.Name = "SaveToDiskCheckBox";
            SaveToDiskCheckBox.Size = new Size(160, 28);
            SaveToDiskCheckBox.TabIndex = 7;
            SaveToDiskCheckBox.TabStop = false;
            SaveToDiskCheckBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // BackgroundImagePicker
            // 
            BackgroundImagePicker.BackColor = Color.Transparent;
            BackgroundImagePicker.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            BackgroundImagePicker.ButtonColor = Color.LemonChiffon;
            BackgroundImagePicker.ButtonImage = (Image)resources.GetObject("BackgroundImagePicker.ButtonImage");
            BackgroundImagePicker.ButtonWidth = 48;
            BackgroundImagePicker.DarkMode = false;
            BackgroundImagePicker.DisabledLabelColor = Color.Empty;
            BackgroundImagePicker.Editable = true;
            BackgroundImagePicker.EnabledLabelColor = Color.Empty;
            BackgroundImagePicker.Filter = null;
            BackgroundImagePicker.Font = new Font("Verdana", 12F);
            BackgroundImagePicker.HideBrowseButton = false;
            BackgroundImagePicker.LabelBottomMargin = 0;
            BackgroundImagePicker.LabelColor = Color.LemonChiffon;
            BackgroundImagePicker.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            BackgroundImagePicker.LabelText = "Background:";
            BackgroundImagePicker.LabelTopMargin = 0;
            BackgroundImagePicker.LabelWidth = 140;
            BackgroundImagePicker.Location = new Point(24, 85);
            BackgroundImagePicker.Name = "BackgroundImagePicker";
            BackgroundImagePicker.OnTextChangedListener = null;
            BackgroundImagePicker.OpenCallback = null;
            BackgroundImagePicker.ScrollBars = ScrollBars.None;
            BackgroundImagePicker.SelectedPath = null;
            BackgroundImagePicker.Size = new Size(935, 32);
            BackgroundImagePicker.StartPath = null;
            BackgroundImagePicker.TabIndex = 1;
            BackgroundImagePicker.TextBoxBottomMargin = 0;
            BackgroundImagePicker.TextBoxDisabledColor = Color.Empty;
            BackgroundImagePicker.TextBoxEditableColor = Color.Empty;
            BackgroundImagePicker.TextBoxFont = new Font("Verdana", 12F);
            BackgroundImagePicker.TextBoxTopMargin = 0;
            BackgroundImagePicker.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // HeaderIimagePicker
            // 
            HeaderIimagePicker.BackColor = Color.Transparent;
            HeaderIimagePicker.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            HeaderIimagePicker.ButtonColor = Color.LemonChiffon;
            HeaderIimagePicker.ButtonImage = (Image)resources.GetObject("HeaderIimagePicker.ButtonImage");
            HeaderIimagePicker.ButtonWidth = 48;
            HeaderIimagePicker.DarkMode = false;
            HeaderIimagePicker.DisabledLabelColor = Color.Empty;
            HeaderIimagePicker.Editable = true;
            HeaderIimagePicker.EnabledLabelColor = Color.Empty;
            HeaderIimagePicker.Filter = null;
            HeaderIimagePicker.Font = new Font("Verdana", 12F);
            HeaderIimagePicker.HideBrowseButton = false;
            HeaderIimagePicker.LabelBottomMargin = 0;
            HeaderIimagePicker.LabelColor = Color.LemonChiffon;
            HeaderIimagePicker.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            HeaderIimagePicker.LabelText = "Header:";
            HeaderIimagePicker.LabelTopMargin = 0;
            HeaderIimagePicker.LabelWidth = 140;
            HeaderIimagePicker.Location = new Point(24, 132);
            HeaderIimagePicker.Name = "HeaderIimagePicker";
            HeaderIimagePicker.OnTextChangedListener = null;
            HeaderIimagePicker.OpenCallback = null;
            HeaderIimagePicker.ScrollBars = ScrollBars.None;
            HeaderIimagePicker.SelectedPath = null;
            HeaderIimagePicker.Size = new Size(935, 32);
            HeaderIimagePicker.StartPath = null;
            HeaderIimagePicker.TabIndex = 2;
            HeaderIimagePicker.TextBoxBottomMargin = 0;
            HeaderIimagePicker.TextBoxDisabledColor = Color.Empty;
            HeaderIimagePicker.TextBoxEditableColor = Color.Empty;
            HeaderIimagePicker.TextBoxFont = new Font("Verdana", 12F);
            HeaderIimagePicker.TextBoxTopMargin = 0;
            HeaderIimagePicker.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // InfoLabel
            // 
            InfoLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InfoLabel.ForeColor = Color.LemonChiffon;
            InfoLabel.Location = new Point(408, 69);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(167, 16);
            InfoLabel.TabIndex = 10;
            InfoLabel.Text = "1120 x 740";
            InfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InfoLabel2
            // 
            InfoLabel2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InfoLabel2.ForeColor = Color.LemonChiffon;
            InfoLabel2.Location = new Point(408, 115);
            InfoLabel2.Name = "InfoLabel2";
            InfoLabel2.Size = new Size(167, 16);
            InfoLabel2.TabIndex = 11;
            InfoLabel2.Text = "1120 x 80";
            InfoLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BaseColorComboBox
            // 
            BaseColorComboBox.BackColor = Color.Transparent;
            BaseColorComboBox.ComboBoxLeftMargin = 1;
            BaseColorComboBox.ComboBoxText = "";
            BaseColorComboBox.ComoboBoxFont = null;
            BaseColorComboBox.Editable = true;
            BaseColorComboBox.Font = new Font("Verdana", 12F);
            BaseColorComboBox.HideLabel = false;
            BaseColorComboBox.LabelBottomMargin = 0;
            BaseColorComboBox.LabelColor = Color.LemonChiffon;
            BaseColorComboBox.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            BaseColorComboBox.LabelText = "Base Color:";
            BaseColorComboBox.LabelTopMargin = 0;
            BaseColorComboBox.LabelWidth = 112;
            BaseColorComboBox.List = null;
            BaseColorComboBox.Location = new Point(51, 226);
            BaseColorComboBox.Name = "BaseColorComboBox";
            BaseColorComboBox.SelectedIndex = -1;
            BaseColorComboBox.SelectedIndexListener = null;
            BaseColorComboBox.Size = new Size(299, 28);
            BaseColorComboBox.Sorted = false;
            BaseColorComboBox.Source = null;
            BaseColorComboBox.TabIndex = 4;
            BaseColorComboBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // HiddenButton
            // 
            HiddenButton.BackColor = Color.Transparent;
            HiddenButton.ButtonText = "Hidden";
            HiddenButton.FlatStyle = FlatStyle.Flat;
            HiddenButton.ForeColor = Color.LemonChiffon;
            HiddenButton.Location = new Point(-641, 346);
            HiddenButton.Margin = new Padding(4);
            HiddenButton.Name = "HiddenButton";
            HiddenButton.Size = new Size(179, 53);
            HiddenButton.TabIndex = 14;
            HiddenButton.TabStop = false;
            HiddenButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // HeaderColorComboBox
            // 
            HeaderColorComboBox.BackColor = Color.Transparent;
            HeaderColorComboBox.ComboBoxLeftMargin = 1;
            HeaderColorComboBox.ComboBoxText = "";
            HeaderColorComboBox.ComoboBoxFont = null;
            HeaderColorComboBox.Editable = true;
            HeaderColorComboBox.Font = new Font("Verdana", 12F);
            HeaderColorComboBox.HideLabel = false;
            HeaderColorComboBox.LabelBottomMargin = 0;
            HeaderColorComboBox.LabelColor = Color.LemonChiffon;
            HeaderColorComboBox.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            HeaderColorComboBox.LabelText = "Header Color:";
            HeaderColorComboBox.LabelTopMargin = 0;
            HeaderColorComboBox.LabelWidth = 140;
            HeaderColorComboBox.List = null;
            HeaderColorComboBox.Location = new Point(447, 226);
            HeaderColorComboBox.Name = "HeaderColorComboBox";
            HeaderColorComboBox.SelectedIndex = -1;
            HeaderColorComboBox.SelectedIndexListener = null;
            HeaderColorComboBox.Size = new Size(299, 28);
            HeaderColorComboBox.Sorted = false;
            HeaderColorComboBox.Source = null;
            HeaderColorComboBox.TabIndex = 5;
            HeaderColorComboBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // HeaderFontComboBox
            // 
            HeaderFontComboBox.BackColor = Color.Transparent;
            HeaderFontComboBox.ComboBoxLeftMargin = 1;
            HeaderFontComboBox.ComboBoxText = "";
            HeaderFontComboBox.ComoboBoxFont = null;
            HeaderFontComboBox.Editable = true;
            HeaderFontComboBox.Font = new Font("Verdana", 12F);
            HeaderFontComboBox.HideLabel = false;
            HeaderFontComboBox.LabelBottomMargin = 0;
            HeaderFontComboBox.LabelColor = Color.LemonChiffon;
            HeaderFontComboBox.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            HeaderFontComboBox.LabelText = "Header Font:";
            HeaderFontComboBox.LabelTopMargin = 0;
            HeaderFontComboBox.LabelWidth = 140;
            HeaderFontComboBox.List = null;
            HeaderFontComboBox.Location = new Point(447, 268);
            HeaderFontComboBox.Name = "HeaderFontComboBox";
            HeaderFontComboBox.SelectedIndex = -1;
            HeaderFontComboBox.SelectedIndexListener = null;
            HeaderFontComboBox.Size = new Size(299, 28);
            HeaderFontComboBox.Sorted = false;
            HeaderFontComboBox.Source = null;
            HeaderFontComboBox.TabIndex = 7;
            HeaderFontComboBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // BaseFontComboBox
            // 
            BaseFontComboBox.BackColor = Color.Transparent;
            BaseFontComboBox.ComboBoxLeftMargin = 1;
            BaseFontComboBox.ComboBoxText = "";
            BaseFontComboBox.ComoboBoxFont = null;
            BaseFontComboBox.Editable = true;
            BaseFontComboBox.Font = new Font("Verdana", 12F);
            BaseFontComboBox.HideLabel = false;
            BaseFontComboBox.LabelBottomMargin = 0;
            BaseFontComboBox.LabelColor = Color.LemonChiffon;
            BaseFontComboBox.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            BaseFontComboBox.LabelText = "Base Font:";
            BaseFontComboBox.LabelTopMargin = 0;
            BaseFontComboBox.LabelWidth = 112;
            BaseFontComboBox.List = null;
            BaseFontComboBox.Location = new Point(51, 268);
            BaseFontComboBox.Name = "BaseFontComboBox";
            BaseFontComboBox.SelectedIndex = -1;
            BaseFontComboBox.SelectedIndexListener = null;
            BaseFontComboBox.Size = new Size(299, 28);
            BaseFontComboBox.Sorted = false;
            BaseFontComboBox.Source = null;
            BaseFontComboBox.TabIndex = 6;
            BaseFontComboBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // HeaderFontSizeControl
            // 
            HeaderFontSizeControl.BackColor = Color.Transparent;
            HeaderFontSizeControl.ComboBoxLeftMargin = 1;
            HeaderFontSizeControl.ComboBoxText = "";
            HeaderFontSizeControl.ComoboBoxFont = null;
            HeaderFontSizeControl.Editable = true;
            HeaderFontSizeControl.Font = new Font("Verdana", 12F);
            HeaderFontSizeControl.HideLabel = false;
            HeaderFontSizeControl.LabelBottomMargin = 0;
            HeaderFontSizeControl.LabelColor = Color.LemonChiffon;
            HeaderFontSizeControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            HeaderFontSizeControl.LabelText = "Font Size:";
            HeaderFontSizeControl.LabelTopMargin = 0;
            HeaderFontSizeControl.LabelWidth = 140;
            HeaderFontSizeControl.List = null;
            HeaderFontSizeControl.Location = new Point(447, 310);
            HeaderFontSizeControl.Name = "HeaderFontSizeControl";
            HeaderFontSizeControl.SelectedIndex = -1;
            HeaderFontSizeControl.SelectedIndexListener = null;
            HeaderFontSizeControl.Size = new Size(299, 28);
            HeaderFontSizeControl.Sorted = false;
            HeaderFontSizeControl.Source = null;
            HeaderFontSizeControl.TabIndex = 9;
            HeaderFontSizeControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // BaseFontSizeControl
            // 
            BaseFontSizeControl.BackColor = Color.Transparent;
            BaseFontSizeControl.ComboBoxLeftMargin = 1;
            BaseFontSizeControl.ComboBoxText = "";
            BaseFontSizeControl.ComoboBoxFont = null;
            BaseFontSizeControl.Editable = true;
            BaseFontSizeControl.Font = new Font("Verdana", 12F);
            BaseFontSizeControl.HideLabel = false;
            BaseFontSizeControl.LabelBottomMargin = 0;
            BaseFontSizeControl.LabelColor = Color.LemonChiffon;
            BaseFontSizeControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            BaseFontSizeControl.LabelText = "Font Size:";
            BaseFontSizeControl.LabelTopMargin = 0;
            BaseFontSizeControl.LabelWidth = 112;
            BaseFontSizeControl.List = null;
            BaseFontSizeControl.Location = new Point(51, 310);
            BaseFontSizeControl.Name = "BaseFontSizeControl";
            BaseFontSizeControl.SelectedIndex = -1;
            BaseFontSizeControl.SelectedIndexListener = null;
            BaseFontSizeControl.Size = new Size(299, 28);
            BaseFontSizeControl.Sorted = false;
            BaseFontSizeControl.Source = null;
            BaseFontSizeControl.TabIndex = 8;
            BaseFontSizeControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // InfoLabel3
            // 
            InfoLabel3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InfoLabel3.ForeColor = Color.LemonChiffon;
            InfoLabel3.Location = new Point(408, 163);
            InfoLabel3.Name = "InfoLabel3";
            InfoLabel3.Size = new Size(167, 16);
            InfoLabel3.TabIndex = 21;
            InfoLabel3.Text = "1120 x 60";
            InfoLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DayRowImage
            // 
            DayRowImage.BackColor = Color.Transparent;
            DayRowImage.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            DayRowImage.ButtonColor = Color.LemonChiffon;
            DayRowImage.ButtonImage = (Image)resources.GetObject("DayRowImage.ButtonImage");
            DayRowImage.ButtonWidth = 48;
            DayRowImage.DarkMode = false;
            DayRowImage.DisabledLabelColor = Color.Empty;
            DayRowImage.Editable = true;
            DayRowImage.EnabledLabelColor = Color.Empty;
            DayRowImage.Filter = null;
            DayRowImage.Font = new Font("Verdana", 12F);
            DayRowImage.HideBrowseButton = false;
            DayRowImage.LabelBottomMargin = 0;
            DayRowImage.LabelColor = Color.LemonChiffon;
            DayRowImage.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            DayRowImage.LabelText = "Day Row:";
            DayRowImage.LabelTopMargin = 0;
            DayRowImage.LabelWidth = 140;
            DayRowImage.Location = new Point(24, 179);
            DayRowImage.Name = "DayRowImage";
            DayRowImage.OnTextChangedListener = null;
            DayRowImage.OpenCallback = null;
            DayRowImage.ScrollBars = ScrollBars.None;
            DayRowImage.SelectedPath = null;
            DayRowImage.Size = new Size(935, 32);
            DayRowImage.StartPath = null;
            DayRowImage.TabIndex = 3;
            DayRowImage.TextBoxBottomMargin = 0;
            DayRowImage.TextBoxDisabledColor = Color.Empty;
            DayRowImage.TextBoxEditableColor = Color.Empty;
            DayRowImage.TextBoxFont = new Font("Verdana", 12F);
            DayRowImage.TextBoxTopMargin = 0;
            DayRowImage.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LemonChiffon;
            label1.Location = new Point(530, 162);
            label1.Name = "label1";
            label1.Size = new Size(72, 16);
            label1.TabIndex = 22;
            label1.Text = "Optional";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BoldCheckBox
            // 
            BoldCheckBox.BackColor = Color.Transparent;
            BoldCheckBox.CheckBoxHorizontalOffSet = 0;
            BoldCheckBox.CheckBoxVerticalOffSet = 3;
            BoldCheckBox.CheckChangedListener = null;
            BoldCheckBox.Checked = false;
            BoldCheckBox.Editable = true;
            BoldCheckBox.Font = new Font("Verdana", 12F);
            BoldCheckBox.LabelColor = Color.LemonChiffon;
            BoldCheckBox.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            BoldCheckBox.LabelText = "Bold:";
            BoldCheckBox.LabelWidth = 60;
            BoldCheckBox.Location = new Point(348, 268);
            BoldCheckBox.Name = "BoldCheckBox";
            BoldCheckBox.Size = new Size(80, 28);
            BoldCheckBox.TabIndex = 23;
            BoldCheckBox.TabStop = false;
            BoldCheckBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // HeaderBoldCheckBox
            // 
            HeaderBoldCheckBox.BackColor = Color.Transparent;
            HeaderBoldCheckBox.CheckBoxHorizontalOffSet = 0;
            HeaderBoldCheckBox.CheckBoxVerticalOffSet = 3;
            HeaderBoldCheckBox.CheckChangedListener = null;
            HeaderBoldCheckBox.Checked = false;
            HeaderBoldCheckBox.Editable = true;
            HeaderBoldCheckBox.Font = new Font("Verdana", 12F);
            HeaderBoldCheckBox.LabelColor = Color.LemonChiffon;
            HeaderBoldCheckBox.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            HeaderBoldCheckBox.LabelText = "Bold:";
            HeaderBoldCheckBox.LabelWidth = 60;
            HeaderBoldCheckBox.Location = new Point(744, 268);
            HeaderBoldCheckBox.Name = "HeaderBoldCheckBox";
            HeaderBoldCheckBox.Size = new Size(80, 28);
            HeaderBoldCheckBox.TabIndex = 24;
            HeaderBoldCheckBox.TabStop = false;
            HeaderBoldCheckBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(991, 798);
            Controls.Add(HeaderBoldCheckBox);
            Controls.Add(BoldCheckBox);
            Controls.Add(label1);
            Controls.Add(InfoLabel3);
            Controls.Add(DayRowImage);
            Controls.Add(HeaderFontSizeControl);
            Controls.Add(BaseFontSizeControl);
            Controls.Add(HeaderFontComboBox);
            Controls.Add(BaseFontComboBox);
            Controls.Add(HeaderColorComboBox);
            Controls.Add(HiddenButton);
            Controls.Add(BaseColorComboBox);
            Controls.Add(InfoLabel2);
            Controls.Add(InfoLabel);
            Controls.Add(HeaderIimagePicker);
            Controls.Add(BackgroundImagePicker);
            Controls.Add(SaveToDiskCheckBox);
            Controls.Add(Canvas);
            Controls.Add(StatusLabel);
            Controls.Add(Graph);
            Controls.Add(YearControl);
            Controls.Add(MonthPicker);
            Controls.Add(FolderPicker);
            Controls.Add(CreateCalendarButton);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calendar Creator";
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataJuggler.Win.Controls.Button CreateCalendarButton;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl FolderPicker;
        private DataJuggler.Win.Controls.LabelComboBoxControl MonthPicker;
        private DataJuggler.Win.Controls.LabelTextBoxControl YearControl;
        private ProgressBar Graph;
        private Label StatusLabel;
        private PictureBox Canvas;
        private DataJuggler.Win.Controls.LabelCheckBoxControl SaveToDiskCheckBox;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl BackgroundImagePicker;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl HeaderIimagePicker;
        private Label InfoLabel;
        private Label InfoLabel2;
        private DataJuggler.Win.Controls.LabelComboBoxControl BaseColorComboBox;
        private DataJuggler.Win.Controls.Button HiddenButton;
        private DataJuggler.Win.Controls.LabelComboBoxControl HeaderColorComboBox;
        private DataJuggler.Win.Controls.LabelComboBoxControl HeaderFontComboBox;
        private DataJuggler.Win.Controls.LabelComboBoxControl BaseFontComboBox;
        private DataJuggler.Win.Controls.LabelComboBoxControl HeaderFontSizeControl;
        private DataJuggler.Win.Controls.LabelComboBoxControl BaseFontSizeControl;
        private Label InfoLabel3;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl DayRowImage;
        private Label label1;
        private DataJuggler.Win.Controls.LabelCheckBoxControl BoldCheckBox;
        private DataJuggler.Win.Controls.LabelCheckBoxControl HeaderBoldCheckBox;
    }
}
