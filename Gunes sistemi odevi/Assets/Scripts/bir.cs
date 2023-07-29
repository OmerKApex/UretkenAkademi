using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bir : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 vect3;
    void Start()
    {
        vect3 = new Vector3(0, 1.0f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vect3);
    }
}
