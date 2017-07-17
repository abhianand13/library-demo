using LibraryDemo.Helper;
using LibraryDemo.LibraryService;

namespace LibraryDemo.Model
{
    public class TransactionTypeModel : NotifierBase
    {
        private string code;
        private string description;

        public string Code
        {
            get { return code; }
            set
            {
                this.code = value;
                OnPropertyChanged("Code");
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                this.description = value;
                OnPropertyChanged("Description");
            }
        }
    }
}
