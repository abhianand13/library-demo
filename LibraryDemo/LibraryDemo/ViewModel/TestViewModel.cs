using AutoMapper;
using LibraryDemo.Helper;
using LibraryDemo.LibraryService;
using LibraryDemo.Model;
using System.Collections.Generic;
using System.Windows.Input;

namespace LibraryDemo
{
    public class TestViewModel : NotifierBase
    {
        private string selectedTransactionTypeCode;
        private List<TransactionTypeModel> transactionTypes = new List<TransactionTypeModel>();

        private ICommand loadTransactionTypesCommand;

        public string SelectedTransactionTypeCode
        {
            get { return selectedTransactionTypeCode; }
            set
            {
                selectedTransactionTypeCode = value;
                OnPropertyChanged("SelectedTransactionTypeCode");
            }
        }

        public List<TransactionTypeModel> TransactionTypes
        {
            get { return transactionTypes; }
            set
            {
                transactionTypes = value;
                OnPropertyChanged("TransactionTypes");
            }
        }

        public ICommand LoadTransactionTypesCommand
        {
            get
            {
                if (loadTransactionTypesCommand == null)
                    loadTransactionTypesCommand = new DelegateCommand(LoadAllTransactionTypes);
                return loadTransactionTypesCommand;
            }
        }

        private void LoadAllTransactionTypes()
        {
            LibraryServiceClient client = new LibraryServiceClient();
            List<TransactionType> transactionTypesDTO = client.GetTransactionTypes();

            TransactionTypes = Mapper.Map<List<TransactionType>, List<TransactionTypeModel>>(transactionTypesDTO);
        }
    }
}
