using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NomesanasVieta : MonoBehaviour, IDropHandler  {
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;
   public static int ievetoti = 0;
   
  
    public Timer TimerSkripts;  



    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null) {
            if (eventData.pointerDrag.tag.Equals(tag))
            {
                vietasZRot =
                GetComponent<RectTransform>().transform.eulerAngles.z;

                velkObjZRot =
                eventData.pointerDrag.GetComponent<RectTransform>().
                transform.eulerAngles.z;

                rotacijasStarpiba = Mathf.Abs(velkObjZRot - vietasZRot);

                velkObjIzm = eventData.pointerDrag.
                    GetComponent<RectTransform>().localScale;

                vietasIzm = GetComponent<RectTransform>().localScale;

                xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
                yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);

                if ((rotacijasStarpiba <= 6 ||
                    (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
                    && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1))
                {

                    objektuSkripts.vaiIstajaVieta = true;

                    eventData.pointerDrag.GetComponent<RectTransform>()
                        .anchoredPosition =
                        GetComponent<RectTransform>().anchoredPosition;

                    eventData.pointerDrag.GetComponent<RectTransform>()
                        .localRotation =
                        GetComponent<RectTransform>().localRotation;

                    eventData.pointerDrag.GetComponent<RectTransform>()
                        .localScale =
                        GetComponent<RectTransform>().localScale;


                    switch (eventData.pointerDrag.tag)
                    {
                        case "atkritumi":
                            objektuSkripts.audioAvots.
                            PlayOneShot(objektuSkripts.skanasKoAtskanot[1]); ievetoti++;
                            break;

                        case "medicina":
                            objektuSkripts.audioAvots.
                            PlayOneShot(objektuSkripts.skanasKoAtskanot[2]); ievetoti++;
                            break;

                        case "buss":
                            objektuSkripts.audioAvots.
                            PlayOneShot(objektuSkripts.skanasKoAtskanot[3]); ievetoti++;
                            break;

                        case "Police":

                            objektuSkripts.audioAvots.
                            PlayOneShot(objektuSkripts.skanasKoAtskanot[4]); ievetoti++;
                            break;

                        case "b2":

                            objektuSkripts.audioAvots.
                          PlayOneShot(objektuSkripts.skanasKoAtskanot[5]); ievetoti++;
                            break;

                        case "cementa":
                            objektuSkripts.audioAvots.
                         PlayOneShot(objektuSkripts.skanasKoAtskanot[6]); ievetoti++;
                            break;


                        case "e46":
                            objektuSkripts.audioAvots.
                         PlayOneShot(objektuSkripts.skanasKoAtskanot[7]); ievetoti++;
                            break;



                        case "e61":
                            objektuSkripts.audioAvots.
                        PlayOneShot(objektuSkripts.skanasKoAtskanot[8]); ievetoti++;
                            break;


                        case "eksko":
                            objektuSkripts.audioAvots.
                       PlayOneShot(objektuSkripts.skanasKoAtskanot[9]); ievetoti++;
                            break;


                        case "tractors1":
                            objektuSkripts.audioAvots.
                       PlayOneShot(objektuSkripts.skanasKoAtskanot[10]); ievetoti++;
                            break;


                        case "tractors5":
                            objektuSkripts.audioAvots.
                       PlayOneShot(objektuSkripts.skanasKoAtskanot[11]); ievetoti++;
                            break;



                        case "Uguns":

                            objektuSkripts.audioAvots.
                       PlayOneShot(objektuSkripts.skanasKoAtskanot[12]); ievetoti++;
                            break;



                    }

                    Debug.Log("PAPA " + ievetoti);

                    if (ievetoti == 12)
                    {
                        ievetoti = 0;
                        TimerSkripts.Izvade();



                        Debug.Log("PsaaaaaaaaaaaaAPA " + ievetoti);
                    }
                }
            }
               
            } else {
                objektuSkripts.vaiIstajaVieta = false;
                objektuSkripts.audioAvots.
                 PlayOneShot(objektuSkripts.skanasKoAtskanot[0]);
                
                switch (eventData.pointerDrag.tag){
                    case "atkritumi":
                        objektuSkripts.atkritumuMasina.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.atkrMKoord;
                        break;

                    case "medicina":
                        objektuSkripts.atraPalidziba.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.atraPKoord;
                        break;

                    case "buss":
                        objektuSkripts.autobuss.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.bussKoord;
                        break;


                    case "Police":
                        objektuSkripts.DePolice.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.PoliceKoord;
                        break;

                    case "b2":
                        objektuSkripts.b2.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.b2Koord;
                        break;

                    case "cementa":
                        objektuSkripts.cementa.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.CementKoord;
                        break;


                    case "e46":
                        objektuSkripts.e46.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.e46Koord;
                        break;

                    case "e61":
                        objektuSkripts.e61.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.e61Koord;
                        break;


                    case "eksko":
                        objektuSkripts.Eskavators.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.EskavatorsKoord;
                        break;

                    case "tractors1":
                        objektuSkripts.Tractors1.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.Tractors1Koord;
                        break;

                    case "tractors5":
                        objektuSkripts.Tractors5.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.Tractors5Koord;
                        break;

                    case "Uguns":
                        objektuSkripts.UgunsDzesejs.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.UgunsKoord;
                        break;





                }
            }
        }
    

    }


    

    
