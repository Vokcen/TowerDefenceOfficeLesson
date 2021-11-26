using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TowerBehaviour : MonoBehaviour
{
   public Transform target;
    [SerializeField] float viewDistance, fireSpeed, fireTimer;
    [SerializeField] GameObject head;
    Transform enemyPos;
    void Start()
    {

    }

    // Update is called once per frame
    public virtual void Update()
    {
        fireTimer -= Time.deltaTime;
        if (target != null) if (head != null) head.transform.LookAt(target.transform.position);
        if (fireTimer <= 0)
        {
            fireTimer = fireSpeed;
            Fire();
        }
        else FindEnemy();
    }
    void FindEnemy()
    {
        GameObject[] enemyList = GameManager.i.GetEnemyList();
        foreach (var item in enemyList)
        {
            if (Vector3.Distance(item.transform.position, transform.position) < viewDistance)
            {
                target = item.transform;

                break;


            }
        }
    }
    public virtual void Fire()
    {
   
    }
    public virtual void Fire2()
    {

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, viewDistance);
    }
  
}
