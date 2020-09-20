using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace CustomTaskPanel
{
    public partial class ScriptToolsPane : UserControl
    {
      public Microsoft.Office.Interop.Word.Document nativeDocument;
      public ScriptToolsPane()
        {
            InitializeComponent();
            //System.Windows.Forms.MessageBox.Show("in the control Initialize");
            //else { Globals.ThisAddIn.Application.Documents.Add(new Application.Document()); }
        }
        private void SetupDocument()
        {
            if (Globals.ThisAddIn.Application.Documents.Count > 0)
            {
                nativeDocument = Globals.ThisAddIn.Application.ActiveDocument;
                Populate();
                Microsoft.Office.Tools.Word.Document vstoDoc = (Microsoft.Office.Tools.Word.Document)Globals.Factory.GetVstoObject(nativeDocument);
                vstoDoc.SelectionChange += new Microsoft.Office.Tools.Word.SelectionEventHandler(ThisDocument_SelectionChange);
            }

        }

        void ThisDocument_SelectionChange(object sender, Microsoft.Office.Tools.Word.SelectionEventArgs e)
        {
            var s = Globals.ThisAddIn.Application.Selection.Range.Paragraphs[1].Range.get_Style().NameLocal;
            if (s != null)
            System.Windows.Forms.MessageBox.Show(nativeDocument.Name + " was clicked.  Style: " + s);
        }


        //void ThisDocument_OnClick(object sender, Microsoft.Office.Tools.Word.ClickEventArgs e)
        //{
        //    var s = nativeDocument.Paragraphs[1].Range.get_Style();
        //    System.Windows.Forms.MessageBox.Show(nativeDocument.Name + " was clicked.  Style: " + s.NameLocal);
        //}
        private void Populate()
        {
            this.CharNames.Items.Add("Fred");
            this.CharNames.Items.Add("Ethel");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnDirection_Click(object sender, EventArgs e)
        {
            SetupDocument(); 
            var p = nativeDocument.Paragraphs.Add();
            p.Reset();
            p.Range.Text = "()";
            p.Range.Select();
            p.set_Style(nativeDocument.Styles["sDirection"]);
            p.Range.Select();
            Globals.ThisAddIn.Application.Selection.MoveRight(WdUnits.wdCharacter,1);
            Globals.ThisAddIn.Application.Selection.MoveLeft(WdUnits.wdCharacter, 1);
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            SetupDocument();
            SetupDocument(); 
            var p = nativeDocument.Paragraphs.Add();
            p.Reset();
            p.set_Style(nativeDocument.Styles["sCharacter Name"]);
        }

        private void btnSlug_Click(object sender, EventArgs e)
        {
            SetupDocument();
            var p = nativeDocument.Paragraphs.Add();
            p.Reset();
            p.set_Style(nativeDocument.Styles["sSlugline"]);
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            SetupDocument();
            var p = nativeDocument.Paragraphs.Add();
            p.Reset();
            p.set_Style(nativeDocument.Styles["sDialog"]);
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            SetupDocument();
            var p = nativeDocument.Paragraphs.Add();
            p.Reset();
            p.set_Style(nativeDocument.Styles["sAction"]);
        }

        private void btnCutTo_Click(object sender, EventArgs e)
        {
            SetupDocument();
            var p = nativeDocument.Paragraphs.Add();
            //var s = p.Range.get_Style();
            //MessageBox.Show("After Reset: " + s.NameLocal);
            p.Range.Text = "CUT TO:";
            p.Range.set_Style(nativeDocument.Styles["sCutTo:"]);
            p.Range.InsertParagraphAfter();
            p.Range.Next();
            p.Range.Select();
            Globals.ThisAddIn.Application.Selection.MoveDown(WdUnits.wdLine, 1);
        }
        private void btnDissolve_Click(object sender, EventArgs e)
        {
            SetupDocument();
            var p = nativeDocument.Paragraphs.Add();
            p.Range.Text = "DISSOLVE TO:";
            p.Range.set_Style(nativeDocument.Styles["sDissolveTo:"]);
            p.Range.InsertParagraphAfter();
            p.Range.Next();
            p.Range.Select();
            p.Range.set_Style(nativeDocument.Styles["sSlugline"]);
            Globals.ThisAddIn.Application.Selection.MoveDown(WdUnits.wdLine, 1);
        }

        private void btn2ndSlug_Click(object sender, EventArgs e)
        {
            SetupDocument();
            var p = nativeDocument.Paragraphs.Add();
            p.Reset();
            p.set_Style(nativeDocument.Styles["sSecondarySlug"]);
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            SetupDocument();
            var p = nativeDocument.Paragraphs.Add();
            p.Reset();
            p.set_Style(nativeDocument.Styles["sNotes"]);
        }

        private void btnParaphrase_Click(object sender, EventArgs e)
        {
            SetupDocument();
            var p = nativeDocument.Paragraphs.Add();
            p.Reset();
            p.set_Style(nativeDocument.Styles["sSceneParaphrase"]);
        }

        private void btnSceneSumm_Click(object sender, EventArgs e)
        {
            SetupDocument();
            var p = nativeDocument.Paragraphs.Add();
            p.Reset();
            p.set_Style(nativeDocument.Styles["Summary"]);
        }

    }
}
