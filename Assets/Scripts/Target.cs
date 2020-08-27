using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float rotSpeed;//velocidade da rotação
    public float intervalo;//intervalo entre as decisões de mudança de rotação
    bool clockwise;//sentido da rotação
    void Start()
    {
        clockwise = true;//começa em sentido horario
    }

    // Update is called once per frame
    void Update()
    {
        if (clockwise == true)
        {
            transform.Rotate(0, 0, Time.deltaTime * rotSpeed, Space.Self);
        }
        else transform.Rotate(0, 0, -(Time.deltaTime * rotSpeed), Space.Self);
        RandomSpin();
            
    }
    void RandomSpin()//determina sentido da rotação aleatoriamente, 1% de chance de inverter sentido
    {
        System.Random d100 = new System.Random();
        int roll = d100.Next(1,100);//rola um dado de 100 lados pra determinar sentido
        if (roll ==1)
        {
            clockwise = !clockwise;
        }
    }

    

}
