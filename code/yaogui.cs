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
    public int huanglian=1;//����
    public int huangling=2;//����
    public int renshen=3;//�˲�
    public int dihuang=4;//�ػ�
    public int zhimu = 5;//֪ĸ
    public int gancao = 6;//�ʲ�
    public int shigao = 7;//ʯ��
    public int gengmi = 8;//����
    public int huangshi = 9;//����
    public int guizhi = 10;//��֦
    public int fuling = 11;//����
    public int xixin = 12;//ϸ��
    public int baishu = 13;//����
    public int xingren = 14;//����
    public int yiyi = 15;//޲��
    public int mahuang = 16;//���
    public int houpu = 17;//����
    public int mudan = 18;//ĵ��
    public int shaoyao = 19;//��ҩ
    public int zhizi = 20;//����

    

        public void Huanglian()//1
    {
        if (i < 6)
        {
            data[i]= huanglian;
            shiyan.text = "����һ��";
            i++;
        }
    }

    public void Huangling()//2
    {
        if (i < 6)
        {
        data[i] = huangling;
        shiyan.text = "����һ��";
            i++;
        }
    }

    public void Renshen()//3
    {
        if (i < 6)
        {
        data[i] = renshen;
            shiyan.text = "�˲�һ��";
            i++;
        }
    }

    public void Dihuang()//4
    {
        if (i < 6)
        {
        data[i] = dihuang;
            shiyan.text = "�ػ�һ��";
            i++;
        }
    }

    public void Zhimu()//5
    {
        if (i < 6)
        {
        data[i] = zhimu;
            shiyan.text = "֪ĸһ��";
            i++;
        }
    }

    public void Gancao()//6
    {
        if (i < 6)
        {
        data[i] = gancao;
            shiyan.text = "�ʲ�һ��";
            i++;
        }
    }

    public void Shigao()//7
    {
        if (i < 6)
        {
        data[i] = shigao;
            shiyan.text = "ʯ��һ��";
            i++;
        }
    }

    public void Gengmi()//8
    {
        if (i < 6)
        {
        data[i] = gengmi;
            shiyan.text = "����һ��";
            i++;
        }
    }

    public void Huangshi()//9
    {
        if (i < 6)
        {
        data[i] = huangshi;
            shiyan.text = "����һ��";
            i++;
        }
    }

    public void Guizhi()//10
    {
        if (i < 6)
        {
        data[i] = guizhi;
            shiyan.text = "��֦һ��";
            i++;
        }
    }

    public void Fuling()//11
    {
        if (i < 6)
        {
        data[i] = fuling;
            shiyan.text = "����һ��";
            i++;
        }
    }

    public void Xixin()//12
    {
        if (i < 6)
        {
        data[i] = xixin;
            shiyan.text = "ϸ��һ��";
            i++;
        }
    }

    public void Baishu()//13
    {
        if (i < 6)
        {
        data[i] = baishu;
            shiyan.text = "����һ��";
            i++;
        }
    }

    public void Xingren()//14
    {
        if (i < 6)
        {
        data[i] = xingren;
            shiyan.text = "����һ��";
            i++;
        }
    }

    public void Yiyi()//15
    {
        if (i < 6)
        {
        data[i] = yiyi;
            shiyan.text = "޲��һ��";
            i++;
        }
    }

    public void Mahuang()//16
    {
        if (i < 6)
        {
        data[i] = mahuang;
            shiyan.text = "���һ��";
            i++;
        }
    }

    public void Houpu()//17
    {
        if (i < 6)
        {
        data[i] = houpu;
            shiyan.text = "����һ��";
            i++;
        }
    }

    public void Mudan()//18
    {
        if (i < 6)
        {
        data[i] = mudan;
            shiyan.text = "ĵ��һ��";
            i++;
        }
    }

    public void Shaoyao()//19
    {
        if (i < 6)
        {
        data[i] = shaoyao;
            shiyan.text = "��ҩһ��";
            i++;
        }
    }

    public void Zhizi()//20
    {
        if (i < 6)
        {
        data[i] = zhizi;
            shiyan.text = "����һ��";
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
                shiyan.text = "��������";
                return;
            }
        }
        bingren.renshu = 0;
        shiyan.text = "ҩ������";
        Restart();
        if(bingren.hp >= bingren.TotalHp)
        {
            GameObject.Find("�������").GetComponent<xingji>().right();
        }
        hpslider.value = (float)bingren.hp / bingren.TotalHp;
        return;
    }
}
