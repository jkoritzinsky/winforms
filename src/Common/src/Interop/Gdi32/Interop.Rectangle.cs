﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Gdi32
    {
        [DllImport(Libraries.Gdi32, ExactSpelling = true)]
        public static extern BOOL Rectangle(IntPtr hdc, int left, int top, int right, int bottom);

        public static BOOL Rectangle(HandleRef hdc, int left, int top, int right, int bottom)
        {
            BOOL result = Rectangle(hdc.Handle, left, top, right, bottom);
            GC.KeepAlive(hdc.Wrapper);
            return result;
        }
    }
}
