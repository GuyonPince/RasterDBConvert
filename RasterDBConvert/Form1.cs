namespace RasterDBConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filePath = "";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dbFile = new OpenFileDialog();
            dbFile.ShowDialog();
            filePath = System.IO.Path.GetDirectoryName(dbFile.FileName);
            textBox1.Text = dbFile.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> varNames = new List<string>();
            List<string> newProgData = new List<string>();
            string[] txt;
            try
            {
                txt = System.IO.File.ReadAllLines(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            

            foreach (string line in richTextBox1.Lines)
            {
                if (line == "EXTRA")
                {
                    for (int i =  1; i <= 101; i++)
                    {
                        varNames.Add($"{line}[{i}]");
                    }
                }
                else
                {
                    varNames.Add(line);
                }
            }


            foreach (string prog in txt) 
            {
                var datapoints = prog.Split(';').ToList();
                List<string> newProgDataPoint = new List<string>();
                if (datapoints.Count != varNames.Count)
                {
                    MessageBox.Show($"Aantal vars niet gelijk!\n{datapoints.Count} != {varNames.Count}");
                    return;
                }

                newProgDataPoint.Add(datapoints[0]);
                for (int i = 1;i < datapoints.Count;i++)
                {
                    newProgDataPoint.Add($"{varNames[i]}={datapoints[i]}");
                }
                newProgData.Add(String.Join(";", newProgDataPoint));
            }

            File.WriteAllLines($"{filePath}/CONVERTED-rfagriddb.csv", newProgData);

        }
    }
}