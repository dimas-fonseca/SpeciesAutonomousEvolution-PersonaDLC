using UnityEngine;

public class EnemiesGlobalAttributes : MonoBehaviour {
    public int species;
    public int creaturesCount = 0;
    public Persona persona;//= GetComponent<Persona>();
    public string nomeCriatura;

    void Start () {
        GameObject.Find("EnemiesCreatures/Enemies0").GetComponent<EnemiesGlobalAttributes>().species = (PlayerInfo.selectedSpecies + 1) % 4;
        GameObject.Find("EnemiesCreatures/Enemies0").GetComponent<EnemiesGlobalAttributes>().persona = new Persona(PlayerInfo.creaturePersona0);//

        GameObject.Find("EnemiesCreatures/Enemies1").GetComponent<EnemiesGlobalAttributes>().species = (PlayerInfo.selectedSpecies + 2) % 4;
        GameObject.Find("EnemiesCreatures/Enemies1").GetComponent<EnemiesGlobalAttributes>().persona = new Persona (PlayerInfo.creaturePersona1);//

        GameObject.Find("EnemiesCreatures/Enemies2").GetComponent<EnemiesGlobalAttributes>().species = (PlayerInfo.selectedSpecies + 3) % 4;
        GameObject.Find("EnemiesCreatures/Enemies2").GetComponent<EnemiesGlobalAttributes>().persona = new Persona(PlayerInfo.creaturePersona2);//

        GameObject.Find("EnemiesCreatures/Enemies0").GetComponent<EnemiesGlobalAttributes>().nomeCriatura = GetNome((PlayerInfo.selectedSpecies + 1) % 4);
        GameObject.Find("EnemiesCreatures/Enemies1").GetComponent<EnemiesGlobalAttributes>().nomeCriatura = GetNome((PlayerInfo.selectedSpecies + 2) % 4);
        GameObject.Find("EnemiesCreatures/Enemies2").GetComponent<EnemiesGlobalAttributes>().nomeCriatura = GetNome((PlayerInfo.selectedSpecies + 3) % 4);
    }

    private string GetNome(int n) {
        switch (n) {
            case 0: return "Algawa";
            case 1: return "Tetuf";
            case 2: return "Hudufa";
            case 3: return "Hibay";
        }
        return "";
    }
}

