using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTransformData", menuName = "TransformData")]
public class TransformData : ScriptableObject
{
    public Vector2 position;

    public void ResetData(){
        position = new Vector2(-5.42f, -1.33f);
    }
}