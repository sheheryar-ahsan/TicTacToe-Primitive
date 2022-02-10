using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToeGrid : Matrix
{
    private int row;
    private int col;
    private int totalRow;
    private int TotalCol;
    private float cellNumber;
    private GameObject unityCell;
    public delegate void DelegateOfGrid(int rowValue, int colValue, int row, int col, float space, GameObject unityCell);
    public DelegateOfGrid delegateOfGrid;
    private List<List<float>> gridRow = new List<List<float>>();
    private List<float> gridCol = new List<float>();
    public string storeGrid;

    public TicTacToeGrid()
    {
        delegateOfGrid += AssignCellToGrid;
        //Debug.Log("TictacToe Grid Invoked");
    }

    public void AssignCellToGrid(int rowValue, int colValue, int row, int col, float space, GameObject unityCell)
    {
        cellNumber = 0;
        this.totalRow = rowValue;
        this.TotalCol = colValue;
        this.row = row;
        this.col = col;
        this.unityCell = unityCell;

        for (int x = 0; x < totalRow; x++)
        {
            
            for (int z = 0; z < TotalCol; z++)
            {
                if (x == row && z == col)
                {
                    cellNumber++;
                    unityCell.transform.position = GenerateCellPosition(row, col);
                    gridCol.Add(unityCell.GetInstanceID());
                    storeGrid += "["+x+","+z+"]";
                    //return;
                    if (col == colValue - 1)
                    {
                        storeGrid += "\n";
                    }
                }
            }
        }
        if (col == colValue - 1)
        {
            foreach (var rowData in gridCol)
            {
                Debug.Log("Row Data" + rowData + ",");
            }
            Debug.Log("Row End");
            gridRow.Add(gridCol);
            gridCol.Clear();
        }
    }
    public Vector3 GenerateCellPosition(float xValue, float zValue)
    {
        Vector3 cellPosition = new Vector3(xValue, 0, zValue);
        return cellPosition;
    }

    public void PrintGrid()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(storeGrid);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < totalRow; i++)
            {
                for (int j = 0; j < TotalCol; j++)
                {
                    Debug.Log("X:" + i + " Z: " + j + gridRow[i][j] + ",");
                }
            }
            //foreach (var item in gridRow)
            //{
            //    foreach (var item2 in item)
            //    {
            //        Debug.Log("Item1: " );
            //    }
            //    Debug.Log("Item2: " );
            //}
            //Debug.Log("Grid had value: " + gridRow.Contains(gridRow[1]));
            Debug.Log("Grid Capacity: "+gridRow.Capacity);
        }
    }
}
