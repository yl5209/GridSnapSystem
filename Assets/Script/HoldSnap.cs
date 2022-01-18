using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HoldSnap : MonoBehaviour
{
    public Vector3 target;
    public bool isActive;

    public float snapTime;

    private Tween tweenX;
    private Tween tweenZ;
    private Tween tweenXB;
    private Tween tweenZB;

    private Vector3 origin;

    // Start is called before the first frame update
    void Start()
    {
        //tweenX = Move.player.transform.DOMoveX(transform.position.x, snapTime).Pause();
        //tweenZ = Move.player.transform.DOMoveZ(transform.position.z, snapTime).Pause();

        //tweenX.OnPlay(() => { SetPController(false); });
        //tweenX.OnRewind(() => { SetPController(true); });
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {

            if (Input.GetMouseButtonDown(1))
                Snap();

            if (Input.GetMouseButtonUp(1))
                Return();

        }
    }

    public void Snap()
    {
        Debug.Log("Snap");

        tweenXB.Pause();
        tweenZB.Pause();

        tweenX = Move.player.transform.DOMoveX(transform.position.x, snapTime);
        tweenZ = Move.player.transform.DOMoveZ(transform.position.z, snapTime);

        origin = Move.player.transform.position;

        tweenX.OnPlay(() => { SetPController(false); });
    }

    public void Return()
    {
        Debug.Log("Return");

        tweenX.Pause();
        tweenZ.Pause();

        tweenXB = Move.player.transform.DOMoveX(origin.x, snapTime);
        tweenZB = Move.player.transform.DOMoveZ(origin.z, snapTime);

        tweenXB.OnComplete(() => { SetPController(true); });
    }

    public void SetPController(bool b)
    {
        Move.player.controller.enabled = b;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isActive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isActive = false;
        }
    }
}
