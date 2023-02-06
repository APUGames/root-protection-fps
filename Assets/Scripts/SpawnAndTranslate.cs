using UnityEngine;
using System.Collections;

public class SpawnAndTranslate : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Vector3 positionToTranslate;
    public float translationSpeed = 1.0f;
    public float spawnQueueTime = 2.0f;

    private float spawnerCurrentTime = 0f;

    private void Start()
    {
        spawnerCurrentTime = spawnQueueTime;

        Spawn();
    }

    private void Update()
    {
        if (spawnerCurrentTime <= 0f)
        {
            Spawn();
            spawnerCurrentTime = spawnQueueTime;
        }
        else
        {
            spawnerCurrentTime -= Time.deltaTime;
        }
    }

    private void Spawn()
    {
        GameObject spawnedPrefab = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        StartCoroutine(TranslateOverTime(spawnedPrefab.transform, positionToTranslate, translationSpeed));
    }

    private IEnumerator TranslateOverTime(Transform objToTranslate, Vector3 endPosition, float speed)
    {
        if (objToTranslate != null)
        {
            float t = 0.0f;
            Vector3 startPosition = objToTranslate.position;

            while (t < 1.0f)
            {
                t += Time.deltaTime * speed;
                if (objToTranslate != null)
                {
                    objToTranslate.position = Vector3.Lerp(startPosition, endPosition, t);
                    yield return null;
                }
            }

            if (objToTranslate != null)
            {
                objToTranslate.position = endPosition;
            }
        }
    }
}
