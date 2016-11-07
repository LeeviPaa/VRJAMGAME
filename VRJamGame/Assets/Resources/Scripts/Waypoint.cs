using UnityEngine;
using System.Collections;

public class Waypoint : MonoBehaviour {

    public GameObject nextTarget;

    private AIPathfinding Instructable;
	void Start () 
    {
	
	}
	
	void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<AIPathfinding>())
        {
            Instructable = other.gameObject.GetComponent<AIPathfinding>();
            Instructable.SetWaypoint(nextTarget.transform.position);
        }

    }
}
