using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PrefabMaker : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;

    private GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            DoThis();
        }
    }

    public void DoThis()
    {
        prefab = Instantiate(new GameObject(), new Vector3(1,2,3), Quaternion.identity);
        prefab.name = "New_Station";
        prefab.AddComponent<TestObject>();
        prefab.GetComponent<TestObject>().propertyA = 123.0f;
        prefab.GetComponent<TestObject>().propertyB = new Vector3(10, 10, 10);
        prefab.GetComponent<TestObject>().propertyC = new Vector3(15, 15, 15);
        prefab.GetComponent<TestObject>().listA = new List<GameObject>();
        prefab.GetComponent<TestObject>().listB = new List<GameObject>();
        prefab.GetComponent<TestObject>().listA.Add(a);
        prefab.GetComponent<TestObject>().listB.Add(b);
        prefab.GetComponent<TestObject>().listB.Add(c);

        string path = "Assets/Prefabs/" + prefab.name + ".prefab";

        PrefabUtility.SaveAsPrefabAsset(prefab, path);
    }
}
