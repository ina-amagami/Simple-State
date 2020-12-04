using UnityEngine;

public class Player : MonoBehaviour
{
    public const string Tag = "Player";

    [Header("スクロール速度")]
    [SerializeField] private float moveSpeed = 1f;

    private Material materialInstance = null;

    private void Start()
    {
        materialInstance = GetComponent<MeshRenderer>().material;
    }

    private void Update()
    {
        // 自動で右方向に移動
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        materialInstance.color = Color.red;
    }

    private void OnTriggerExit(Collider other)
    {
        materialInstance.color = Color.blue;
    }

    private void OnDestroy()
    {
        Destroy(materialInstance);
    }
}
