using ems2.Db;
using ems2.Models;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace ems2.ViewModel
{

    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            localDb = new localDb();
        }

        localDb localDb;
        private ObservableCollection<Student> gridModelList;
        public ObservableCollection<Student> GridModelList
        {
            get { return gridModelList; }
            set { gridModelList = value; RaisePropertyChanged(); }
        }

        public void Query()
        {
            var models = localDb.GetStudents();
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