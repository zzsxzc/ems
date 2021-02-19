using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 *  瓶子种类
 */
namespace ems2.Models
{
    public class BtlCategory : ViewModelBase
    {
        private int id;
        private string bottleCategory;

        public int Id
        {
            get { return id; }
            set
            {
                id = value; RaisePropertyChanged();
            }
        }

        public string BottleCategory
        {
            get { return bottleCategory; }
            set
            {
                bottleCategory = value; RaisePropertyChanged();
            }
        }
    }
}
