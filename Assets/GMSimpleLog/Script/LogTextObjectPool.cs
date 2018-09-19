using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GMLogSystem
{
    public class LogTextObjectPool : MonoBehaviour
    {

        public LogText LogTextPrefab;
        public Transform parent;
        public int maxPooledAmount = 10;

        List<LogText> pooledLogTexts;

        public void Init()
        {

            pooledLogTexts = new List<LogText>();

            for (int i = 0; i < maxPooledAmount; i++)
            {
                LogText logText = Instantiate(LogTextPrefab);
                logText.gameObject.SetActive(false);
                logText.gameObject.transform.SetParent(parent);
                pooledLogTexts.Add(logText);
            }

        }

        public LogText GetLogText()
        {

            for (int i = 0; i < pooledLogTexts.Count; i++)
            {
                if (!pooledLogTexts[i].gameObject.activeInHierarchy)
                {
                    return pooledLogTexts[i];
                }
            }

            // After all the pooledLogText is activated
            // code will always go here

            // Make the first pooledLogText become the last one
            pooledLogTexts[0].gameObject.SetActive(false);
            pooledLogTexts[0].gameObject.transform.SetAsLastSibling(); // Don't remove this line!
            pooledLogTexts.Add(pooledLogTexts[0]);
            pooledLogTexts.RemoveAt(0);
            return pooledLogTexts[pooledLogTexts.Count - 1];

        }

    }

}
