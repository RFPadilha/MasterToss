using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    
    Rigidbody2D m_Rigidbody;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Target"))//se a colisão da faca for com o alvo
        {
            transform.SetParent(collider.transform, true);//muda o parent object da faca
            m_Rigidbody.velocity = Vector2.zero;//impede que a faca continue se movendo após a colisao
            m_Rigidbody.freezeRotation = true;//impede que a faca gire no próprio eixo
            Score.points++;
            CameraShake.TriggerShake();

        }
        else if (collider.gameObject.CompareTag("Apple"))
        {
            AppleScore.ApplePoints++;
            Object.Destroy(collider.gameObject);//se a faca atingir a maçã, aumenta pontos e remove maçã
        }
        else if (collider.gameObject.CompareTag("Knife"))
        {
            Debug.Log("Game Ends");
        }
        
    }
}

