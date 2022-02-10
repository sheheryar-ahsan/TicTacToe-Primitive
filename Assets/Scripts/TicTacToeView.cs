using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToeView : MonoBehaviour
{
    public int rowsOfMatrix;
    public int colsOfMatrix;
    public float cellSpace;
    public GameObject cellPrefab;
    private UnityCell unityCell;
    private TicTacToeGrid ticTacToeGrid;

    void Start()
    {
        ticTacToeGrid = new TicTacToeGrid();
        GridSetup();
    }

    void Update()
    {
        ticTacToeGrid.PrintGrid();
    }

    public void GridSetup()
    {
        for (int x = 0; x < rowsOfMatrix; x++)
        {
            for (int z = 0; z < colsOfMatrix; z++)
            {
                if (InitializingCell() != null)
                {
                    //Debug.Log(x + " , " + z);
                    ticTacToeGrid.delegateOfGrid.Invoke(rowsOfMatrix, colsOfMatrix, x, z, cellSpace, InitializingCell());
                }
            }
        }
    }

    public GameObject InitializingCell()
    {
        GameObject initializedCell = Instantiate(cellPrefab);
        return initializedCell;
    }

    
}
