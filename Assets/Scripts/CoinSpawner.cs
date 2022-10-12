using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;

    // Start is called before the first frame update
    void Start()
    {
        coinPrefab = GameObject.FindWithTag("Coin");
        SpawnCoin();
        SpawnCoin();
    }

    private void SpawnCoin()
    {
        int xPos = Random.Range(-10, 10);
        int yPos = Random.Range(-10, 10);
        int zPos = Random.Range(-10, 10);
        Instantiate(coinPrefab, new Vector3(xPos, yPos, zPos), Quaternion.identity);
    }
}
