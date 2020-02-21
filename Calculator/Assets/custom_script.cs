using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class custom_script : MonoBehaviour
{

    public InputField number1, number2;
    public Text result;

    private int num1,num2;

    public void onAdd() {
    	
    	 num1 = int.Parse(number1.text);
    	 num2 = int.Parse(number2.text);

    	 result.text = "Result : " + (num1 + num2).ToString();
    	
    }

    public void onMultiply()
    {

        num1 = int.Parse(number1.text);
        num2 = int.Parse(number2.text);

        result.text = "Result : " + (num1 * num2).ToString();

    }
}
