﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nepy.Core
{
    public class ParserContext
    {
        public ParserContext()
        {
            DateTimeBase = DateTime.Now;
        }

        /// <summary>
        /// text to be parsed
        /// </summary>
        public string Text { get; set; }

        public DateTime DateTimeBase { get; set; }

        public ParserPattern Pattern { get; set; }

        public ParserContext Clone()
        {
            ParserContext pc = new ParserContext();
            pc.Text = this.Text;
            return pc;
        }
    }
}
