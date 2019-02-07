using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockonSystem : MonoBehaviour {

	//メインカメラに付いているタグ名
	private const string MAIN_CAMERA_TAG_NAME = "MainCamera";
	//カメラに表示されているか
	private bool _isRendered = false;
 
	void Start () {
	}
 
	void Update () {		
		_isRendered = false;
	}
 
	public bool getIsRendered(){
		return _isRendered;
	}
 
	//カメラに映ってる間に呼ばれる
	private void OnWillRenderObject(){
		//メインカメラに映った時だけ_isRenderedを有効に
		if (Camera.current.tag == MAIN_CAMERA_TAG_NAME) {
			_isRendered = true;
		}
	}
}
