using UnityEngine;
using System.Collections;

public class CameraHandler : MonoBehaviour, ICameraHandler
{
    private Vector3 offset = new Vector3();

    // Use this for initialization
    void Start () {
        offset = GetComponent<Transform>().position;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetPosition(Vector3 position)
    {
        transform.position = position + offset;
    }

    public void LookAt(Transform target)
    {
        if (!target) return;

        transform.LookAt(target);
    }
}
