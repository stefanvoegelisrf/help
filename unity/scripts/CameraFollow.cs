using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float newSize;
    private GameObject playerObject;
    private Movement playerScript;
    private new Camera camera;
    public bool enableShake = false;
    public float shakeDuration = 1.0f;
    public float shakeMagnitude = 0.1f;
    private float shakeTimer;
    public float followSmoothness = 0.125f; // Smoothness of the position interpolation
    public float rotationSmoothness = 1f; // Smoothness of the rotation interpolation

    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
        camera = GetComponent<Camera>();
        if (playerObject != null)
        {
            playerScript = playerObject.GetComponent<Movement>();
        }
        StartCoroutine(ShakeRoutine());
    }
    void LateUpdate()
    {
        if (target != null && playerScript != null)
        {
            if (playerScript.hypnoCounter >= 3) enableShake = true;
            // Smooth Camera Follow
            Vector2 desiredPosition = new(target.position.x, target.position.y);
            Vector2 smoothedPosition = Vector2.Lerp(new Vector2(transform.position.x, transform.position.y), desiredPosition, followSmoothness);
            var smoothedPositionVector3 = new Vector3(smoothedPosition.x, smoothedPosition.y, -9);

            // Smooth Camera Rotation
            Vector2 playerDirection = playerScript.currentDirection;
            float rotationAngle = Mathf.Atan2(playerDirection.y, playerDirection.x) * Mathf.Rad2Deg - 90;
            Quaternion targetRotation = Quaternion.Euler(0, 0, rotationAngle);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSmoothness);

            if (enableShake && shakeTimer > 0)
            {
                transform.position = smoothedPositionVector3 + Random.insideUnitSphere * shakeMagnitude;
                shakeTimer -= Time.deltaTime;
            }
            else
            {
                shakeTimer = 0f;
                transform.position = smoothedPositionVector3;
            }
            if (playerScript.hypnoCounter >= 2)
            {
                camera.orthographicSize = newSize;
            }
            else
            {
                camera.orthographicSize = 1;
            }
        }
    }


    IEnumerator ShakeRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2f, 5f));
            if (enableShake)
            {
                shakeTimer = shakeDuration;
            }
        }
    }

    public void ActivateShake()
    {
        enableShake = true;
    }

    public void DeactivateShake()
    {
        enableShake = false;
    }
}