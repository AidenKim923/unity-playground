using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : CelestialBody
{
    [SerializeField] private float m_fSunRotationSpeed = 0f; // 태양 자전 속도


    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        // 태양 자전
        transform.Rotate(Vector3.up, m_fSunRotationSpeed * Time.deltaTime);
    }
}
