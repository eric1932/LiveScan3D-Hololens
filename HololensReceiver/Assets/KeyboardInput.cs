using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class StringEvent : UnityEvent<string> { }

public class KeyboardInput : MonoBehaviour {
    public StringEvent keyboardDone;
    public string titleText;
    TouchScreenKeyboard keyboard;

    void Start ()
    {
        // Just for testing in the editor
        if (keyboardDone != null)
            // keyboardDone.Invoke("127.0.0.1");
            // keyboardDone.Invoke("192.168.2.231");
            // keyboardDone.Invoke("192.168.196.13");
            keyboardDone.Invoke("10.147.17.14");
    }
	
	void Update ()
    {
        //if (TouchScreenKeyboard.visible == false && keyboard != null)
        //{
        //    if (keyboard.done == true)
        //    {
        //        keyboardDone.Invoke(keyboard.text);
        //        keyboard = null;
        //    }
        //}
    }
}
