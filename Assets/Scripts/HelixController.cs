using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixController : MonoBehaviour
{

private Vector2 lastPosition;

private Vector3 startPosition;


public Transform TopTransform;
public Transform goalTramsform;

public GameObject helixLevelPrefab;

public List<Stage> allStages = new List<Stage>();

public float helixDistance;

private List<GameObject> spawnedLevels = new List<GameObject>();


private void Awake()
{
    startPosition = transform.localEulerAngles;
    helixDistance = TopTransform.localPosition.y - (goalTramsform.localPosition.y + .1f);
    //LoadStage(0);
}
    
    void Update()
    {


        if(Input.GetMouseButton(0))
        {
            Vector2 currentTapPosition = Input.mousePosition;

            if(lastPosition==Vector2.zero)
            {
                lastPosition = currentTapPosition;
            }

            float distance = lastPosition.x - currentTapPosition.x;
            lastPosition = currentTapPosition;

            transform.Rotate(Vector3.up * distance);
        }

        if(Input.GetMouseButtonUp(0))
        {
            lastPosition = Vector2.zero;
        }
        
    }

public void LoadStage(int stageNumber)
{

}

}
