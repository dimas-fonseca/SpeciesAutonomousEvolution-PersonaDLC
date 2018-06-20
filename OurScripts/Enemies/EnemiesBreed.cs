
using UnityEngine;
using UnityEngine.AI;

public class EnemiesBreed : MonoBehaviour
{
    /*
    private int character;
    private EnemiesGlobalAttributes globalAttributes;
    private EnemiesAttributes attributes;
    private int species;
    private Persona persona;
    
    void Start()
    { 
        persona = gameObject.transform.parent.GetComponent<EnemiesGlobalAttributes>().persona;
        attributes = GetComponent<EnemiesAttributes>();
        character = int.Parse(gameObject.name);
        float randomStart = Random.value * 3;
        InvokeRepeating("EnemyBreed", randomStart, 1);
        species = gameObject.transform.parent.GetComponent<EnemiesGlobalAttributes>().species % 3;
    }

    void EnemyBreed()
    {
        if (attributes.libido >= 300)
        {
            GameObject activeCreature = GameObject.Find("Enemies" + (globalAttributes.species) % 3 + "/" + character).gameObject;
            Vector3 childPosition = new Vector3();
            Vector3 childRotation;
            Vector3 childScale;
            childPosition.x = activeCreature.transform.position.x + 7;//
            childPosition.z = activeCreature.transform.position.z + 7;//
            childRotation.x = 0;
            childRotation.y = 0;
            childRotation.z = 0;
            childScale.x = 5;
            childScale.y = 5;
            childScale.z = 1;
            GameObject creaturesNode = GameObject.Find("EnemiesCreatures/Enemies" + species+"/");//("Enemies" + species + "/");
            int lastCreatureName = int.Parse(creaturesNode.transform.GetChild(creaturesNode.transform.childCount - 1).name);
            GameObject childObject = new GameObject((lastCreatureName + 1).ToString());

            SpriteRenderer spriteRenderer = childObject.AddComponent<SpriteRenderer>();
            //Sprite creatureSprite = Resources.Load<Sprite>("species_" + PlayerInfo.selectedSpecies.ToString() + "_default");
            //childSprite.sprite = creatureSprite;

            Animator childAnimator = childObject.AddComponent<Animator>();
            childAnimator.runtimeAnimatorController = Resources.Load("playerSpeciesController") as RuntimeAnimatorController;
            childAnimator.updateMode = AnimatorUpdateMode.Normal;
            childAnimator.cullingMode = AnimatorCullingMode.AlwaysAnimate;

            childAnimator.SetInteger("movementUpgrade", attributes.movementUpgrade);
            childAnimator.SetInteger("perceptionUpgrade", attributes.perceptionUpgrade);
            childAnimator.SetInteger("combatUpgrade", Mathf.Max(attributes.attackUpgrade, attributes.deffenseUpgrade));


            childObject.transform.parent = GameObject.Find("EnemiesCreatures/Enemies" + species + "/").transform;
            childObject.transform.rotation = Quaternion.Euler(childRotation);
            childObject.transform.localScale = childScale;
            BoxCollider childBox = childObject.AddComponent<BoxCollider>();
            childBox.isTrigger = false;
            childBox.material = new PhysicMaterial("None");
            Vector3 childBoxCenter;
            childBoxCenter.x = 0;
            childBoxCenter.y = 0;
            childBoxCenter.z = 0;
            childBox.center = childBoxCenter;
            Vector3 childBoxSize;
            childBoxSize.x = 0.9f;
            childBoxSize.y = 0.8f;
            childBoxSize.z = 4;
            childBox.size = childBoxSize;
            Rigidbody childRigidbody = childObject.AddComponent<Rigidbody>();
            childRigidbody.mass = 10;
            childRigidbody.drag = 0;
            childRigidbody.useGravity = true;
            childRigidbody.isKinematic = false;
            childRigidbody.collisionDetectionMode = CollisionDetectionMode.Discrete;
            childRigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            childObject.tag = "EnemySpecies";
            Terrain terrain = GameObject.Find("Terrain").GetComponent<Terrain>();
            childPosition.y = terrain.SampleHeight(childPosition) + 12;
            childObject.transform.position = childPosition;

            NavMeshObstacle obstacle = childObject.AddComponent<NavMeshObstacle>();
            obstacle.center = new Vector3(0f, 0f, 0f);
            obstacle.size = new Vector3(1f, 1f, 4.1f);
            obstacle.carving = true;
            obstacle.enabled = true;
            NavMeshAgent agent = childObject.AddComponent<NavMeshAgent>();
            agent.radius = 0.53f;
            agent.height = 1;
            agent.speed = (6.0f + attributes.movementUpgrade * 3) * GameConstants.movementSpeed;
            agent.angularSpeed = 120;
            agent.acceleration = 99;
            agent.stoppingDistance = 0;
            agent.autoBraking = true;
            agent.avoidancePriority = 50;
            agent.autoTraverseOffMeshLink = true;
            agent.autoRepath = true;
            agent.areaMask = 1;
            agent.enabled = false;


            EnemiesAttributes childAttributes = childObject.AddComponent<EnemiesAttributes>();
            childAttributes.movementUpgrade = attributes.movementUpgrade;
            childAttributes.perceptionUpgrade = attributes.perceptionUpgrade;
            childAttributes.attackUpgrade = attributes.attackUpgrade;
            childAttributes.deffenseUpgrade = attributes.deffenseUpgrade;
            Debug.Log("Enemy newborn generated:\nSpecies - " + species + ";\nPersona - " + persona.Nome+";");
            childObject.AddComponent<EnemiesAttributeUpdater>();
            //childObject.AddComponent<CharacterMovement>();
            childObject.AddComponent<FixRotation>();
            childObject.AddComponent<EnemiesAutonomousBehavior>();

            attributes.libido -= 300;
        }
    }*/
    /*private void goToBreed()
    {
        obstacle.enabled = false;
        agent.enabled = true;
        agent.speed = (6.0f + attributes.movementUpgrade * 3) * GameConstants.movementSpeed;

        if (anim)
        {
            anim.SetBool("walking", true);
        }
        agent.SetDestination(closestAlly.obj.transform.position);
    }*/
}