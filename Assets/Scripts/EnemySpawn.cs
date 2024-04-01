using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject prefab;
    public List<GameObject> spawnList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 1f);
    }

    public void SpawnEnemy()
    {
        float randX = Random.Range(-2f, 2f);

        //for(int i = 0; i < spawnList.Count;)
        //{
        //        spawnList.Add(prefab);
        //}

        if (enableSpawn)
        {
            for (int i = 0; i < spawnList.Count; i++)
            {
                Instantiate(spawnList[i], new Vector3(-2f + i, 5, 0), Quaternion.identity);
                //Instantiate(prefab, new Vector3(i * .5f, 5, 0), Quaternion.identity);
            }
        }
    }

    void Spawn()
    {
        System.Random rand = new System.Random();
        float distanceX = rand.Next(-4, 4);
        transform.position = new Vector2(distanceX, transform.position.y);
        Instantiate(prefab);
    }

}
