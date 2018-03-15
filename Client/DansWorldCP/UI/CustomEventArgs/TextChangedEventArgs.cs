﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DansWorld.GameClient.UI.CustomEventArgs
{
    class TextChangedEventArgs : EventArgs
    {
        public string Text;
        public string OldText;
        public TextChangedEventArgs(string text, string oldText)
        {
            Text = text;
            OldText = oldText;
        }
    }
}
