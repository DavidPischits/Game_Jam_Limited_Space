using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField]public  List <Card> Cards = new List<Card>();
    [SerializeField] public List <PlayerCard> PlayerCards = new List<PlayerCard>();
    [SerializeField] public  List <AggressionCard> AggressionCards = new List<AggressionCard>();
    [SerializeField] public static List <DefensiveCard> DefensiveCards = new List<DefensiveCard>();
    [SerializeField] public static List<PeacefulCard> PeacefulCards = new List<PeacefulCard>();

    void Start()
    {
        foreach(AggressionCard card in  Cards)
        {
            if(AggressionCards.Contains(card) == false)  
                AggressionCards.Add(card);

               
          
        }

        foreach (DefensiveCard card in Cards)
        {
            if (DefensiveCards.Contains(card) == false)
                DefensiveCards.Add(card);

        }

        foreach(PeacefulCard card in Cards)
        {
            if(PeacefulCards.Contains(card) != false)
                PeacefulCards.Add(card);
        }
    }
}
