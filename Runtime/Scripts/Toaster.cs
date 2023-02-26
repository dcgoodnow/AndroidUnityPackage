using System;
using UnityEngine;

public class Toaster : IDisposable
{

    private const string CLASS_NAME = "com.dcgoodnow.androidunityplugin.Toaster";
    private const string METHOD_SHOW_TOAST = "ShowToast";

    private readonly AndroidJavaObject _javaObject;

    public Toaster()
    {
        using (var player = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        using (var activity = player.GetStatic<AndroidJavaObject>("currentActivity"))
        {
            _javaObject = new AndroidJavaObject(CLASS_NAME, activity);
        }
    }

    public void ShowToast(string text)
    {
        _javaObject.Call(METHOD_SHOW_TOAST, text);
    }


    public void Dispose()
    {
        _javaObject?.Dispose();
    }

}
