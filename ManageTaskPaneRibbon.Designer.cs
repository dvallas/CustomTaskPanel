using CustomTaskPanel;
using Microsoft.Office.Tools.Ribbon;

namespace ToggleScriptToolsTaskPanelVisibility
{
    partial class ManageTaskPaneRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ManageTaskPaneRibbon()
            : base(CustomTaskPanel.Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.TaskPaneManager = this.Factory.CreateRibbonGroup();
            this.ScriptTools2 = this.Factory.CreateRibbonToggleButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tab1.SuspendLayout();
            this.TaskPaneManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.TaskPaneManager);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // TaskPaneManager
            // 
            this.TaskPaneManager.Items.Add(this.ScriptTools2);
            this.TaskPaneManager.Label = "ScriptTools2";
            this.TaskPaneManager.Name = "TaskPaneManager";
            // 
            // ScriptTools2
            // 
            this.ScriptTools2.Label = "ScriptTools2";
            this.ScriptTools2.Name = "ScriptTools2";
            this.ScriptTools2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ScriptTools2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ManageTaskPaneRibbon
            // 
            this.Name = "ManageTaskPaneRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.TaskPaneManager.ResumeLayout(false);
            this.TaskPaneManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup TaskPaneManager;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton ScriptTools2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }

}
