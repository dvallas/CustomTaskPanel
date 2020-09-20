namespace CustomTaskPanel
{
    partial class ScriptToolsPane
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnDirection = new System.Windows.Forms.Button();
            this.btnDialog = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnDissolve = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.btnSlug = new System.Windows.Forms.Button();
            this.btnCutTo = new System.Windows.Forms.Button();
            this.btn2ndSlug = new System.Windows.Forms.Button();
            this.btnParaphrase = new System.Windows.Forms.Button();
            this.CharNames = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSceneSumm = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDirection
            // 
            this.btnDirection.Location = new System.Drawing.Point(84, 33);
            this.btnDirection.Name = "btnDirection";
            this.btnDirection.Size = new System.Drawing.Size(75, 23);
            this.btnDirection.TabIndex = 0;
            this.btnDirection.Text = "Direction";
            this.btnDirection.UseVisualStyleBackColor = true;
            this.btnDirection.UseWaitCursor = true;
            this.btnDirection.Click += new System.EventHandler(this.btnDirection_Click);
            // 
            // btnDialog
            // 
            this.btnDialog.Location = new System.Drawing.Point(3, 61);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(75, 23);
            this.btnDialog.TabIndex = 1;
            this.btnDialog.Text = "Dialog";
            this.btnDialog.UseVisualStyleBackColor = true;
            this.btnDialog.UseWaitCursor = true;
            this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(84, 4);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.UseWaitCursor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnDissolve
            // 
            this.btnDissolve.Location = new System.Drawing.Point(3, 90);
            this.btnDissolve.Name = "btnDissolve";
            this.btnDissolve.Size = new System.Drawing.Size(75, 23);
            this.btnDissolve.TabIndex = 3;
            this.btnDissolve.Text = "Dissolve To:";
            this.btnDissolve.UseVisualStyleBackColor = true;
            this.btnDissolve.UseWaitCursor = true;
            this.btnDissolve.Click += new System.EventHandler(this.btnDissolve_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(3, 119);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(75, 23);
            this.btnNotes.TabIndex = 4;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.UseWaitCursor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(3, 32);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 5;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.UseWaitCursor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnSlug
            // 
            this.btnSlug.Location = new System.Drawing.Point(3, 4);
            this.btnSlug.Name = "btnSlug";
            this.btnSlug.Size = new System.Drawing.Size(75, 23);
            this.btnSlug.TabIndex = 6;
            this.btnSlug.Text = "Slugline";
            this.btnSlug.UseVisualStyleBackColor = true;
            this.btnSlug.UseWaitCursor = true;
            this.btnSlug.Click += new System.EventHandler(this.btnSlug_Click);
            // 
            // btnCutTo
            // 
            this.btnCutTo.Location = new System.Drawing.Point(84, 61);
            this.btnCutTo.Name = "btnCutTo";
            this.btnCutTo.Size = new System.Drawing.Size(75, 23);
            this.btnCutTo.TabIndex = 7;
            this.btnCutTo.Text = "Cut To:";
            this.btnCutTo.UseVisualStyleBackColor = true;
            this.btnCutTo.UseWaitCursor = true;
            this.btnCutTo.Click += new System.EventHandler(this.btnCutTo_Click);
            // 
            // btn2ndSlug
            // 
            this.btn2ndSlug.Location = new System.Drawing.Point(84, 90);
            this.btn2ndSlug.Name = "btn2ndSlug";
            this.btn2ndSlug.Size = new System.Drawing.Size(75, 23);
            this.btn2ndSlug.TabIndex = 8;
            this.btn2ndSlug.Text = "2nd SLug";
            this.btn2ndSlug.UseVisualStyleBackColor = true;
            this.btn2ndSlug.UseWaitCursor = true;
            this.btn2ndSlug.Click += new System.EventHandler(this.btn2ndSlug_Click);
            // 
            // btnParaphrase
            // 
            this.btnParaphrase.Location = new System.Drawing.Point(84, 119);
            this.btnParaphrase.Name = "btnParaphrase";
            this.btnParaphrase.Size = new System.Drawing.Size(75, 23);
            this.btnParaphrase.TabIndex = 9;
            this.btnParaphrase.Text = "Paraphrase";
            this.btnParaphrase.UseVisualStyleBackColor = true;
            this.btnParaphrase.UseWaitCursor = true;
            this.btnParaphrase.Click += new System.EventHandler(this.btnParaphrase_Click);
            // 
            // CharNames
            // 
            this.CharNames.FormattingEnabled = true;
            this.CharNames.Location = new System.Drawing.Point(3, 196);
            this.CharNames.Name = "CharNames";
            this.CharNames.Size = new System.Drawing.Size(166, 21);
            this.CharNames.TabIndex = 10;
            this.CharNames.UseWaitCursor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 227);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnSceneSumm);
            this.panel1.Controls.Add(this.btnAction);
            this.panel1.Controls.Add(this.btnDirection);
            this.panel1.Controls.Add(this.btnDialog);
            this.panel1.Controls.Add(this.btnDissolve);
            this.panel1.Controls.Add(this.btnParaphrase);
            this.panel1.Controls.Add(this.btnNotes);
            this.panel1.Controls.Add(this.btn2ndSlug);
            this.panel1.Controls.Add(this.btnName);
            this.panel1.Controls.Add(this.btnCutTo);
            this.panel1.Controls.Add(this.btnSlug);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 180);
            this.panel1.TabIndex = 12;
            this.panel1.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Spare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            // 
            // btnSceneSumm
            // 
            this.btnSceneSumm.Location = new System.Drawing.Point(3, 148);
            this.btnSceneSumm.Name = "btnSceneSumm";
            this.btnSceneSumm.Size = new System.Drawing.Size(75, 23);
            this.btnSceneSumm.TabIndex = 10;
            this.btnSceneSumm.Text = "Scene";
            this.btnSceneSumm.UseVisualStyleBackColor = true;
            this.btnSceneSumm.UseWaitCursor = true;
            this.btnSceneSumm.Click += new System.EventHandler(this.btnSceneSumm_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 254);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(166, 269);
            this.treeView1.TabIndex = 13;
            this.treeView1.UseWaitCursor = true;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // ScriptToolsPane
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.CharNames);
            this.Location = new System.Drawing.Point(5, 0);
            this.Name = "ScriptToolsPane";
            this.Size = new System.Drawing.Size(172, 531);
            this.UseWaitCursor = true;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDirection;
        private System.Windows.Forms.Button btnDialog;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnDissolve;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnSlug;
        private System.Windows.Forms.Button btnCutTo;
        private System.Windows.Forms.Button btn2ndSlug;
        private System.Windows.Forms.Button btnParaphrase;
        private System.Windows.Forms.ComboBox CharNames;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSceneSumm;
    }
}
