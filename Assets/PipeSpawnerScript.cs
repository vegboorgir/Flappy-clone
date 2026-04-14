using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
   [Header("Pipe Settings")]
   public GameObject pipe;

   [Header("Spawn Time")]
   public float spawnRate = 2f;
   private float timer = 0f;

   [Header("Spawn random values")]
   public float minY = -2f;
   public float maxY = 2f;

   [Header("Spawn Position")]
   public float spawnX = 9f;

   void Update()
    {
        timer += Time.deltaTime;
        if(timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(minY,maxY);
        Vector3 spawnPosition = new Vector3(spawnX, randomY, 0f);
        Instantiate(pipe, spawnPosition, Quaternion.identity);
    } 
}