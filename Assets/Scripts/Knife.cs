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
        if (collider.gameObject.CompareTag("Target") && this.gameObject.CompareTag("Knife"))//se a colisão da faca for com o alvo
        {
            CameraShake.Shake(0.2f, 0.5f);//vibra a camera ao acertar o alvo

            transform.SetParent(collider.transform, true);//muda o parent object da faca

            Score.points++;//aumenta pontuação
            audioSource.PlayOneShot(targetHit, 1f);//emite som apropriado
            gameObject.tag = "AttachedKnife";//altera a "tag" do objeto para melhor diferenciação dos objetos

            if (AmmoDisplay.knivesLeft==0)
            {
                SceneManager.LoadScene(1);//ao atirar todas as facas, recomeça a cena
                StageProgress.stage++;//avança de fase
            }

        }

        else if (collider.gameObject.CompareTag("AttachedKnife"))//se a faca atingir uma faca no alvo
        {
            audioSource.PlayOneShot(knifeHit, 1f);
            SceneManager.LoadScene(2);
        }
        
    }
     void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Apple") && this.gameObject.CompareTag("Knife"))//se a faca atingir a maçã
        {
            AppleScore.ApplePoints++;
            audioSource.PlayOneShot(appleSlice, 1f);
            Object.Destroy(collider.gameObject);//aumenta pontos e remove maçã
        }
    }
}

