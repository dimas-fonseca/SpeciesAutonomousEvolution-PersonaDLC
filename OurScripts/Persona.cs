using UnityEngine;

public class Persona {//:MonoBehaviour {
    public string Nome;
    public int Attack, Defense, Lifepoints, FatigueGain, LibidoGain, HungryGain, NAttack;
    public float MoveSpeed;

    /*public Persona() {
        Nome = "";
        Attack = Defense = Lifepoints = FatigueGain = LibidoGain = HungryGain = NAttack = 0;
        MoveSpeed = 0.0f;
    }*/
    void Start()
    {
        Nome = "";
        Attack = Defense = Lifepoints = FatigueGain = LibidoGain = HungryGain = NAttack = 0;
        MoveSpeed = 0.0f;
    }
    public /*void set*/ Persona (string nome, int attack, int defense, int lifepoints, float moveSpeed, int fatigueGain, int libidoGain, int hungryGain, int nAttack) {
        Nome = nome;
        Attack = attack;
        Defense = defense;
        Lifepoints = lifepoints;
        MoveSpeed = moveSpeed;
        FatigueGain = fatigueGain;
        LibidoGain = libidoGain;
        HungryGain = hungryGain;
        NAttack = nAttack;
	}
    public Persona(Persona p) {
        Nome = p.Nome;
        Attack = p.Attack;
        Defense = p.Defense;
        Lifepoints = p.Lifepoints;
        MoveSpeed = p.MoveSpeed;
        FatigueGain = p.FatigueGain;
        LibidoGain = p.LibidoGain;
        HungryGain = p.HungryGain;
        NAttack = p.NAttack;
    }

    public string ToString(){
        return "Persona - " +Nome+";\nAttack - "+Attack+";\nDefense - "+Defense+";\nLifepoints - "+Lifepoints+";\nMoveSpeed - "+MoveSpeed+ ";\nFatigue Gain - "+FatigueGain+"/s;\nLibido Gain - "+LibidoGain+"/s;\nHungry Gain - "+HungryGain+"/s;\nAdditional Attacks - "+NAttack;
    }
}
