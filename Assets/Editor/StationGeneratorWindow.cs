using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class StationGeneratorWindow : EditorWindow
{
    Rect HeaderSection;
    Rect StationSettingsSection;

    [MenuItem("Window/Station Generator")]

    static void OpenWindow()
    {
        StationGeneratorWindow window = (StationGeneratorWindow)GetWindow(typeof(StationGeneratorWindow));

        window.minSize = new Vector2(600, 300);
        window.Show();
    }

    /// <summary>
    /// Similar to Start() or Awake()
    /// </summary>
    void OnEnable()
    {
            
    }

    /// <summary>
    /// Similar to any update function
    /// Not called once per frame. Called one or more time per interaction
    /// </summary>
    void OnGUI()
    {
        DrawLayouts();
        DrawHeader();
        DrawStaionSettings();
    }

    /// <summary>
    /// Define rect values
    /// </summary>
    void DrawLayouts()
    {

    }

    /// <summary>
    /// Draw contents of header
    /// </summary>
    void DrawHeader()
    {

    }

    /// <summary>
    /// Draw staion editing section
    /// </summary>
    void DrawStaionSettings()
    {

    }

}
