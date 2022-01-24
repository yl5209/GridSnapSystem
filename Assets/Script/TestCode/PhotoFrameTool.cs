using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoFrameTool : MonoBehaviour
{
    [SerializeField]
    [Range(100, 1000)]
    public float centerX;
    [SerializeField]
    [Range(100, 1000)]
    public float centerY;
    [SerializeField]
    [Range(100,1000)]
    public float sizeX;
    [SerializeField]
    [Range(100, 1000)]
    public float sizeY;

    public GUISkin skin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.skin = skin;
        GUI.Box(new Rect(centerX, centerY, sizeX, sizeY), GUIContent.none);
    }
}
