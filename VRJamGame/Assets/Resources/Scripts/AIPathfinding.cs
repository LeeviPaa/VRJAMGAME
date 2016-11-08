using UnityEngine;
using System.Collections;

public class AIPathfinding : MonoBehaviour {
    public GameObject path;
    private AIPath PathScript;
    private NavMeshAgent navmesh;
	void Start () 
    {
        navmesh = transform.GetComponent<NavMeshAgent>();
        if (path.GetComponent<AIPath>())
        {
            PathScript = path.GetComponent<AIPath>();
            navmesh.SetDestination(PathScript.GetFirstCheckpoint());
        }
	}

    public void SetWaypoint(Vector3 target)
    {
        if(navmesh.enabled == true)
        navmesh.SetDestination(target);
    }

    public void SetWaypointIndex(int index)
    {
        navmesh.SetDestination(PathScript.GetWaypoint(index));
    }
}
