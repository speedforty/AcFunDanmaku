﻿using AcFunDanmuSongRequest.Platform.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcFunDanmuSongRequest.Platform.NetEase
{
    struct Song : ISong
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public TimeSpan Duration { get; set; }
        public string Source { get; set; }
    }
}
