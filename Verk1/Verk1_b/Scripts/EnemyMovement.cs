using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    // Transform spilara
    public Transform player;
    // NavMeshAgent fyrir pathfinding
    private NavMeshAgent navMeshAgent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Nær í og geymir NavMeshAgent tengt object
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // Ef að það er reference til spilara
        if (player != null)
        {
            // Setja staðsetningu óvinar til staðsetningu spilara
            navMeshAgent.SetDestination(player.position);
        }
    }
}
