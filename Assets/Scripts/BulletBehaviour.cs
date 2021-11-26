using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BulletBehaviour : MonoBehaviour
{
    public Transform target;
    public Transform target2;
    [SerializeField] float speed;
    [SerializeField] int damage, minDamage, maxDamage;
    void Start()
    {

    }


    void Update()
    {
        if (target != null)
        {
            Vector3 dir = target.position - transform.position;
            Vector3 mov = dir = dir.normalized * speed * Time.deltaTime;

            if (Vector3.Distance(target.position, transform.position) > mov.magnitude)
            {
                transform.position += mov;
            }
            else
            {
                damage = Random.Range(minDamage, maxDamage);
                bool isCriticalHit = Random.Range(0, 100) < 30;
                if (isCriticalHit)
                {
                    damage *= 2;
                    Camera.main.DOShakePosition(1, 3, 10, 90);
                }
                target.GetComponent<Hp>().TakeDamage(damage, isCriticalHit);

                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
