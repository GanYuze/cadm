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
            data1[0] =1;//1,2,6,7ʯ��������˸ʲ�����
            data1[1] =2;
            data1[2] =6;
            data1[3] =7;
            data1[4] =0;
            data1[5] =0;
            shang.text = "���ȣ���ʹ���ٸ���ҹ�����и�ʹ������ʵ";
            bingli.text = "ʯ��������˸ʲ�����";
            xia.text= "ʯ�����飨�޹��� �������� �������� �ʲݶ���";
                hp = hp+4;
        }
        if (a == 2)
        {
            data1[0] = 1;//1,2,18,19,20������������ĵ����ҩ����
            data1[1] = 2;
            data1[2] = 18;
            data1[3] = 19;
            data1[4] = 20;
            data1[5] = 0;
            shang.text = "ͷʹ����࣬����";
            bingli.text = "������������ĵ����ҩ����";
            xia.text= "�������� �������� ����ʮ��ö������ ĵ������ ��ҩ����";
                hp = hp+5;
        }
        if (a == 3)
        {
            data1[0] = 6;//6,10,14,16�������
            data1[1] = 10;
            data1[2] = 14;
            data1[3] = 16;
            data1[4] = 0;
            data1[5] = 0;
            shang.text= "���ȣ��޺�";
            bingli.text = "�������";
            xia.text= "���������ȥ�ڣ� ��֦������ȥƤ�� �ʲ�һ�����ˣ� ������ʮö ��ȥƤ�⣩";
                hp = hp + 4;
        }
        if (a == 4)
        {
            data1[0] = 5;//5,6,7,8�׻�����
            data1[1] = 6;
            data1[2] = 7;
            data1[3] = 8;
            data1[4] = 0;
            data1[5] = 0;
            shang.text= "���ȣ��������ڿ�����";
            bingli.text = "�׻�����";
            xia.text= "֪ĸ���� ʯ��һ�� �ʲݶ������ˣ� ��������";
                hp = hp + 4;
        }
        if (a == 5)
        {
            data1[0] = 2;//2,6,7,11,13,17���߰�������ʯ����˸ʲ�����
            data1[1] = 6;
            data1[2] = 7;
            data1[3] = 11;
            data1[4] = 13;
            data1[5] = 17;
            shang.text= "�ȣ��������ڿʣ����м�ʹ";
            bingli.text = "���߰�������ʯ����˸ʲ�����";
            xia.text= "�������� �������� �������� ʯ���� �������� �ʲݶ������ˣ�";
                hp = hp + 6;
        }
        if (a == 6)
        {
            data1[0] = 9;//9,10,11,12���ι�֦����ϸ������
            data1[1] = 10;
            data1[2] = 11;
            data1[3] = 12;
            data1[4] = 0;
            data1[5] = 0;
            shang.text= "������ʹ��������ɬ";
            bingli.text = "���ι�֦����ϸ������";
            xia.text= "�������� ��֦���� �������� ϸ��һ��";
                hp = hp + 4;
        }
        if (a == 7)
        {
            data1[0] =10;//10,11,12,13��֦���߰���ϸ������
            data1[1] =11;
            data1[2] =12;
            data1[3] =13;
            data1[4] =0;
            data1[5] =0;
            shang.text= "ʪ�����£�������";
            bingli.text = "��֦���߰���ϸ������";
            xia.text= "��֦���� �������� �������� ϸ������";
                hp = hp + 4;
            }
        if (a == 8)
        {
            data1[0] =6;//6,10,13,14,16��Ƽ�������
            data1[1] =10;
            data1[2] =13;
            data1[3] =14;
            data1[4] =16;
            data1[5] =0;
            shang.text= "ʪ�ң�����";
            bingli.text = "��Ƽ�������";
            xia.text = "���������ȥ�ڣ� ��֦������ȥƤ���ʲ�һ�����ˣ� �������� ������ʮ����ȥƤ�⣩";
                hp = hp + 5;
        }
        if (a == 9)
        {
            data1[0] = 6;//6,14,15,16�������޲�Ӹʲ�����
            data1[1] = 14;
            data1[2] = 15;
            data1[3] = 16;
            data1[4] = 0;
            data1[5] = 0;
            shang.text= "��ʪ";
            bingli.text = "�������޲�Ӹʲ�����";
            xia.text= "���һ�� ���ʶ�ʮö��ȥƤ�⣩ ޲��һ�� �ʲ�һ�����ˣ�";
                hp = hp + 4;
            }
            renshu = 1;
       }
       
    }

}
