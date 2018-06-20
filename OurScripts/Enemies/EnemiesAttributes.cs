using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesAttributes : MonoBehaviour
{
    public static int MAX_MOVEMENT = 3000;
    public int movementRemaining;
    public int movementUpgrade = 0;
    public int perceptionUpgrade = 0;
    public int perceptionRay = 200;
    public int attackUpgrade = 0;
    public int deffenseUpgrade = 0;
    public int hungry = 300;
    public int life = 100;
    public bool dying = false;
    public int libido = 0;
    private EnemiesGlobalAttributes globalAttributes;
    private Animator anim;
    public Persona persona;

    void Start()
    {
        movementRemaining = MAX_MOVEMENT;
        globalAttributes = gameObject.transform.parent.gameObject.GetComponent<EnemiesGlobalAttributes>();
        anim = GetComponent<Animator>();
        anim.SetInteger("selectedSpecies", globalAttributes.species);

        setPersona();
        life += persona.Lifepoints;
    }

    private void setPersona() {
        persona = globalAttributes.persona;
    }

    void Update()
    {
        if (life == 0 && !dying)
        {
            StartCoroutine(deathRoutine());
        }
    }

    private IEnumerator deathRoutine()
    {
        dying = true;
        if (gameObject.GetComponent<SpriteRenderer>() == null)
        {
            gameObject.AddComponent<SpriteRenderer>();
        }

        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("species_" + globalAttributes.species + "_death");
        Destroy(gameObject.GetComponent<Animator>());
        yield return new WaitForSeconds(5.0f);
        Destroy(gameObject);
        globalAttributes.creaturesCount--;
        dying = false;
    }
}
