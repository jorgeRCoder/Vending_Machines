using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3OO
{
    class Stock
    {
        private int _cupsStock;

        private int _teaLeaves;
        private int _teaBags;

        public Stock()
        {

        }

        public int Cups
        {
            get { return _cupsStock; }
        }

        public int TeaLeaves
        {
            get { return _teaLeaves; }
        }

        public int TeaBags
        {
            get { return _teaBags; }
        }

        public int AddCups(int cups)
        {
            _cupsStock += cups;
            return _cupsStock;
        }

        public int RemoveCups(int cups)
        {
            _cupsStock -= cups; 
            return _cupsStock;
        }

        public int AddTeaLeaves(int teaLeaves)
        {
            _teaLeaves += teaLeaves;
            return _teaLeaves;
        }

        public int RemoveTeaLeaves(int teaLeaves)
        {
            _teaLeaves -= teaLeaves;
            return _teaLeaves;
        }

        public int AddTeaBags(int teaBags)
        {
            _teaBags += teaBags;
            return _teaBags;
        }

        public int RemoveTeaBags(int teaBags)
        {
            _teaBags -= teaBags;
            return _teaBags;
        }

        public override string ToString()
        {
            return $"cups{_cupsStock},tea leaves {_teaLeaves}, tea bags{_teaBags}";
        }
    }
}
