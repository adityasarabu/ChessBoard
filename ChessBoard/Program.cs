using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chessboard2;

namespace ChessBoard
{
    class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        {
            //show empty chess board
            printBoard(myBoard);
            // ask user for x and y coordinates
            Cell currentCell = setCurrentCell();
            currentCell.CurrentlyOccupied = true;
            //calculate legal 
            Console.WriteLine("Enter the Piece:");
            string currentPiece = Console.ReadLine();
            myBoard.MarkNextLegalMove(currentCell, currentPiece);
            //print chess board, use x for occupied squar
            printBoard(myBoard);
            Console.ReadLine();
        }

        private static Cell setCurrentCell()
        {
            
                Console.WriteLine("Enter the X Row: ");
                int currentRow = int.Parse(Console.ReadLine());
            
                Console.WriteLine("Enter the Y Column: ");
                var currentColumn = int.Parse(Console.ReadLine());

                return myBoard.TheGrid[currentRow, currentColumn];

           
            //Get the Coordinates
            
            

            

        }

        private static void printBoard(Board myBoard)
        {
            var line = "+---+---+---+---+---+---+---+---+";
            for (int i = 0; i < myBoard.Size; i++)
            {
                Console.WriteLine(line);
                for (int j = 0; j < myBoard.Size; j++)
                {
                    //grab the cell location
                    Cell c = myBoard.TheGrid[i, j];
                    if (c.CurrentlyOccupied == true)
                    {
                        Console.Write("| X ");
                    }
                    else if (c.LegalNextMove == true)
                    {
                        Console.Write("| + ");
                       
                    }
                    else
                    {
                        Console.Write("|   ");
                        
                    }
                   
                }
                
                Console.Write("|");
                Console.WriteLine(); 
            }
            Console.WriteLine(line);
            
            Console.WriteLine("======================================");
        }
    }
}
