using UnityEngine;
using System.Collections;

public class KillEnemy : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<EnemyInteractions>())
        {
            other.GetComponent<EnemyInteractions>().TakeDamage(100);
        }
    }
}
