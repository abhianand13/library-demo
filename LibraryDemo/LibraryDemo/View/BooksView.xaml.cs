using Prism.Regions;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace LibraryDemo
{
    /// <summary>
    /// Interaction logic for BooksView.xaml
    /// </summary>
    [Export("BooksView")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [RegionMemberLifetime(KeepAlive = false)]
    public partial class BooksView : UserControl
    {
        [ImportingConstructor]
        public BooksView(BooksViewModel booksViewModel)
        {
            InitializeComponent();
            this.DataContext = booksViewModel;
        }
    }
}
