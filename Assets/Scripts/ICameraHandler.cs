using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public interface ICameraHandler : IEventSystemHandler
{
    void SetPosition(Vector3 position);
    void LookAt(Transform target);
}
