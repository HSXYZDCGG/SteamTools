#pragma warning disable IDE0079 // 请删除不必要的忽略
#pragma warning disable SA1634 // File header should show copyright
// <console-tools-generated/>
#pragma warning restore SA1634 // File header should show copyright
#pragma warning restore IDE0079 // 请删除不必要的忽略
using static BD.WTTS.Settings.Abstractions.IUISettings;

// ReSharper disable once CheckNamespace
namespace BD.WTTS.Settings;

[JsonSourceGenerationOptions(WriteIndented = true, IgnoreReadOnlyProperties = true)]
[JsonSerializable(typeof(UISettings_))]
internal partial class UISettingsContext : JsonSerializerContext
{
    static UISettingsContext? instance;

    public static UISettingsContext Instance
        => instance ??= new UISettingsContext(ISettings.GetDefaultOptions());
}

[MPObj, MP2Obj(SerializeLayout.Explicit)]
public sealed partial class UISettings_ : IUISettings, ISettings, ISettings<UISettings_>
{
    public const string Name = nameof(UISettings);

    static string ISettings.Name => Name;

    static JsonSerializerContext ISettings.JsonSerializerContext
        => UISettingsContext.Instance;

    static JsonTypeInfo ISettings.JsonTypeInfo
        => UISettingsContext.Instance.UISettings_;

    static JsonTypeInfo<UISettings_> ISettings<UISettings_>.JsonTypeInfo
        => UISettingsContext.Instance.UISettings_;

    #region 主题

    /// <summary>
    /// 主题
    /// </summary>
    [MPKey(0), MP2Key(0), JsonPropertyOrder(0)]
    public AppTheme? Theme { get; set; }

    /// <summary>
    /// 主题强调色（16 进制 RGB 字符串）
    /// </summary>
    [MPKey(1), MP2Key(1), JsonPropertyOrder(1)]
    public string? ThemeAccent { get; set; }

    /// <summary>
    /// 从系统中获取主题强调色
    /// </summary>
    [MPKey(2), MP2Key(2), JsonPropertyOrder(2)]
    public bool? UseSystemThemeAccent { get; set; }

    #endregion

    /// <summary>
    /// 语言
    /// </summary>
    [MPKey(3), MP2Key(3), JsonPropertyOrder(3)]
    public string? Language { get; set; }

    /// <summary>
    /// 不再提示的消息框
    /// </summary>
    [MPKey(4), MP2Key(4), JsonPropertyOrder(4)]
    public HashSet<MessageBox.DontPromptType>? MessageBoxDontPrompts { get; set; }

    /// <summary>
    /// 是否显示广告
    /// </summary>
    [MPKey(5), MP2Key(5), JsonPropertyOrder(5)]
    public bool? IsShowAdvertisement { get; set; }

    /// <summary>
    /// 窗口位置大小
    /// </summary>
    [MPKey(6), MP2Key(6), JsonPropertyOrder(6)]
    public ConcurrentDictionary<string, SizePosition>? WindowSizePositions { get; set; }

    /// <summary>
    /// 字体
    /// </summary>
    [MPKey(7), MP2Key(7), JsonPropertyOrder(7)]
    public string? FontName { get; set; }

    /// <summary>
    /// 库存游戏网格布局大小
    /// </summary>
    [MPKey(8), MP2Key(8), JsonPropertyOrder(8)]
    public int? GameListGridSize { get; set; }

    /// <summary>
    /// 圆角
    /// </summary>
    [MPKey(9), MP2Key(9), JsonPropertyOrder(9)]
    public bool? Fillet { get; set; }

    #region WindowBackground 窗口背景

    /// <summary>
    /// 窗口背景不透明度
    /// </summary>
    [MPKey(10), MP2Key(10), JsonPropertyOrder(10)]
    public double? WindowBackgroundOpacity { get; set; }

    /// <summary>
    /// 窗口背景材质
    /// </summary>
    [MPKey(11), MP2Key(11), JsonPropertyOrder(11)]
    public WindowBackgroundMaterial? WindowBackgroundMaterial { get; set; }

    /// <summary>
    /// 动态桌面背景
    /// </summary>
    [MPKey(12), MP2Key(12), JsonPropertyOrder(12)]
    public bool? WindowBackgroundDynamic { get; set; }

    /// <summary>
    /// 是否打开自定义背景图像
    /// </summary>
    [MPKey(13), MP2Key(13), JsonPropertyOrder(13)]
    public bool? WindowBackgroundCustomImage { get; set; }

    /// <summary>
    /// 自定义背景图像路径
    /// </summary>
    [MPKey(14), MP2Key(14), JsonPropertyOrder(14)]
    public string? WindowBackgroundCustomImagePath { get; set; }

    /// <summary>
    /// 自定义背景图像不透明度
    /// </summary>
    [MPKey(15), MP2Key(15), JsonPropertyOrder(15)]
    public double? WindowBackgroundCustomImageOpacity { get; set; }

    /// <summary>
    /// 自定义背景图像缩放方式
    /// </summary>
    [MPKey(16), MP2Key(16), JsonPropertyOrder(16)]
    public XamlMediaStretch? WindowBackgroundCustomImageStretch { get; set; }

    #endregion

}

public static partial class UISettings
{
    #region 主题

    /// <summary>
    /// 主题
    /// </summary>
    public static SettingsStructProperty<AppTheme, UISettings_> Theme { get; }
        = new(DefaultTheme);

    /// <summary>
    /// 主题强调色（16 进制 RGB 字符串）
    /// </summary>
    public static SettingsProperty<string, UISettings_> ThemeAccent { get; }
        = new(DefaultThemeAccent);

    /// <summary>
    /// 从系统中获取主题强调色
    /// </summary>
    public static SettingsStructProperty<bool, UISettings_> UseSystemThemeAccent { get; }
        = new(DefaultUseSystemThemeAccent);

    #endregion

    /// <summary>
    /// 语言
    /// </summary>
    public static SettingsProperty<string, UISettings_> Language { get; }
        = new(DefaultLanguage);

    /// <summary>
    /// 不再提示的消息框
    /// </summary>
    public static SettingsProperty<MessageBox.DontPromptType, HashSet<MessageBox.DontPromptType>, UISettings_> MessageBoxDontPrompts { get; }
        = new(DefaultMessageBoxDontPrompts);

    /// <summary>
    /// 是否显示广告
    /// </summary>
    public static SettingsStructProperty<bool, UISettings_> IsShowAdvertisement { get; }
        = new(DefaultIsShowAdvertisement);

    /// <summary>
    /// 窗口位置大小
    /// </summary>
    public static SettingsProperty<string, SizePosition, ConcurrentDictionary<string, SizePosition>, UISettings_> WindowSizePositions { get; }
        = new(DefaultWindowSizePositions);

    /// <summary>
    /// 字体
    /// </summary>
    public static SettingsProperty<string, UISettings_> FontName { get; }
        = new(DefaultFontName);

    /// <summary>
    /// 库存游戏网格布局大小
    /// </summary>
    public static SettingsStructProperty<int, UISettings_> GameListGridSize { get; }
        = new(DefaultGameListGridSize);

    /// <summary>
    /// 圆角
    /// </summary>
    public static SettingsStructProperty<bool, UISettings_> Fillet { get; }
        = new(DefaultFillet);

    #region WindowBackground 窗口背景

    /// <summary>
    /// 窗口背景不透明度
    /// </summary>
    public static SettingsStructProperty<double, UISettings_> WindowBackgroundOpacity { get; }
        = new(DefaultWindowBackgroundOpacity);

    /// <summary>
    /// 窗口背景材质
    /// </summary>
    public static SettingsStructProperty<WindowBackgroundMaterial, UISettings_> WindowBackgroundMaterial { get; }
        = new(DefaultWindowBackgroundMaterial);

    /// <summary>
    /// 动态桌面背景
    /// </summary>
    public static SettingsStructProperty<bool, UISettings_> WindowBackgroundDynamic { get; }
        = new(DefaultWindowBackgroundDynamic);

    /// <summary>
    /// 是否打开自定义背景图像
    /// </summary>
    public static SettingsStructProperty<bool, UISettings_> WindowBackgroundCustomImage { get; }
        = new(DefaultWindowBackgroundCustomImage);

    /// <summary>
    /// 自定义背景图像路径
    /// </summary>
    public static SettingsProperty<string, UISettings_> WindowBackgroundCustomImagePath { get; }
        = new(DefaultWindowBackgroundCustomImagePath);

    /// <summary>
    /// 自定义背景图像不透明度
    /// </summary>
    public static SettingsStructProperty<double, UISettings_> WindowBackgroundCustomImageOpacity { get; }
        = new(DefaultWindowBackgroundCustomImageOpacity);

    /// <summary>
    /// 自定义背景图像缩放方式
    /// </summary>
    public static SettingsStructProperty<XamlMediaStretch, UISettings_> WindowBackgroundCustomImageStretch { get; }
        = new(DefaultWindowBackgroundCustomImageStretch);

    #endregion

}
