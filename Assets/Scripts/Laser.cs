using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private int _laserspeed = 8;

    void Update()
    {
        transform.Translate(Vector3.up * _laserspeed * Time.deltaTime);

        if (transform.position.y >= 8)
        {
            Destroy(this.gameObject);
        }
    }
}
