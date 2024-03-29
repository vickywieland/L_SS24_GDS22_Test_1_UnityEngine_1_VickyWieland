using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealtimeReflection : MonoBehaviour
{
    void Update()
    {
        GetComponent<ReflectionProbe>().RenderProbe();
    }
}
