using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpeedPointsManager : MonoBehaviour
{
    [SerializeField] List<Transform> speedPoints = new List<Transform>();
    [SerializeField] private GameObject speedForcePrefab;
    [SerializeField] private LayerMask groundMask;

    private void Start()
    {
        for(int i = 0; i < 80; i++)
        {
            RaycastHit hit;

            Transform tranform = speedPoints[Random.Range(0, speedPoints.Count)];

            if(Physics.Raycast(tranform.position, -tranform.up, out hit, 10000f, groundMask))
            {
                Instantiate(speedForcePrefab, hit.point + Vector3.up * 2f, Quaternion.identity);
            }
        }
    }
}
