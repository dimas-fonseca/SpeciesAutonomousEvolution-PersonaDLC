using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesAttributeUpdater : MonoBehaviour {
    EnemiesAttributes attributes;

    void Start()
    {
        attributes = GetComponent<EnemiesAttributes>();
        InvokeRepeating("IncreaseLibido", 0, 1);
        InvokeRepeating("DecreaseHungry", 0, 1);
    }

    void IncreaseLibido()
    {
        if (attributes.libido < 200)
        {
            attributes.libido++;
            //Debug.Log(attributes.persona.LibidoGain);
            if (attributes.persona.LibidoGain > 0 && (attributes.libido + attributes.persona.LibidoGain) < 200) { //
                attributes.libido += attributes.persona.LibidoGain;
            }
            else if (attributes.persona.LibidoGain > 0 && (attributes.libido + attributes.persona.LibidoGain) >=200) {
                attributes.libido = 200;
            }
        }
        
    }

    void DecreaseHungry()
    {
        if (attributes.hungry > 0)
        {
            attributes.hungry--;

            if (attributes.persona.HungryGain > 0 && (attributes.hungry - attributes.persona.HungryGain) > 0)
            { //
                attributes.hungry -= attributes.persona.HungryGain;
            }
            else if (attributes.persona.HungryGain > 0 && (attributes.hungry - attributes.persona.HungryGain) <= 0)
            {
                attributes.hungry = 0;
            }
        }
        else if (attributes.life > 0)
        {
            attributes.life--;
            if (attributes.persona.HungryGain > 0 && (attributes.life - attributes.persona.HungryGain) > 0)
            { //
                attributes.life -= attributes.persona.HungryGain;
            }
            else if (attributes.persona.HungryGain > 0 && (attributes.life - attributes.persona.HungryGain) <= 0)
            {
                attributes.life = 0;
            }
        }
    }
}
