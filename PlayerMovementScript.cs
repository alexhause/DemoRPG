using UnityEngine;
using UnityEngine.AI;

public class PlayerMovementScript : MonoBehaviour
{
    private NavMeshAgent agent;
    private Camera cam;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Move();
        }
    }

    private void Move()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            agent.SetDestination(hit.point);
        }
    }
}
