using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TagLib;

namespace iTSfvLib
{
    public class XmlArtwork
    {
        private Picture picture = null; 

        public XmlArtwork(TagLib.Picture pic)
        {
            this.picture = pic;
        }
    }
}
