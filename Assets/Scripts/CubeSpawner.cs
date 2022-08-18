using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;
    public GameObject diamond;
    Vector3 lastPos;
    float size;
   public bool gameOver;


    // Start is called before the first frame update
    void Start()
    {
        lastPos = cube.transform.position;
        size = cube.transform.localScale.x;
        for(int i = 0; i < 3; i++)
        {
            print("i");
            
        }
        
    }
     
    public void StartSpawnCubes()
    {
        InvokeRepeating("SpawnCubes", 0.1f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            CancelInvoke("SpawnCubes");
        }
    }

    void SpawnCubes()
    {
        int rand = Random.Range(0, 6);
        if (rand < 3)
        {
            SpawnX();
        } else if (rand >= 3)
        {
            SpawnZ();
        }
    }

    void SpawnX()
    {
        Vector3 newPos = lastPos;
        newPos.x += size;
        lastPos = newPos;
        Instantiate(cube, newPos, Quaternion.identity);
        int rand = Random.Range(0, 4);
        if (rand < 1)
        {
            Instantiate(diamond, new Vector3(newPos.x, newPos.y + 1.2f, newPos.z), diamond.transform.rotation);
        }


    }


    void SpawnZ()
    { 
        Vector3 newPos = lastPos;
        newPos.z += size;
        lastPos = newPos;
        Instantiate(cube, newPos, Quaternion.identity);
        int rand = Random.Range(0, 4);
        if (rand < 1)
        {
            Instantiate(diamond, new Vector3(newPos.x, newPos.y + 1.2f, newPos.z), diamond.transform.rotation);
        }

    }




}
