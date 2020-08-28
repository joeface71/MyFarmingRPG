
using UnityEngine;
using Cinemachine;
using System;

public class SwitchConfineBoundingShape : MonoBehaviour
{
    void Start()
    {
        SwitchBoundingShape();
    }

    /// <summary>
    /// Switch the collider that cinemachine uses to define the edges of the screen
    /// </summary>
    private void SwitchBoundingShape()
    {
        // Get the polygon collider on the boundsconfiner gameobject which is used by cm to prevent the cam from going beyond the screen edge
        PolygonCollider2D polygonCollider2D = GameObject.FindGameObjectWithTag(Tags.BoundsConfiner).GetComponent<PolygonCollider2D>();

        CinemachineConfiner cinemachineConfiner = GetComponent<CinemachineConfiner>();

        cinemachineConfiner.m_BoundingShape2D = polygonCollider2D;

        // since the confiner bounds have changed need to clear the cache

        cinemachineConfiner.InvalidatePathCache();
    }
}
