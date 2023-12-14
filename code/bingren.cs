using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bingren : MonoBehaviour
{
   public static float TotalHp = 50;
    public static float hp = 0;
    static public int renshu=0;
    public Text bingli;
    public Text shang;
    public Text xia;
    public int a = 0;
    static public int[] data1 = new int[6];
  
    public void Ren()
    {
        if (renshu==0)
       {
         a = Random.Range(1, 10);
        if (a == 1)
        {
            data1[0] =1;//1,2,6,7石膏黄连黄芩甘草汤方
            data1[1] =2;
            data1[2] =6;
            data1[3] =7;
            data1[4] =0;
            data1[5] =0;
            shang.text = "发热，腹痛引少腹，夜半咽中干痛，脉沉实";
            bingli.text = "石膏黄连黄芩甘草汤方";
            xia.text= "石膏半斤碎（棉裹） 黄连三两 黄芩四两 甘草二两";
                hp = hp+4;
        }
        if (a == 2)
        {
            data1[0] = 1;//1,2,18,19,20黄连黄芩栀子牡丹芍药汤方
            data1[1] = 2;
            data1[2] = 18;
            data1[3] = 19;
            data1[4] = 20;
            data1[5] = 0;
            shang.text = "头痛，面赤，发热";
            bingli.text = "黄连黄芩栀子牡丹芍药汤方";
            xia.text= "黄连三两 黄芩三两 栀子十四枚（劈） 牡丹三两 芍药三两";
                hp = hp+5;
        }
        if (a == 3)
        {
            data1[0] = 6;//6,10,14,16麻黄汤方
            data1[1] = 10;
            data1[2] = 14;
            data1[3] = 16;
            data1[4] = 0;
            data1[5] = 0;
            shang.text= "发热，无汗";
            bingli.text = "麻黄汤方";
            xia.text= "麻黄三两（去节） 桂枝三两（去皮） 甘草一两（炙） 杏仁七十枚 （去皮尖）";
                hp = hp + 4;
        }
        if (a == 4)
        {
            data1[0] = 5;//5,6,7,8白虎汤方
            data1[1] = 6;
            data1[2] = 7;
            data1[3] = 8;
            data1[4] = 0;
            data1[5] = 0;
            shang.text= "发热，汗出，口渴舌燥";
            bingli.text = "白虎汤方";
            xia.text= "知母六两 石膏一斤 甘草二两（炙） 粳米六合";
                hp = hp + 4;
        }
        if (a == 5)
        {
            data1[0] = 2;//2,6,7,11,13,17茯苓白术厚朴石膏黄芩甘草汤方
            data1[1] = 6;
            data1[2] = 7;
            data1[3] = 11;
            data1[4] = 13;
            data1[5] = 17;
            shang.text= "热，下利，口渴，腹中急痛";
            bingli.text = "茯苓白术厚朴石膏黄芩甘草汤方";
            xia.text= "茯苓四两 白术三两 厚朴四两 石膏半斤 黄芩三两 甘草二两（炙）";
                hp = hp + 6;
        }
        if (a == 6)
        {
            data1[0] = 9;//9,10,11,12黄芪桂枝茯苓细辛汤方
            data1[1] = 10;
            data1[2] = 11;
            data1[3] = 12;
            data1[4] = 0;
            data1[5] = 0;
            shang.text= "两额疼痛，脉浮而涩";
            bingli.text = "黄芪桂枝茯苓细辛汤方";
            xia.text= "黄芪三两 桂枝二两 茯苓三两 细辛一两";
                hp = hp + 4;
        }
        if (a == 7)
        {
            data1[0] =10;//10,11,12,13桂枝茯苓白术细辛汤方
            data1[1] =11;
            data1[2] =12;
            data1[3] =13;
            data1[4] =0;
            data1[5] =0;
            shang.text= "湿气在下，两足肿";
            bingli.text = "桂枝茯苓白术细辛汤方";
            xia.text= "桂枝三两 茯苓四两 白术三两 细辛二两";
                hp = hp + 4;
            }
        if (a == 8)
        {
            data1[0] =6;//6,10,13,14,16麻黄加术汤方
            data1[1] =10;
            data1[2] =13;
            data1[3] =14;
            data1[4] =16;
            data1[5] =0;
            shang.text= "湿家，身烦疼";
            bingli.text = "麻黄加术汤方";
            xia.text = "麻黄三两（去节） 桂枝二两（去皮）甘草一两（炙） 白术四两 杏仁七十个（去皮尖）";
                hp = hp + 5;
        }
        if (a == 9)
        {
            data1[0] = 6;//6,14,15,16麻黄杏仁薏苡甘草汤方
            data1[1] = 14;
            data1[2] = 15;
            data1[3] = 16;
            data1[4] = 0;
            data1[5] = 0;
            shang.text= "风湿";
            bingli.text = "麻黄杏仁薏苡甘草汤方";
            xia.text= "麻黄一两 杏仁二十枚（去皮尖） 薏苡一两 甘草一两（炙）";
                hp = hp + 4;
            }
            renshu = 1;
       }
       
    }

}
