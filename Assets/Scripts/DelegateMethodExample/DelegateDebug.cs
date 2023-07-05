using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateDebug : MonoBehaviour
{
    public delegate void DebugDelegate(); //Tanımlama.

    public DebugDelegate debugDelegate; // Obje Oluşturma.
    
    void Start()
    {
        debugDelegate += Debug1;

        debugDelegate();
    }

    private void Debug1()
    {
        Debug.Log("Debug 1!");
    }
    
    
    private void Debug2()
    {
        Debug.Log("Debug 2!");
    }
    
    
}
