using Spooksoft.HexEditor.Infrastructure;
using System.IO;
using System.Windows;

namespace Spooksoft.HexEditor.Tester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var ms = new MemoryStream();
            for (int i = 0; i < 16 * 4; i++)
                ms.WriteByte((byte)(i % 256));

            ms.Seek(0, SeekOrigin.Begin);

            heEditor.Document = new HexByteContainer(ms);
        }
    }
}