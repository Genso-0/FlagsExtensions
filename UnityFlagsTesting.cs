using UnityEngine;
namespace FlagsTesting
{
    public class UnityFlagsTesting : MonoBehaviour
    {
        public ExampleFlags flags;
        public ExampleFlags testAgainst;
        GUIStyle guiButtonStyle;
        private void OnGUI()
        {
            guiButtonStyle = GUI.skin.button;
            if (GUILayout.Button("Add", guiButtonStyle))
            {
                flags.Add(testAgainst);
            }
            else if (GUILayout.Button("Remove", guiButtonStyle))
            {
                flags.Remove(testAgainst);
            }
            else if (GUILayout.Button("Test_IsEqual", guiButtonStyle))
            {
                print($"Is equal: {flags.IsEqual(testAgainst)}");
            }
            else if (GUILayout.Button("Test_ContainsEitherOr", guiButtonStyle))
            {
                print($"Contains either or: {flags.Contains_EitherOr(testAgainst)}");
            }
            else if (GUILayout.Button("Test_ContainsAllOf", guiButtonStyle))
            {
                print($"Contains all of: {flags.Contains_AllOf(testAgainst)}");
            }
            else if (GUILayout.Button("Get common", guiButtonStyle))
            {
                print($"Get common: {flags.GetCommon(testAgainst)}");
            }
            else if (GUILayout.Button("Print Flags as BitArray", guiButtonStyle))
            {
                print($"Flags: {EnumExtensions.MaskToBitArrayString((int)flags)}");
                print($"Test Against: {EnumExtensions.MaskToBitArrayString((int)testAgainst)}");
            }
        }
    }
}
