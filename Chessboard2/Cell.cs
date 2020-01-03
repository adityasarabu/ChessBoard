using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard2
{
    public class Cell
    {
        
        public int? RowNumber { get; set; }
        public int? ColumnNumber { get; set; }
        public bool CurrentlyOccupied { get; set; }
        public bool LegalNextMove { get; set; }

        public Cell(int a, int b)
        {
            RowNumber = a;
            ColumnNumber = b;
        }

       
    }
}
