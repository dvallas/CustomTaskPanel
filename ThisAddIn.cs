namespace CustomTaskPanel
{
    public partial class ThisAddIn
    {
        private ToggleScriptToolsTaskPanelVisibility.ManageTaskPaneRibbon myControlPane;
        private ScriptToolsPane myUserControl;
        private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            myUserControl = new CustomTaskPanel.ScriptToolsPane();
            myCustomTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(myUserControl, "Script Tools");
            myCustomTaskPane.Visible = true;
            // System.Windows.Forms.MessageBox.Show("Here in Startup");
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }


        private void taskPaneValue_VisibleChanged(object sender, System.EventArgs e)
        {
            myControlPane.ScriptTools2.Checked =
                myCustomTaskPane.Visible;
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}



