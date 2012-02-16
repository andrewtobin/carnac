﻿using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;
using System.Text;
using Caliburn.Micro;

namespace Carnac
{
    [Serializable]
    public class Settings: PropertyChangedBase
    {
        public int ItemMaxWidth { get; set; }
        public double ItemOpacity { get; set; }
        public string ItemBackgroundColor { get; set; }
        
        public string FontColor { get; set; }
        public int FontSize { get; set; }
    }
}
