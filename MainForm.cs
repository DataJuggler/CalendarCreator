

#region using statements

using DataJuggler.PixelDatabase;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using CalendarCreator.Enumerations;
using DataJuggler.UltimateHelper;

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
                // Setup the ProgressBar
                Graph.Value = 0;
                Graph.Maximum = 55;
                Graph.Visible = true;

                StatusLabel.Text = "Status: Creating Calendar";
                StatusLabel.Refresh();

                // Reload 
                PixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(Properties.Resources.Blank, null);

                // Increment the value for Graph
                Graph.Value++;

                // Load the second image
                PixelDatabase pixelDatabase2 = PixelDatabaseLoader.LoadPixelDatabase(Properties.Resources.Maroon, null);

                // Increment the value for Graph
                Graph.Value++;

                // Top Left
                Point point = new Point(0, 0);

                // Copy the sub image
                PixelDatabase.CopySubImage(pixelDatabase2, point);

                // Increment the value for Graph
                Graph.Value++;
                
                // Create a font
                Font font = new Font("Broadway", 36);
                
                // Second point
                Point point2 = new Point(560, 40);

                // Create a white brush
                SolidBrush brush = new SolidBrush(Color.White);

                // Set the Month and Year
                string title = MonthPicker.ComboBoxText.ToUpper() + " " + YearControl.Text;

                // Draw the Text
                PixelDatabase.DrawText(title, font, point2, StringAlignment.Center, StringAlignment.Center, brush);

                // Increment the value for Graph
                Graph.Value++;

                // Update the UI
                Graph.Refresh();

                PixelCriteria criteria = new PixelCriteria();
                criteria.StartPoint = new Point(0, 140);
                criteria.EndPoint = new Point(1120, 140);
                criteria.Thickness = 2;
                criteria.BackColor = Color.Black;

                 // Create the Graphics object
                Graphics g = Graphics.FromImage(PixelDatabase.DirectBitmap.Bitmap);

                // Draw the line
                Bitmap bitmap = PixelDatabase.DrawLine(criteria, 255, PixelDatabase.DirectBitmap.Bitmap, null, g, true, Color.Black);

                // loop for each day
                for (int x = 0; x < 7; x++)
                {
                    PixelCriteria criteria2 = new PixelCriteria();
                    criteria2.StartPoint = new Point(x * 160, 80);
                    criteria2.EndPoint = new Point(x * 160, 740);
                    criteria2.Thickness = 2;
                    criteria2.BackColor = Color.Black;

                    // Draw the line
                    bitmap = PixelDatabase.DrawLine(criteria2, 255, bitmap, null, g, true, Color.Black);

                    // Increment the value for Graph
                    Graph.Value++;

                    // Update the UI
                    Graph.Refresh();
                }

                // draw 6 lines
                for (int x = 0; x < 6; x++)
                {
                    PixelCriteria criteria3 = new PixelCriteria();
                    criteria3.StartPoint = new Point(0, 140 + (x * 100));
                    criteria3.EndPoint = new Point(1120, 140 + (x * 100));
                    criteria3.Thickness = 2;
                    criteria3.BackColor = Color.Black;

                    // Draw the line
                    bitmap = PixelDatabase.DrawLine(criteria3, 255, bitmap, null, g, true, Color.Black);

                    // Increment the value for Graph
                    Graph.Value++;

                    // Update the UI
                    Graph.Refresh();
                }

                 // Load the pixelDatabase
                PixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(bitmap, null);

                // Create a white brush
                SolidBrush blackBrush = new SolidBrush(Color.Black);

                // draw each day
                for (int x = 0; x < 7; x++)
                {
                    // Get the dayName
                    string dayName = ((DayEnum) x + 1).ToString().Substring(0, 3);

                    // create a point
                    Point point4 = new Point(x * 160 + 80, 108);

                    // Smaller Font
                    font = new Font("Broadway", 28);

                    // Draw the Text
                    PixelDatabase.DrawText(dayName, font, point4, StringAlignment.Center, StringAlignment.Center, blackBrush);

                    // Increment the value for Graph
                    Graph.Value++;

                    // Update the UI
                    Graph.Refresh();
                }

                // Get the days in month
                int daysInMonth = System.DateTime.DaysInMonth(YearControl.IntValue, MonthPicker.SelectedIndex + 1);

                // Draw Numbers
                for (int x = 1; x <= daysInMonth; x++)
                {
                    // Get the month to use
                    DateTime dateToUse = new DateTime(YearControl.IntValue, MonthPicker.SelectedIndex + 1, x);

                    // create a point
                    Point point5 = GetPoint(x, dateToUse, daysInMonth);

                    // Draw the Text
                    PixelDatabase.DrawText(x.ToString(), font, point5, StringAlignment.Near, StringAlignment.Center, blackBrush);

                    // Increment the value for Graph
                    Graph.Value++;

                    // Update the UI
                    Graph.Refresh();
                }

                // Hide
                Graph.Visible = false;

                // Display
                Canvas.BackgroundImage = PixelDatabase.DirectBitmap.Bitmap;

                // If checked
                if (SaveToDiskCheckBox.Checked)
                {
                    // Write out the image
                    string fileName = Path.Combine(FolderPicker.Text, title + ".png");

                    // make sure unique in folder
                    fileName = FileHelper.CreateFileNameWithPartialGuid(fileName, 12);

                    // Save the file
                    PixelDatabase.SaveAs(fileName);

                    // Show Finished
                    StatusLabel.Text = "Status: The file has been saved to: " + fileName;
                }
                else
                {
                    // Show Finished
                    StatusLabel.Text = "Status: Finished.";
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

            #region GetPoint(int day, DateTime dateToUse, int daysInMonth)
            /// <summary>
            /// returns the Point
            /// </summary>
            public Point GetPoint(int day, DateTime dateToUse, int daysInMonth)
            {
                // locals
                int x = 0;
                int y = 0;

                // get the day of the week for this date
                DayOfWeek dayOfWeek = dateToUse.DayOfWeek;

                // initial value
                int weekNumber = GetWeekNumber(dateToUse);

                // get the dayOfWeek
                int dayOfWeekNumber = (int) dayOfWeek;

                // Set x
                x = dayOfWeekNumber * 160 + 8;

                // Set the value for y
                y = 168 + (100 * (weekNumber - 1));

                // initial value
                Point point = new Point(x, y);
                
                // return value
                return point;
            }
            #endregion
            
            #region GetWeekNumber(DateTime dateToUse)
            /// <summary>
            /// returns the Week Number
            /// </summary>
            public int GetWeekNumber(DateTime dateToUse)
            {
                // initial value
                int weekNumber = 1;

                // count the Saturdays
                for (int x = 1; x < dateToUse.Day; x++)
                {
                    // Create a tempDate
                    DateTime tempDate = new DateTime(dateToUse.Year, dateToUse.Month, x);

                    // if Saturday
                    if (tempDate.DayOfWeek == DayOfWeek.Saturday)
                    {
                        // Increment the value for weekNumber
                        weekNumber++;
                    }
                }
                
                // return value
                return weekNumber;
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

                // Set Temp for now
                FolderPicker.Text = @"c:\Temp";

                // Load the image
                PixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(Properties.Resources.Blank, null);

                // Ready to create a calendar
                StatusLabel.Text = "Status: Ready.";

                // Setup the Listener
                SaveToDiskCheckBox.CheckChangedListener = this;

                // Enable
                SaveToDiskCheckBox.Checked = true;
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
