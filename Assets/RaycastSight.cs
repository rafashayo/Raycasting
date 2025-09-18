using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastSight : MonoBehaviour
{

    [SerializeField] Transform originTR;
    [SerializeField] float rayLength;

    // Start is called before the first frame update
    void Start()
    {
        originTR = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
        if(Physics.Raycast(originTR.position, originTR.forward, out hitInfo, rayLength))
        {
            Debug.Log(hitInfo.collider.name);
        }
    }

    void OnDrawGizmos()
    {
        Color color = Color.red;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(originTR.position, originTR.position + originTR.forward * rayLength);
    }
}
