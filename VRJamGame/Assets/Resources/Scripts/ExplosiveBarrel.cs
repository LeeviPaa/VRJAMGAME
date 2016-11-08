using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExplosiveBarrel : MonoBehaviour {

    List<GameObject> rangelist = new List<GameObject>();
    public float ExplosionRadius = 1;
    public float ExplosionForce = 1;

    private BarrelRange rangeScript;
    void Start()
    {
        rangeScript = gameObject.GetComponentInChildren<BarrelRange>();
    }
    void Update()
    {
        rangelist = rangeScript.GetList();
    }
	void OnTriggerEnter(Collider other)
    {
        rangelist.ForEach(delegate(GameObject obj)
        {
            obj.GetComponent<NavMeshAgent>().enabled = false;
            obj.GetComponent<Rigidbody>().isKinematic = false;
            obj.GetComponent<Rigidbody>().AddExplosionForce(ExplosionForce, transform.position+new Vector3(0,-10,0), ExplosionRadius);
            obj.GetComponent<EnemyInteractions>().Exploded();
        });
    }
}
