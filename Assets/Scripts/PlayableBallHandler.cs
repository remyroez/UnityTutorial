using UnityEngine;
using System.Collections;

public class PlayableBallHandler : MonoBehaviour, IPlayableHandler
{
    public void Move (float x, float z)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (rigidbody)
        {
            rigidbody.AddForce(x * 10, 0, z * 10);
        }
    }
}
