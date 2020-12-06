using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] enemyPrefabs = null;
    [SerializeField] private float posY = 0.4f;
    [SerializeField] private float limit = 500f;
    [SerializeField] private float startX = 10f;
    [SerializeField] private float minSpan = 8f;
    [SerializeField] private float maxSpan = 12f;

    void Awake()
    {
        Vector3 pos = new Vector3(startX, posY, 0);
        while (pos.x <= limit)
		{
            var prefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
            var obj = Instantiate(prefab, transform);
            obj.transform.position = pos;
            pos.x += Random.Range(minSpan, maxSpan);
		}
    }
}
