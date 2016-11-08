using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AIPath : MonoBehaviour {

    public List<GameObject> pathlist;
	void Start () 
    {
	    foreach( Transform child in transform)
        {
            pathlist.Add(child.gameObject);
        }
	}
    public Vector3 GetFirstCheckpoint()
    {
        return pathlist[0].transform.position;
    }
}
