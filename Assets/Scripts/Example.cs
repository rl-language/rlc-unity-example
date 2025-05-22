using System.Runtime.InteropServices;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Example : MonoBehaviour
{
    private static Game globalGame = null;
    private static String serialized = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        globalGame = RLC.play();
    }

    static public Game getState() {
        return globalGame;
    }

    static public void before_hot_reload()
    {
        Debug.Log("Before Hot Reload");
        if (globalGame != null)
            serialized = RLC.to_string(globalGame);
        else
            serialized = null;
    }

    static public void after_hot_reload()
    {
        Debug.Log("Attempt Hot Reload");
        if (serialized == null)
            return;
        if (!RLC.from_string(globalGame, serialized))
        {
            Debug.Log("Could not hot reload the code, it has changed too much");
            Application.Quit();
        }
    }

    public static bool applyAction(AnyGameAction action)
    {
        if (!RLC.can_apply(action, globalGame))
            return false;
        RLC.apply(action, globalGame);
        Debug.Log("applied action " + actionToString(action));
        return true;
    }

    public static bool can_apply(AnyGameAction action)
    {
        return RLC.can_apply(action, globalGame);
    }

    static string actionToString(AnyGameAction action)
    {
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
