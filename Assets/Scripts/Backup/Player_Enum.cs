//using UnityEngine;

//public partial class Player
//{
//	public enum State
//	{
//		/// <summary>
//		/// 立っている
//		/// </summary>
//		Standing = 0,
//		/// <summary>
//		/// ジャンプ中
//		/// </summary>
//		Jumping,
//		/// <summary>
//		/// しゃがんでいる
//		/// </summary>
//		Ducking,
//		/// <summary>
//		/// ダイブ中
//		/// </summary>
//		Diving,
//		/// <summary>
//		/// ゲームオーバー
//		/// </summary>
//		Dead
//	}
//	private State _currentState = State.Standing;
//	private State currentState
//	{
//		get => _currentState;
//		set
//		{
//			// 死亡したらステートは変更しない
//			if (IsDead)
//			{
//				return;
//			}
//			_currentState = value;
//		}
//	}

//	public bool IsDead => currentState == State.Dead;

//	// Start()から呼ばれる
//	private void OnStart()
//	{
//	}

//	// Update()から呼ばれる
//	private void OnUpdate()
//	{
//		switch (currentState)
//		{
//			case State.Standing:
//				if (Input.GetKey(KeyCode.DownArrow))
//				{
//					StartDuck();
//				}
//				else if (Input.GetKeyDown(KeyCode.Space))
//				{
//					Jump();
//				}
//				break;

//			case State.Jumping:
//				if (Input.GetKeyDown(KeyCode.DownArrow))
//				{
//					Dive();
//				}
//				break;

//			case State.Ducking:
//				if (!Input.GetKey(KeyCode.DownArrow))
//				{
//					EndDuck();
//				}
//				break;

//			case State.Diving:
//				break;
//		}
//	}

//	// ジャンプ
//	private void Jump()
//	{
//		rigidBody.AddForce(Vector3.up * 7f, ForceMode.Impulse);
//		currentState = State.Jumping;
//	}

//	// ダイブ
//	private void Dive()
//	{
//		rigidBody.AddForce(Vector3.down * 14f, ForceMode.Impulse);
//		currentState = State.Diving;
//	}

//	// しゃがみ開始
//	private void StartDuck()
//	{
//		transform.localScale = Vector3.one;
//		AdjustGround();
//		currentState = State.Ducking;
//	}

//	// しゃがみ終了
//	private void EndDuck()
//	{
//		transform.localScale = defaultScale;
//		AdjustGround();
//		currentState = State.Standing;
//	}

//	// 死亡した時に呼ばれる
//	private void OnDeath()
//	{
//		currentState = State.Dead;

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
//		currentState = State.Standing;
//	}
//}
