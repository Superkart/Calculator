using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField inputField;

    private Stack<int> inputStack = new Stack<int>();
    private float sum = 0;
    private char[] symbols = { '+', '-', '*', '/' };

    public void NumberButton(int num)
    {
        inputField.text = inputField.text + "" +  num.ToString();
        inputStack.Push(num);
    }

    public void FunctionButton(int index)
    {
        inputField.text = inputField.text + "" + symbols[index].ToString();
    }

    public void Equals()
    {
        inputField.text = sum.ToString();
        sum = 0;
    }
    public void Clear()
    {
        inputField.text = null;
        sum = 0;
    }
}
