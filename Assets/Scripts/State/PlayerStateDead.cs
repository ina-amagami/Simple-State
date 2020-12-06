using UnityEngine;

public partial class Player
{
	/// <summary>
	/// 死亡状態
	/// </summary>
	public class StateDead : PlayerStateBase
	{
		public override void OnEnter(Player owner, PlayerStateBase prevState)
		{
			// 動作停止
			owner.enabled = false;
			owner.GetComponent<Collider>().enabled = false;

			// 吹っ飛ばす
			owner.rigidBody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX;
			owner.rigidBody.AddForce(owner.deathAddForce, ForceMode.Impulse);
			owner.rigidBody.AddTorque(owner.deathAddTorque, ForceMode.Impulse);
		}
	}
}