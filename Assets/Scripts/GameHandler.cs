using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class GameHandler : MonoBehaviour, IGameHandler
{
    public delegate bool CheckFunction();
    
    public GameObject[] titleObjects;
    public GameObject[] playObjects;
    public GameObject[] clearObjects;

    private bool nextFlow = false;

    public void Next()
    {
        nextFlow = true;
    }

    // Use this for initialization
    void Start ()
    {
        StartGameFlow(
            new IEnumerator[]
            {
                Flow(titleObjects, () => Input.GetButtonDown("Submit")),
                Flow(playObjects),
                Flow(clearObjects, () => Input.GetButtonDown("Submit"))
            }
        );
    }

    public void StartGameFlow(IEnumerator[] flows)
    {
        StartCoroutine(GameFlow(flows));
    }
	
    IEnumerator GameFlow(IEnumerator[] flows)
    {
        foreach (IEnumerator flow in flows)
        {
            nextFlow = false;
            yield return StartCoroutine(flow);
        }
    }

    IEnumerator Flow(GameObject[] objects, CheckFunction checker = null)
    {
        SetActiveGameObjects(objects, true);
        while (checker == null ? !nextFlow : !checker())
        {
            yield return null;
        }
        SetActiveGameObjects(objects, false);
    }
    
    static void SetActiveGameObjects(GameObject[] list, bool value)
    {
        if (list == null) return;

        foreach (GameObject state in list)
        {
            if (state)
            {
                state.SetActive(value);
            }
        }
    }
}
