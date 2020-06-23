using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public  List<BasePokemon> ownedPokemon = new List<BasePokemon>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

[System.Serializable]
public class OwnedPokemon
{
  public string Nickname;
  public BasePokemon pokemon;
  public int level;
  public List<PokemonMoves> moves = new List<PokemonMoves>();
}
