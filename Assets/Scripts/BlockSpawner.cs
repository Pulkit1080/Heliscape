using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject[] BlockPrefabs;
    public Transform playerTransform;
    private float SpawnX = 40f;
    private float BlockLength = 150;
    private int amtOfBlocksOnScreen = 1;

    // Start is called before the first frame update
    void Start()
    {
        int prefabIndex = Random.Range(0, BlockPrefabs.Length);
        for (int i = 0; i < amtOfBlocksOnScreen; i++)
        {
            SpawnBlock(prefabIndex);
        }
    }

    // Update is called once per frame
    void Update()
    {
        int prefabIndex = Random.Range(0, BlockPrefabs.Length);
        if(playerTransform.position.x > (SpawnX - amtOfBlocksOnScreen * BlockLength))
        {
            SpawnBlock(prefabIndex);
        }
    }

    private void SpawnBlock(int prefabIndex)
    {
        GameObject go;
        go = Instantiate(BlockPrefabs[prefabIndex]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.right * SpawnX;
        SpawnX += BlockLength; 
    }

}
