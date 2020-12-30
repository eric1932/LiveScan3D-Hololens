using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class StringEvent : UnityEvent<string> { }

public class KeyboardInput : MonoBehaviour {
    public StringEvent keyboardDone;
    public string titleText;
    //TouchScreenKeyboard keyboard;

    void Start ()
    {
        //#if WINDOWS_UWP
        //        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, false, false, titleText);
        //#else
        //        //Just for testing in the editor
        //        if (keyboardDone != null)
        //            keyboardDone.Invoke("127.0.0.1");
        //#endif
        #if UNITY_EDITOR
            keyboardDone.Invoke("192.168.2.232");
        #else
            // ASUS Router
            // keyboardDone.Invoke("192.168.1.81");  // MacBook
            // keyboardDone.Invoke("192.168.1.77");  // Lenovo
            // Huawei Router
            keyboardDone.Invoke("192.168.3.3");  // Lenovo
        #endif
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
