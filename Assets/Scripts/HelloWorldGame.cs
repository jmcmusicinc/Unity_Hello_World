//originally found at https://docs.unity3d.com/ScriptReference/UI.Text-text.html

//Create an Empty Game Object
//Attach this script to that GameObject.
//Create a Text GameObject (Create>UI>Text) and attach it to the My Text field in the Inspector of your GameObject
//Press the space bar in Play Mode to see the Text change.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloWorldGame : MonoBehaviour {

    public Text m_MyText;

    void Start()
    {
        //Text sets your text to say this message
        m_MyText.text = "Hello World!";
    }

    void Update()
    {
        //Press the space key to change the Text message
        if (Input.GetKey(KeyCode.Space))
        {
            m_MyText.text = "Text has changed.";
        }
    }
}
