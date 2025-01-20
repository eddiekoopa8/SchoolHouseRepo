using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cameraTransform;
    public Vector3 offsetAngle = new Vector3(0, 0, 0);
    void Start()
    {
        if (cameraTransform == null)
        {
            Debug.LogError("no camera found. dont want me? kill me from gameobject then.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cameraTransform);
        transform.Rotate(offsetAngle.x, offsetAngle.y, offsetAngle.z);
    }
}
