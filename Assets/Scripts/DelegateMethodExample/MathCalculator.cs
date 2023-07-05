using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices.WindowsRuntime;

public class MathCalculator : MonoBehaviour
{
    public delegate int CalculatorDelegate(int x1, int x2);

    public CalculatorDelegate calculatorDelegate;
    
    
    void Start()
    {
        calculatorDelegate += Add;
        calculatorDelegate += Remove;
        calculatorDelegate += Multiplication;
        calculatorDelegate += (x1, x2) =>
        {
            Debug.Log("Bölündü");
            return x1 / x2;
        };

        Delegate[] funcs = calculatorDelegate.GetInvocationList();

        for (int i = 0; i < funcs.Length; i++)
        {
            int result = ((CalculatorDelegate)funcs[i]).Invoke(13, 3);
            Debug.Log(result);
        }
        


    }


    public int Add(int a, int b)
    {
        Debug.Log("TOPLANDI");
        return a + b;
    }

    public int Remove(int a, int b)
    {
        Debug.Log("ÇIKARTILDI");
        return a - b;
    }

    public int Multiplication(int a, int b)
    {
        Debug.Log("ÇARPILDI");
        return a * b;
    }

   
}
