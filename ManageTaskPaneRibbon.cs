using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using CustomTaskPanel;

namespace ToggleScriptToolsTaskPanelVisibility
{
    public partial class ManageTaskPaneRibbon
    {
        private ToggleScriptToolsTaskPanelVisibility.ManageTaskPaneRibbon myControlPane;
        private ScriptToolsPane myUserControl;
        private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("in ribbon1_Load");
        }

        private void ScriptTools2_Click(object sender, RibbonControlEventArgs e)
        {
            if (Globals.ThisAddIn.CustomTaskPanes.Count() < 1)
            {
                CustomTaskPanel.ScriptToolsPane myUserControl = new CustomTaskPanel.ScriptToolsPane();
                myCustomTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(myUserControl, "Script Tools");
                myCustomTaskPane.Visible = true;
                myUserControl.Visible = true;
                // Globals.ThisAddIn.CustomTaskPanes.Remove(myCustomTaskPane);
            }

        }
    }
}
