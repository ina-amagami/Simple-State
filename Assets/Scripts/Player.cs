using UnityEngine;

public partial class Player
{
	// ステートのインスタンス
	private static readonly StateStanding stateStanding = new StateStanding();
	private static readonly StateJumping stateJumping = new StateJumping();
	private static readonly StateDucking stateDucking = new StateDucking();
	private static readonly StateDiving stateDiving = new StateDiving();
	private static readonly StateDead stateDead = new StateDead();

	public bool IsDead => currentState is StateDead;

	/// <summary>
	/// 現在のステート
	/// </summary>
	private PlayerStateBase currentState = stateStanding;

	// Start()から呼ばれる
	private void OnStart()
	{
		currentState.OnEnter(this, null);
	}

	// Update()から呼ばれる
	private void OnUpdate()
	{
		currentState.OnUpdate(this);
	}

	// ステート変更
	private void ChangeState(PlayerStateBase nextState)
	{
		currentState.OnExit(this, nextState);
		nextState.OnEnter(this, currentState);
		currentState = nextState;
	}

	// 死亡した時に呼ばれる
	private void OnDeath()
	{
		ChangeState(stateDead);
	}

	// 地面との衝突
	private void OnCollisionEnter(Collision collision)
	{
		ChangeState(stateStanding);
	}
}
