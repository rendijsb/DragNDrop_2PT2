﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuTransform : MonoBehaviour {
	public Objekti objektuSkripts;
	
	void Update () {
		if(objektuSkripts.pedejaisVilktais !=null)
		{



			if(Input.GetKey(KeyCode.Z))
			{
				objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, Time.deltaTime * 15f);
			}
            if (Input.GetKey(KeyCode.X))
            {
				objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, -Time.deltaTime * 15f);
            }




            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.x >= 0.4f)
                {
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale =
                    new Vector2(objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.x - 0.004f,
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.y);
                }
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.x <= 0.85f)
                {
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale =
                    new Vector2(objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.x + 0.004f,
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.y);
                }
            }





            if(Input.GetKey(KeyCode.UpArrow)) 
			{
				if(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y <= 0.85f)
				{
					objektuSkripts.pedejaisVilktais.
					GetComponent<RectTransform>().transform.localScale =
					new Vector2(objektuSkripts.pedejaisVilktais.
					GetComponent<RectTransform>().transform.localScale.x,
					objektuSkripts.pedejaisVilktais.
					GetComponent<RectTransform>().transform.localScale.y + 0.004f);
				}
			}
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y >= 0.4f)
                {
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale =
                    new Vector2(objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.x,
                    objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.y - 0.004f);
                }
            }
        }
	}
}