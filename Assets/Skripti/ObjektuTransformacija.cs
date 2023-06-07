using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuTransformacija : MonoBehaviour {
	public Objekti objektuSkripts;
 

    void Update () {
		if(objektuSkripts.pedejaisVilktais != null)
		{
			if (Input.GetKey(KeyCode.Z))
			{
				objektuSkripts.pedejaisVilktais.
				GetComponent<RectTransform>().
				transform.Rotate(0, 0, Time.deltaTime * 20f);
			}

            if (Input.GetKey(KeyCode.X))
            {
                objektuSkripts.pedejaisVilktais.
                GetComponent<RectTransform>().
                transform.Rotate(0, 0, -Time.deltaTime * 20f);
            }

			if(Input.GetKey(KeyCode.UpArrow)){
				if(objektuSkripts.pedejaisVilktais.
					GetComponent<RectTransform>().
					localScale.y <= 1.5f){
					objektuSkripts.pedejaisVilktais.
					GetComponent<RectTransform>().transform.localScale =
					new Vector2(objektuSkripts.pedejaisVilktais.
					GetComponent<RectTransform>().transform.localScale.x,
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().
					transform.localScale.y + 0.01f);
				}
			}


            if (Input.GetKey(KeyCode.DownArrow)){
                if (objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().
                    localScale.y >= 0.2f){
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale =
                    new Vector2(objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.x,
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().
                    transform.localScale.y - 0.01f);
                }
            }


            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().
                    localScale.x >= 0.2f)
                {
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale =
                    new Vector2(objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.x - 0.01f,
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.y);
                }
            }


            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().
                    localScale.x <= 1.5f)
                {
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale =
                    new Vector2(objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.x + 0.01f,
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.y);
                }
            }
        }
	}
}
