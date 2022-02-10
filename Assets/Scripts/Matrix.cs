using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrix 
{
    public int sizeOfMatrix;
    public float spaceOfCell;
    List<List<float>> gridMatrix;

    void Start()
    {
        GeneratingMatrix();
    }

    void Update()
    {
        
    }

    private void GeneratingMatrix()
    {
        gridMatrix = new List<List<float>>();
        for (float x = 0; x < sizeOfMatrix; x++)
        {
            for (float z = 0; z < sizeOfMatrix; z++)
            {
            }
        }
    }

    private Vector3 GenerateCellPosition(float xValue,float zValue)
    {
        Vector3 cellPosition = new Vector3(xValue, 0, zValue);
        return cellPosition;
    }
}
