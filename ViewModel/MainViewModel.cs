using ems2.Db;
using ems2.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;

namespace ems2.ViewModel
{

    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            localDb = new localDb();
            QueryCommand = new RelayCommand(Query);
            ResetCommand = new RelayCommand(() =>
             {
                 Search = string.Empty;
                 this.Query();
             });
        }

        localDb localDb;
        private string search = string.Empty;
        public string Search
        {
            get { return search; }
            set { search = value;RaisePropertyChanged(); }
        }
        private ObservableCollection<Student> gridModelList;
        public ObservableCollection<Student> GridModelList
        {
            get { return gridModelList; }
            set { gridModelList = value; RaisePropertyChanged(); }
        }


        #region Command

        public RelayCommand QueryCommand { get; set; }
        public RelayCommand ResetCommand { get; set; }

        #endregion

        public void Query()
        {
            var models = localDb.GetStudentsByName(Search);
            GridModelList = new ObservableCollection<Student>();
            if(models!=null)
            {
                models.ForEach(arg =>
                {
                    GridModelList.Add(arg);
                });
            }
        }
    }
}