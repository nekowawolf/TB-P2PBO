﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_P2PBO.controller
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ComboboxItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
