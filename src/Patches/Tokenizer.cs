using EcmaScript.utils;
using HarmonyLib;

namespace EcmaScript.Patches;

[HarmonyPatch(typeof(Tokenizer))]
public class EcmaScriptTokenizer
{
    [HarmonyPrefix]
    [HarmonyPatch(nameof(Tokenizer.Tokenize))]
    public static bool Tokenize(string code, ref TokenStream stream, ref bool __result)
    {
        var result = Singleton<EcmaScript.Lexer>.Instance.Process("harvest()");
        __result = result.IsOk;
        
        if (result.IsOk)
            stream = result.Value;

        return PrefixAction.SkipOriginal;
    }
}
