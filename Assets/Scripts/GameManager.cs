using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Check1");
    }

    public bool IsTrueVersion1()
    {
        return true;
    }
    
    public bool IsTrueVersion2()
    {
        return false;
    }
}
