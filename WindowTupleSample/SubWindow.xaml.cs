using System.Windows;

namespace WindowTupleSample
{
    /// <summary>
    /// SubWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class SubWindow : Window
    {
        /// <summary>
        /// returnのプロパティ
        /// </summary>
        public bool RetValue { get; set; } = false; 

        public SubWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// チェックボックスの値込みで返す
        /// </summary>
        /// <returns></returns>
        public (bool?, bool?) ShowDialogRetCheckBox()
        {
            var _ = this.ShowDialog();
            return (isCheck.IsChecked, RetValue);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RetValue = true;
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RetValue = false;
            this.Close();
        }
    }
}
