using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelestialBody : MonoBehaviour
{
    [SerializeField] protected float orbitSpeed = 1f; // 공전 속도
    [SerializeField] protected float rotateSpeed = 1f; // 자전 속도
    [SerializeField] protected float orbitRadius = 1f; // 공전 반지름
    [SerializeField] protected float orbitAngle = 0f; // 공전 각도
    [SerializeField] protected float rotateAngle = 0f; // 자전 각도

    [SerializeField] protected float gravity = 0f; // 중력
    [SerializeField] protected float mass = 0f; // 질량

    // Start is called before the first frame update
    protected virtual void Start()
    {
        Vector3 initPosition = new Vector3(orbitRadius, 0, 0);
        transform.position = initPosition;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        // 공전
        orbitAngle += Time.deltaTime * orbitSpeed;
        float orbitX = Mathf.Cos(orbitAngle) * orbitRadius;
        float orbitZ = Mathf.Sin(orbitAngle) * orbitRadius;
        transform.position = new Vector3(orbitX, 0, orbitZ);

        // 자전
        rotateAngle += Time.deltaTime * rotateSpeed;
        transform.Rotate(Vector3.up, rotateAngle);
    }
}
