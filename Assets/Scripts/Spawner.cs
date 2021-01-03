using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] items;
    public GameObject bomb;
    public float xBound, yBound;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomItem = Random.Range(0, items.Length);

        if (Random.value <= .6f)
            Instantiate(items[randomItem],
                new Vector2(Random.Range(-xBound - 1.58f, xBound - 1.58f), yBound), Quaternion.identity);
        else
            Instantiate(bomb,
                new Vector2(Random.Range(-xBound - 1.58f, xBound - 1.58f), yBound), Quaternion.identity);

        StartCoroutine(SpawnRandomGameObject());
    }
}
