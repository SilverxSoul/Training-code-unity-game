using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    Slider Fill;
    //public GameObject player;
    //PlayerStat stat;
    public PlayerStat stat;//gan gameobject co script PlayerStat la ok !!
    void Start()
    {
        Fill = GetComponent<Slider>();
        //stat = player.GetComponent<PlayerStat>();
        SetMaxHealth(stat.maxHP);
        SetHealth(stat.HP);
    }

    //ham Update nay khong can thiet neu nhu da su dung cai update ben PlayerStats !!
    void Update()
    {
        SetHealth(stat.HP);
    }


    public void SetMaxHealth(float maxHP)
    {
        Fill.maxValue = maxHP;
    }

    public void SetHealth(float HP)
    {
        Fill.value = HP;
    }
}
