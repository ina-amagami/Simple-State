//using UnityEngine;

//public partial class Player
//{
//	public bool IsDead { get; private set; } = false;
//	private bool isJumping = false;
//	private bool isDucking = false;
//	private bool isDiving = false;

//	// Start()から呼ばれる
//	private void OnStart()
//	{
//	}

//	// Update()から呼ばれる
//	private void OnUpdate()
//	{
//		if (Input.GetKeyDown(KeyCode.DownArrow))
//		{
//			if (isJumping && !isDiving)
//			{
//				Dive();
//			}
//		}

//		if (Input.GetKey(KeyCode.DownArrow))
//		{
//			if (!isDucking && !isJumping && !isDiving)
//			{
//				StartDuck();
//			}
//		}
//		else
//		{
//			if (isDucking && !isJumping && !isDiving)
//			{
//				EndDuck();
//			}
//		}

//		if (!isJumping && !isDucking && !isDiving && Input.GetKeyDown(KeyCode.Space))
//		{
//			Jump();
//		}
//	}

//	// ジャンプ
//	private void Jump()
//	{
//		rigidBody.AddForce(Vector3.up * 7f, ForceMode.Impulse);
//		isJumping = true;
//	}

//	// ダイブ
//	private void Dive()
//	{
//		rigidBody.AddForce(Vector3.down * 14f, ForceMode.Impulse);
//		isJumping = false;
//		isDiving = true;
//	}

//	// しゃがみ開始
//	private void StartDuck()
//	{
//		transform.localScale = Vector3.one;
//		AdjustGround();
//		isDucking = true;
//	}

//	// しゃがみ終了
//	private void EndDuck()
//	{
//		transform.localScale = defaultScale;
//		AdjustGround();
//		isDucking = false;
//	}

//	// 死亡した時に呼ばれる
//	private void OnDeath()
//	{
//		IsDead = true;

//		// 動作停止
//		enabled = false;
//		GetComponent<Collider>().enabled = false;

//		// 吹っ飛ばす
//		rigidBody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX;
//		rigidBody.AddForce(deathAddForce, ForceMode.Impulse);
//		rigidBody.AddTorque(deathAddTorque, ForceMode.Impulse);
//	}

//	// 地面との衝突
//	private void OnCollisionEnter(Collision collision)
//	{
//		isJumping = false;
//		isDiving = false;
//	}
//}