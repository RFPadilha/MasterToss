using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private Vector3 iniPosition;//salva posição inicial da camera
    float intervalo = 0f;//contador de tempo
    public static CameraShake instance;//necessário para acesso de fora do script

    void Awake()//inicialização
    {
        iniPosition = transform.localPosition;
        instance = this;
    }

    public static void Shake(float tempo, float intensidade)
    {
        instance.StopAllCoroutines();
        instance.StartCoroutine(instance.shakeFunction(tempo, intensidade));
        Debug.Log("Camera should have shook");//camera vibra somente na primeira faca, consertarei depois
    }

    public IEnumerator shakeFunction(float tempo, float intensidade)//o script da vibração em si
    {
        
        while (intervalo < tempo)
        {
            transform.localPosition = iniPosition + (Random.insideUnitSphere * intensidade);//é o que, de fato, vibra a camera, usando os valores acima
            intervalo += Time.deltaTime;//controla o tempo decorrido
            yield return null;

        }
        transform.localPosition = iniPosition;//encerra a vibração da camera
        
    }
}  
