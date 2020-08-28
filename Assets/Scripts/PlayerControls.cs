using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed;
    public GameObject knife;//objeto a ser instanciado várias vezes
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && AmmoDisplay.knivesLeft>0)//quando clicar com o botão esquerdo:
        {
            GameObject activeKnife;
            activeKnife = Instantiate(knife, gameObject.transform);//gera uma faca nova a cada arremesso
            activeKnife.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);//impõe aceleração na faca, no eixo Y global
            AmmoDisplay.knivesLeft--;
        }
        
    }
}
