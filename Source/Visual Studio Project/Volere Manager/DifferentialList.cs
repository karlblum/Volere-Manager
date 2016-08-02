using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Volere_Manager
{
    class DifferentialList
    {
        private List<string> oldItems;
        private ListBox.ObjectCollection newItems;

        public DifferentialList(List<string> _oldItems, ListBox.ObjectCollection _newItems)
        {
            oldItems = _oldItems;
            newItems = _newItems;
        }

        public List<Int64> getAdds()
        {
            List<Int64> addedList = new List<Int64>();
            if (newItems != null)
            {
                foreach (var i in newItems)
                {
                    if (oldItems == null || !oldItems.Contains(i.ToString()))
                    {
                        addedList.Add(Convert.ToInt64(i));
                    }
                }

            }
            return addedList;
        }

        public List<Int64> getRemoves()
        {
            List<Int64> removedList = new List<Int64>();
            if (oldItems != null)
            {
                foreach (var i in oldItems)
                {
                    if (!newItems.Contains(i))
                    {
                        removedList.Add(Convert.ToInt64(i));
                    }
                }

            }
            return removedList;
        }
    }
}
