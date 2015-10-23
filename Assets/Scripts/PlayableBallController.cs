using UnityEngine;
using System.Collections;

public class PlayableBallController : MonoBehaviour, IPlayable
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
