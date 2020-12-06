/// <summary>
/// Stateの抽象クラス
/// </summary>
public abstract class PlayerStateBase
{
	/// <summary>
	/// ステートを開始した時に呼ばれる
	/// </summary>
	public virtual void OnEnter(Player owner, PlayerStateBase prevState) { }
	/// <summary>
	/// 毎フレーム呼ばれる
	/// </summary>
	public virtual void OnUpdate(Player owner) { }
	/// <summary>
	/// ステートを終了した時に呼ばれる
	/// </summary>
	public virtual void OnExit(Player owner, PlayerStateBase nextState) { }
}
