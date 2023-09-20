using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppData : MonoBehaviour
{
    [SerializeField]GameObject app;

    public void ToogleApp(bool on)
    {
        app.SetActive(on);
    }
}
