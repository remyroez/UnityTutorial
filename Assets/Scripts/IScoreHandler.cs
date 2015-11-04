using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public interface IScoreHandler : IEventSystemHandler
{
    void OnTriggerEnterItem(GameObject target, Collider hit);
}
