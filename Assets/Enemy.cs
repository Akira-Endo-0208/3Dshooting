using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Emeny�̗̑͗p�ϐ�
    private int enemyHp;

    public void Damage()
    {
        enemyHp = enemyHp - 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        //�������ɑ̗͂��w�肵�Ă���
        enemyHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //�����̗͂�0�ȉ��ɂȂ�����
        if(enemyHp <= 0)
        {
            //�����ŏ�����
            Destroy(this.gameObject);

        }
    }
}
