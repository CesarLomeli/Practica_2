using System.ComponentModel;
using System.Timers;

namespace Practica_2
{
    public partial class Form1 : Form
    {
        public List<string> list = new List<string>();
        public BindingList<string> listDel = new BindingList<string>();
        public string path = String.Empty;
        public System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public int contador = 0;
        public Form1()
        {
            InitializeComponent();
            listFilesFront.DataSource = listDel;
            timer.Interval = 5000;
            timer.Tick += ListFiles;
            timer.Enabled = true;
            timer.Start();
        }

        private void llenarListView()
        {
            listView.Items.Clear();
            foreach (var item in list)
            {
                ListViewItem itemView = new ListViewItem(item);
                listView.Items.Add(itemView);
            }
        }
        private void addExtBtn_Click(object sender, EventArgs e)
        {
            errorExt.Visible = false;
            //Revisar si existe extension en lista
            if (!extInput.Text.StartsWith('.'))
            {
                errorExt.Text = "Las extensiones deben de ser del tipo .ext";
                errorExt.Visible = true;
                return;
            }
            if (list.Contains(extInput.Text))
            {
                errorExt.Text = "Las extension ya fue agregada";
                errorExt.Visible = true;
                return;
            }
            list.Add(extInput.Text);
            extInput.Text = String.Empty;
            llenarListView();
        }

        private void fileSelectorBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.RootFolder = Environment.SpecialFolder.Desktop;
                dlg.ShowNewFolderButton = false;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    path = dlg.SelectedPath;
                    folderLabel.Text = path;
                }
            }
        }
        //Object source : Es el objeto que genera el evento (Timer dispara Elapsed)
        //Nos permite acceder al objeto que dispara el evento (Timer)
        //EventArgs e: Datos adicionales sobre el evento elapsed
        //por ejemplo info con la hora en que se dispara el evento
        private void ListFiles(object source, EventArgs e)
        {
            if (string.IsNullOrEmpty(path)) return;
            if (list.Count < 0) return;
            // Obtener archivos en la carpeta
            var currentFiles = new List<string>(Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)); 
            DeleteFiles(currentFiles);
        }
        private void DeleteFiles(List<string> files)
        {
            foreach (var file in files)
            {
                string fileExt = Path.GetExtension(file);
                if (list.Contains(fileExt))
                {
                    try
                    {
                        listDel.Add(file);
                        File.Delete(file);
                    }
                    catch { Console.WriteLine($"No se pudo eliminar el archivo {file}"); }
                }
            }
        }
    }
}
