using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private Vector3 iniPosition;//salva posição inicial da camera
    float intervalo = 0f;//duração final da vibração
    public static CameraShake instance;//necessário para acesso de fora do script

    void Awake()//inicialização
    {
        iniPosition = transform.localPosition;//importante pra quando parar a vibração
        instance = this;
    }

    public static void Shake(float tempo, float intensidade)
    {
        instance.StopAllCoroutines();//encerra vibrações anteriores
        instance.StartCoroutine(instance.shakeFunction(tempo, intensidade));//inicia uma nova
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
        intervalo = 0f;//reseta o intervalo, para que a próxima faca faça a camera vibrar
        
    }
}  
