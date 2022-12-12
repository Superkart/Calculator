using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField inputField;

    private Stack<int> inputStack = new Stack<int>();
    private float sum = 0;

    public void NumberButton(int num)
    {
        inputField.text = inputField.text + "" +  num.ToString();
    }

    public void Add()
    {
        int count = 0;
        if (inputField.text != null)
        {
            for (int i = 0; i < inputField.text.Length; i++)
            {
                if (inputField.text[i] != ' ')
                {
                    inputStack.Push(inputField.text[i]);
                    Debug.Log(inputField.text[i]);
                    count++;
                }          
            }
        }
        for (int i = 0; i < count; i++)
        {
           sum = sum + inputStack.Pop();
        }
        inputField.text = sum.ToString();
    }
    public void Clear()
    {
        inputField.text = null;
        sum = 0;
    }
}
