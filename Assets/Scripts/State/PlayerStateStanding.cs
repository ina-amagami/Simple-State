using UnityEngine;

public partial class Player
{
	/// <summary>
	/// 通常状態
	/// </summary>
	public class StateStanding : PlayerStateBase
	{
		public override void OnUpdate(Player owner)
		{
			if (Input.GetKey(KeyCode.DownArrow))
			{
				owner.ChangeState(stateDucking);
			}
			else if (Input.GetKeyDown(KeyCode.Space))
			{
				owner.ChangeState(stateJumping);
			}
		}
	}
}