using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard2
{
    public class Board
    {
        //size of the board which will be 8X8
        public int Size { get; set; }
        //2d arry of type cell
        public Cell[,] TheGrid { get; set; }

        public Board(int s)
        {
            Size = s;
            TheGrid = new Cell[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0;  j< Size; j++)
                {
                    TheGrid[i,j] = new Cell(i, j);
                }
            }
        }

        public void MarkNextLegalMove(Cell currentCell, String chessPiece)
        {
            //clear all previous legal Moves
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    TheGrid[i, j].LegalNextMove = false;
                    TheGrid[i, j].CurrentlyOccupied = false;
                }
            }


            //Find all legal moves and mark the cells as 'Legal'
            switch (chessPiece)
            {
                case "Knight":
                    TheGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true; 
                    TheGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    break;
                case "King":
                    TheGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    break;
                case "Rook":
                    if ( currentCell.RowNumber <= 8 && currentCell.ColumnNumber <= 8)
                        
                    {
                        //var rowSize = 8 - currentCell.RowNumber;
                        for (int i = 0; i < (8 - currentCell.RowNumber); i++)
                        {
                            
                            TheGrid[currentCell.RowNumber + i, currentCell.ColumnNumber + 0].LegalNextMove = true;
                        }
                        for (int i = 0; i < (8 - currentCell.ColumnNumber); i++)
                        {

                            
                            TheGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + i].LegalNextMove = true;
                        }
                        for (int i = 1, j =0 ; j <= (currentCell.RowNumber -i); i++)
                        {

                            TheGrid[currentCell.RowNumber - i, currentCell.ColumnNumber + 0].LegalNextMove = true;
                        }
                        for (int i = 1, j = 0; j <= (currentCell.ColumnNumber - i); i++)
                        {

                            TheGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber - i].LegalNextMove = true;
                        }
                    }
                    break;
                case "Bishop":

                    for (int i = 0; i < (8 - currentCell.RowNumber); i++)
                    {

                        TheGrid[currentCell.RowNumber + i, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    for (int i = 1, j = 0; j <= (currentCell.ColumnNumber - i); i++)
                    {


                        TheGrid[currentCell.RowNumber - i, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    for (int i = 1, j = 0; j <= (currentCell.RowNumber - i); i++)
                    {

                        TheGrid[currentCell.RowNumber - i, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    for (int i = 1, j = 0; j <= (currentCell.ColumnNumber - i); i++)
                    {

                        TheGrid[currentCell.RowNumber + i, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    break;
                case "Queen":
                    for (int i = 0; i < (8 - currentCell.RowNumber); i++)
                    {

                        TheGrid[currentCell.RowNumber + i, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    for (int i = 1, j = 0; j <= (currentCell.ColumnNumber - i); i++)
                    {


                        TheGrid[currentCell.RowNumber - i, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    for (int i = 1, j = 0; j <= (currentCell.RowNumber - i); i++)
                    {
                        TheGrid[currentCell.RowNumber - i, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    for (int i = 1, j = 0; j <= (currentCell.ColumnNumber - i); i++)
                    {

                        TheGrid[currentCell.RowNumber + i, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    for (int i = 0; i < (8 - currentCell.RowNumber); i++)
                    {

                        TheGrid[currentCell.RowNumber + i, currentCell.ColumnNumber + 0].LegalNextMove = true;
                    }
                    for (int i = 0; i < (8 - currentCell.ColumnNumber); i++)
                    {


                        TheGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    for (int i = 1, j = 0; j <= (currentCell.RowNumber - i); i++)
                    {

                        TheGrid[currentCell.RowNumber - i, currentCell.ColumnNumber + 0].LegalNextMove = true;
                    }
                    for (int i = 1, j = 0; j <= (currentCell.ColumnNumber - i); i++)
                    {

                        TheGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }

                    break;
                default:
                    break;
            }
            TheGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
        }

    }
}
