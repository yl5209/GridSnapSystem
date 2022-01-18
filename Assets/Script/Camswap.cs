using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camswap : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    private bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwapCam()
    {
        if (flag)
        {
            cam2.SetActive(false);
            cam1.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
        }

        flag = !flag;
    }
}
