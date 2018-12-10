using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    [SerializeField]
    float Xmin;
    [SerializeField]
    float Xmax;
    [SerializeField]
    float Ymin;
    [SerializeField]
    float Ymax;

    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;    
    }

    void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x, Xmin, Xmax),Mathf.Clamp(target.position.y, Ymin, Ymax),transform.position.z);
    }

}
