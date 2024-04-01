using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 1f);
    }

    public void SpawnEnemy()
    {
        float randX = Random.Range(-2f, 2f);

        if (enableSpawn)
        {
            Instantiate(prefab, new Vector3(randX, 5, 0f), Quaternion.identity);
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
