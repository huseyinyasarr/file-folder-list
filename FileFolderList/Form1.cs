using System.Text;

namespace FileFolderList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var path = textBox1.Text;
            ListFiles(path);

            string ListFiles(string path)
            {
                StringBuilder output = new StringBuilder();



                listBox1.Items.Add("__________");
                listBox1.Items.Add(($"{new DirectoryInfo(path).Name}"));
                listBox1.Items.Add("¯¯¯¯¯¯¯¯¯¯¯");


                if (Directory.GetFileSystemEntries(path).Length == 0)
                {
                    listBox1.Items.Add($"\"{new DirectoryInfo(path).Name}\" klasörü boþ!");
                }



                foreach (string file in Directory.GetFiles(path))
                {

                    listBox1.Items.Add(file.Split('\\').Last());
                }

                foreach (string directory in Directory.GetDirectories(path))
                {
                    ListFiles(directory);
                }

                return output.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
