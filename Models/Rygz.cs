﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 *  人员工种类
 */
namespace ems2.Models
{
    public class Rygz : ViewModelBase
    {
        private int id;
        private string name;

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
    }
}
