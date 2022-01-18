using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public Image mask;
    public GridSnap target;
    public AnimationCurve myCurve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(new Vector3(Move.player.transform.position.x, 0, Move.player.transform.position.z), target.transform.position);
        mask.fillAmount = myCurve.Evaluate(1f - (1f - distance * 0.3f));
    }
}
