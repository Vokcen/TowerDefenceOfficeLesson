using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    [SerializeField] float maxHp, currentHp;
    private void Start()
    {
    currentHp=maxHp;
    }
      
      public void TakeDamage(int damage,bool isCriticalHit)
      {
          currentHp-=damage;
          DamagePopup.Create(transform.position,damage,isCriticalHit);
          if (currentHp<=0)
          { 
              currentHp=0;
              Die();
          }
      }
      void Die()
      {
          Destroy(gameObject);
          transform.tag="Untagged";
          GameManager.i.RefreshEnemyList();
      }
}
