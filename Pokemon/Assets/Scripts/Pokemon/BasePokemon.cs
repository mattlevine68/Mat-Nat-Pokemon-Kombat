using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePokemon : MonoBehaviour
{
    public string Name;
    public Sprite Image;
    public BiomeList biomeFound;
    public PokemonType type;
    public Rarity rarity;
    public Stat HPStat;
    public Stat AttackStat;
    public Stat DefenseStat;
    public float speed;

    public bool canEvolve;
    public PokemonEvolution evolveTo;
    private int level;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

public enum Rarity
{
  VeryCommon,
  Common,
  SemiRare,
  Rare,
  VeryRare
}

public enum PokemonType
{
  Flying,
  Ground,
  Rock,
  Steel,
  Fire,
  Water,
  Grass,
  Ice,
  Electric,
  Psychic,
  Dark,
  Dragon,
  Fighting,
  Normal
}

[System.Serializable]
public class PokemonEvolution
{
  public BasePokemon nextEvolution;
  public int levelUpLevel;
}
