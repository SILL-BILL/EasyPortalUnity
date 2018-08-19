using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyPortal : MonoBehaviour {

	// --------
	#region インスペクタ設定用フィールド
	/// <summary>
	/// エスケープモードフラグ
	/// </summary>
	[SerializeField] protected bool m_EscapeMode;
	/// <summary>
	/// 
	/// </summary>
	[SerializeField] protected string m_PortalId;
	/// <summary> 
	/// 
	/// </summary>
	[SerializeField] protected Transform m_OtherPortalTransform;
	#endregion

	// --------
	#region メンバフィールド
	/// <summary> 
	/// 
	/// </summary>
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

	/// <summary>
	/// トリガーエンター
	/// </summary>
	/// <param name="other"></param>
	protected virtual void OnTriggerEnter(Collider other) {
		// Debug.Log("MOB- Enter other.name : "+other.name);
		if(other.GetComponent<EasyPortalPass>() != null){
			// Debug.Log("MOB- EasyPortalPassを持ってる");

			if(m_EscapeMode){

				// -------------
				// エスケープモード時
				// -------------

				other.GetComponent<EasyPortalPass>().PortalEntered = false;
				other.transform.position = m_OtherPortalTransform.position;
				other.transform.localEulerAngles = m_OtherPortalTransform.localEulerAngles;

			}else{

				// -------------
				// 通常モード時
				// -------------

				if(!other.GetComponent<EasyPortalPass>().PortalEntered){
					other.GetComponent<EasyPortalPass>().PortalEntered = true;
					other.GetComponent<EasyPortalPass>().EnteredPortalId = m_PortalId;
					other.transform.position = m_OtherPortalTransform.position;
					other.transform.localEulerAngles = m_OtherPortalTransform.localEulerAngles;
				}

			}

		}else{
			// Debug.Log("MOB- EasyPortalPassを持ってない");
		}
	}

	/// <summary>
	/// トリガーイグジット
	/// </summary>
	/// <param name="other"></param>
	protected virtual void OnTriggerExit(Collider other) {
		// Debug.Log("MOZ- Exit other.name : " + other.name);
		if(other.GetComponent<EasyPortalPass>() != null){
			// Debug.Log("MOB- EasyPortalPassを持ってる");

			if (m_EscapeMode){

				// -------------
				// エスケープモード時
				// -------------

				other.GetComponent<EasyPortalPass>().PortalEntered = false;

			}else{

				// -------------
				// 通常モード時
				// -------------

				if(other.GetComponent<EasyPortalPass>().EnteredPortalId != m_PortalId){
					other.GetComponent<EasyPortalPass>().PortalEntered = false;
				}

			}



		}else{
			// Debug.Log("MOB- EasyPortalPassを持ってない");
		}
	}
	#endregion

	// --------
	#region メンバメソッド
	#endregion

	// --------
	#region インナークラス
	#endregion

}
