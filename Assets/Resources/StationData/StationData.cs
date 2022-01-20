using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using State;


[CreateAssetMenuAttribute(fileName = "New Station Data", menuName = "Station Data")]
public class StationData : ScriptableObject
{
    public List<GameObject> past;
    public List<GameObject> present;
    public Vector3 loc;
    public Vector3 rot;
    public float tolerance;
    public StationState state;
    public bool isSingleUse;

}
