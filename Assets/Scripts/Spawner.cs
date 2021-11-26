using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField]float timeBetweenSpawns;
    IEnumerator Start()
    {
        while (true)
        {
            Instantiate(enemyPrefab,transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeBetweenSpawns);
            GameManager.i.RefreshEnemyList();
        }
    }
}
