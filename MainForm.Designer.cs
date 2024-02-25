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
            BaseColor = new DataJuggler.Win.Controls.LabelComboBoxControl();
            HiddenButton = new DataJuggler.Win.Controls.Button();
            HeaderColor = new DataJuggler.Win.Controls.LabelComboBoxControl();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            SuspendLayout();
            // 
            // CreateCalendarButton
            // 
            CreateCalendarButton.BackColor = Color.Transparent;
            CreateCalendarButton.ButtonText = "Create Calendar";
            CreateCalendarButton.FlatStyle = FlatStyle.Flat;
            CreateCalendarButton.ForeColor = Color.LemonChiffon;
            CreateCalendarButton.Location = new Point(641, 262);
            CreateCalendarButton.Margin = new Padding(4);
            CreateCalendarButton.Name = "CreateCalendarButton";
            CreateCalendarButton.Size = new Size(179, 53);
            CreateCalendarButton.TabIndex = 0;
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
            FolderPicker.Location = new Point(24, 59);
            FolderPicker.Name = "FolderPicker";
            FolderPicker.OnTextChangedListener = null;
            FolderPicker.OpenCallback = null;
            FolderPicker.ScrollBars = ScrollBars.None;
            FolderPicker.SelectedPath = null;
            FolderPicker.Size = new Size(712, 32);
            FolderPicker.StartPath = null;
            FolderPicker.TabIndex = 1;
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
            MonthPicker.Location = new Point(24, 287);
            MonthPicker.Name = "MonthPicker";
            MonthPicker.SelectedIndex = -1;
            MonthPicker.SelectedIndexListener = null;
            MonthPicker.Size = new Size(299, 28);
            MonthPicker.Sorted = false;
            MonthPicker.Source = null;
            MonthPicker.TabIndex = 2;
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
            YearControl.Location = new Point(329, 287);
            YearControl.MultiLine = false;
            YearControl.Name = "YearControl";
            YearControl.OnTextChangedListener = null;
            YearControl.PasswordMode = false;
            YearControl.ScrollBars = ScrollBars.None;
            YearControl.Size = new Size(294, 28);
            YearControl.TabIndex = 3;
            YearControl.TextBoxBottomMargin = 0;
            YearControl.TextBoxDisabledColor = Color.LightGray;
            YearControl.TextBoxEditableColor = Color.White;
            YearControl.TextBoxFont = new Font("Verdana", 12F);
            YearControl.TextBoxTopMargin = 0;
            YearControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // Graph
            // 
            Graph.Location = new Point(24, 754);
            Graph.Name = "Graph";
            Graph.Size = new Size(815, 23);
            Graph.TabIndex = 4;
            Graph.Visible = false;
            // 
            // StatusLabel
            // 
            StatusLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StatusLabel.ForeColor = Color.LemonChiffon;
            StatusLabel.Location = new Point(24, 728);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(832, 23);
            StatusLabel.TabIndex = 5;
            StatusLabel.Text = "Status:";
            // 
            // Canvas
            // 
            Canvas.BackgroundImage = Properties.Resources.Blank;
            Canvas.BackgroundImageLayout = ImageLayout.Stretch;
            Canvas.Location = new Point(121, 380);
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
            SaveToDiskCheckBox.Location = new Point(24, 16);
            SaveToDiskCheckBox.Name = "SaveToDiskCheckBox";
            SaveToDiskCheckBox.Size = new Size(160, 28);
            SaveToDiskCheckBox.TabIndex = 7;
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
            BackgroundImagePicker.Location = new Point(24, 122);
            BackgroundImagePicker.Name = "BackgroundImagePicker";
            BackgroundImagePicker.OnTextChangedListener = null;
            BackgroundImagePicker.OpenCallback = null;
            BackgroundImagePicker.ScrollBars = ScrollBars.None;
            BackgroundImagePicker.SelectedPath = null;
            BackgroundImagePicker.Size = new Size(712, 32);
            BackgroundImagePicker.StartPath = null;
            BackgroundImagePicker.TabIndex = 8;
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
            HeaderIimagePicker.Location = new Point(24, 176);
            HeaderIimagePicker.Name = "HeaderIimagePicker";
            HeaderIimagePicker.OnTextChangedListener = null;
            HeaderIimagePicker.OpenCallback = null;
            HeaderIimagePicker.ScrollBars = ScrollBars.None;
            HeaderIimagePicker.SelectedPath = null;
            HeaderIimagePicker.Size = new Size(712, 32);
            HeaderIimagePicker.StartPath = null;
            HeaderIimagePicker.TabIndex = 9;
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
            InfoLabel.Location = new Point(279, 103);
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
            InfoLabel2.Location = new Point(279, 157);
            InfoLabel2.Name = "InfoLabel2";
            InfoLabel2.Size = new Size(167, 16);
            InfoLabel2.TabIndex = 11;
            InfoLabel2.Text = "1120 x 80";
            InfoLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BaseColor
            // 
            BaseColor.BackColor = Color.Transparent;
            BaseColor.ComboBoxLeftMargin = 1;
            BaseColor.ComboBoxText = "";
            BaseColor.ComoboBoxFont = null;
            BaseColor.Editable = true;
            BaseColor.Font = new Font("Verdana", 12F);
            BaseColor.HideLabel = false;
            BaseColor.LabelBottomMargin = 0;
            BaseColor.LabelColor = Color.LemonChiffon;
            BaseColor.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            BaseColor.LabelText = "Base Color:";
            BaseColor.LabelTopMargin = 0;
            BaseColor.LabelWidth = 112;
            BaseColor.List = null;
            BaseColor.Location = new Point(24, 231);
            BaseColor.Name = "BaseColor";
            BaseColor.SelectedIndex = -1;
            BaseColor.SelectedIndexListener = null;
            BaseColor.Size = new Size(299, 28);
            BaseColor.Sorted = false;
            BaseColor.Source = null;
            BaseColor.TabIndex = 12;
            BaseColor.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // HiddenButton
            // 
            HiddenButton.BackColor = Color.Transparent;
            HiddenButton.ButtonText = "Hidden";
            HiddenButton.FlatStyle = FlatStyle.Flat;
            HiddenButton.ForeColor = Color.LemonChiffon;
            HiddenButton.Location = new Point(-641, 345);
            HiddenButton.Margin = new Padding(4);
            HiddenButton.Name = "HiddenButton";
            HiddenButton.Size = new Size(179, 53);
            HiddenButton.TabIndex = 14;
            HiddenButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // HeaderColor
            // 
            HeaderColor.BackColor = Color.Transparent;
            HeaderColor.ComboBoxLeftMargin = 1;
            HeaderColor.ComboBoxText = "";
            HeaderColor.ComoboBoxFont = null;
            HeaderColor.Editable = true;
            HeaderColor.Font = new Font("Verdana", 12F);
            HeaderColor.HideLabel = false;
            HeaderColor.LabelBottomMargin = 0;
            HeaderColor.LabelColor = Color.LemonChiffon;
            HeaderColor.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            HeaderColor.LabelText = "Header Color:";
            HeaderColor.LabelTopMargin = 0;
            HeaderColor.LabelWidth = 140;
            HeaderColor.List = null;
            HeaderColor.Location = new Point(324, 231);
            HeaderColor.Name = "HeaderColor";
            HeaderColor.SelectedIndex = -1;
            HeaderColor.SelectedIndexListener = null;
            HeaderColor.Size = new Size(299, 28);
            HeaderColor.Sorted = false;
            HeaderColor.Source = null;
            HeaderColor.TabIndex = 15;
            HeaderColor.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(868, 798);
            Controls.Add(HeaderColor);
            Controls.Add(HiddenButton);
            Controls.Add(BaseColor);
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
        private DataJuggler.Win.Controls.LabelComboBoxControl BaseColor;
        private DataJuggler.Win.Controls.Button HiddenButton;
        private DataJuggler.Win.Controls.LabelComboBoxControl HeaderColor;
    }
}
