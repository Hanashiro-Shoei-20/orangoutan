using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    void OnTriggerEnter(Collision other)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (other.gameObject.tag == "Player")
		{
			Debug.Log("当たった");
			// 0.2秒後に消える
			Destroy(gameObject, 0.2f);
		}
	}
}
