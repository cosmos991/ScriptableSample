using System.Diagnostics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjScriptableObject", menuName = "ScriptableObject_Test/ObjScriptableObject", order = 0)]
public class ObjScriptableObject : ScriptableObject 
{
    public OBJ_TYPE type;
    public int MakeCount;
}
