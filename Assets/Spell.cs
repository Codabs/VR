using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spell : MonoBehaviour
{
    public List<SpellScriptable> spellScriptable;
    public SpellScriptable currentSpellScriptable;
    public int spellId;
    public int currentSpellPathIndex;

    public bool handGrab;
    public bool handInSpell;
    public bool handStartSpellCast;


    public InputActionProperty grip_Input;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Main"))
        {
            handInSpell = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Main"))
        {
            handInSpell = false;
        }
    }
    private void Update()
    {
        handGrab = grip_Input.action.ReadValue<float>() >= 0.5f;
        if (handInSpell && grip_Input.action.ReadValue<float>() >= 0.5f)
        {
            handStartSpellCast = true;
        }

        if (grip_Input.action.ReadValue<float>() >= 0.5f && handStartSpellCast)
        {

        }
    }
    /// <summary>
    /// start the spell when the hand grab the orb
    /// </summary>
    void StartCast()
    {

    }
}
