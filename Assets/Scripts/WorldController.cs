using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour {
    public GameObject block;
    public int worldWidth = 10;
    public int worldHeight = 2;
    public int worldDepth = 10;

    public IEnumerator BuildWorld() {
        for (int z = 0; z < worldDepth; z++)
        for (int y = 0; y < worldHeight; y++) {
            for (int x = 0; x < worldWidth; x++) {
                Vector3 pos = new Vector3(x,y,z);
                GameObject cube = GameObject.Instantiate(block, pos, Quaternion.identity);
                cube.name = x + "_" + y + "_" + z;
            }

            yield return null;
        }    
        
    }
    void Start() {
        StartCoroutine(BuildWorld());
    }

}