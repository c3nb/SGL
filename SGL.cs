public static class SGL
{
    public static void BI(float indentSize = 20f)
    {
        BH();
        S(indentSize);
        BV();
    }
    public static void EI()
    {
        EV();
        EH();
    }
    public static Color CRgbS(Color color)
    {
        float oldR = Mathf.Round(color.r * 255);
        float oldG = Mathf.Round(color.g * 255);
        float oldB = Mathf.Round(color.b * 255);
        float newR = NS("R:", oldR, 0, 255, 300f, 1, 40f);
        float newG = NS("G:", oldG, 0, 255, 300f, 1, 40f);
        float newB = NS("B:", oldB, 0, 255, 300f, 1, 40f);
        if (oldR != newR || oldG != newG || oldB != newB)
        {
            return new Color(newR / 255, newR / 255, newR / 255);
        }
        return color;
    }
    public static Color CRgbaS(Color color)
    {
        float oldR = Mathf.Round(color.r * 255);
        float oldG = Mathf.Round(color.g * 255);
        float oldB = Mathf.Round(color.b * 255);
        float oldA = Mathf.Round(color.a * 255);
        float newR = NS("R:", oldR, 0, 255, 300f, 1, 40f);
        float newG = NS("G:", oldG, 0, 255, 300f, 1, 40f);
        float newB = NS("B:", oldB, 0, 255, 300f, 1, 40f);
        float newA = NS("A:", oldA, 0, 255, 300f, 1, 40f);
        if (oldR != newR || oldG != newG || oldB != newB || oldA != newA)
        {
            return new Color(newR / 255, newR / 255, newR / 255, newA / 255);
        }
        return color;
    }
    public static (Color, Color) CRgbSP(Color color1, Color color2)
    {
        float newR1, newR2, newG1, newG2, newB1, newB2;
        float oldR1 = Mathf.Round(color1.r * 255);
        float oldG1 = Mathf.Round(color1.g * 255);
        float oldB1 = Mathf.Round(color1.b * 255);
        float oldR2 = Mathf.Round(color2.r * 255);
        float oldG2 = Mathf.Round(color2.g * 255);
        float oldB2 = Mathf.Round(color2.b * 255);
        (newR1, newR2) = NSP("R:", "R:", oldR1, oldR2, 0, 255, 300f, 1, 40f);
        (newG1, newG2) = NSP("G:", "G:", oldG1, oldG2, 0, 255, 300f, 1, 40f);
        (newB1, newB2) = NSP("B:", "B:", oldB1, oldB2, 0, 255, 300f, 1, 40f);
        if (oldR1 != newR1 || oldG1 != newG1 || oldB1 != newB1)
        {
            color1 = new Color(newR1 / 255, newG1 / 255, newB1 / 255);
        }
        if (oldR2 != newR2 || oldG2 != newG2 || oldB2 != newB2)
        {
            color2 = new Color(newR2 / 255, newG2 / 255, newB2 / 255);
        }
        return (color1, color2);
    }
    public static (Color, Color) CRgbaSP(Color color1, Color color2)
    {
        float newR1, newR2, newG1, newG2, newB1, newB2, newA1, newA2;
        float oldR1 = Mathf.Round(color1.r * 255);
        float oldG1 = Mathf.Round(color1.g * 255);
        float oldB1 = Mathf.Round(color1.b * 255);
        float oldA1 = Mathf.Round(color1.a * 255);
        float oldR2 = Mathf.Round(color2.r * 255);
        float oldG2 = Mathf.Round(color2.g * 255);
        float oldB2 = Mathf.Round(color2.b * 255);
        float oldA2 = Mathf.Round(color2.a * 255);
        (newR1, newR2) = NSP("R:", "R:", oldR1, oldR2, 0, 255, 300f, 1, 40f);
        (newG1, newG2) = NSP("G:", "G:", oldG1, oldG2, 0, 255, 300f, 1, 40f);
        (newB1, newB2) = NSP("B:", "B:", oldB1, oldB2, 0, 255, 300f, 1, 40f);
        (newA1, newA2) = NSP("A:", "A:", oldA1, oldA2, 0, 255, 300f, 1, 40f);
        if (oldR1 != newR1 || oldG1 != newG1 || oldB1 != newB1 || oldA1 != newA1)
        {
            color1 = new Color(newR1 / 255, newG1 / 255, newB1 / 255, newA1 / 255);
        }
        if (oldR2 != newR2 || oldG2 != newG2 || oldB2 != newB2 || oldA2 != newA2)
        {
            color2 = new Color(newR2 / 255, newG2 / 255, newB2 / 255, newA2 / 255);
        }
        return (color1, color2);
    }
    public static float NS(string name, float value, float leftValue, float rightValue, float sliderWidth, float roundNearest = 0, float labelWidth = 0, string valueFormat = "{0}")
    {
        BH();
        float newValue =
            NSC(
                name,
                value,
                leftValue,
                rightValue,
                sliderWidth,
                roundNearest,
                labelWidth,
                valueFormat);
        EH();
        return newValue;
    }
    public static (float, float) NSP(string name1, string name2, float value1, float value2, float leftValue, float rightValue, float sliderWidth, float roundNearest = 0, float labelWidth = 0, string valueFormat = "{0}")
    {
        BH();
        float newValue1 =
            NSC(
                name1,
                value1,
                leftValue,
                rightValue,
                sliderWidth,
                roundNearest,
                labelWidth,
                valueFormat);
        float newValue2 =
            NSC(
                name2,
                value2,
                leftValue,
                rightValue,
                sliderWidth,
                roundNearest,
                labelWidth,
                valueFormat);
        EH();
        return (newValue1, newValue2);
    }
    private static float NSC(string name, float value, float leftValue, float rightValue, float sliderWidth, float roundNearest = 0, float labelWidth = 0, string valueFormat = "{0}")
    {
        if (labelWidth == 0)
        {
            L(name);
            S(4f);
        }
        else L(name, W(labelWidth));
        float newValue = HS(value, leftValue, rightValue, W(sliderWidth));
        if (roundNearest != 0) newValue = Mathf.Round(newValue / roundNearest) * roundNearest;
        S(8f);
        L(string.Format(valueFormat, newValue), W(40f));
        FS();
        return newValue;
    }
    public static string NTF(string name, string value, float fieldWidth, float labelWidth = 0)
    {
        BH();
        string newValue = NTFC(name, value, fieldWidth, labelWidth);
        EH();
        return newValue;
    }
    public static (string, string) NTFP(string name1, string name2, string value1, string value2, float fieldWidth, float labelWidth = 0)
    {
        BH();
        string newValue1 = NTFC(name1, value1, fieldWidth, labelWidth);
        string newValue2 = NTFC(name2, value2, fieldWidth, labelWidth);
        EH();
        return (newValue1, newValue2);
    }
    private static string NTFC(string name, string value, float fieldWidth, float labelWidth = 0)
    {
        if (labelWidth == 0)
        {
            L(name);
            S(4f);
        }
        else L(name, W(labelWidth));
        string newValue = TF(value, W(fieldWidth));
        FS();
        return newValue;
    }
    public static bool TL<T>(List<T> list, ref int selectedIndex, Func<T, string> nameFunc)
    {
        bool changed = false;
        int moveUp = -1, moveDown = -1;
        for (int i = 0; i < list.Count; i++)
        {
            T curr = list[i];
            string name = nameFunc.Invoke(curr);
            BH();
            BH();
            if (Btn("▲") && i > 0)
            {
                moveUp = i;
            }
            if (Btn("▼") && i < list.Count - 1)
            {
                moveDown = i;
            }
            EH();
            S(8f);
            if (SGL.T(selectedIndex == i, name) && selectedIndex != i)
            {
                selectedIndex = i;
                changed = true;
            }
            FS();
            EH();
        }
        if (moveUp != -1)
        {
            changed = true;
            T temp = list[moveUp];
            list[moveUp] = list[moveUp - 1];
            list[moveUp - 1] = temp;
            if (moveUp - 1 == selectedIndex)
            {
                selectedIndex++;
            }
            else if (moveUp == selectedIndex)
            {
                selectedIndex--;
            }
        }
        else if (moveDown != -1)
        {
            changed = true;
            T temp = list[moveDown];
            list[moveDown] = list[moveDown + 1];
            list[moveDown + 1] = temp;
            if (moveDown + 1 == selectedIndex)
            {
                selectedIndex--;
            }
            else if (moveDown == selectedIndex)
            {
                selectedIndex++;
            }
        }
        return changed;
    }
    public static void HL(float thickness, float length = 0f)
    {
        Box(GUIContent.none, new GUIStyle()
        {
            margin = new RectOffset(8, 8, 4, 4),
            padding = new RectOffset(),
            fixedHeight = thickness,
            fixedWidth = length,
            normal = {
                    background = Texture2D.whiteTexture,
                },
        });
    }
    public static void BA(Rect screenRect, string text, GUIStyle style) => GUILayout.BeginArea(screenRect, text, style);
    public static void BA(Rect screenRect, Texture image, GUIStyle style) => GUILayout.BeginArea(screenRect, image, style);
    public static void BA(Rect screenRect, GUIContent content, GUIStyle style) => GUILayout.BeginArea(screenRect, content, style);
    public static void BA(Rect screenRect, Texture image) => GUILayout.BeginArea(screenRect, image);
    public static void BA(Rect screenRect, string text) => GUILayout.BeginArea(screenRect, text);
    public static void BA(Rect screenRect) => GUILayout.BeginArea(screenRect);
    public static void BA(Rect screenRect, GUIStyle style) => GUILayout.BeginArea(screenRect, style);
    public static void BA(Rect screenRect, GUIContent content) => GUILayout.BeginArea(screenRect, content);
    public static void BH(params GUILayoutOption[] options) => GUILayout.BeginHorizontal(options);
    public static void BH(GUIStyle style, params GUILayoutOption[] options) => GUILayout.BeginHorizontal(style, options);
    public static void BH(string text, GUIStyle style, params GUILayoutOption[] options) => GUILayout.BeginHorizontal(text, style, options);
    public static void BH(Texture image, GUIStyle style, params GUILayoutOption[] options) => GUILayout.BeginHorizontal(image, style, options);
    public static void BH(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => GUILayout.BeginHorizontal(content, style, options);
    public static Vector2 BSV(Vector2 scrollPosition, params GUILayoutOption[] options) => GUILayout.BeginScrollView(scrollPosition, options);
    public static Vector2 BSV(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options) => GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, options);
    public static Vector2 BSV(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options) => GUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, options);
    public static Vector2 BSV(Vector2 scrollPosition, GUIStyle style) => GUILayout.BeginScrollView(scrollPosition, style);
    public static Vector2 BSV(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options) => GUILayout.BeginScrollView(scrollPosition, style, options);
    public static Vector2 BSV(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options) => GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, options);
    public static Vector2 BSV(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options) => GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
    public static void BV(Texture image, GUIStyle style, params GUILayoutOption[] options) => GUILayout.BeginVertical(image, style, options);
    public static void BV(string text, GUIStyle style, params GUILayoutOption[] options) => GUILayout.BeginVertical(text, style, options);
    public static void BV(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => GUILayout.BeginVertical(content, style, options);
    public static void BV(params GUILayoutOption[] options) => GUILayout.BeginVertical(options);
    public static void BV(GUIStyle style, params GUILayoutOption[] options) => GUILayout.BeginVertical(style, options);
    public static void Box(string text, params GUILayoutOption[] options) => GUILayout.Box(text, options);
    public static void Box(string text, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Box(text, style, options);
    public static void Box(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Box(content, style, options);
    public static void Box(Texture image, params GUILayoutOption[] options) => GUILayout.Box(image, options);
    public static void Box(Texture image, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Box(image, style, options);
    public static void Box(GUIContent content, params GUILayoutOption[] options) => GUILayout.Box(content, options);
    public static bool Btn(Texture image, params GUILayoutOption[] options) => GUILayout.Button(image, options);
    public static bool Btn(string text, params GUILayoutOption[] options) => GUILayout.Button(text, options);
    public static bool Btn(GUIContent content, params GUILayoutOption[] options) => GUILayout.Button(content, options);
    public static bool Btn(Texture image, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Button(image, style, options);
    public static bool Btn(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Button(content, style, options);
    public static bool Btn(string text, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Button(text, style, options);
    public static void EA() => GUILayout.EndArea();
    public static void EH() => GUILayout.EndHorizontal();
    public static void ESV() => GUILayout.EndScrollView();
    public static void EV() => GUILayout.EndVertical();
    public static GUILayoutOption EH(bool expand) => GUILayout.ExpandHeight(expand);
    public static GUILayoutOption EW(bool expand) => GUILayout.ExpandWidth(expand);
    public static void FS() => GUILayout.FlexibleSpace();
    public static GUILayoutOption H(float height) => GUILayout.Height(height);
    public static float HSb(float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options) => GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, style, options);
    public static float HSb(float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options) => GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, options);
    public static float HS(float value, float leftValue, float rightValue, params GUILayoutOption[] options) => GUILayout.HorizontalSlider(value, leftValue, rightValue, options);
    public static float HS(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options) => GUILayout.HorizontalSlider(value, leftValue, rightValue, slider, thumb, options);
    public static void L(Texture image, params GUILayoutOption[] options) => GUILayout.Label(image, options);
    public static void L(string text, params GUILayoutOption[] options) => GUILayout.Label(text, options);
    public static void L(GUIContent content, params GUILayoutOption[] options) => GUILayout.Label(content, options);
    public static void L(Texture image, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Label(image, style, options);
    public static void L(string text, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Label(text, style, options);
    public static void L(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Label(content, style, options);
    public static GUILayoutOption MxH(float maxHeight) => GUILayout.MaxHeight(maxHeight);
    public static GUILayoutOption MxW(float maxWidth) => GUILayout.MaxWidth(maxWidth);
    public static GUILayoutOption MnH(float minHeight) => GUILayout.MinHeight(minHeight);
    public static GUILayoutOption MnW(float minWidth) => GUILayout.MinWidth(minWidth);
    public static string PF(string password, char maskChar, params GUILayoutOption[] options) => GUILayout.PasswordField(password, maskChar, options);
    public static string PF(string password, char maskChar, int maxLength, params GUILayoutOption[] options) => GUILayout.PasswordField(password, maskChar, maxLength, options);
    public static string PF(string password, char maskChar, GUIStyle style, params GUILayoutOption[] options) => GUILayout.PasswordField(password, maskChar, style, options);
    public static string PF(string password, char maskChar, int maxLength, GUIStyle style, params GUILayoutOption[] options) => GUILayout.PasswordField(password, maskChar, maxLength, style, options);
    public static bool RB(Texture image, GUIStyle style, params GUILayoutOption[] options) => GUILayout.RepeatButton(image, style, options);
    public static bool RB(string text, params GUILayoutOption[] options) => GUILayout.RepeatButton(text, options);
    public static bool RB(Texture image, params GUILayoutOption[] options) => GUILayout.RepeatButton(image, options);
    public static bool RB(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => GUILayout.RepeatButton(content, style, options);
    public static bool RB(string text, GUIStyle style, params GUILayoutOption[] options) => GUILayout.RepeatButton(text, style, options);
    public static bool RB(GUIContent content, params GUILayoutOption[] options) => GUILayout.RepeatButton(content, options);
    public static int SG(int selected, GUIContent[] contents, int xCount, GUIStyle style, params GUILayoutOption[] options) => GUILayout.SelectionGrid(selected, contents, xCount, style, options);
    public static int SG(int selected, string[] texts, int xCount, params GUILayoutOption[] options) => GUILayout.SelectionGrid(selected, texts, xCount, options);
    public static int SG(int selected, Texture[] images, int xCount, GUIStyle style, params GUILayoutOption[] options) => GUILayout.SelectionGrid(selected, images, xCount, style, options);
    public static int SG(int selected, string[] texts, int xCount, GUIStyle style, params GUILayoutOption[] options) => GUILayout.SelectionGrid(selected, texts, xCount, style, options);
    public static int SG(int selected, GUIContent[] content, int xCount, params GUILayoutOption[] options) => GUILayout.SelectionGrid(selected, content, xCount, options);
    public static int SG(int selected, Texture[] images, int xCount, params GUILayoutOption[] options) => GUILayout.SelectionGrid(selected, images, xCount, options);
    public static void S(float pixels) => GUILayout.Space(pixels);
    public static string TA(string text, GUIStyle style, params GUILayoutOption[] options) => GUILayout.TextArea(text, style, options);
    public static string TA(string text, params GUILayoutOption[] options) => GUILayout.TextArea(text, options);
    public static string TA(string text, int maxLength, params GUILayoutOption[] options) => GUILayout.TextArea(text, maxLength, options);
    public static string TA(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options) => GUILayout.TextArea(text, maxLength, style, options);
    public static string TF(string text, GUIStyle style, params GUILayoutOption[] options) => GUILayout.TextField(text, style, options);
    public static string TF(string text, int maxLength, params GUILayoutOption[] options) => GUILayout.TextField(text, maxLength, options);
    public static string TF(string text, params GUILayoutOption[] options) => GUILayout.TextField(text, options);
    public static string TF(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options) => GUILayout.TextField(text, maxLength, style, options);
    public static bool T(bool value, Texture image, params GUILayoutOption[] options) => GUILayout.Toggle(value, image, options);
    public static bool T(bool value, string text, params GUILayoutOption[] options) => GUILayout.Toggle(value, text, options);
    public static bool T(bool value, GUIContent content, params GUILayoutOption[] options) => GUILayout.Toggle(value, content, options);
    public static bool T(bool value, Texture image, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Toggle(value, image, style, options);
    public static bool T(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Toggle(value, content, style, options);
    public static bool T(bool value, string text, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Toggle(value, text, style, options);
    public static int Tb(int selected, string[] texts, params GUILayoutOption[] options) => GUILayout.Toolbar(selected, texts, options);
    public static int Tb(int selected, GUIContent[] contents, params GUILayoutOption[] options) => GUILayout.Toolbar(selected, contents, options);
    public static int Tb(int selected, string[] texts, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Toolbar(selected, texts, style, options);
    public static int Tb(int selected, Texture[] images, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Toolbar(selected, images, style, options);
    public static int Tb(int selected, Texture[] images, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options) => GUILayout.Toolbar(selected, images, style, buttonSize, options);
    public static int Tb(int selected, GUIContent[] contents, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Toolbar(selected, contents, style, options);
    public static int Tb(int selected, GUIContent[] contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options) => GUILayout.Toolbar(selected, contents, style, buttonSize, options);
    public static int Tb(int selected, GUIContent[] contents, bool[] enabled, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Toolbar(selected, contents, enabled, style, options);
    public static int Tb(int selected, GUIContent[] contents, bool[] enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options) => GUILayout.Toolbar(selected, contents, enabled, style, buttonSize, options);
    public static int Tb(int selected, Texture[] images, params GUILayoutOption[] options) => GUILayout.Toolbar(selected, images, options);
    public static int Tb(int selected, string[] texts, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options) => GUILayout.Toolbar(selected, texts, style, buttonSize, options);
    public static float VSb(float value, float size, float topValue, float bottomValue, GUIStyle style, params GUILayoutOption[] options) => GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, style, options);
    public static float VSb(float value, float size, float topValue, float bottomValue, params GUILayoutOption[] options) => GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, options);
    public static float VS(float value, float leftValue, float rightValue, params GUILayoutOption[] options) => GUILayout.VerticalSlider(value, leftValue, rightValue, options);
    public static float VS(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options) => GUILayout.VerticalSlider(value, leftValue, rightValue, slider, thumb, options);
    public static GUILayoutOption W(float width) => GUILayout.Width(width);
    public static Rect Wnd(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Window(id, screenRect, func, content, style, options);
    public static Rect Wnd(int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Window(id, screenRect, func, text, style, options);
    public static Rect Wnd(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, params GUILayoutOption[] options) => GUILayout.Window(id, screenRect, func, content, options);
    public static Rect Wnd(int id, Rect screenRect, GUI.WindowFunction func, Texture image, params GUILayoutOption[] options) => GUILayout.Window(id, screenRect, func, image, options);
    public static Rect Wnd(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options) => GUILayout.Window(id, screenRect, func, text, options);
    public static Rect Wnd(int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Window(id, screenRect, func, image, style, options);
}
