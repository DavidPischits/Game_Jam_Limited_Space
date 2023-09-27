using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppData : MonoBehaviour
{
    [SerializeField]GameObject app;
    [SerializeField] GameObject workCanvas;

    public void ToogleWorkCanvas(bool on)
    {
        workCanvas.SetActive(on);
    }
    public void ToogleApp(bool on)
    {
        app.SetActive(on);
    }
}
