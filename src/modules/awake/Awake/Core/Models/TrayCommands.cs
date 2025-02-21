﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Awake.Core.Models
{
    internal enum TrayCommands : uint
    {
        TC_DISPLAY_SETTING = NativeConstants.WM_USER + 1,
        TC_MODE_PASSIVE = NativeConstants.WM_USER + 2,
        TC_MODE_INDEFINITE = NativeConstants.WM_USER + 3,
        TC_EXIT = NativeConstants.WM_USER + 4,
        TC_TIME = NativeConstants.WM_USER + 5,
    }
}
