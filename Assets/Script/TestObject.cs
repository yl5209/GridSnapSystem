using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{
    public float propertyA;
    public Vector3 propertyB;
    public Vector3 propertyC;
    [SerializeField]
    [Range(0,10)]
    private int propertyD;
    public List<GameObject> listA;
    public List<GameObject> listB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
