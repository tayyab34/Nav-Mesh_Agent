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
        Debug.DrawRay(transform.position, transform.forward * 10,Color.black);
        if (Physics.SphereCast(transform.position, 0.5f, transform.forward, out hit, 10, layer, QueryTriggerInteraction.UseGlobal))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
