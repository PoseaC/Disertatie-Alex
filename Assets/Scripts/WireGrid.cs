using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireGrid : MonoBehaviour
{
    public LineRenderer wire;

    private void OnTriggerEnter(Collider other)
    {
        wire.positionCount++;
        wire.SetPosition(wire.positionCount - 1, other.gameObject.transform.position);
    }
}
