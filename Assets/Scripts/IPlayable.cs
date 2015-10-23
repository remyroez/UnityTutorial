using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public interface IPlayable : IEventSystemHandler
{
    void Move(float x, float z);
}
