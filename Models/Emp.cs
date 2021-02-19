using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 *  员工类
 */
namespace ems2.Models
{
    public class Emp : ViewModelBase
    {
        private int id;
        private string name;
        private string empcategory;
        private string group;
        private string rygz;

        public int Id
        {
            get { return id; }
            set
            {
                id = value; RaisePropertyChanged();
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value; RaisePropertyChanged();
            }
        }

        public string Empcategory
        {
            get { return empcategory; }
            set
            {
                empcategory = value; RaisePropertyChanged();
            }
        }

        public string Group
        {
            get { return group; }
            set
            {
                group = value; RaisePropertyChanged();
            }
        }

        public string Rygz
        {
            get { return rygz; }
            set
            {
                rygz = value; RaisePropertyChanged();
            }
        }
    }
}
