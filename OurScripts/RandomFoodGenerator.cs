using System.Collections.Generic;
using UnityEngine;

public class RandomFoodGenerator : MonoBehaviour {
    public static int randomFoodCount;
    private int maxRandomFood = 100;
    private float generateFrameInSeconds = 10;
    Vector3 terrainSize;
    Terrain terrain;

    private List<Persona> personas = new List<Persona>();

    void Start ()
    {
        randomFoodCount = 0;
        InvokeRepeating("GenerateFood", 0, generateFrameInSeconds);
        terrain = GameObject.Find("Terrain").GetComponent<Terrain>();
        terrainSize = terrain.terrainData.size;

        Persona aux;//GetComponent<Persona>();//GameObject.Find("EnemiesCreatures/").AddComponent<Persona>();
        aux = new Persona("Raiva", 5, 0, 0, 0.0f, 0, 0, 0, 0);
        personas.Add(aux);
        aux = new Persona("Inveja", 0, 5, 0, 0.0f, 0, 0, 0, 0);
        personas.Add(aux);
        aux = new Persona("Orgulho", 0, 0, 20, 0.0f, 0, 0, 0, 0);
        personas.Add(aux);
        aux = new Persona("Ganância", 0, 0, 0, 0.5f, 0, 0, 0, 0);
        personas.Add(aux);
        aux = new Persona("Preguiça", 0, 0, 0, 0.0f, 1, 0, 0, 0);
        personas.Add(aux);
        aux = new Persona("Luxúria", 0, 0, 0, 0.0f, 0, 1, 0, 0);
        personas.Add(aux);
        aux = new Persona("Gula", 0, 0, 0, 0.0f, 0, 0, 1, 0);
        personas.Add(aux);

        /* 
        Para adicionar novas personas, só adicionar as seguintes linhas, modificando o que desejar na primeira e mantendo a segunda intacta
        aux = new Persona(string Nome da persona, int incremento de ataque, int incremento de defesa, int incremento de pontos de vida, 
                          float incremento da velocidade de movimento (não recomendado valores acima de 0.5f), int ganho de fadiga incremental, 
                          int ganho de libido incremental, int ganho de fome incremental, int numero de ataques adicionais);
        personas.Add(aux);
        */

        PlayerInfo.creaturePersona0 = personas[Random.Range(0, personas.Count)];
        Debug.Log(PlayerInfo.creaturePersona0.ToString());
        PlayerInfo.creaturePersona1 = personas[Random.Range(0, personas.Count)];
        Debug.Log(PlayerInfo.creaturePersona1.ToString());
        PlayerInfo.creaturePersona2 = personas[Random.Range(0, personas.Count)];
        Debug.Log(PlayerInfo.creaturePersona2.ToString());
    }
	
    void GenerateFood ()
    {
        if(randomFoodCount < maxRandomFood)
        {
            Vector3 foodPosition = new Vector3();
            Vector3 foodRotation;
            Vector3 foodScale;
            foodPosition.x = Random.Range(3, terrainSize.x-10);
            foodPosition.z = Random.Range(3, terrainSize.z-10);
            foodRotation.x = 0;
            foodRotation.y = 0;
            foodRotation.z = 0;
            foodScale.x = 5;
            foodScale.y = 5;
            foodScale.z = 1;
            GameObject foodObject = new GameObject("RandomFood");
            foodObject.transform.parent = gameObject.transform;
            foodObject.transform.rotation = Quaternion.Euler(foodRotation);
            foodObject.transform.localScale = foodScale;
            BoxCollider foodBox = foodObject.AddComponent<BoxCollider>();
            foodBox.isTrigger = false;
            foodBox.material = new PhysicMaterial("None");
            Vector3 foodBoxCenter;
            foodBoxCenter.x = 0;
            foodBoxCenter.y = 0;
            foodBoxCenter.z = 0;
            foodBox.center = foodBoxCenter;
            Vector3 foodBoxSize;
            foodBoxSize.x = 0.6f;
            foodBoxSize.y = 0.8f;
            foodBoxSize.z = 2;
            foodBox.size = foodBoxSize;
            SpriteRenderer foodSprite = foodObject.AddComponent<SpriteRenderer>();
            int randomFruitNumber = Random.Range(4, 7);
            Sprite fruitSprite = Resources.Load<Sprite>("fruta"+randomFruitNumber);
            foodSprite.sprite = fruitSprite;
            foodObject.tag = "RandomFood";
            foodObject.AddComponent<FoodMarks>();

            foodPosition.y = terrain.SampleHeight(foodPosition) + foodBoxSize.y + 1;
            foodObject.transform.position = foodPosition;

            randomFoodCount++;
        }
    }
}
