﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VBF.Compilers.Scanners
{
    /// <summary>
    /// Represents a regular expression accepts an empty set
    /// </summary>
    public sealed class EmptyExpression : RegularExpression
    {
        private EmptyExpression() : base(RegularExpressionType.Empty) { }

        public static readonly EmptyExpression Instance = new EmptyExpression();

        public override string ToString()
        {
            return "ε";
        }

        internal override Func<HashSet<char>>[] GetCompactableCharSets()
        {
            return new Func<HashSet<char>>[0];
        }

        internal override HashSet<char> GetUncompactableCharSet()
        {
            return new HashSet<char>();
        }

        internal override T Accept<T>(RegularExpressionConverter<T> converter)
        {
            return converter.ConvertEmpty(this);
        }
    }
}
