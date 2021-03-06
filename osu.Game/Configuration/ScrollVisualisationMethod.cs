﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System.ComponentModel;

namespace osu.Game.Configuration
{
    public enum ScrollVisualisationMethod
    {
        [Description("Sequential")]
        Sequential,
        [Description("Overlapping")]
        Overlapping,
        [Description("Constant")]
        Constant
    }
}
