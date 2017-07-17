using System.Windows;

namespace LibraryDemo
{
    /// <summary>
    /// Interaction logic for TestView.xaml
    /// </summary>
    public partial class TestView : Window
    {
        public TestView()
        {
            InitializeComponent();
            this.DataContext = new TestViewModel();
        }
    }
}
