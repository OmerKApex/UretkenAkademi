using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sifiryedi : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 vect3;
    void Start()
    {

        vect3 = new Vector3(0, 0.7f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vect3);
    }
}
