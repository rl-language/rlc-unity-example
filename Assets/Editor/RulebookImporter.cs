using UnityEngine;
using UnityEditor;
using UnityEditor.AssetImporters;

// Tells Unity to treat .rl as text!
[ScriptedImporter(1, "rl")]
public class RulebookImporter : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        var textAsset = new TextAsset(System.IO.File.ReadAllText(ctx.assetPath));
        ctx.AddObjectToAsset("main", textAsset);
        ctx.SetMainObject(textAsset);
    }
}
