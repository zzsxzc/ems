using ems2.Db;
using ems2.Models;
using ems2.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

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
            EditCommand = new RelayCommand<int>(t => Edit(t));
            DelCommand = new RelayCommand<int>(t => Del(t));
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

        public RelayCommand<int> EditCommand { get; set; }
        public RelayCommand<int> DelCommand { get; set; }

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

        public void Edit(int id)
        {
            var model = localDb.GetStudentById(id);
            if(model!=null)
            {
                UserView view = new UserView(model);
                //运行到这里会弹出对话框
                //点击确定按钮，对话框的返回值为true，点击取消按钮，对话框的返回值为false
                var r = view.ShowDialog();
                if (r.Value)
                {
                    var newModel = GridModelList.FirstOrDefault(t => t.Id == model.Id);
                    if (newModel != null)
                    {
                        newModel.Name = model.Name;
                    }
                }
            }
        }

        public void Del(int id)
        {
            var model = localDb.GetStudentById(id);
            if (model != null)
            {
                var r = MessageBox.Show($"确认删除当前用户:{model.Name}?", "操作提示", MessageBoxButton.OK, MessageBoxImage.Question);
                if(r==MessageBoxResult.OK)
                    localDb.Delstudent(model.Id);
                this.Query();
            }
            
        }
    }
}