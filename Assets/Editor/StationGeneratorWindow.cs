using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class StationGeneratorWindow : EditorWindow
{
    [MenuItem("Window/Station Generator")]

    static void OpenWindow()
    {
        StationGeneratorWindow window = (StationGeneratorWindow)GetWindow(typeof(StationGeneratorWindow));

        window.minSize = new Vector2(600, 300);
        window.Show();
    }
    
}
