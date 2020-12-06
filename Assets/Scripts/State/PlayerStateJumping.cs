using UnityEngine;

public partial class Player
{
	/// <summary>
	/// ジャンプ中
	/// </summary>
	public class StateJumping : PlayerStateBase
	{
		public override void OnEnter(Player owner, PlayerStateBase prevState)
		{
			owner.rigidBody.AddForce(Vector3.up * 7f, ForceMode.Impulse);
		}

		public override void OnUpdate(Player owner)
		{
			if (Input.GetKeyDown(KeyCode.DownArrow))
			{
				owner.ChangeState(stateDiving);
			}
		}
	}
}