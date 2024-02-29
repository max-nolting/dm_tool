
using System.ComponentModel;

namespace dm_tool.WindowHandlers;

internal class TabHandler
{
    public TabStatus CurrentTab { get; private set; }
}

public enum TabStatus
{
    MainTab
}