using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utils;
public class SpiralsController : MonoBehaviour
{
    [SerializeField, Range(0, 360)] float _arc = 0;

    void OnValidate()
    {
        // var spirals = FindObjectsOfType(typeof(Animation));

        // if (spirals.Length == 0) { return; }

        // var unit = 360 / spirals.Length;

        // for (int i = 0; i < spirals.Length; i++)
        // {
        //     Debug.Log(spirals[i]);
        //     float st = (_arc - unit * i) / unit;

        //     var sp = spirals[i].GetComponent<Animation>();
        //     Debug.Log(sp);
        //     foreach (AnimationState state in sp)
        //     {
        //         state.time = Mathf.Clamp(0, 1, st);
        //     }
        // }
    }

    void Update()
    {

    }
}
