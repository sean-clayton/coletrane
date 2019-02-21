using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugWorldLevel : CTLevel
{
    void Start()
    {
        base.Init();
        OnEnter();
    }

    public override void OnEnter()
    {
        base.OnEnter();

        Debug.Log("Entered Debug World");

        if (timesEntered == 1)
        {
            OnFirstEnter();
        }
    }

    public override void OnFirstEnter()
    {
        Debug.Log("Entered Debug World for the first time");
    }
}
