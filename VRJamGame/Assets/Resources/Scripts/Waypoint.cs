using UnityEngine;
using System.Collections;

public class Waypoint : MonoBehaviour {

    public GameObject nextTarget;
    public int RandomizePosRange = 6;

    private AIPathfinding Instructable;
	void Start () 
    {
	
	}
	
	void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<AIPathfinding>())
        {
            Instructable = other.gameObject.GetComponent<AIPathfinding>();
            Instructable.SetWaypoint(nextTarget.transform.position + new Vector3(Random.Range(-RandomizePosRange, RandomizePosRange), 0, Random.Range(-RandomizePosRange, RandomizePosRange)));
        }

    }
}
