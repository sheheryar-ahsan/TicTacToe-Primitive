using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCell : MonoBehaviour
{

    public List<GameObject> prefabObjects;
    public NonMonoCell nonMonoCell;
    public int cellID;

    void Start()
    {
        nonMonoCell = new NonMonoCell();
        nonMonoCell.statusUpdated += setStatus;
        nonMonoCell.SetStatus(NonMonoCell.Status.None);
    }

    public void setStatus(NonMonoCell.Status status)
    {
        for (int i = 0; i < prefabObjects.Count; i++)
        {
            if (i == (int)status)
            {
                prefabObjects[i].SetActive(true);
            }
            else
            {
                prefabObjects[i].SetActive(false);
            }
        }
    }

    public void OnMouseDown()
    {
        setStatus(NonMonoCell.Status.Win);
    }
}
