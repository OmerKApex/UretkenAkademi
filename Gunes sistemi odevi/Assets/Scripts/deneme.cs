using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        gameObject.transform.Rotate(0, speed, 0);

    }

}
