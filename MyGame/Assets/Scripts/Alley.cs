using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Alley : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DeathTrap")
        {
            Destroy(this.gameObject);
        }
    }
}
