using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGenerator : MonoBehaviour
{
    private GameObject Player;
    private GameObject CharactorGameObject;

    public void GenCharacter()
    {
        Player = Instantiate(CharactorGameObject);
        Player.transform.position = new Vector3(-2f, 0.5f, 08.6f);
    }
}
