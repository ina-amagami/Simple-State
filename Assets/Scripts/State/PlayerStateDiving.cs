using UnityEngine;

public partial class Player
{
	/// <summary>
	/// ダイブ状態
	/// </summary>
	public class StateDiving : PlayerStateBase
	{
		public override void OnEnter(Player owner, PlayerStateBase prevState)
		{
			owner.rigidBody.AddForce(Vector3.down * 14f, ForceMode.Impulse);
		}
	}
}