using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Volere_Manager
{
    public class HeaderItem
    {
        public String colDbName { get; set; }
        public String colHeaderName { get; set; }
        public Boolean disabled { get; set; }
        public Boolean selected { get; set; }
        public int order { get; set; }
        public int width { get; set; }
        public string colHint { get; set; }

        public HeaderItem(String _colDbName)
        {
            this.colDbName = _colDbName;
            this.disabled = true;
        }

        public HeaderItem(String _colDbName, int _colWidth, Boolean showDefault)
        {
            this.colDbName = _colDbName;
            this.colHeaderName = _colDbName;
            this.disabled = false;
            this.selected = showDefault;
            this.width = _colWidth;
        }

        public HeaderItem(String _colDbName,String _colHeaderName,int _colWidth, Boolean showDefault)
        {
            this.colDbName = _colDbName;
            this.colHeaderName = _colHeaderName;
            this.disabled = false;
            this.selected = showDefault;
            this.width = _colWidth;
        }

        public HeaderItem(String _colDbName, String _colHeaderName, String _colHint, int _colWidth, Boolean showDefault)
        {
            this.colDbName = _colDbName;
            this.colHeaderName = _colHeaderName;
            this.colHint = _colHint;
            this.disabled = false;
            this.selected = showDefault;
            this.width = _colWidth;
        }


    }
}
