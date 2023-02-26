using UnityEngine;

public class ToastBehaviour : MonoBehaviour
{
    private Toaster _toaster;

    private void Awake()
    {
        _toaster = new();
    }

    private void OnDestroy()
    {
        _toaster.Dispose();
    }

    public void ShowToast(string message)
    {
        _toaster.ShowToast(message);
    }

}


