using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTurn : MonoBehaviour
{
    public GameObject character;

    /// <summary>
    /// 버튼 클릭시 캐릭터가 회전을 하는 코드
    /// </summary>
    public void RightTurnCharacter() 
    {
        character.transform.Rotate(0, -45, 0);
    }

    public void LeftTurnCharacter() 
    {
        character.transform.Rotate(0, 45, 0);
    }
}
