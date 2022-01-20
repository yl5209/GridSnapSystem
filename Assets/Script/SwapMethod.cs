using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapMethod : MonoBehaviour
{
    public GameObject grid;
    public GameObject chris;
    public bool flag;
    public Text t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (flag)
            {
                grid.SetActive(false);
                chris.SetActive(true);
                flag = !flag;
                t.text = "Lerp";
            }
            else 
            {
                grid.SetActive(true);
                chris.SetActive(false);
                flag = !flag;
                t.text = "Grid";
            }
        }
    }
}
