using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private NavMeshAgent nav;
    public Transform target;
    public LayerMask layer;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        nav.SetDestination(target.position);
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.SphereCast(transform.position+Vector3.up, 1f, transform.forward, out hit, 10, layer, QueryTriggerInteraction.UseGlobal))
        {
            Destroy(hit.transform.gameObject);
        }
    }
}
