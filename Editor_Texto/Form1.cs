
namespace Editor_Texto
{
    public partial class Form1 : Form
    {
        string path;
        string text;

        public Form1()
        {
            InitializeComponent();
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            RineTxtxContext.Clear();
            path = null!;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Archivos de texto|*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.path = openFile.FileName;

                using (StreamReader reader = new StreamReader(path))
                {
                    this.text = reader.ReadToEnd();
                    RineTxtxContext.Text = text;
                }
                Form1.ActiveForm.Text = path + " | Editor de Texto";
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "Archivos de texto|*.txt";

            if (path != null)
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(RineTxtxContext.Text);
                }

                MessageBox.Show("Se ha editado el archivo - cambios guardados");
            }
            else
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    this.path = saveFile.FileName;

                    using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                    {
                        writer.WriteLine(RineTxtxContext.Text);
                    }

                    MessageBox.Show("Nuevo archivo guardados");
                }
            }
        }

        private void CloseEditor_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro de cerrar el editor?",
                    "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    return;
                }
            }
            Environment.Exit(0);
        }
    }
}