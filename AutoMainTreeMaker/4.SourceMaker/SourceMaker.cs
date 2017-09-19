using System;
using AutoMainTreeMaker.MainTree;
using System.Text;

namespace AutoMainTreeMaker.SourceMaker
{
    public class SourceMaker
    {

        Tree mainTree;
        public string filaCause;

        private class TreePart
        {
            
        }

        private Tree tree;
        private StringBuilder headerBld;
        private StringBuilder sourceBld;

        private string classname;
        private string logcodename;
        private string filename;
        private string[] types;
        private string[] subcodes;
        private string[] enunnames;

        public SourceMaker(Tree tree)
        {
            mainTree = tree;
            headerBld = new StringBuilder();
            sourceBld = new StringBuilder();
        }

        public bool MakeSource()
        {
            bool res =  MakeHeadFile() && MakeCppFile();
            if (res)
            {
                SaveFiles();
                return true;
            }
            else
                return res;
        }

        private void PushString(string str, StringBuilder bld)
        {
            bld.Append(str);
        }

        private void SaveFiles()
        {

        }

        private bool MakeHeadFile()
        {
            headerBld.Append("#if _MSC_VER > 100\n");
            headerBld.Append("#pragma once\n");
            headerBld.Append("#endif // _MSC_VER > 1000\n");
            headerBld.Append("# include \"WorkParameter.h\"\n");
            headerBld.Append(@"# include ""..\DRCommCls\RecordSet.h""\n");
            headerBld.Append("# include \"Preprocessing/Predefined_LTE.h\"\n");
            headerBld.Append("# include \"../DRAnalyzer/DRConstant#\" //DRConstant는 별도로 정의. \n");
            if(tree.IsExistingVirtualNode)
                headerBld.Append("# include \"../ DRCommCls / VTreeEnum.h\"\n");

            //가상트리 배열들...

            //class 선언부
            headerBld.Append("class ").Append(classname).Append(" : ").Append("public CWorkParameter \n");
            headerBld.Append("{\n");
            headerBld.Append("\tpublic\n\n");
            headerBld.Append("\t").Append(classname).Append("();\n");
            headerBld.Append("\tvirtual ~").Append(classname).Append("();\n");
            headerBld.Append("\tvoid SaveResultSet();\n");
            headerBld.Append("\tvoid SetPacket(SPREHead *pHead, LPARAM lParam);\n\n");
            headerBld.Append("\tprotected:\n\n");
            headerBld.Append("\ttypedef enum eType{\n");
            foreach(string s in types)
            {
                headerBld.Append("\t\t").Append(s).Append("\n");
            }
            headerBld.Append("\t\t};\n");

            //가상파라메터 위한 구조체
            headerBld.Append(";\n\n");


            //common
            headerBld.Append("\ttypedef struct COMMON{\n");
            headerBld.Append("\t\tCRecordSet rs;\n");
            headerBld.Append("\t\tlong cnt;\n");
            headerBld.Append("\t\tbool bCreated;\n");
            headerBld.Append("\t\tUINT nCode;\n");
            headerBld.Append("\t\teType type;\n");
            if(tree.IsExistingVirtualNode)
                headerBld.Append("\t\tlong idx;\n");
            headerBld.Append("\t\tCOMMON();\n");
            headerBld.Append("\t\t:cnt(0), bCreated(false),nCode(0)");
            if(tree.IsExistingVirtualNode)
                headerBld.Append(",idx(0)");
            headerBld.Append("\n");
            headerBld.Append("\t\t{}\n\t};");

            headerBld.Append("");
            headerBld.Append("");
            headerBld.Append("");
            headerBld.Append("");
            headerBld.Append("");




            return true;

        }

        private bool MakeCppFile()
        {


            return true;
        }

    }
}
