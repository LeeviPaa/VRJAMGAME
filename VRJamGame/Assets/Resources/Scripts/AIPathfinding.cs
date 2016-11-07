using UnityEngine;
using System.Collections;

public class AIPathfinding : MonoBehaviour {
    public GameObject path;
    private Path PathScript;
    private NavMeshAgent navmesh;
	void Start () 
    {
        navmesh = transform.GetComponent<NavMeshAgent>();
        if (path.GetComponent<Path>())
        {
            PathScript = path.GetComponent<Path>();
            navmesh.SetDestination(PathScript.GetFirstCheckpoint());
        }
	}

    public void SetWaypoint(Vector3 target)
    {
        navmesh.SetDestination(target);
    }
}
