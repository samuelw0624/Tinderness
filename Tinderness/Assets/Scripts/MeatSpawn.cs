using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatSpawn : MonoBehaviour
{
    public GameObject[] meats;
    public GameObject SpawnPos;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(meats[Random.Range(0, meats.Length)], SpawnPos.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("no meat");
        Instantiate(meats[Random.Range(0, meats.Length)], SpawnPos.transform.position, Quaternion.identity);
    }
}
