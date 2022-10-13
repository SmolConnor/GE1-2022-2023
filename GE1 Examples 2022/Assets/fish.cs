using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : MonoBehaviour
{

    public Transform head;
    public Transform tail;
    public float Theta;
    [Range(0.1f, 3.0f)]
    public float frequincy;
    public float headAmplitude;
    public float tailAmplitude;
    // Start is called before the first frame update
    void Start()
    {
        frequincy = 0.6f;
        headAmplitude = 10f;
        tailAmplitude = 10f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        head.localRotation = Quaternion.AngleAxis(headAmplitude, Vector3.forward);
    }
}
