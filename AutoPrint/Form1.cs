using RawPrint;
using System.Drawing.Printing;

namespace AutoPrint
{
    public partial class Form1 : Form
    {
        string selectedPath = "";
        string selectedPrinter = "";
        string fileFilter = "*.pdf";
        bool started = false;
        FileSystemWatcher watcher;
        SynchronizationContext m_SyncContext = null;
        public Form1()
        {
            InitializeComponent();
            m_SyncContext = SynchronizationContext.Current;
        }

        private void btnChooseDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK && Directory.Exists(folderBrowserDialog1.SelectedPath))
            {
                selectedPath = folderBrowserDialog1.SelectedPath;
                txtMonitorPath.Text = selectedPath;
            }
            else if (result == DialogResult.OK)
            {
                txtMonitorPath.Text = "";
                MessageBox.Show("Please choose a valid path.");
            }
            else
            {
                txtMonitorPath.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                comboBoxPrinter.Items.Add(printerName);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // check if the selected printer and path valid
            if (!Directory.Exists(selectedPath) || selectedPath == string.Empty)
            {
                MessageBox.Show("Please choose a valid path.");
                return;
            }
            if (started)
            {
                watcher.EnableRaisingEvents = false;
                btnStart.Text = "Start";
                comboBoxPrinter.Enabled = true;
                btnChooseDir.Enabled = true;
                started = false;
                richTextLog.Text += "Stop monitoring...\n";
            }
            else
            {
                watcher = new FileSystemWatcher(selectedPath);
                watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;
                watcher.Created += OnCreated;
                watcher.Filter = fileFilter;

                watcher.EnableRaisingEvents = true;

                btnStart.Text = "Stop";
                comboBoxPrinter.Enabled = false;
                btnChooseDir.Enabled = false;
                started = true;

                richTextLog.Text+="Start monitoring...\n";
            }

        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            m_SyncContext.Post(AppendLogSafePost, $"Created: {e.FullPath}\n");
            string filePath = e.FullPath;
            string fileName = Path.GetFileName(filePath);
            IPrinter printer = new Printer();
            while (true)
            {
                try
                {
                    printer.PrintRawFile(selectedPrinter, filePath, fileName);
                    break;
                }catch(IOException exception)
                {
                    Thread.Sleep(1000);
                }
            }
            m_SyncContext.Post(AppendLogSafePost, $"Printed: {e.FullPath}\n");
        }

        private void AppendLogSafePost(object text)
        {
            richTextLog.Text += text.ToString();
        }

        private void comboBoxPrinter_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPrinter = (string)comboBoxPrinter.SelectedItem;
        }
    }
}