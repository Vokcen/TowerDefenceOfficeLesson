using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager i;
    public Transform checkPointParent;
    Transform[] checkPoints;
    GameObject[] enemyList;

    private void Awake()
    {
        if (i == null) i = this;
        else Destroy(gameObject);
    }
    private void Start()
    {
        checkPoints = new Transform[checkPointParent.childCount];
        for (int i = 0; i < checkPointParent.childCount; i++)
        {
            checkPoints[i] = checkPointParent.GetChild(i);
        }
    }
    public Transform GetPoint(int index) => checkPoints[index];
    public bool ControlChildAmount(int index) => index < checkPointParent.childCount;

    public void RefreshEnemyList()
    {
      enemyList= GameObject.FindGameObjectsWithTag("Enemy");
    }
    public GameObject[] GetEnemyList()=>enemyList;

}
