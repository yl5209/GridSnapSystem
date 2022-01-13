using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(x, 0, z);
        DoMove(dir * speed);
        SetTransform();
    }

    public void DoMove(Vector3 v2)
    {
        position += v2;
    }

    public void SetTransform()
    {
        transform.position = position;
    }
}
