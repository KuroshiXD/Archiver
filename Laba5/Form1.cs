namespace Laba5
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationTokenSource;
        private Archivator archiver;

        public Form1()
        {
            InitializeComponent();

            inputFileTextBox.ReadOnly = true;
            outputFileTextBox.ReadOnly = true;

            archiver = new Archivator();
            archiver.ProgressBarUpdated += UpdateProgressBar;
        }

        private void inputFileTextBox_TextChanged(object sender, EventArgs e) { }

        private void outputFileTextBox_TextChanged(object sender, EventArgs e) { }

        private void inputFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFileTextBox.Text = openFileDialog.FileName;
            }
        }

        private void outputFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputFileTextBox.Text = saveFileDialog.FileName;
            }
        }

        private async void packButton_Click(object sender, EventArgs e)
        {
            string inputFile = inputFileTextBox.Text;
            string outputFile = outputFileTextBox.Text;
            cancellationTokenSource = new CancellationTokenSource();
            progressBar.Value = 0;

            try
            {
                await Task.Run(() => archiver.Pack(inputFile, outputFile, cancellationTokenSource.Token));
                MessageBox.Show("Архивация завершена");
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Операция прервана");
            }
        }

        private async void unpackButton_Click(object sender, EventArgs e)
        {
            string inputFile = inputFileTextBox.Text;
            string outputFile = outputFileTextBox.Text;
            cancellationTokenSource = new CancellationTokenSource();
            progressBar.Value = 0;

            try
            {
                await Task.Run(() => archiver.UnPack(inputFile, outputFile, cancellationTokenSource.Token));
                MessageBox.Show("Разархивация завершена");
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Операция прервана");
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
        }

        private void progressBar_Click(object sender, EventArgs e) { }

        private void UpdateProgressBar(int value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateProgressBar(value)));
            }
            else
            {
                if (value < 0) { value = 0; }
                if (value > 100) { value = 100; }

                progressBar.Value = value;
            }
        }
    }
}
