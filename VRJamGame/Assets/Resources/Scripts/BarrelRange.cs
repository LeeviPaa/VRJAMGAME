using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BarrelRange : MonoBehaviour {

	List<GameObject> rangelist = new List<GameObject>();

    void OnTriggerEnter(Collider other)
    {
        rangelist.Add(other.gameObject);
    }
    void OnTriggerExit(Collider other)
    {
        rangelist.Remove(other.gameObject);
    }
    public List<GameObject> GetList()
    {
        return rangelist;
    }
}
