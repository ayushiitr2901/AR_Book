using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class text_wrapper : MonoBehaviour
{
    public TextMesh textMesh;

    public int maxLineChars = 35;
    private int lastMaxLineChars = 35;

    string wrappedText = "";
    public bool disableWhilePlaying = true;

    void Awake()
    {
    }

    void Update()
    {
        if (textMesh.text != wrappedText || maxLineChars != lastMaxLineChars)
        {
            int charCount = 0;
            wrappedText = "";
            string line = "";

            char[] separators = new char[] { ' ', '\n', '\t' };
            string[] words = textMesh.text.Split(separators);

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].Trim();

                if (i == 0)
                {
                    line = word;
                    charCount = word.Length;
                }
                else
                {
                    if ((charCount + (charCount > 0 ? 1 : 0) + word.Length) <= maxLineChars)
                    {
                        if (charCount > 0)
                        {
                            line += ' ';
                            charCount += 1;
                        }

                        line += word;
                        charCount += word.Length;
                    }
                    else
                    {
                        if (wrappedText.Length > 0)
                            wrappedText += '\n';

                        wrappedText += line;

                        line = word;
                        charCount = word.Length;
                    }
                }
            }

            if (charCount > 0)
            {
                if (wrappedText.Length > 0)
                    wrappedText += '\n';

                wrappedText += line;
            }

            textMesh.text = wrappedText;
            textMesh.anchor = TextAnchor.UpperLeft;
            lastMaxLineChars = maxLineChars;
        }
    }
}