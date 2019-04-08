using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputUserName : MonoBehaviour
{
    public InputField inputField;
    


    public void clickGameStart()
    {
        Userdata.setUserName(inputField.text);
    }
    
   
}
