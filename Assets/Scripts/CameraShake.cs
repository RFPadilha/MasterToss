using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static float tempo = 1f;
    private float intensidade = 1f;
    private float fadeAway = 1f;
    Vector3 initialPosition;
    void OnEnable()
    {
        initialPosition = transform.localPosition;
    }

    void Update()
    {
        if (tempo > 0)
        {
            transform.localPosition = initialPosition + Random.insideUnitSphere * intensidade;
            tempo -= Time.deltaTime * fadeAway;
        }
        else
        {
            tempo = 0f;
            transform.localPosition = initialPosition;
        }
    }
    public static void TriggerShake()
    {
        tempo = 2.0f;
        Debug.Log("Camera Shakes");
    }
}
