using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongGrass : MonoBehaviour
{
    public BiomeList grassType;

    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
      gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
      if(col.GetComponent<PlayerMovement>())
      {
        //Prob = x/187.5
        //VC = 10, C= 8.5, SemiRare = 6.75, Rare=3.33, VR = 1.25
        float vc = 10 / 187.5f;
        float c = 8.5f / 187.5f;
        float sr = 6.75f / 187.5f;
        float r = 3.33f / 187.5f;
        float vr = 1.25f / 187.5f;

        float prob = Random.Range(0.0f,100.0f);

        if(prob < vr*100)
        {
          if(gm != null)
            gm.EnterBattle(Rarity.VeryRare);
        }
        else if(prob < r*100)
        {
          if(gm != null)
            gm.EnterBattle(Rarity.Rare);
        }
        else if(prob < sr*100)
        {
          if(gm != null)
            gm.EnterBattle(Rarity.SemiRare);
        }
        else if(prob < c*100)
        {
          if(gm != null)
            gm.EnterBattle(Rarity.Common);
        }
        else if(prob < vc*100)
        {
          if(gm != null)
            gm.EnterBattle(Rarity.VeryCommon);
        }
      }
    }
}
