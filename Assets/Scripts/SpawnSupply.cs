using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSupply : MonoBehaviour
{
    public Transform start, end;

    public GameObject supply;

    public int maxSupply = 10;

    public float waitSecondToSpawn = 2;

    float sx, sz, ex, ez;

    int supplyCount = 0;

    float timer = 0.0f;

    private void Start()
    {
        sx = start.position.x <= end.position.x ? start.position.x : end.position.x;
        sz = start.position.z <= end.position.z ? start.position.z : end.position.z;
        ex = start.position.x >= end.position.x ? start.position.x : end.position.x;
        ez = start.position.z >= end.position.z ? start.position.z : end.position.z;
        supply.GetComponent<Supply>().destroyEvent += onDestorySupply;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= waitSecondToSpawn)
        {
            StartCoroutine(spawnSupply());

            timer = 0;
        }
            
    }

    IEnumerator spawnSupply()
    {
        if (supplyCount < maxSupply)
        {
            supplyCount++;
            Vector3 spawnLocation = new Vector3(Random.Range(sx, ex), transform.position.y, Random.Range(sz, ez));
            GameObject isupply = Instantiate(supply, spawnLocation, supply.transform.rotation);
            isupply.GetComponent<Supply>().destroyEvent += onDestorySupply;
            isupply.transform.parent = this.transform;
        }

        yield return null;
    }

    private void onDestorySupply()
    {
        supplyCount--;
    }
}
