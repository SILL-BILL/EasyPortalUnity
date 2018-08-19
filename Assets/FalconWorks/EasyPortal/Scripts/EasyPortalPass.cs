using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyPortalPass : MonoBehaviour {

	// --------
	#region インスペクタ設定用フィールド
	/// <summary> 
	/// 
	/// </summary>
	#endregion

	// --------
	#region メンバフィールド
	/// <summary>
	/// ポータルに入ったフラグ
	/// </summary>
	protected bool m_PortalEntered;
	/// <summary>
	/// [プロパティ] ポータルに入ったフラグ
	/// </summary>
	public bool PortalEntered {
		get{ return m_PortalEntered; }
		set{ m_PortalEntered = value; }
	}
	/// <summary>
	/// 入ったポータルのIDを格納するフィールド
	/// </summary>
	protected string m_EnteredPortalId;
	/// <summary>
	/// [プロパティ]入ったポータルのIDを格納するプロパティ
	/// </summary>
	public string EnteredPortalId {
		get{ return m_EnteredPortalId; }
		set{ m_EnteredPortalId = value; }
	}
	#endregion

	// --------
	#region MonoBehaviourメソッド
	/// <summary> 
	/// 初期化処理
	/// </summary>
	protected virtual void Awake() {

	}
	/// <summary> 
	/// 開始処理
	/// </summary>
	protected virtual void Start () {

	}
	/// <summary> 
	/// 更新処理
	/// </summary>
	protected virtual void Update () {

	}

	/// <summary> 
	/// 更新処理
	/// </summary>
	protected virtual void FixedUpdate(){

	}

	/// <summary> 
	/// 更新処理
	/// </summary>
	protected virtual void LateUpdate(){

	}
	#endregion

	// --------
	#region メンバメソッド
	#endregion

	// --------
	#region インナークラス
	#endregion

}
