//#2-------------
//Select terrain, change to static, navigation - BAKE
using UnityEngine.AI;

//before class [RequireCoponent(typeof(NavMeshAgent))]

public class blahblahblah : MonoBehaviour
 private NavMeshAgent agent;
 void Awake(){
     agent = GetComponent<NavMeshAgent>();
 }

 void Update(){
     agent.destination = player.position;
 }

 //#3-----------Send to enemy
 using System;
 public static Action<Transform> SendTransforms;
 
 void Start(){
     SendTransform(transform); //this is just GetComponent<transform>(); But SHORTENED c:

 }
 //In The Enemy Script
 private Transform player;
 void Start(){
     SendToEnemy.SendTransform += SendTransformHandler;
 }
private void SendTransformHandler(Transform _transform){
    player = _transform;
}

//EnemyMove#1
    public NavMeshAgent agent;
    public Transform player;
    void Update(){
        agent.destination = player.position;
    }