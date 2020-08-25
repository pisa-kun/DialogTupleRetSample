using System.Windows;

namespace WindowTupleSample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var subw = new SubWindow();
            var (isCheck, result) = subw.ShowDialogRetCheckBox();
            this.textblock.Text = $"CheckBox : {isCheck.ToString()}";
            this.textblock2.Text = $"OK(t) or Cancel(f) :{result.ToString()}";
        }
    }
}
