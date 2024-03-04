
using System.ComponentModel;

namespace DmTool.WindowHandlers;

internal class TabHandler
{
    public TabStatus CurrentTab { get; private set; }
}

public enum TabStatus
{
    MainTab
}