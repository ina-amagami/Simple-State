using UnityEngine;

// ステート以外の処理部分
public partial class Player : MonoBehaviour
{
    public const string Tag = "Player";

    [Header("最大HP")]
    [SerializeField] private float maxHp = 5f;
    public float MaxHp => maxHp;

    private float _Hp;
    public float Hp
    {
        get => _Hp;
        set
        {
            _Hp = Mathf.Min(value, maxHp);
            if (_Hp <= 0)
            {
                _Hp = 0;
                Death();
            }
        }
    }

    [Header("スクロール速度")]
    [SerializeField] private float moveSpeed = 4f;

    [Header("死んだ時にRigidbodyに与える力")]
    [SerializeField] private Vector3 deathAddForce = Vector3.zero;
    [SerializeField] private Vector3 deathAddTorque = Vector3.zero;

    private Vector3 defaultScale;
    private Material materialInstance = null;
    private Rigidbody rigidBody;

    public System.Action OnDeathAction;

    private void Start()
    {
        Hp = maxHp;
        defaultScale = transform.localScale;
        rigidBody = GetComponent<Rigidbody>();
        materialInstance = GetComponent<MeshRenderer>().material;
        OnStart();
    }

	private void Update()
	{
        // 自動で右方向に移動
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        OnUpdate();
    }

    private void OnDestroy()
    {
        Destroy(materialInstance);
    }

    // 死亡
    private void Death()
	{
        OnDeath();
        OnDeathAction?.Invoke();
    }

    // 地面(Y=0)に接地させる
    private void AdjustGround()
    {
        var pos = transform.position;
        pos.y = transform.localScale.y * 0.5f;
        transform.position = pos;
    }

    #region 敵との当たり判定

    private void OnTriggerEnter(Collider other)
    {
        materialInstance.color = Color.red;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            Hp -= enemy.Damage * Time.deltaTime;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        materialInstance.color = Color.blue;
    }

    #endregion
}
