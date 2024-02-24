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
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            SuspendLayout();
            // 
            // CreateCalendarButton
            // 
            CreateCalendarButton.BackColor = Color.Transparent;
            CreateCalendarButton.ButtonText = "Create Calendar";
            CreateCalendarButton.FlatStyle = FlatStyle.Flat;
            CreateCalendarButton.ForeColor = Color.LemonChiffon;
            CreateCalendarButton.Location = new Point(557, 116);
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
            MonthPicker.LabelWidth = 80;
            MonthPicker.List = null;
            MonthPicker.Location = new Point(49, 127);
            MonthPicker.Name = "MonthPicker";
            MonthPicker.SelectedIndex = -1;
            MonthPicker.SelectedIndexListener = null;
            MonthPicker.Size = new Size(240, 28);
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
            YearControl.LabelWidth = 80;
            YearControl.Location = new Point(295, 127);
            YearControl.MultiLine = false;
            YearControl.Name = "YearControl";
            YearControl.OnTextChangedListener = null;
            YearControl.PasswordMode = false;
            YearControl.ScrollBars = ScrollBars.None;
            YearControl.Size = new Size(240, 28);
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
            Graph.Location = new Point(12, 589);
            Graph.Name = "Graph";
            Graph.Size = new Size(724, 23);
            Graph.TabIndex = 4;
            Graph.Visible = false;
            // 
            // StatusLabel
            // 
            StatusLabel.ForeColor = Color.LemonChiffon;
            StatusLabel.Location = new Point(12, 563);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(733, 23);
            StatusLabel.TabIndex = 5;
            StatusLabel.Text = "Status:";
            // 
            // Canvas
            // 
            Canvas.BackgroundImage = Properties.Resources.Blank;
            Canvas.BackgroundImageLayout = ImageLayout.Stretch;
            Canvas.Location = new Point(109, 206);
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
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(766, 634);
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
    }
}
