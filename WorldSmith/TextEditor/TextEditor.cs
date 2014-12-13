﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigitalRune.Windows.TextEditor;
using DigitalRune.Windows.TextEditor.Actions;
using DigitalRune.Windows.TextEditor.Completion;
using DigitalRune.Windows.TextEditor.Document;
using DigitalRune.Windows.TextEditor.Formatting;
using DigitalRune.Windows.TextEditor.Highlighting;
using DigitalRune.Windows.TextEditor.Insight;
using DigitalRune.Windows.TextEditor.Markers;
using DigitalRune.Windows.TextEditor.Selection;
using DigitalRune.Windows.Docking;
using System.IO;
using WorldSmith.DataClasses;

namespace WorldSmith
{
    public partial class TextEditor : DockableForm
    {
        public enum TextEditorStyle
        {
            KeyValues,
            Lua,
        }

        public TextEditorStyle EditorStyle;


        private bool isReadOnly;
        /// <summary>
        /// Is this document read only?  Set true for VPK files
        /// </summary>
        public bool IsReadOnly
        {
            get { return isReadOnly; }
            set
            {
                isReadOnly = value;
                ReadOnlyChanged(value);
            }
        }

        public string Filename;
        

        public TextEditor()
        {
            InitializeComponent();
            Filename = String.Empty;
        }

        public void OpenFile(string path, bool fromVPK)
        {
           if(fromVPK)
           {
               //Stuff for loading from vpk
               string text = DotaData.ReadAllText(path);
               Filename = Path.GetFileName(path);
               IsReadOnly = true;

               textEditorControl1.Document.TextContent = text;

           }
           else
           {
               Filename = Path.GetFileName(path);
               IsReadOnly = false;
               

               textEditorControl1.Document.TextContent = File.ReadAllText(path);
           }

        }

        protected void ReadOnlyChanged(bool value)
        {
            if (value)
            {
                saveButton.Enabled = false;
                textEditorControl1.IsReadOnly = false;
            }
            else
            {
                saveButton.Enabled = true;
                textEditorControl1.IsReadOnly = true;
            }
        }


        private void cutButton_Click(object sender, EventArgs e)
        {
            Cut cut = new Cut();
            cut.Execute(textEditorControl1);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Copy copy = new Copy();
            copy.Execute(textEditorControl1);
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            Paste paste = new Paste();
            paste.Execute(textEditorControl1);
        }
    }
}
