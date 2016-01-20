﻿// ***********************************************************************
// Copyright (c) 2016 Charlie Poole
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
using System.Collections.Generic;
using System.Text;

namespace NUnit.Engine.Internal
{
    /// <summary>
    /// Represents the target platform that an assembly is compiled to target
    /// </summary>
    public enum TargetPlatform
    {
        Unknown = 0,

        /// <summary>
        /// Any desktop platform such as .NET 2.0, 3.5, 4.5, etc.
        /// </summary>
        Desktop,

        /// <summary>
        /// PCL assembly
        /// </summary>
        Portable,

        /// <summary>
        /// Xamarin Android
        /// </summary>
        Android,
        
        /// <summary>
        /// Xamarin iOS
        /// </summary>
        Ios,
        
        /// <summary>
        /// .NET Core/DNX
        /// </summary>
        NetCore,
        
        /// <summary>
        /// Silverlight 5.0
        /// </summary>
        Silverlight,
        
        /// <summary>
        /// Universal Windows Platform AKA Windows 10
        /// </summary>
        UniversalWindows,

        /// <summary>
        /// Windows 8.1 RT
        /// </summary>
        Win81,

        /// <summary>
        /// Windows Phone 8.0 Silverlight
        /// </summary>
        WinPhone80Silverlight,

        /// <summary>
        /// Windows Phone 8.1 Silverlight
        /// </summary>
        WinPhone81Silverlight,

        /// <summary>
        /// Windows Phone 8.1
        /// </summary>
        WinPhone81
    }
}
