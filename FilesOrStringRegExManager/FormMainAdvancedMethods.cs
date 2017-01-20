using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using System.Collections;

namespace FilesOrStringRegExManager
{
    public partial class FormRegEx
    {

        #region     //正则表达式处理

        private void buttonRegexAsCreateNowType(int type)
        {
            switch (type)
            {
                case 0:
                    this.richTextBoxResults.Text = buttonRegexAsCreateString(this.richTextBoxStringOrFilesOrUrl.Text);
                    break;
                case 1:
                    buttonRegexAsCreateFiles();
                    break;
                case 2:
                    buttonRegexAsCreateUrl();
                    break;
                default:
                    break;
            }

        }


        private void buttonRegexAsCreateUrl()
        {
            /*第一步：从Web获取一个Stream*/
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.richTextBoxStringOrFilesOrUrl.Text);
                request.Method = "GET";
                request.ContentType = "text/html;charset=UTF-8";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));

                /*第二步：将页面内容存储到ArrayList*/
                string sLine = "";
                ArrayList LineList = new ArrayList();
                while (sLine != null)
                {
                    sLine = myStreamReader.ReadLine();
                    if (sLine != null && !sLine.Equals(""))
                        LineList.Add(sLine);
                }
                myStreamReader.Close();
                myResponseStream.Close();

                /*第三步：分行处理ArrayList，并得到处理后的string，即fileStr*/
                ArrayList RegexList = new ArrayList();
                for (int i = 0; i < LineList.Count; i++)
                {
                    string line = LineList[i].ToString();
                    if (line != null && !line.Equals(""))
                    {
                        RegexList.Add(buttonRegexAsCreateString(line));
                    }
                }
                //正常流程：
                string fileStr = string.Join("\n", (string[])RegexList.ToArray(typeof(string)));

                /*保存结果到文件*/
                writeStringIntoFiles(fileStr);

            }
            catch (Exception ex)
            {
                this.richTextBoxResults.Text = "抱歉，执行过程出错了：" + ex.Message;//如果报错，就中断
            }

        }


        private string buttonRegexAsCreateString(string sLine)
        {
            Regex reg = new Regex(this.textBoxRegexAsFinder.Text);
            string modified = "";
            MatchCollection match = reg.Matches(sLine);

            if (this.textBoxRegexAsFinder.Text != "")
            {
                if (match.Count > 0)
                {
                    char[] splitChar = this.comboBoxRegexAsReplaceSplit.Text.ToCharArray(0, 1);
                    string[] regs = { "" };

                    if (splitChar[0] != '\0')
                    {
                        regs = this.textBoxRegexAsReplace.Text.Split(splitChar[0]);
                    }
                    else
                    {
                        regs = this.textBoxRegexAsReplace.Text.Split('/');
                    }

                    for (int i = 0; i < regs.Length; i++)
                    {
                        reg = new Regex(regs[i]);
                        match = reg.Matches(sLine);

                        //在输入字符串中找到所有匹配  
                        for (int j = 0; j < match.Count; j++)
                        {
                            //同行中匹配加换行符输出
                            modified += match[i].Value + "\n";
                        }   

                    }
                }
            }///!~if(this.textBoxRegexAsFinder.Text != null) end
            else
            {   /* 假设不必须考虑是否行特征是否符合，只负责过滤并保留有效字段 */
                char[] splitChar = this.comboBoxRegexAsReplaceSplit.Text.ToCharArray(0, 1);
                string[] regs = { "" };

                if (splitChar[0] != '\0')
                {
                    regs = this.textBoxRegexAsReplace.Text.Split(splitChar[0]);
                }
                else
                {
                    regs = this.textBoxRegexAsReplace.Text.Split('/');
                }

                for (int i = 0; i < regs.Length; i++)
                {
                    reg = new Regex(regs[i]);
                    match = reg.Matches(sLine);

                    //在输入字符串中找到所有匹配  
                    for (int j = 0; j < match.Count; j++)
                    {
                        //同行中匹配加换行符输出
                        modified += match[j].Value + "\n";
                    } 
                }
            }///!~else end;

            return modified;

        }


        private void buttonRegexAsCreateFiles()
        {
            try
            {
                StreamReader objReader = new StreamReader(this.richTextBoxStringOrFilesOrUrl.Text, Encoding.UTF8);

                //生成文件或覆盖原文件
                FileStream fs = new FileStream(FormRegEx.SAVE_FILE_NAME, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                string sLine = "";

                while ((sLine = objReader.ReadLine()) != null)
                {
                    string modified = "";
                    modified = buttonRegexAsCreateString(sLine);

                    //开始写入
                    sw.WriteLine(modified);
                    //清空缓冲区
                    sw.Flush();
                }
                
                //打个标签，写上时间日期
                sw.WriteLine("----" + "正则过滤" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "----\n");
                
                //及时释放资源，这个很重要。
                objReader.Close();

                //关闭流
                sw.Close();
                fs.Close();

            }
            catch
            {
                this.richTextBoxResults.Text = "使用帮助：(本提示只会在操作出错的情形下出现)\n"
                        + "1.在最上方输入框中输入你想处理的行规则；\n"
                        + "2.在下一个方框中输入你想保留内容的规则，多条规则要用特定的分隔符号分开；\n"
                        + "3.分隔符号请在小方框中输入；\n"
                        + "4.只允许输入一个字符，默认字符为“/”";
            }

        }

        #endregion      //End 正则表达式处理


        #region     //截取字符串

        private void buttonContentSubstringCreateNowType(int type)
        {
            switch (type)
            {
                case 0:
                    this.richTextBoxResults.Text = buttonContentSubstringCreateString(this.richTextBoxStringOrFilesOrUrl.Text,
                            this.textBoxContentSubstringHead.Text, this.textBoxContentSubstringTail.Text);
                    break;
                case 1:
                    buttonContentSubstringCreateFiles();
                    break;
                case 2:
                    buttonContentSubstringCreateUrl();
                    break;
                default:
                    break;
            }

        }


        private void buttonContentSubstringCreateUrl()
        {
            try
            {
                /*第一步：从Web获取一个Stream*/
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.richTextBoxStringOrFilesOrUrl.Text);
                request.Method = "GET";
                request.ContentType = "text/html;charset=UTF-8";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));

                /*第二步：将页面内容存储到ArrayList*/
                string sLine = "";
                ArrayList LineList = new ArrayList();
                while (sLine != null)
                {
                    sLine = myStreamReader.ReadLine();
                    if (sLine != null && !sLine.Equals(""))
                        LineList.Add(sLine);
                }
                myStreamReader.Close();
                myResponseStream.Close();

                /*第三步：分行处理ArrayList，并得到处理后的string，即fileStr*/
                ArrayList RegexList = new ArrayList();
                for (int i = 0; i < LineList.Count; i++)
                {
                    string line = LineList[i].ToString();
                    if (line != null && !line.Equals(""))
                    {
                        RegexList.Add(buttonContentSubstringCreateString(line,
                                this.textBoxContentSubstringHead.Text, this.textBoxContentSubstringTail.Text));
                    }
                }
                //正常流程：
                string fileStr = string.Join("\n", (string[])RegexList.ToArray(typeof(string)));

                /*保存结果到文件*/
                writeStringIntoFiles(fileStr);

            }
            catch (Exception ex)
            {
                this.richTextBoxResults.Text = ex.Message;
            }

        }


        private void buttonContentSubstringCreateFiles()
        {
            try
            {
                StreamReader objReader = new StreamReader(this.richTextBoxStringOrFilesOrUrl.Text, Encoding.UTF8);

                //生成文件或覆盖原文件
                FileStream fs = new FileStream(FormRegEx.SAVE_FILE_NAME, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                string sLine = "";

                while ((sLine = objReader.ReadLine()) != null)
                {
                    string modified = "";

                    modified = buttonContentSubstringCreateString(sLine,
                            this.textBoxContentSubstringHead.Text, this.textBoxContentSubstringTail.Text);

                    //开始写入
                    sw.WriteLine(modified);
                    //清空缓冲区
                    sw.Flush();
                }

                //打个标签，写上时间日期
                sw.WriteLine("----" + "正则过滤" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "----\n");

                //sw.Flush();//清空缓冲区/*没有必要清空缓存了，Close动作已经包含！*/
                //及时释放资源，这个很重要。
                objReader.Close();

                //关闭流
                sw.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                this.richTextBoxResults.Text = "抱歉，执行过程出错了：" + ex.Message;
            }
        }


        /*
         * stringFindingForEach
         * 字符串内截取关键字段，截取方式认为每条文本中只出现一次。
         * */
        public static string buttonContentSubstringCreateString(string strIn, string left, string right)
        {
            int start, ends = 0;
            string outStr = "";
            start = strIn.IndexOf(left, 0);
            
            string usefullIn = "";
            if (strIn.Length > 0 && start > 0)
            {
                usefullIn = strIn.Substring(start + left.Length, strIn.Length - start - left.Length);
                ends = usefullIn.IndexOf(right, 0);
                ends = ends + start + left.Length;//为了防止前段有与right相同的内容，将start节点前的全部排除再处理
            }

            //判断值是否有效
            if (ends <= start || (ends < 0 || start < 0))
            {
                return "";
            }
            //判断结束

            switch (FormRegEx.SUBSTRING_HEAR_TAIL_INCLUDE)
            {
                case 1:
                    outStr = strIn.Substring(start + left.Length, ends - start + left.Length);
                    break;
                case 10:
                    outStr = strIn.Substring(start, ends - start);
                    break;
                case 11:
                    outStr = strIn.Substring(start, ends - start + right.Length);
                    break;
                case 22:
                    outStr = strIn.Substring(start + left.Length, ends - start - left.Length);
                    break;
                default:
                    break;//默认为零
            }

            return outStr;
        }

        #endregion      //End 截取字符串


        #region //字符串拼接

        private void buttonSplitReplaceCreatingNowType(int type)
        {
            switch (type)
            {
                case 0:
                    buttonSplitReplaceCreatingString();
                    break;
                case 1:
                    buttonSplitReplaceCreatingFiles();
                    break;
                case 2:
                    this.richTextBoxResults.Text = "没有定义该方法！因为web网页的内容可能不齐整，"
                    + "无法批量处理，建议您先保存成本地文档再尝试，谢谢！";
                    break;
                default:
                    break;
            }

        }

        private void buttonSplitReplaceCreatingFiles()
        {
            string crStr = this.richTextBoxStringOrFilesOrUrl.Text;
            string[] myReg = this.textBoxSplitReplaceMyStyle.Text.Split('$');

            if (myReg.Length < 2 || this.textBoxSplitReplaceMyStyle.Text == "")
            {
                return;//不符合逻辑，设置规则语句中不存在要引用文本的本身。
            }

            try
            {
                FileStream fs = new FileStream(FormRegEx.SAVE_FILE_NAME, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                FileInfo files = new FileInfo(crStr);
                if (files.Exists == true)//&& crStr.EndsWith(".txt")
                {
                    StreamReader sr = new StreamReader(crStr, Encoding.UTF8);
                    String line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string outPut = "";
                        for (int i = 0; i < myReg.Length; i++)
                        {
                            string[] reSp = myReg[i].Split('~');

                            if (reSp.Length == 2)
                            {
                                if (reSp[1] != "0")
                                    outPut += line.Substring(Int32.Parse(reSp[0]), Int32.Parse(reSp[1]));
                                else
                                    outPut += line.Substring(Int32.Parse(reSp[0]));
                                //理论上$0~0会插入开头，而$n~0会在行尾追加。
                            }
                            else
                                outPut += myReg[i];
                        }

                        //开始写入
                        sw.WriteLine(outPut);
                        //清空缓冲区
                        sw.Flush();
                    }
                    sr.Close();
                }

                //关闭流
                sw.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                this.richTextBoxResults.Text = "抱歉，执行过程出错了：" + ex.Message;
            }
        }


        //本地文本
        private void buttonSplitReplaceCreatingString()
        {
            /*
             * 示例原文本：
             * 本地文本处理
             * 示例格式：
             * XXX$0~2$YYYYY$2~2$ZZZZZ$4~0$;
             * 示例结果：
             * XXX本地YYYYY文本ZZZZZ处理
             * 本方法适用于将齐整格式的文本按固定"语法"批量生成指定格式的文本。
             * 如SQL语句、XML语句、套路式语句等。
             * */
            string line = this.richTextBoxStringOrFilesOrUrl.Text;
            string[] myReg = this.textBoxSplitReplaceMyStyle.Text.Split('$');
            
            if (myReg.Length < 2 || this.textBoxSplitReplaceMyStyle.Text == "")
            {
                return;//前插或尾加的方法用列模式即可以处理。
            }

            try
            {
                string outPut = "";
                for (int i = 0; i < myReg.Length; i++)
                {
                    string[] reSp = myReg[i].Split('~');

                    if (reSp.Length == 2)
                    {
                        if (reSp[1] != "0")
                            outPut += line.Substring(Int32.Parse(reSp[0]), Int32.Parse(reSp[1]));
                        else
                            outPut += line.Substring(Int32.Parse(reSp[0]));
                        //理论上$0~0会插入开头，而$n~0会在行尾追加(n值为行最字符串总长度)。
                    }
                    else
                        outPut += myReg[i];

                }

                this.richTextBoxResults.Text = outPut;//改写结果框的显示内容。

            }
            catch (Exception ex)
            {
                this.richTextBoxResults.Text = "抱歉，执行过程出错了：" + ex.Message;
            }
        }

        #endregion      //End 字符串拼接


    }
}
