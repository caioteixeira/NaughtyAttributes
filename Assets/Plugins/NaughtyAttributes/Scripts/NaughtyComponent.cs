﻿using NaughtyAttributes;
using UnityEngine;

public class NaughtyComponent : MonoBehaviour
{
    //[Dropdown("intValues")]
    public int intValue;

    //[Dropdown("stringValues")]
    public string stringValue;

    //[Dropdown("vectorValues")]
    public Vector3 vectorValue;

    private int[] intValues = new int[] { 1, 2, 3, 4, 5 };

    private string[] stringValues = new string[] { "A", "B", "C", "D", "E" };

    private DropdownList<Vector3> vectorValues = new DropdownList<Vector3>()
    {
        { "Right",   Vector3.right   },
        { "Left",    Vector3.left    },
        { "Up",      Vector3.up      },
        { "Down",    Vector3.down    },
        { "Forward", Vector3.forward },
        { "Back",    Vector3.back    },
    };

    [Button]
    private void Method()
    {
        Debug.Log("asd");
    }
}
