using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject cementa;
	public GameObject e46;
	public GameObject e61;
	public GameObject Eskavators;
	public GameObject DePolice;
	public GameObject Tractors1;
	public GameObject Tractors5;
	public GameObject UgunsDzesejs;



	[HideInInspector]
	public Vector2 atkrMKoord;

	[HideInInspector]
	public Vector2 atraPKoord;
	
	[HideInInspector]
	public Vector2 bussKoord;
    
	[HideInInspector]
	public Vector2 b2Koord;    

    [HideInInspector]
    public Vector2 CementKoord;

    [HideInInspector]
    public Vector2 e46Koord;

    [HideInInspector]
    public Vector2 e61Koord;

    [HideInInspector]
    public Vector2 EskavatorsKoord;

    [HideInInspector]
    public Vector2 PoliceKoord;

    [HideInInspector]
    public Vector2 Tractors1Koord;


    [HideInInspector]
    public Vector2 Tractors5Koord;

    [HideInInspector]
    public Vector2 UgunsKoord;






    public Canvas kanva;

	public AudioSource audioAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;


	// Use this for initialization
	void Start () {
		atkrMKoord =
		atkritumuMasina.GetComponent<RectTransform>().localPosition;

       atraPKoord =
       atraPalidziba.GetComponent<RectTransform>().localPosition;

		bussKoord =
        autobuss.GetComponent<RectTransform>().localPosition;


		 b2Koord= b2.GetComponent<RectTransform>().localPosition;

		CementKoord= cementa.GetComponent<RectTransform>().localPosition;

		e46Koord=e46.GetComponent<RectTransform>().localPosition;

		e61Koord=e61.GetComponent<RectTransform>().localPosition;

		EskavatorsKoord=Eskavators.GetComponent<RectTransform>().localPosition;

		PoliceKoord=DePolice.GetComponent<RectTransform>().localPosition;

		Tractors1Koord=Tractors1.GetComponent<RectTransform>().localPosition;

		Tractors5Koord=Tractors5.GetComponent<RectTransform>().localPosition;

		UgunsKoord=UgunsDzesejs.GetComponent<RectTransform>().localPosition;





    }
}
