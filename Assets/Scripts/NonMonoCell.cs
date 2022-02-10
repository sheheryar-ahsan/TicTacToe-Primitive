using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonMonoCell
{
    public enum Status { None, Circle, Cross, Win, Loose };
    Status status;
    public delegate void StatusUpdated(Status status);
    public StatusUpdated statusUpdated;

    public NonMonoCell()
    {
        status = Status.None;
    }

    public void SetStatus(Status status)
    {
        this.status = status;
        statusUpdated.Invoke(status);
    }

    public Status GetStatus()
    {
        return status;
    }

    internal void CellInteraction()
    {
        SetStatus(Status.None);
    }
}
