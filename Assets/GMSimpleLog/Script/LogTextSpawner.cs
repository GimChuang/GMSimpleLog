using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GMLogSystem
{
    public static class LogTextSpawner
    {
        public static LogTextObjectPool thePool;

        public static Color normalColor = Color.black;
        public static Color warningColor = Color.yellow;
        public static Color errorColor = Color.red;

        // This method must be called in an Awake()
        public static void SetUpSpawner(LogTextObjectPool _thePool)
        {
            thePool = _thePool;
        }

        public static void Log(string _string)
        {
            LogText logText = thePool.GetLogText();
            logText.SetUp(normalColor, _string);
            logText.gameObject.SetActive(true);
        }

        public static void LogWarning(string _string)
        {
            LogText logText = thePool.GetLogText();
            logText.SetUp(warningColor, _string);
            logText.gameObject.SetActive(true);
        }

        public static void LogError(string _string)
        {
            LogText logText = thePool.GetLogText();
            logText.SetUp(errorColor, _string);
            logText.gameObject.SetActive(true);
        }
    }
}


