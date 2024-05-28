using UnityEngine;
using UnityEngine.AI;

public class NavPlayer : MonoBehaviour
{
    private NavMeshAgent meshAgent;
    private void Awake()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
            {
                meshAgent.SetDestination(hit.point);
            }
        }
    }
}
    