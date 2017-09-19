using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AutoMainTreeMaker.Database;

namespace AutoMainTreeMaker.SourceMaker
{
    public partial class Dialog_MappingData : Form
    {
        bool isInit;
        
        List<CRichTextbox> richs;
        CRichTextBoxInterface richInterface;
        Dialog_SourceInfo dlgSourceInfo;
        Dialog_Database dlgDatabase;
        Tree tree;

        public Dialog_MappingData(Dialog_Database dlg )
        {
            isInit = false;
            InitializeComponent();

            richs = new List<CRichTextbox>();
            richs.Add(richShortcutName);
            richs.Add(richRecordsetName);
            richs.Add(richSubCode);
            richs.Add(richStructName);

            richInterface = new AutoMainTreeMaker.CRichTextBoxInterface();
            richInterface.SetInterface(richs);

            dlgDatabase = dlg;
            dlgSourceInfo = new Dialog_SourceInfo(this);
        }

        public void Init(List<string> listRsName, Tree tree)
        {
            this.tree = tree;
            isInit = true;
            foreach (string s in listRsName)
            {
                richRecordsetName.AppendText(s+"\n");
            }

            richInterface.EqualLinesToMaximumLine();
        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm_MappingData dlg = new HelpForm_MappingData();
            dlg.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!IsInvalidateData())
            {
                return;
            }

            var datas = new AutoMainTreeMaker.SourceMaker.MappingData();
            datas.className = textClassName.Text;
            datas.fileName = textFileName.Text;
            datas.logCode = textLogCode.Text;

            List<MappingData.MappedRecordset> maprs = new List<MappingData.MappedRecordset>();
            for(int i=0; i < richRecordsetName.Lines.Length; i++)
            {
                MappingData.MappedRecordset rs = new MappingData.MappedRecordset();
                rs.rsName = richRecordsetName.Lines[i];
                rs.shortcutName = richShortcutName.Lines[i];
                rs.subcode = richSubCode.Lines[i];
                maprs.Add(rs);
            }
            datas.mappedRs = maprs;

            this.Hide();

            dlgSourceInfo.Init(datas,tree);
            dlgSourceInfo.ShowDialog();
        }

        private bool IsInvalidateData()
        {
            textFileName.Text.TrimEnd();
            if (textFileName.TextLength == 0)
                return false;
            textClassName.Text.TrimEnd();
            if (textClassName.TextLength == 0)
                return false;
            textLogCode.Text.TrimEnd();
            if (textLogCode.TextLength == 0)
                return false;

            foreach(CRichTextbox rich in richs)
            {
                if (rich.Equals(richRecordsetName))
                    continue;
                if(rich.Lines.Length != richRecordsetName.Lines.Length)
                {
                    MessageBox.Show("레코드셋에 맞춰 모두 기입해주세요");
                    return false;
                }
            }

            return true;
        }
    }

    public struct MappingData
    {
        public struct MappedRecordset
        {
            public string rsName;
            public string subcode;
            public string shortcutName;
            public string structName;
        }
        public string className;
        public string fileName;
        public string logCode;
        public List<MappedRecordset> mappedRs;
    }
}
