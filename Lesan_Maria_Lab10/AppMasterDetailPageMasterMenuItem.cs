﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesan_Maria_Lab10
{

    public class AppMasterDetailPageMasterMenuItem
    {
        public AppMasterDetailPageMasterMenuItem()
        {
            TargetType = typeof(AppMasterDetailPageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}