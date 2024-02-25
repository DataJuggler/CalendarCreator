

#region using statements

using DataJuggler.PixelDatabase;
using DataJuggler.PixelDatabase.Enumerations;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using DataJuggler.UltimateHelper;
using System.Data;

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

                // validate
                if (IsValid())
                {
                    // Reload 
                    PixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(Properties.Resources.Blank, null);

                    // Load the second image
                    PixelDatabase pixelDatabase2 = PixelDatabaseLoader.LoadPixelDatabase(Properties.Resources.Maroon, null);

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

                    // Load the PixelDatabase
                    PixelDatabase header = PixelDatabaseLoader.LoadPixelDatabase(HeaderIimagePicker.Text, null);

                    // Get the base color
                    Color baseColor = Color.FromName(BaseColor.ComboBoxText);

                    // Get the header color
                    Color headerColor = Color.FromName(HeaderColor.ComboBoxText);

                    // Create the Calendar
                    PixelDatabase = PixelDatabase.CreateCalendar(blank.DirectBitmap.Bitmap, header.DirectBitmap.Bitmap, UpdateCallback, month, year, SaveToDiskCheckBox.Checked, fileName, baseColor, headerColor);

                    // Draw the Calendar
                    Canvas.BackgroundImage = PixelDatabase.DirectBitmap.Bitmap;

                    // Hide
                    Graph.Visible = false;
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
                BaseColor.LoadItems(typeof(KnownColor));
                HeaderColor.LoadItems(typeof(KnownColor));

                // Select Black
                BaseColor.SelectedIndex = BaseColor.FindItemIndexByValue("Black");            
                HeaderColor.SelectedIndex = BaseColor.FindItemIndexByValue("Black");
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
