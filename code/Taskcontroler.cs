using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using Unity.VisualScripting;
using System.Drawing;
public class Taskcontroler : MonoBehaviour{
    public GameObject CheckButton,BackButton,AnalysisButton,CheckList,AnalysisList;
    bool IfTextShow;
    public Text Prescription, Require, Symptom, PatientArriveText;
    double timeTmp1=0,time0=0,Lasttime=5;
    bool IfCheck = false;
    private void Awake() {
        AnalysisList.SetActive(false);
        CheckList.SetActive(false);
        CheckButton.SetActive(true);
        BackButton.SetActive(false);
        AnalysisButton.SetActive(false);
    }
    private void Start() {
        IfTextShow=true;
    }
    private void Update() {
        timeTmp1 += Time.deltaTime;
        if(!IfTextShow){
            if(!PatientShow.TextShowUp(PatientArriveText,time0,Lasttime)){
                time0 += Time.deltaTime;
            }
            else{
                IfTextShow = true;
            }
        }
    }
    public void Check(){
        if(!PatientShow.IfPatient){
            IfTextShow = false;
        }
        else{
            WhatSymptom();
            CheckButton.SetActive(false);
            BackButton.SetActive(true);
            CheckList.SetActive(true);
            AnalysisButton.SetActive(true);
        }
    }
    public void Analysis(){
        CheckList.SetActive(false);
        AnalysisButton.SetActive(false);
        AnalysisList.SetActive(true);
    }
    private void Escape(){
        CheckButton.SetActive(true);
        BackButton.SetActive(false);
        CheckList.SetActive(false);
        AnalysisButton.SetActive(false);
        AnalysisList.SetActive(false);
    }
    private void WhatSymptom(){
        bingren.Ren();
        switch(bingren.a){
            case 1: Symptom.text = "发热，腹痛引少腹，夜半咽中干痛，脉沉实";
                    Prescription.text = "石膏黄连黄芩甘草汤方";
                    Require.text = "石膏半斤碎（棉裹） 黄连三两 黄芩四两 甘草二两";                
                break;
            case 2: Symptom.text = "头痛，面赤，发热";
                    Prescription.text = "黄连黄芩栀子牡丹芍药汤方";
                    Require.text = "黄连三两 黄芩三两 栀子十四枚（劈） 牡丹三两 芍药三两"; 
                break;
            case 3: Symptom.text = "发热，无汗";
                    Prescription.text = "麻黄汤方";
                    Require.text = "麻黄三两（去节） 桂枝三两（去皮） 甘草一两（炙） 杏仁七十枚 （去皮尖）"; 
                break;
            case 4: Symptom.text = "发热，汗出，口渴舌燥";
                    Prescription.text = "白虎汤方";
                    Require.text = "知母六两 石膏一斤 甘草二两（炙） 粳米六合"; 
                break;
            case 5: Symptom.text = "热，下利，口渴，腹中急痛";
                    Prescription.text = "茯苓白术厚朴石膏黄芩甘草汤方";
                    Require.text = "茯苓四两 白术三两 厚朴四两 石膏半斤 黄芩三两 甘草二两（炙）"; 
                break;
            case 6: Symptom.text = "两额疼痛，脉浮而涩";
                    Prescription.text = "黄芪桂枝茯苓细辛汤方";
                    Require.text = "黄芪三两 桂枝二两 茯苓三两 细辛一两"; 
                break;
            case 7: Symptom.text = "湿气在下，两足肿";
                    Prescription.text = "桂枝茯苓白术细辛汤方";
                    Require.text = "桂枝三两 茯苓四两 白术三两 细辛二两"; 
                break;
            case 8: Symptom.text = "湿家，身烦疼";
                    Prescription.text = "麻黄加术汤方";
                    Require.text = "麻黄三两（去节） 桂枝二两（去皮）甘草一两（炙） 白术四两 杏仁七十个（去皮尖）"; 
                break;
            case 9: Symptom.text = "风湿";
                    Prescription.text = "麻黄杏仁薏苡甘草汤方";
                    Require.text = "麻黄一两 杏仁二十枚（去皮尖） 薏苡一两 甘草一两（炙）"; 
                break;
        }
    }
}