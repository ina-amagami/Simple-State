using UnityEngine;

public class Enemy : MonoBehaviour
{
	[Header("1秒間触れた場合のダメージ")]
	[SerializeField] private float damage = 3f;
	public float Damage => damage;
}
