using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Volere_Manager
{
    public static class FilterState
    {
        public static Boolean filterActive = false;
        public static List<Int64> unCheckedIds = new List<Int64>();
        public static DateTime createdFrom = DateTime.MinValue;
        public static DateTime createdTo = DateTime.MaxValue;
        public static DateTime lastFrom = DateTime.MinValue;
        public static DateTime lastTo = DateTime.MaxValue;
        public static int priority = -1;
        public static int satisfaction = -1;
        public static int dissatisfaction = -1;
        public static String searchString = "";
        public static String originator = "";
        public static List<Int64> conflictingIds = new List<Int64>();
        public static Boolean conflictAny = false;
        public static Boolean conflictNone = false;
    }
}
