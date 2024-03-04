

#region using statements

using DataJuggler.PixelDatabase;
using DataJuggler.PixelDatabase.Enumerations;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using DataJuggler.UltimateHelper;
using System.Data;
using System.Drawing.Text;
using System.Windows.Forms;

#endregion

namespace CalendarCreator
{

    #region class MainForm
    /// <summary>
    /// This class is the MainForm
    /// </summary>
    public partial class MainForm : Form, ICheckChangedListener
    {
        
        #region Private Variables
        private PixelDatabase pixelDatabase;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events
            
            #region CreateCalendarButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CreateCalendarButton' is clicked.
            /// </summary>
            private void CreateCalendarButton_Click(object sender, EventArgs e)
            {
                // remove focus
                HiddenButton.Focus();
                Refresh();
                Application.DoEvents();

                // local
                bool abort = false;

                // validate
                if (IsValid())
                {
                    // Reload 
                    PixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(Properties.Resources.Blank, null);

                    // Get the month
                    MonthEnum month = (MonthEnum) (MonthPicker.SelectedIndex + 1);

                    // Get the year
                    int year = YearControl.IntValue;

                    // Set the title
                    string title = month.ToString().ToUpper() + " " + year.ToString();

                    // Write out the image
                    string fileName = Path.Combine(FolderPicker.Text, title + ".png");

                    // Display
                    Canvas.BackgroundImage = PixelDatabase.DirectBitmap.Bitmap;

                    // If checked
                    if (SaveToDiskCheckBox.Checked)
                    {  
                        // make sure unique in folder
                        fileName = FileHelper.CreateFileNameWithPartialGuid(fileName, 12);
                    }                

                    // Load the PixelDatabase
                    PixelDatabase blank = PixelDatabaseLoader.LoadPixelDatabase(BackgroundImagePicker.Text, null);

                    // if not the right size
                    if ((blank.Width != 1120) || (blank.Height != 740))
                    {
                        // bail
                        abort = true;

                        // Display a message
                        DisplayStatus("The Background Image must be 1120 x 740.", Color.Firebrick);
                    }

                    // Load the PixelDatabase
                    PixelDatabase header = PixelDatabaseLoader.LoadPixelDatabase(HeaderIimagePicker.Text, null);

                    // if not the right size
                    if ((header.Width != 1120) || (header.Height != 80))
                    {
                        // bail
                        abort = true;

                        // Display a message
                        DisplayStatus("The Header Image must be 1120 x 80.", Color.Firebrick);
                    }

                    // only used if text is entered
                    PixelDatabase dayRowDatabase = null;

                    if (DayRowImage.HasText)
                    {
                        // Load the day row image
                        dayRowDatabase = PixelDatabaseLoader.LoadPixelDatabase(DayRowImage.Text, null);
                    }

                    // if continue
                    if (!abort)
                    {
                        // Get the base color
                        Color baseColor = Color.FromName(BaseColorComboBox.ComboBoxText);

                        // Get the header color
                        Color headerColor = Color.FromName(HeaderColorComboBox.ComboBoxText);

                        // Set the baseFontSize
                        float baseFontSize = (float) NumericHelper.ParseInteger(BaseFontSizeControl.ComboBoxText, 0, 0);
                        float headerFontSize = (float) NumericHelper.ParseInteger(HeaderFontSizeControl.ComboBoxText, 0, 0);

                        // Create the Fonts
                        Font baseFont = new Font(BaseFontComboBox.ComboBoxText, baseFontSize);
                        Font headerFont = new Font(HeaderFontComboBox.ComboBoxText, headerFontSize);

                        // if Checked
                        if (BoldCheckBox.Checked)
                        {
                            // Use Bold
                            baseFont = new Font(BaseFontComboBox.ComboBoxText, baseFontSize, FontStyle.Bold);
                        }

                        // if Checked
                        if (HeaderBoldCheckBox.Checked)
                        {
                            // Use Bold
                            headerFont = new Font(HeaderFontComboBox.ComboBoxText, headerFontSize, FontStyle.Bold);
                        }

                        // Create the Calendar
                        PixelDatabase = PixelDatabase.CreateCalendar(blank.DirectBitmap.Bitmap, header.DirectBitmap.Bitmap, UpdateCallback, month, year, SaveToDiskCheckBox.Checked, fileName, baseColor, headerColor, baseFont, headerFont, dayRowDatabase);

                        // Draw the Calendar
                        Canvas.BackgroundImage = PixelDatabase.DirectBitmap.Bitmap;

                        // Hide
                        Graph.Visible = false;
                    }
                }
            }
            #endregion
           
            #region OnCheckChanged(LabelCheckBoxControl sender, bool isChecked)
            /// <summary>
            /// event is fired when On Check Changed
            /// </summary>
            public void OnCheckChanged(LabelCheckBoxControl sender, bool isChecked)
            {  
                // Enable the control
                FolderPicker.Editable = isChecked;
                FolderPicker.Enabled = isChecked;

                // only if isChecked
                if (isChecked)
                {
                    // Set the LabelColor
                    FolderPicker.LabelColor = Color.LemonChiffon;
                }
            }
            #endregion
            
        #endregion

        #region Methods

            #region DisplayStatus(string message, Color color)
            /// <summary>
            /// Display Status
            /// </summary>
            public void DisplayStatus(string message, Color color)
            {
                StatusLabel.ForeColor = color;
                StatusLabel.Text = message;
            }
            #endregion
            
            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Load Months
                MonthPicker.LoadItems(typeof(MonthEnum));

                // Select the current month
                MonthPicker.SelectedIndex = DateTime.Now.Month - 1;

                // Set the year
                YearControl.Text = DateTime.Now.Year.ToString();

                // Load the image
                PixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(Properties.Resources.Blank, null);

                // Ready to create a calendar
                StatusLabel.Text = "Status: Ready.";

                // Setup the Listener
                SaveToDiskCheckBox.CheckChangedListener = this;

                // Enable
                SaveToDiskCheckBox.Checked = true;

                // Load the Colors
                BaseColorComboBox.LoadItems(typeof(KnownColor));
                HeaderColorComboBox.LoadItems(typeof(KnownColor));

                // Select Black
                BaseColorComboBox.SelectedIndex = BaseColorComboBox.FindItemIndexByValue("Black");            
                HeaderColorComboBox.SelectedIndex = BaseColorComboBox.FindItemIndexByValue("Black");

                // Load each font installed
                using(InstalledFontCollection instealledFonts = new InstalledFontCollection())
                {  
                    foreach(FontFamily font in instealledFonts.Families)
                    {  
                        if ((font.IsStyleAvailable(FontStyle.Bold)) && (font.IsStyleAvailable(FontStyle.Regular)))
                        {
                            // Add this font
                            BaseFontComboBox.Items.Add(font.Name);
                            HeaderFontComboBox.Items.Add(font.Name);
                        }
                    }  
                }

                // Add the font sizes
                BaseFontSizeControl.Items.Add("12");
                BaseFontSizeControl.Items.Add("14");
                BaseFontSizeControl.Items.Add("16");
                BaseFontSizeControl.Items.Add("18");
                BaseFontSizeControl.Items.Add("20");
                BaseFontSizeControl.Items.Add("24");
                BaseFontSizeControl.Items.Add("28");
                BaseFontSizeControl.Items.Add("32");
                BaseFontSizeControl.Items.Add("36");
                BaseFontSizeControl.Items.Add("40");
                BaseFontSizeControl.Items.Add("44");
                BaseFontSizeControl.Items.Add("48");
                BaseFontSizeControl.Items.Add("60");

                // Select 28
                BaseFontSizeControl.SelectedIndex = BaseFontSizeControl.FindItemIndexByValue("28");

                // Load Each Size Again
                HeaderFontSizeControl.Items.Add("12");
                HeaderFontSizeControl.Items.Add("14");
                HeaderFontSizeControl.Items.Add("16");
                HeaderFontSizeControl.Items.Add("18");
                HeaderFontSizeControl.Items.Add("20");
                HeaderFontSizeControl.Items.Add("24");
                HeaderFontSizeControl.Items.Add("28");
                HeaderFontSizeControl.Items.Add("32");
                HeaderFontSizeControl.Items.Add("36");
                HeaderFontSizeControl.Items.Add("40");
                HeaderFontSizeControl.Items.Add("44");
                HeaderFontSizeControl.Items.Add("48");
                HeaderFontSizeControl.Items.Add("60");

                // Select 36
                HeaderFontSizeControl.SelectedIndex = HeaderFontSizeControl.FindItemIndexByValue("36");
            }
            #endregion

            #region IsValid()
            /// <summary>
            /// returns the Valid
            /// </summary>
            public bool IsValid()
            {
                // initial value
                bool isValid = true;

                // if checked
                if (SaveToDiskCheckBox.Checked)
                {
                    // if the Output Folder does not exist
                    if (!FolderPicker.HasText)
                    {
                        // not valid
                        isValid = false;

                        // Display a message
                        DisplayStatus("You must pick an output folder to continue.", Color.Firebrick);
                    }
                    else
                    {
                        // if the directory doesn't exist
                        if (!Directory.Exists(FolderPicker.Text))
                        {
                            // Display a message
                            DisplayStatus("The output folder does not exist.", Color.Firebrick);
                        }
                    }
                }

                // if set
                if (BackgroundImagePicker.HasText)
                {
                    // if file doesn't exist
                    if (!FileHelper.Exists(BackgroundImagePicker.Text))
                    {
                        // not valid
                        isValid = false;

                        // Display a message
                        DisplayStatus("You must pick a background image that is 1120 by 740 to continue.", Color.Firebrick);
                    }
                }
                else
                {
                    // not valid
                    isValid = false;

                    // Display a message
                    DisplayStatus("You must pick a background image that is 1120 by 740 to continue.", Color.Firebrick);
                }
                
                // return value
                return isValid;
            }
            #endregion
            
            #region UpdateCallback(string message, int progress)
            /// <summary>
            /// Update Callback
            /// </summary>
            public void UpdateCallback(string message, int progress)
            {
                // if SetGraphMax
                if (message == "SetGraphMax")
                {
                    // Setup the Graph
                    Graph.Visible = true;
                    Graph.Maximum = progress;
                    Graph.Value = 0;
                }
                else
                {
                    // Display a status
                    DisplayStatus(message, Color.LemonChiffon);

                    // if less than Max
                    if (progress < Graph.Maximum)
                    {
                        Graph.Value = progress;
                    }
                }

                // Force the UI To Update
                Refresh();
                Application.DoEvents();
            }
            #endregion
            
        #endregion

        #region Properties

            #region HasPixelDatabase
            /// <summary>
            /// This property returns true if this object has a 'PixelDatabase'.
            /// </summary>
            public bool HasPixelDatabase
            {
                get
                {
                    // initial value
                    bool hasPixelDatabase = (this.PixelDatabase != null);
                    
                    // return value
                    return hasPixelDatabase;
                }
            }
            #endregion
            
            #region PixelDatabase
            /// <summary>
            /// This property gets or sets the value for 'PixelDatabase'.
            /// </summary>
            public PixelDatabase PixelDatabase
            {
                get { return pixelDatabase; }
                set { pixelDatabase = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
