using LibraryDemo.Helper;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows.Input;
using LibraryDemo.ServiceRepository;
using System.Collections.Generic;
using LibraryDemo.ServiceRepository.LibraryService;
using AutoMapper;

namespace LibraryDemo
{
    [Export]
    public class BooksViewModel : ViewModelBase
    {
        private IServiceRepository serviceRepository;
        private List<BookModel> allBooks;
        private ObservableCollection<BookModel> filteredBooks;
        private string searchText;
        private ICommand searchCommand;

        [ImportingConstructor]
        public BooksViewModel(IServiceRepository serviceRepository)
        {
            this.serviceRepository = serviceRepository;
            LoadAllBooks();
        }

        #region Public Properties

        public ObservableCollection<BookModel> FilteredBooks
        {
            get { return filteredBooks; }
            set
            {
                filteredBooks = value;
                OnPropertyChanged("FilteredBooks");
            }
        }

        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                OnPropertyChanged("SearchText");
            }
        }

        public ICommand SearchCommand
        {
            get
            {
                if (searchCommand == null)
                {
                    searchCommand = new DelegateCommand(OnSearch);
                }
                return searchCommand;
            }
        }

        #endregion

        #region Private Methods

        private void LoadAllBooks()
        {
            List<BookDTO> books = serviceRepository.GetAllBooks();
            allBooks = Mapper.Map<List<BookDTO>, List<BookModel>>(books);
            FilteredBooks = new ObservableCollection<BookModel>(allBooks);
        }

        private void OnSearch()
        {
            var result = allBooks.Where(x => x.Title.ToLower().Contains(SearchText.ToLower()));
            FilteredBooks = new ObservableCollection<BookModel>(result);
        }

        #endregion
    }
}
