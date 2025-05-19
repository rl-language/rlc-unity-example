using System.Runtime.InteropServices;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Example : MonoBehaviour
{
    private static Game globalGame = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        globalGame = RLC.play();
    }

    static public Game getState() {
        return globalGame;
    }

    public static bool applyAction(AnyGameAction action) {
        if (!RLC.can_apply(action, globalGame))
            return false;
        RLC.apply(action, globalGame);
        Debug.Log("applied action " + actionToString(action));
        return true;
    }

    static string actionToString(AnyGameAction action) {
        return toCSString(RLC.to_string(action));
    }

    static unsafe string toCSString(String s) {
        char** str_pp = (char**)s.__content;
        char* str_p = *str_pp; 
        long size = s.size(); 

        byte[] buffer = new byte[size];
        for (int i = 0; i != size; i++)
            buffer[i] = (byte)s.get(i);
        
        return Encoding.UTF8.GetString(buffer);
    }

}
