using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject target;

    private void FixedUpdate()
    {
        Vector3 direction = new Vector3(target.transform.position.x, target.transform.position.y, this.transform.position.z);
        this.transform.position = direction;
    }
}
