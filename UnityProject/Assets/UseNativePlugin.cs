using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class UseNativePlugin : MonoBehaviour
{
    [DllImport ("NativePlugin")]
    private static extern float ExamplePluginFunction ();

    // Start is called before the first frame update
    void Start()
    {
        // Calls the ExamplePluginFunction inside the plugin
        // And prints 5 to the console
        Debug.Log("Hello world!");
        print (ExamplePluginFunction ());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
