using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] Rigidbody src;
    [SerializeField] Rigidbody dst;
    [SerializeField] float force = 5;

    void Update()
    {
        var c = new Vector3(0, 5, 0);
        var ds = (c - src.transform.position * (1 + Mathf.PerlinNoise(Time.time, 0) * 0.3f)).normalized;
        var ls = (c - src.transform.position).magnitude + 1;
        src.AddForce(ds * force * ls);

        var dd = (c - dst.transform.position * (1 + Mathf.PerlinNoise(Time.time, 1) * 0.3f)).normalized;
        var ld = (c - dst.transform.position).magnitude + 1;
        dst.AddForce(dd * force * ld);
    }
}
