using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using Unity.VisualScripting;
public class PatientShow : MonoBehaviour{
    public static bool IfPatient=false,IfTextShow=false;
    public Text PatientArriveText;
    public double timeTmp1,time0,Lasttime;
    private void Awake() {
        
    }
    private void Start() {
        timeTmp1=0;
        time0=0;
        Lasttime=5.0;
        PatientArriveText.color=new Color(
            PatientArriveText.color.r,
            PatientArriveText.GetComponent<Renderer>().material.color.g,
            PatientArriveText.GetComponent<Renderer>().material.color.b,
            0);
    }
    private void Update() {
        if(!IfPatient){
            if(timeTmp1 <= 10.0d){
                timeTmp1 += Time.deltaTime;
            }
            else{
                timeTmp1 = 0.0d;
                IfPatient = true;
            }
        }
        else{
            if(!IfTextShow){
                if(!TextShowUp(PatientArriveText,time0,Lasttime)){
                    time0 += Time.deltaTime;
                }
                else{
                    IfTextShow = true;
                }
            }
        }
    }
    public static bool TextShowUp(Text text,double time,double lasttime)
    {
        if (text.color.a > 0.1)
        {
            text.color = new Color(
                text.color.r,
                text.color.g,
                text.color.b,
                (float)(lasttime-time)/5.0f);
            return false;
        }
        return true;
    }
}