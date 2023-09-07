using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.InputSystem;
using System;

public class InputEnabling : MonoBehaviour 
{
   	public static InputEnabling inputEnabling;
    public Inputs inputs;

	
	void Awake()
	{
		if(inputEnabling != null)
			GameObject.Destroy(inputEnabling);
		else
			inputEnabling = this;
		
		DontDestroyOnLoad(this);
	}

   

    public static void EnableAction(InputAction action)
    {
        action.Enable();
    }
    
    public static void DisableAction(InputAction action)
    {
        action.Disable();

    }




}
