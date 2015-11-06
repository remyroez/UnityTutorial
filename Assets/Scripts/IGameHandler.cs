using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public interface IGameHandler : IEventSystemHandler
{
    void Next();
}
