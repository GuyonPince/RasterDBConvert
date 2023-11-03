using System.Diagnostics;
using System.Text.RegularExpressions;

namespace RasterDBConvert
{
    public partial class Form1 : Form
    {
        string filePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        // Select old databse file
        private void SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dbFile = new OpenFileDialog();
            dbFile.ShowDialog();
            filePath = System.IO.Path.GetDirectoryName(dbFile.FileName);
            dbFileName.Text = dbFile.FileName;
        }

        // Convert the old databse file, saves in the same folder
        // CONVERTED-rfagriddb.csv
        private void convert_Click(object sender, EventArgs e)
        {
            List<string> datapointNames = new List<string>();     // list of datapoint names to add to the values of the old db
            List<string> newDB = new List<string>();        // updated database

            string[] oldDB;

            // try to read the old db file
            try
            {
                oldDB = System.IO.File.ReadAllLines(dbFileName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // generate list of new datapoint names
            foreach (string line in newDatapointNames.Lines)
            {
                if (line.StartsWith("EXTRA"))
                {
                    var extraRange = line.Split(" ").Last().Split("-");
                    for (int i = int.Parse(extraRange[0]); i <= int.Parse(extraRange[1]); i++)
                    {
                        datapointNames.Add($"extra[{i}]");
                    }
                }
                else
                {
                    datapointNames.Add(line);
                }
            }


            foreach (string progData in oldDB)
            {
                List<string> newDatapoint = new List<string>();

                var datapointValues = progData.Split(';').ToList();
                

                // check if there are an equal amount of data vlaues and data names
                if (datapointValues.Count != datapointNames.Count+1) 
                {
                    MessageBox.Show($"Aantal vars niet gelijk!\n{datapointValues.Count} != {datapointNames.Count}\nSkipping {datapointValues[0]}");
                    continue;
                }


                // for every other datapoint, add prefix
                newDatapoint.Add(datapointValues[0]);   //Program name, unchanged
                newDatapoint.Add($"rijen[0]={datapointValues[1]}");
                Debug.WriteLine(datapointValues[0]);
                for (int i = 1; i < datapointValues.Count; i++)
                {
                    try
                    {
                        newDatapoint.Add($"{datapointNames[i-1]}={datapointValues[i]}");
                    }
                    catch (Exception ex) { Debug.WriteLine(i); }
                    
                }

                // join all datapoints to program data and add to updated database
                newDB.Add(String.Join(";", newDatapoint));
            }

            try
            {
                File.WriteAllLines($"{filePath}/CONVERTED-rfagriddb.csv", newDB);
                MessageBox.Show("Database succesfully converted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}