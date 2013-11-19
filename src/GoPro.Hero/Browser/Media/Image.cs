﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using GoPro.Hero.Commands;
using Newtonsoft.Json.Linq;

namespace GoPro.Hero.Browser.Media
{
    public class Image : Media
    {
        public Stream BigThumbnail()
        {
            return base.BigThumbnail(base.Name);
        }

        public override string ToString()
        {
            return string.Format("image:{0}", base.Name);
        }
    }
}
