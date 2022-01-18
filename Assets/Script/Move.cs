using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public static Move player;
    public float speed;
    public Vector3 position;
    public Vector3 direction;

    public bool isMoving;

    //player controller component
    public CharacterController controller;


    private void Awake()
    {
        player = this;
    }

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
        direction = transform.right * x + transform.forward * z;
        isMoving = direction != Vector3.zero ? true : false;
    }

    private void FixedUpdate()
    {
        DoMove(direction * speed);
        //SetTransform();
        
    }

    public void DoMove(Vector3 v2)
    {
        //position += v2 * Time.deltaTime;
        controller.Move(v2 * Time.deltaTime);
    }

    public void SetTransform()
    {
        transform.position = position;
    }
}
