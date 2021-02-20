using ems2.Db;
using ems2.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems2.ViewModel
{
    class JjmainViewModel : ViewModelBase
    {
        public JjmainViewModel()
        {

        }
        LocalMysql localMysql;
        private string search = string.Empty;
        public string Search
        {
            get { return search; }
            set { search = value; RaisePropertyChanged(); }
        }
        private ObservableCollection<Jjmain> gridModelList;
        public ObservableCollection<Jjmain> GridModelList
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

            var models = localMysql.getJjmain();
            GridModelList = new ObservableCollection<Jjmain>();
            if (models != null)
            {
                models.ForEach(arg =>
                {
                    GridModelList.Add(arg);
                });
            }



            //var models = localDb.GetStudentsByName(Search);
            //GridModelList = new ObservableCollection<Student>();
            //if (models != null)
            //{
            //    models.ForEach(arg =>
            //    {
            //        GridModelList.Add(arg);
            //    });
            //}
        }

        //public void Edit(int id)
        //{
        //    var model = localDb.GetStudentById(id);
        //    if (model != null)
        //    {
        //        UserView view = new UserView(model);
        //        //运行到这里会弹出对话框
        //        //点击确定按钮，对话框的返回值为true，点击取消按钮，对话框的返回值为false
        //        var r = view.ShowDialog();
        //        if (r.Value)
        //        {
        //            var newModel = GridModelList.FirstOrDefault(t => t.Id == model.Id);
        //            if (newModel != null)
        //            {
        //                newModel.Name = model.Name;
        //            }
        //        }
        //    }
        //}

        //public void Del(int id)
        //{
        //    var model = localDb.GetStudentById(id);
        //    if (model != null)
        //    {
        //        var r = MessageBox.Show($"确认删除当前用户:{model.Name}?", "操作提示", MessageBoxButton.OK, MessageBoxImage.Question);
        //        if (r == MessageBoxResult.OK)
        //            localDb.Delstudent(model.Id);
        //        this.Query();
        //    }

        //}
    }
}
