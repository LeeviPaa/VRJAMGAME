using UnityEngine;
using System.Collections;

public class EnemyPool : MonoBehaviour 
{
    void Start()
    {
        foreach (Transform child in transform)
        {
            if (child.GetComponent<EnemyInteractions>())
            {
                child.GetComponent<EnemyInteractions>().SetHome(transform.position);
            }
        }
    }
}
