using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class CameraController : MonoBehaviour {

    public GameObject receiver;
    public GameObject target;

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        LookForTarget(target);
    }

    void LookForTarget(GameObject target)
    {
        if (!target) return;

        ExecuteEvents.Execute<ICameraHandler>(
            receiver,
            null,
            (handler, data) =>
            {
                handler.SetPosition(target.GetComponent<Transform>().position);
                handler.LookAt(target.GetComponent<Transform>());
            }
        );
    }
}
