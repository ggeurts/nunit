// ***********************************************************************
// Copyright (c) 2009 Charlie Poole, Rob Prouse
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

using System;

namespace NUnit.Framework.Constraints.Comparers
{
    /// <summary>
    /// Comparator for two <see cref="Array"/>s.
    /// </summary>
    internal sealed class ArraysComparer : ChainComparer<Array>
    {
        private readonly EnumerablesComparer _enumerablesComparer;

        internal ArraysComparer(NUnitEqualityComparer equalityComparer)
        {
            _enumerablesComparer = new EnumerablesComparer(equalityComparer);
        }

        public override bool Equals(Array x, Array y, ref Tolerance tolerance)
        {
            if (ReferenceEquals(x, y))
                return true;
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return false;

            int rank = x.Rank;
            if (rank != y.Rank)
                return false;

            for (int r = 1; r < rank; r++)
                if (x.GetLength(r) != y.GetLength(r))
                    return false;

            return _enumerablesComparer.Equals(x, y, ref tolerance);
        }

        public override int GetHashCode(Array a)
        {
            return _enumerablesComparer.GetHashCode(a);
        }
    }
}
