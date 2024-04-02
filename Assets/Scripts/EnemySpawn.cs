using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject prefab;
    public List<GameObject> spawnList1 = new List<GameObject>();
    public List<GameObject> spawnList2 = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy1", 0.7f, 1.7f);
        InvokeRepeating("SpawnEnemy2", 1f, 1f);
    }

    public void SpawnEnemy1()
    {
        float randX = Random.Range(-2f, 2f);
        int ran = Random.Range(0, spawnList2.Count);

        if (enableSpawn)
        {
            for (int i = 0; i < spawnList1.Count; i++)
            {
                //Instantiate(spawnList[i], new Vector3(-2f + i, 5, 0), Quaternion.identity);
                Instantiate(spawnList1[i], new Vector3(-2f + i, 5, 0), Quaternion.identity);
            }
        }
    }

    public void SpawnEnemy2()
    {
        float randX = Random.Range(-2f, 2f);
        int ran = Random.Range(0, spawnList2.Count);

        if (enableSpawn)
        {
            for (int i = 0; i < spawnList2.Count; i++)
            {
                Instantiate(spawnList2[ran], new Vector3(0, 5, 0), Quaternion.identity);
                //Instantiate(prefab, new Vector3(randX, 5, 0), Quaternion.identity);
            }
        }
    }

    //void Spawn()
    //{
    //    System.Random rand = new System.Random();
    //    float distanceX = rand.Next(-4, 4);
    //    transform.position = new Vector2(distanceX, transform.position.y);
    //    Instantiate(prefab);
    //}

}
