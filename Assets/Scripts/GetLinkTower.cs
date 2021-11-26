using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GetLinkTower : TowerBehaviour
{ 
   [SerializeField]GameObject bulletPrefab,bulletPrefab2;
   [SerializeField]GameObject weapon1;
   [SerializeField]GameObject weapon2;
    public override void Fire()
    {
        base.Fire();
        Instantiate(bulletPrefab,weapon1.transform.position,Quaternion.identity).GetComponent<BulletBehaviour>().target=target;
        weapon1.transform.DOPunchPosition(-transform.forward,0.1f,1);
        weapon2.transform.DOPunchPosition(-transform.forward,0.1f,1);
      
    }
   
  public override void Update()
  {
      base.Update();
  }

}
