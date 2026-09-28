using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Ai;
public class EnemyNavigation : MonoBehaviour
{
    NavMeshAgent agent;
    Transform destination;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = FindObjectsOfType<CharacterController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = destination.positon;
    }
}
