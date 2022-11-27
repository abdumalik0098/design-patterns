using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Lib
{
    public class SortContext
    {
        private int[] _arr;
        public ISort _Sort { private get; set; }

        public SortContext(int[] arr, ISort sort)
        {
            _arr = arr;
            _Sort = sort;
        }
        public void Sort()
        {
            _Sort.GetSortNumbers(_arr);
        }
    }
}
