using Avalonia.Controls;
using System.Windows.Input;

namespace SEAL.Views
{
    public partial class MainWindow : Window
    {
        public string pickedfile = "No File";

        public async void FindFile()
        {
            var dialog = new OpenFileDialog { Title = "Pick File", AllowMultiple = false,};
            var file = await dialog.ShowAsync(this);
            if (file?.Length > 0)
            {
                pickedfile = file[0];
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

    }
}
