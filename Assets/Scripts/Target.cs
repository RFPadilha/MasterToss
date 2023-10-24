using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.LightmapEditorSettings;

public class Target : MonoBehaviour
{
    public static Target Instance { get; private set; }
    public float rotSpeed;//velocidade da rotação
    public float intervalo;//intervalo entre as decisões de mudança de rotação
    bool clockwise;//sentido da rotação

    public GameObject startingKnives;
    public GameObject extraApples;

    public int numberOfApples;
    int numberOfKnives;
    public float currentSpeed=0f;
    public float maxSpeed = 100f;
    public float damping = 10;
    float spinTimer = 5f;
    float currentTimer = 5f;
    void Start()
    {
        Instance = this;
        SetGame();
    }
    // Update is called once per frame
    void Update()
    {
        currentSpeed = Mathf.Clamp(currentSpeed + Time.deltaTime * damping * (clockwise ? 1 : -1), -maxSpeed, maxSpeed);

        transform.Rotate(0, 0, Time.deltaTime * currentSpeed, Space.Self);
        currentTimer -= Time.deltaTime;
        if(currentTimer <= 0)
        {
            RandomSpin();
            currentTimer = spinTimer;
        }
    
    }


    void SetGame()
    {
        clockwise = true;//começa em sentido horario
        if (StageProgress.stage >= 0)
        {
            if (StageProgress.stage > 1) numberOfKnives = StageProgress.stage - 1;
            else numberOfKnives = 0;
            numberOfApples = StageProgress.stage + 1;

            SpawnObject(startingKnives, numberOfKnives, "AttachedKnife", 0f);
            SpawnObject(extraApples, numberOfApples, "Apple", 180f);
        }
    }
    public void ResetGame()
    {
        Time.timeScale = 0.1f;
        System.Random rand = new System.Random();
        DestroyChildrenWithTag("Apple");
        DestroyChildrenWithTag("AttachedKnife");
        StageProgress.stage++;//avança de fase
        SetGame();
        AmmoDisplay.knivesLeft = numberOfApples*(StageProgress.stage+1);
        Invoke("ResetTime", .1f);
    }
    void ResetTime()
    {
        Time.timeScale = 1f;
    }
    void RandomSpin()//determina sentido da rotação aleatoriamente, 1% de chance de inverter sentido
    {
        System.Random d100 = new System.Random();
        int roll = d100.Next(1,100);//rola um dado de 100 lados pra determinar sentido
        if (roll <=50)
        {
            clockwise = !clockwise;
        }
    }
    public void DestroyChildrenWithTag(string tag)
    {
        // compare children of game object
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            // only destroy tagged object
            if (transform.GetChild(i).gameObject.CompareTag(tag))
                Destroy(transform.GetChild(i).gameObject);
        }
    }
    void SpawnObject(GameObject obj, int amount, string tag, float angleOffset)
    {
        for (int j = 0; j < amount; j++)
        {
            GameObject newObject = Instantiate(obj);
            newObject.transform.RotateAround(transform.position, Vector3.forward, (360f / amount) * j);
            newObject.transform.parent = transform;
            newObject.transform.rotation = Quaternion.Euler(0, 0, ((360f / amount) * j) + angleOffset);
            newObject.tag = tag;

        }
    }
    

}
