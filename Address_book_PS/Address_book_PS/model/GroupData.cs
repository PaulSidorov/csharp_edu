﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_PS.model
{
    public class GroupData
    {
        public string Name { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }

        public GroupData()
        {
            Name = "";
            Header = "";
            Footer = "";
        }
    }
}
