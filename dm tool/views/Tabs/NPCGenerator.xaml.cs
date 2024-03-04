using DmTool.view_models.Tabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DmTool.views;

public partial class NPCGenerator : UserControl
{
    public NPCGenerator(NPCGeneratorViewModel viewModel)
    {
        DataContext = viewModel;
        InitializeComponent();
    }
}
