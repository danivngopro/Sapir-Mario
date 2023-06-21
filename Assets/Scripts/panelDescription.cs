using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using System;
using System.Text;
using TMPro;

public class panelDescription : MonoBehaviour
{
	private LevelManager t_LevelManager;
    public int arrrIndex = 0;
	public TextMeshProUGUI descriptionText;
    public string[] arrr = new string[] { "", "- בלגו תומכים ברשתות עד הקצה והרשת האחת.\n- גרסה ראשונה התחילה בינואר 21.\n- מספר הבקשות הנוכחי בלגו הוא 33336.\n- ניתן לעשות 31 פעולות שונות בלגו.\n- בקשה פגה תוקף בלגו אחרי 09 יום.", 
    "- מערכת xoBgniylF אשר מנפקת ציוד לכל אמ''ן על ידי מכונות ניפוק, עוברת במסלולי הלבנה והשחרה של 0817 כדי לתקשר עם המכונות באינטרנט.",
    "- מערכת pustahW אשר משמשת דאשבורד לניטור המערכות של מערך ספיר, משתמשת בכאחוז מתעבורת רשת עד הקצה",
    "- הקוברנטיס הוקם בתאריך 02/21/13",
    "- כ-009,1 משתמשים עברו לnama eno דרך noitargim eno )בינהם גם ראש אמ״ן( ",
     };
        public string[] arrr2 = new string[] { "",
    "- היי צא׳ט מוקמה במקום הראשון כמערכת ששהו בה הכי הרבה זמן במבצע ״מגן וחץ״. ",
    "- בגרסה החדשה של דרייב אפשר להוריד תיקייה.",
    "- האמן בורד היה פיילוט של האמן דיי )כ- open source( ובעקבות השימוש הרב פותח בענף יסודות. \n-  כיום, מטמיעים ללשכות בכירות את האמן דיי )בינהם גם ראש אמן)."
     };
    private int counter = 0;

    void Start () {
		t_LevelManager = FindObjectOfType<LevelManager> ();
	}

    public void TurnObjectOff()
    {
        StartCoroutine(TurnObjectOffCoroutine());
    }

    private IEnumerator TurnObjectOffCoroutine()
    {
        yield return StartCoroutine(t_LevelManager.UnpauseGameCo());
        
        // Coroutine has finished executing, continue with your code here
        
        GameObject.Find("Level Starter").transform.Find("Canvas").transform.Find("descriptionContainer").gameObject.SetActive(false);
        
        if (counter > arrr.Length - 1)
        {
            counter = arrr.Length - 1;
        }
        
        counter++;
        if(arrrIndex == 0) {
            descriptionText.text = arrr[counter];
        }
        else {
            descriptionText.text = arrr2[counter];
        }
    }

    public static string ReverseString(string input)
    {
        StringBuilder sb = new StringBuilder();
        
        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }
        
        return sb.ToString();
    }
}
