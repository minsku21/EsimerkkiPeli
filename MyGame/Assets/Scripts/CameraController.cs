using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = this.transform.position - target.transform.position;
    }

    private void LateUpdate()
    {
        this.transform.position = target.transform.position + offset;
    }
}
