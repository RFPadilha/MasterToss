using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class Knife : MonoBehaviour
{
    public AudioClip targetHit;
    public AudioClip appleSlice;
    public AudioClip knifeHit;

    AudioSource audioSource;

    Rigidbody2D m_Rigidbody;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
   
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Target"))//se a colisão da faca for com o alvo
        {
            CameraShake.Shake(0.5f, 1);//vibra a camera ao acertar o alvo

            transform.SetParent(collider.transform, true);//muda o parent object da faca
            m_Rigidbody.velocity = Vector2.zero;//impede que a faca continue se movendo após a colisao
            m_Rigidbody.freezeRotation = true;//impede que a faca gire no próprio eixo

            Score.points++;//aumenta pontuação
            audioSource.PlayOneShot(targetHit, 1f);//emite som apropriado
            gameObject.tag = "AttachedKnife";//altera a "tag" do objeto para melhor diferenciação dos objetos

            if (AmmoDisplay.knivesLeft==0)
            {
                SceneManager.LoadScene(1);//ao atirar todas as facas, recomeça a cena
            }

        }

        else if (collider.gameObject.CompareTag("AttachedKnife"))//se a faca atingir uma faca no alvo
        {
            audioSource.PlayOneShot(knifeHit, 1f);
            FindObjectOfType<GameManager>().GameOver();
            SceneManager.LoadScene(0);
        }
        
    }
     void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Apple"))//se a faca atingir a maçã
        {
            AppleScore.ApplePoints++;
            audioSource.PlayOneShot(appleSlice, 1f);
            Object.Destroy(collider.gameObject);//aumenta pontos e remove maçã
        }
    }
}

