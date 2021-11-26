using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform targetPos;
    [SerializeField] float speed;
    int checkPointIndex = 0;
    void Start()
    {
        GetPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (targetPos != null)
        {
            Vector3 dir = targetPos.position - transform.position;
            Vector3 mov = dir = dir.normalized * speed * Time.deltaTime;

            if (Vector3.Distance(targetPos.position, transform.position) > mov.magnitude)
            {
                transform.position += mov;
            }
            else
            {
                transform.position = targetPos.position;
                GetPoint();
            }
        }

    }
    void GetPoint()
    {
        if (GameManager.i.ControlChildAmount(checkPointIndex))
        {
            targetPos = GameManager.i.GetPoint(checkPointIndex);
            checkPointIndex++;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
