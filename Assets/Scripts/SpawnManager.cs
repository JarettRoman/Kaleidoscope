using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int spawnCount;

    [SerializeField] private List<GameObject> shapes = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        int j = 0;
        for (int i = 0; i < spawnCount; i++) {
            int index = Random.Range(0, shapes.Count);
            Instantiate(shapes[index], new Vector3(8, 0, j), shapes[index].transform.rotation);
            Instantiate(shapes[index], new Vector3(-8, 0, j), shapes[index].transform.rotation);
            Instantiate(shapes[index], new Vector3(0, 8, j), shapes[index].transform.rotation);
            Instantiate(shapes[index], new Vector3(0, -8, j), shapes[index].transform.rotation);
            j+=8;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
