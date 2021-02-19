using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 *  岗位明细类
 */
namespace ems2.Models
{
    public class Gwmx : ViewModelBase
    {
        private int id;
        private string des;

        public int Id
        {
            get { return id; }
            set
            {
                id = value; RaisePropertyChanged();
            }
        }

        public string Des
        {
            get { return des; }
            set
            {
                des = value; RaisePropertyChanged();
            }
        }
    }
}
