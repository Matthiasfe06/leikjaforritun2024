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
        // N�r � og geymir NavMeshAgent tengt object
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // Ef a� �a� er reference til spilara
        if (player != null)
        {
            // Setja sta�setningu �vinar til sta�setningu spilara
            navMeshAgent.SetDestination(player.position);
        }
    }
}
