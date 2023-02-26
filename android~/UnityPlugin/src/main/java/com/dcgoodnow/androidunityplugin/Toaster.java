package com.dcgoodnow.androidunityplugin;

import android.app.Activity;
import android.widget.Toast;

public class Toaster {

    private final Activity _unityActivity;

    public Toaster(Activity unityActivity)
    {
        _unityActivity = unityActivity;
    }

    public void ShowToast(String text)
    {
        Toast.makeText(_unityActivity, text, Toast.LENGTH_SHORT).show();
    }
}
