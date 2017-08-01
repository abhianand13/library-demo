using LibraryDemo.Helper;

namespace LibraryDemo
{
    public class BookModel : NotifierBase
    {
        private string isbn;
        private string title;
        private string authorName;

        public string Isbn
        {
            get { return isbn; }
            set
            {
                isbn = value;
                OnPropertyChanged("Isbn");
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string AuthorName
        {
            get { return authorName; }
            set
            {
                authorName = value;
                OnPropertyChanged("AuthorName");
            }
        }
    }
}
