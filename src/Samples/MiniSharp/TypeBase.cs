﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VBF.MiniSharp
{
    public class TypeBase
    {
        public string Name { get; set; }

        public virtual bool IsAssignableFrom(TypeBase type)
        {
            return false;
        }
    }
}
