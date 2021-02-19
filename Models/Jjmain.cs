using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 *  计件信息类
 */
namespace ems2.Models
{
    public class Jjmain : ViewModelBase
    {
        private int id;
        private string empcategory;//员工类别
        private string group;//班组
        private string empname;//员工姓名
        private int empid;//员工编号
        private string rygz;//人员工种
        private string gwmx;//岗位明细
        private string btlcategory;//产品种类
        private double spdj;//审批单价
        private double xs;//系数
        private double sjjp;//时间节拍
        private double cl;//产量
        private double rgz;//日工资
        private double llgs;//理论工时
        private DateTime workdate;//日期

        public int Id
        {
            get { return id; }
            set
            {
                id = value; RaisePropertyChanged();
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
        public string Empname
        {
            get { return empname; }
            set
            {
                empname = value; RaisePropertyChanged();
            }
        }
        public int Empid
        {
            get { return empid; }
            set
            {
                empid = value; RaisePropertyChanged();
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
        public string Gwmx
        {
            get { return gwmx; }
            set
            {
                gwmx = value; RaisePropertyChanged();
            }
        }
        public string Btlcategory
        {
            get { return btlcategory; }
            set
            {
                btlcategory = value; RaisePropertyChanged();
            }
        }
        public double Spdj
        {
            get { return spdj; }
            set
            {
                spdj = value; RaisePropertyChanged();
            }
        }
        public double Xs
        {
            get { return xs; }
            set
            {
                xs = value; RaisePropertyChanged();
            }
        }
        public double Sjjp
        {
            get { return sjjp; }
            set
            {
                sjjp = value; RaisePropertyChanged();
            }
        }
        public double Cl
        {
            get { return cl; }
            set
            {
                cl = value; RaisePropertyChanged();
            }
        }
        public double Rgz
        {
            get { return rgz; }
            set
            {
                rgz = value; RaisePropertyChanged();
            }
        }
        public double Llgs
        {
            get { return llgs; }
            set
            {
                llgs = value; RaisePropertyChanged();
            }
        }
        public DateTime Workdate
        {
            get { return workdate; }
            set
            {
                workdate = value; RaisePropertyChanged();
            }
        }
    }
    
}
