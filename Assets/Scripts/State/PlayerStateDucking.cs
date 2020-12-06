using UnityEngine;

public partial class Player
{
	/// <summary>
	/// しゃがみ状態
	/// </summary>
	public class StateDucking : PlayerStateBase
	{
		public override void OnEnter(Player owner, PlayerStateBase prevState)
		{
			owner.transform.localScale = Vector3.one;
			owner.AdjustGround();
		}

		public override void OnUpdate(Player owner)
		{
			if (!Input.GetKey(KeyCode.DownArrow))
			{
				owner.ChangeState(stateStanding);
			}
		}

		public override void OnExit(Player owner, PlayerStateBase nextState)
		{
			owner.transform.localScale = owner.defaultScale;
			owner.AdjustGround();
		}
	}
}