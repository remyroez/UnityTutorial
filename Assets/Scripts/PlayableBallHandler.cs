using UnityEngine;
using System.Collections;

public class PlayableBallHandler : MonoBehaviour, IPlayableHandler
{
    public float force = 10.0f;
    
    public void Move (float x, float z)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (rigidbody)
        {
            rigidbody.AddForce(x * force, 0, z * force);
        }
    }
}
