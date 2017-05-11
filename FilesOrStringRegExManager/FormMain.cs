using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FilesOrStringRegExManager
{
    public partial class FormRegEx : Form
    {
        public static int nowSelectCreatedTypeIs = 0;
        public static int isContentSubstringIncludeHead = 0;
        public static int isContentSubstringIncludeTail = 0;
        public static string SAVE_FILE_NAME = "outPutResult.txt";
        public static int SUBSTRING_HEAR_TAIL_INCLUDE = 0;

        public FormRegEx()
        {
            InitializeComponent();
            this.radioButtonString.Checked = true;//默认文本方式
        }


        private void richTextBoxStringOrFilesOrUrl_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //new一个方法

            //"(*.et;*.xls;*.xlsx)|*.et;*.xls;*.xlsx|all|*.*"---------------如果要多种选择
            ofd.Filter = "all|*.*";

            ofd.ShowDialog(); //显示打开文件的窗口
            this.richTextBoxStringOrFilesOrUrl.Text = ofd.FileName; //获得选择的文件路径
            
            this.radioButtonFiles.Checked = true;//本地文件模式已经开启
            
            #region//小动作,拿出第一行的内容演示一下

            try
            {
                string str = this.richTextBoxStringOrFilesOrUrl.Text;
                FileInfo files = new FileInfo(str);
                if (files.Exists == true)
                {
                    StreamReader sr = new StreamReader(this.richTextBoxStringOrFilesOrUrl.Text, Encoding.UTF8);
                    String line;
                    if ((line = sr.ReadLine()) != null)
                    {
                        this.labelSplitReplaceFirstLineContents.Text = line;
                    }

                    //只是拿出第一行的内容演示一下
                    sr.Close();
                }

            }
            catch { }

            #endregion //小动作
        }


        private void radioButtonString_CheckedChanged(object sender, EventArgs e)
        {
            nowSelectCreatedTypeIs = 0;
        }


        private void radioButtonFiles_CheckedChanged(object sender, EventArgs e)
        {
            nowSelectCreatedTypeIs = 1;//本地文件
        }


        private void radioButtonUrl_CheckedChanged(object sender, EventArgs e)
        {
            nowSelectCreatedTypeIs = 2;//远程Web文件
        }


        private void defineIncludeHeadOrTail()
        {
            switch (isContentSubstringIncludeHead + isContentSubstringIncludeTail)
            {
                case 0:
                    FormRegEx.SUBSTRING_HEAR_TAIL_INCLUDE = 22;//不包含头也不包含尾
                    break;
                case 1:
                    if (isContentSubstringIncludeHead == 1)
                    {
                        FormRegEx.SUBSTRING_HEAR_TAIL_INCLUDE = 10;//如果包含头
                    }
                    else
                    {
                        FormRegEx.SUBSTRING_HEAR_TAIL_INCLUDE = 1;//如果包含尾
                    }
                    break;
                case 2:
                    FormRegEx.SUBSTRING_HEAR_TAIL_INCLUDE = 11;//默认包含头也包含尾的
                    break;
                default:
                    FormRegEx.SUBSTRING_HEAR_TAIL_INCLUDE = 0;
                    break;
            }
        }


        private void buttonRegExAll_Create_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            defineIncludeHeadOrTail();//先确定是否包含头、尾。

            this.richTextBoxResults.Text = "";//先将结果输入框内容清空！

            //C# 支持String作为switch对象
            switch (btn.Name.ToString())
            {
                case "buttonRegexAsCreate":
                    buttonRegexAsCreateNowType(nowSelectCreatedTypeIs);//正则处理
                    break;
                case "buttonSplitReplaceCreating":
                    buttonSplitReplaceCreatingNowType(nowSelectCreatedTypeIs);//拼接处理
                    break;
                case "buttonContentSubstringCreate":
                    buttonContentSubstringCreateNowType(nowSelectCreatedTypeIs);//开始处理
                    break;
                default:
                    break;
            }

            MessageBox.Show("处理程序已经结束，请查看结果！如果内容较大，将转入后台继续运行，请不要重复点击【处理】按钮！", "温馨提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void checkBoxContentSubstringIncludeHead_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxContentSubstringIncludeHead.Checked == true)
            {
                isContentSubstringIncludeHead = 1;
            }
            else
                isContentSubstringIncludeHead = 0;
        }


        private void checkBoxContentSubstringIncludeTail_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxContentSubstringIncludeTail.Checked == true)
            {
                isContentSubstringIncludeTail = 1;
            }
            else
                isContentSubstringIncludeTail = 0;
        }


        private Boolean isUsefulHeadTailString(string left, string right)
        {
            if ((left == null || left.Equals("")) || (right == null || right.Equals("")))
            {
                return false;
            }
            else
                return true;
        }


        private void writeStringIntoFiles(string intoStr)
        {
            //生成文件或覆盖原文件
            FileStream fs = new FileStream(FormRegEx.SAVE_FILE_NAME, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            //开始写入
            sw.Write(intoStr);
            //清空缓冲区
            sw.Flush();

            //关闭流
            sw.Close();
            fs.Close();
        }
    }
}
