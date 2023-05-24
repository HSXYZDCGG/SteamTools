#pragma warning disable IDE0079 // 请删除不必要的忽略
#pragma warning disable SA1634 // File header should show copyright
// <console-tools-generated/>
#pragma warning restore SA1634 // File header should show copyright
#pragma warning restore IDE0079 // 请删除不必要的忽略
// ReSharper disable once CheckNamespace
namespace BD.WTTS.Settings.Abstractions;

public interface IUISettings
{
    static IUISettings? Instance
        => Ioc.Get_Nullable<IOptionsMonitor<IUISettings>>()?.CurrentValue;

    #region 主题

    /// <summary>
    /// 主题
    /// </summary>
    AppTheme? Theme { get; set; }

    /// <summary>
    /// 主题的默认值
    /// </summary>
    const AppTheme? DefaultTheme = AppTheme.FollowingSystem;

    /// <summary>
    /// 主题强调色（16 进制 RGB 字符串）
    /// </summary>
    string? ThemeAccent { get; set; }

    /// <summary>
    /// 主题强调色（16 进制 RGB 字符串）的默认值
    /// </summary>
    const string? DefaultThemeAccent = "#FF0078D7";

    /// <summary>
    /// 从系统中获取主题强调色
    /// </summary>
    bool? UseSystemThemeAccent { get; set; }

    /// <summary>
    /// 从系统中获取主题强调色的默认值
    /// </summary>
    const bool? DefaultUseSystemThemeAccent = true;

    #endregion

    /// <summary>
    /// 语言
    /// </summary>
    string? Language { get; set; }

    /// <summary>
    /// 语言的默认值
    /// </summary>
    const string? DefaultLanguage = null;

    /// <summary>
    /// 不再提示的消息框
    /// </summary>
    HashSet<MessageBox.DontPromptType>? MessageBoxDontPrompts { get; set; }

    /// <summary>
    /// 不再提示的消息框的默认值
    /// </summary>
    const HashSet<MessageBox.DontPromptType>? DefaultMessageBoxDontPrompts = null;

    /// <summary>
    /// 是否显示广告
    /// </summary>
    bool? IsShowAdvertisement { get; set; }

    /// <summary>
    /// 是否显示广告的默认值
    /// </summary>
    const bool? DefaultIsShowAdvertisement = true;

    /// <summary>
    /// 窗口位置大小
    /// </summary>
    ConcurrentDictionary<string, SizePosition>? WindowSizePositions { get; set; }

    /// <summary>
    /// 窗口位置大小的默认值
    /// </summary>
    const ConcurrentDictionary<string, SizePosition>? DefaultWindowSizePositions = null;

    /// <summary>
    /// 字体
    /// </summary>
    string? FontName { get; set; }

    /// <summary>
    /// 字体的默认值
    /// </summary>
    const string? DefaultFontName = null;

    /// <summary>
    /// 库存游戏网格布局大小
    /// </summary>
    int? GameListGridSize { get; set; }

    /// <summary>
    /// 库存游戏网格布局大小的默认值
    /// </summary>
    const int? DefaultGameListGridSize = 150;

    /// <summary>
    /// 圆角
    /// </summary>
    bool? Fillet { get; set; }

    /// <summary>
    /// 圆角的默认值
    /// </summary>
    const bool? DefaultFillet = false;

    #region WindowBackground 窗口背景

    /// <summary>
    /// 窗口背景不透明度
    /// </summary>
    double? WindowBackgroundOpacity { get; set; }

    /// <summary>
    /// 窗口背景不透明度的默认值
    /// </summary>
    const double? DefaultWindowBackgroundOpacity = .8;

    /// <summary>
    /// 窗口背景材质
    /// </summary>
    WindowBackgroundMaterial? WindowBackgroundMaterial { get; set; }

    /// <summary>
    /// 窗口背景材质的默认值
    /// </summary>
    static readonly WindowBackgroundMaterial? DefaultWindowBackgroundMaterial = OperatingSystem2.IsWindows11AtLeast() ? Enums.WindowBackgroundMaterial.Mica : Enums.WindowBackgroundMaterial.AcrylicBlur;

    /// <summary>
    /// 动态桌面背景
    /// </summary>
    bool? WindowBackgroundDynamic { get; set; }

    /// <summary>
    /// 动态桌面背景的默认值
    /// </summary>
    const bool? DefaultWindowBackgroundDynamic = false;

    /// <summary>
    /// 是否打开自定义背景图像
    /// </summary>
    bool? WindowBackgroundCustomImage { get; set; }

    /// <summary>
    /// 是否打开自定义背景图像的默认值
    /// </summary>
    const bool? DefaultWindowBackgroundCustomImage = false;

    /// <summary>
    /// 自定义背景图像路径
    /// </summary>
    string? WindowBackgroundCustomImagePath { get; set; }

    /// <summary>
    /// 自定义背景图像路径的默认值
    /// </summary>
    const string? DefaultWindowBackgroundCustomImagePath = "/UI/Assets/back.png";

    /// <summary>
    /// 自定义背景图像不透明度
    /// </summary>
    double? WindowBackgroundCustomImageOpacity { get; set; }

    /// <summary>
    /// 自定义背景图像不透明度的默认值
    /// </summary>
    const double? DefaultWindowBackgroundCustomImageOpacity = .8;

    /// <summary>
    /// 自定义背景图像缩放方式
    /// </summary>
    XamlMediaStretch? WindowBackgroundCustomImageStretch { get; set; }

    /// <summary>
    /// 自定义背景图像缩放方式的默认值
    /// </summary>
    const XamlMediaStretch? DefaultWindowBackgroundCustomImageStretch = XamlMediaStretch.UniformToFill;

    #endregion

}
