using UnityEngine;
using System.Collections;

public class ScoreHandler : MonoBehaviour, IScoreHandler
{
    public void OnTriggerEnterItem(GameObject target, Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            Destroy(target);
        }
    }
}
