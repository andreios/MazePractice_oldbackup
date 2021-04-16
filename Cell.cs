using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazePractice
{
    class Cell
    {
        //members
        public int Row { get; set; }
        public int Column { get; set; }

        public Cell North { get; set; }
        public Cell South { get; set; }
        public Cell East { get; set; }
        public Cell West { get; set; }

    }
}
