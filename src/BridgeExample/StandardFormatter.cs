﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeExample
{
    public class StandardFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0}: {1}", key, value);
        }
    }
}
