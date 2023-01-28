using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI    ;

public class AIChase : MonoBehaviour
{
    public enum AISTATE {PATROL=0, CHASE=1, ATTACK=2};

    private NavMeshAgent ThisAgent = null;
    private Transform Player = null;

    void Awake() {
        ThisAgent = GetComponent<NavMeshAgent>();
        Player = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update() {
        ThisAgent.SetDestination(Player.position);
    }
}
