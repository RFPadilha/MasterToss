using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float rotSpeed;//velocidade da rotação
    public float intervalo;//intervalo entre as decisões de mudança de rotação
    bool clockwise;//sentido da rotação

    public GameObject startingKnives;
    public GameObject extraApples;

    public int numberOfApples;
    void Start()
    {
        clockwise = true;//começa em sentido horario
        if (StageProgress.stage > 0)//se passou da primeira fase
        {
            System.Random d4 = new System.Random();
            int numberOfKnives = d4.Next(1, 4) - 1;//inicializa com um numero aleatorio de facas no alvo, entre 0 e 3
            numberOfApples = d4.Next(1, 3) - 1;//inicializa com um numero aleatorio de maçãs, além da que já foi colocada
           
            for (int i = 0; i < numberOfKnives; i++)
            {
                float posX=0;
                float posY=0;

                GameObject attachedKnife;
                if (i == 1)
                {
                    posX = 0;
                    posY = 3.3f;
                }else if (i == 2)
                {
                    posX = 1.65f;
                    posY = 1.65f;
                }

                attachedKnife = Instantiate(startingKnives, new Vector2(posX, posY),
                    Quaternion.LookRotation(Vector3.forward),//garante que a faca esteja na orientação certa
                    gameObject.transform) ;//coloca as facas no alvo em posições aleatórias
                attachedKnife.transform.rotation = new Quaternion(0, 0, 90 * i, 0);
                attachedKnife.tag = "AttachedKnife";
                //problemas com o posicionamento e angulação relativos da faca
            }//controla o spawn de facas
            for (int j = 0; j < numberOfApples; j++)
            {
                float X = 1.3f;
                float Y = 2.83f;

                GameObject apples;
                if (j == 1)
                {
                    X = -1.3f;
                    Y = 2.83f;
                }else if (j == 2)
                {
                    X = 1.45f;
                    Y = 0.55f;
                }//manualmente seleciona a posição das maçãs extras


                apples = Instantiate(extraApples, new Vector2(X, Y),
                    Quaternion.LookRotation(Vector3.forward),//garante que a faca esteja na orientação certa
                    gameObject.transform);//coloca as facas no alvo em posições aleatórias
                apples.transform.rotation = new Quaternion(0, 0, 120 * j, 0);
                apples.tag = "Apple";//tag é importante pra contabilizar a pontuação de maçãs

            }//controla o spawn de maças
            
        }
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
