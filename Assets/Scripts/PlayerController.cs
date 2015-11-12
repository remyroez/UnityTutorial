using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour {

    public GameObject target;
    
    void FixedUpdate()
    {
        if (target)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            if ((Mathf.Abs(x) > Mathf.Epsilon) || (Mathf.Abs(z) > Mathf.Epsilon))
            {
                ExecuteEvents.Execute<IPlayableHandler>(
                    target,
                    null,
                    (handler, data) => handler.Move(x, z)
                );
            }
        }
    }

}
