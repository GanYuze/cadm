using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yaogui : MonoBehaviour
{
    public Slider hpslider;
    public Text shiyan;
    int[] data=new int[6];
    private int i = 0;
    public int huanglian=1;//黄连
    public int huangling=2;//黄苓
    public int renshen=3;//人参
    public int dihuang=4;//地黄
    public int zhimu = 5;//知母
    public int gancao = 6;//甘草
    public int shigao = 7;//石膏
    public int gengmi = 8;//梗米
    public int huangshi = 9;//黄芪
    public int guizhi = 10;//桂枝
    public int fuling = 11;//茯苓
    public int xixin = 12;//细辛
    public int baishu = 13;//白术
    public int xingren = 14;//杏仁
    public int yiyi = 15;//薏苡
    public int mahuang = 16;//麻黄
    public int houpu = 17;//厚朴
    public int mudan = 18;//牡丹
    public int shaoyao = 19;//芍药
    public int zhizi = 20;//栀子

    

        public void Huanglian()//1
    {
        if (i < 6)
        {
            data[i]= huanglian;
            shiyan.text = "黄连一份";
            i++;
        }
    }

    public void Huangling()//2
    {
        if (i < 6)
        {
        data[i] = huangling;
        shiyan.text = "黄苓一份";
            i++;
        }
    }

    public void Renshen()//3
    {
        if (i < 6)
        {
        data[i] = renshen;
            shiyan.text = "人参一份";
            i++;
        }
    }

    public void Dihuang()//4
    {
        if (i < 6)
        {
        data[i] = dihuang;
            shiyan.text = "地黄一份";
            i++;
        }
    }

    public void Zhimu()//5
    {
        if (i < 6)
        {
        data[i] = zhimu;
            shiyan.text = "知母一份";
            i++;
        }
    }

    public void Gancao()//6
    {
        if (i < 6)
        {
        data[i] = gancao;
            shiyan.text = "甘草一份";
            i++;
        }
    }

    public void Shigao()//7
    {
        if (i < 6)
        {
        data[i] = shigao;
            shiyan.text = "石膏一份";
            i++;
        }
    }

    public void Gengmi()//8
    {
        if (i < 6)
        {
        data[i] = gengmi;
            shiyan.text = "梗米一份";
            i++;
        }
    }

    public void Huangshi()//9
    {
        if (i < 6)
        {
        data[i] = huangshi;
            shiyan.text = "黄芪一份";
            i++;
        }
    }

    public void Guizhi()//10
    {
        if (i < 6)
        {
        data[i] = guizhi;
            shiyan.text = "桂枝一份";
            i++;
        }
    }

    public void Fuling()//11
    {
        if (i < 6)
        {
        data[i] = fuling;
            shiyan.text = "茯苓一份";
            i++;
        }
    }

    public void Xixin()//12
    {
        if (i < 6)
        {
        data[i] = xixin;
            shiyan.text = "细辛一份";
            i++;
        }
    }

    public void Baishu()//13
    {
        if (i < 6)
        {
        data[i] = baishu;
            shiyan.text = "白术一份";
            i++;
        }
    }

    public void Xingren()//14
    {
        if (i < 6)
        {
        data[i] = xingren;
            shiyan.text = "杏仁一份";
            i++;
        }
    }

    public void Yiyi()//15
    {
        if (i < 6)
        {
        data[i] = yiyi;
            shiyan.text = "薏苡一份";
            i++;
        }
    }

    public void Mahuang()//16
    {
        if (i < 6)
        {
        data[i] = mahuang;
            shiyan.text = "麻黄一份";
            i++;
        }
    }

    public void Houpu()//17
    {
        if (i < 6)
        {
        data[i] = houpu;
            shiyan.text = "厚朴一份";
            i++;
        }
    }

    public void Mudan()//18
    {
        if (i < 6)
        {
        data[i] = mudan;
            shiyan.text = "牡丹一份";
            i++;
        }
    }

    public void Shaoyao()//19
    {
        if (i < 6)
        {
        data[i] = shaoyao;
            shiyan.text = "芍药一份";
            i++;
        }
    }

    public void Zhizi()//20
    {
        if (i < 6)
        {
        data[i] = zhizi;
            shiyan.text = "栀子一份";
            i++;
        }
    }

    public void Restart()
    {
        i = 0;
        while(i<6)
        {
            data[i] = 0;
            i++;
        }
        i = 0;
    }

    public void End()
    {
        int j = 0;
        int k = 0;
        while(j < i)
        {
            if(k<6)
            {
                if (data[j] != bingren.data1[k])
                {
                     k++;
                 }
                else
                {
                    j++;
                    k = 0;
                }
            }
            if(k==6)
            {
                shiyan.text = "处方有误";
                return;
            }
        }
        bingren.renshu = 0;
        shiyan.text = "药到病除";
        Restart();
        if(bingren.hp >= bingren.TotalHp)
        {
            GameObject.Find("相机控制").GetComponent<xingji>().right();
        }
        hpslider.value = (float)bingren.hp / bingren.TotalHp;
        return;
    }
}
