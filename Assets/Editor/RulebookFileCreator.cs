using UnityEditor;
using UnityEngine;
using System.IO;

public static class RulebookFileCreator
{
    [MenuItem("Assets/Create/Rulebook File", false, 80)] // Path, isValidateFunction, priority
    public static void CreateRulebookFile()
    {
        // Create a new .rl file
        string path = GetCurrentProjectWindowPath();
        string fileName = "NewRulebook.rl";
        string fullPath = Path.Combine(path, fileName);

        // Ensure unique name
        fullPath = AssetDatabase.GenerateUniqueAssetPath(fullPath);

        File.WriteAllText(fullPath, "import serialization.print\n\nact play() -> Game:\n\tact do_something()\n");

        AssetDatabase.Refresh();

        // Select the newly created file
        UnityEngine.Object obj = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(fullPath);
        Selection.activeObject = obj;
    }

    private static string GetCurrentProjectWindowPath()
    {
        string path = "Assets";

        foreach (UnityEngine.Object obj in Selection.GetFiltered(typeof(UnityEngine.Object), SelectionMode.Assets))
        {
            path = AssetDatabase.GetAssetPath(obj);
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                path = Path.GetDirectoryName(path);
                break;
            }
        }
        return path;
    }
}
