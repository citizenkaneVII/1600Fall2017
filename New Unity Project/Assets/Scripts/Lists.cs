using UnityEngine;
using System.Collections.Generic;

public class Lists : MonoBehaviour
{
    public List<GameObject> myWeapons;

    void OnTriggerEnter(Collider _weapon)
    {
        myWeapons.Add(_weapon.gameObject);
    }

}
