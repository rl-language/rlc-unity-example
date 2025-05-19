using UnityEditor;
using UnityEngine;
using System.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System;
using System.Text.RegularExpressions;
using System.IO;

public class LinuxUnloadLibrary : MonoBehaviour {


    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void EarlyLoad()
    {
        UnityEngine.Debug.Log("Early load called");
        RLCNative.teardown();
        UnityEngine.Debug.Log("Loading Rulebook lib" + getLibToLoad());
        RLCNative.setup(getLibToLoad());
    }

    public static string getLibToLoad() {
        return FindLatest(Path.Combine(
                            Application.dataPath.Substring(0, 
                                                          Application.dataPath.Length - "Assets".Length), 
                            "Assets/Plugins/Generated/"), 
                        "Lib");
    }

    public static string FindLatest(string searchDir, string baseName = "libGameplay")
    {
        // Pattern: libGameplay_YYYYMMDD_HHMMSS.so
        var regex = new Regex($@"^{Regex.Escape(baseName)}_(\d{{8}}_\d{{6}})\.so$");

        var latest = Directory.EnumerateFiles(searchDir, $"{baseName}_*.so")
                              .Select(path => new
                              {
                                  Path = path,
                                  Match = regex.Match(Path.GetFileName(path))
                              })
                              .Where(x => x.Match.Success)
                              .OrderByDescending(x => x.Match.Groups[1].Value) // lexical == chrono
                              .FirstOrDefault();

        return latest == null ? null : Path.GetFullPath(latest.Path);
    }

class CustomAssetPostprocessor : AssetPostprocessor
{
    public static bool RunExternalTool(string toolName, string arguments)
{
    try
    {
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = toolName, // If it's in PATH, you can just specify the name
            Arguments = arguments,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };

        using (Process process = Process.Start(startInfo))
        {
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            UnityEngine.Debug.Log($"Tool output: {output}");
            if (!string.IsNullOrEmpty(error))
                UnityEngine.Debug.LogError($"Tool error: {error}");

            return process.ExitCode == 0;
        }
    }
    catch (System.Exception e)
    {
        UnityEngine.Debug.LogError($"Failed to run external tool: {e}");
        return false;
    }
}


    public static string MakeTimestampedName(string baseName = "libGameplay")
    {
        // UTC avoids daylight-saving oddities; to the second is usually enough
        string stamp = DateTime.UtcNow.ToString("yyyyMMdd_HHmmss");
        return $"{baseName}_{stamp}.so";          // → libGameplay_20250430_153044.so
    }



    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets,
        string[] movedAssets, string[] movedFromAssetPaths)
    {
        bool loadedAnything = false;

        string fulllib = Path.Combine(Application.dataPath.Substring(0, Application.dataPath.Length - "Assets".Length), "Assets/Plugins/Generated/" + MakeTimestampedName("Lib"));
        string fullcs = Path.Combine(Application.dataPath.Substring(0, Application.dataPath.Length - "Assets".Length), "Assets/Scripts/Generated/RLC.cs");

        foreach (string asset in importedAssets) {

            if (asset.EndsWith(".rl")) {
                string fullpath = Path.Combine(Application.dataPath.Substring(0, Application.dataPath.Length - "Assets".Length), asset);

                if (getLibToLoad() != null)
                {
                    //UnityEngine.Debug.Log("Erasing lib " + getLibToLoad());
                    File.Delete(getLibToLoad());
                }
                RunExternalTool("/home/massimo/rlc-infrastructure/rlc-release/install/bin/rlc", "\"" + fullpath + "\" --shared -o " + "\"" + fulllib + "\"");                
                RunExternalTool("/home/massimo/rlc-infrastructure/rlc-release/install/bin/rlc", "\"" + fullpath + "\" --c-sharp -o " + "\"" + fullcs + "\"");                
                loadedAnything = true;
            }
        }
        if (loadedAnything)
        {
            AssetDatabase.Refresh();
        }
    }
}

}
