using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public interface IPlayableHandler : IEventSystemHandler
{
    void Move(float x, float z);
}
