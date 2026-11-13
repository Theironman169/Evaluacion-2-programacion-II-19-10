
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int extraDamage = 0;

    public void AddDamage(int amount)
    {
        extraDamage += amount;

        Debug.Log("Extra damage: " + extraDamage);
    }
}
