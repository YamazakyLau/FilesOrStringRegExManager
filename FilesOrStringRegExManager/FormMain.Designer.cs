namespace FilesOrStringRegExManager
{
    partial class FormRegEx
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRegexAsReplaceSplit = new System.Windows.Forms.Label();
            this.buttonRegexAsCreate = new System.Windows.Forms.Button();
            this.textBoxRegexAsReplace = new System.Windows.Forms.TextBox();
            this.labelRegexAsFinder = new System.Windows.Forms.Label();
            this.textBoxRegexAsFinder = new System.Windows.Forms.TextBox();
            this.labelRegexAsReplace = new System.Windows.Forms.Label();
            this.groupBoxSplitReplace = new System.Windows.Forms.GroupBox();
            this.labelSplitReplaceMyStyle = new System.Windows.Forms.Label();
            this.buttonSplitReplaceCreating = new System.Windows.Forms.Button();
            this.labelSplitReplaceFirstLineContents = new System.Windows.Forms.Label();
            this.labelSplitReplaceFirstLine = new System.Windows.Forms.Label();
            this.textBoxSplitReplaceMyStyle = new System.Windows.Forms.TextBox();
            this.labelStringOrFilesOrUrl = new System.Windows.Forms.Label();
            this.richTextBoxStringOrFilesOrUrl = new System.Windows.Forms.RichTextBox();
            this.radioButtonString = new System.Windows.Forms.RadioButton();
            this.radioButtonFiles = new System.Windows.Forms.RadioButton();
            this.radioButtonUrl = new System.Windows.Forms.RadioButton();
            this.comboBoxRegexAsReplaceSplit = new System.Windows.Forms.ComboBox();
            this.groupBoxRegexAs = new System.Windows.Forms.GroupBox();
            this.groupBoxContentSubstring = new System.Windows.Forms.GroupBox();
            this.labelContentSubstringHead = new System.Windows.Forms.Label();
            this.buttonContentSubstringCreate = new System.Windows.Forms.Button();
            this.labelContentSubstringTail = new System.Windows.Forms.Label();
            this.checkBoxContentSubstringIncludeHead = new System.Windows.Forms.CheckBox();
            this.labelContentSubstringHeadTailInclude = new System.Windows.Forms.Label();
            this.textBoxContentSubstringHead = new System.Windows.Forms.TextBox();
            this.textBoxContentSubstringTail = new System.Windows.Forms.TextBox();
            this.checkBoxContentSubstringIncludeTail = new System.Windows.Forms.CheckBox();
            this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.labelConcatenation = new System.Windows.Forms.Label();
            this.textBoxConcatenation = new System.Windows.Forms.TextBox();
            this.groupBoxSplitReplace.SuspendLayout();
            this.groupBoxRegexAs.SuspendLayout();
            this.groupBoxContentSubstring.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRegexAsReplaceSplit
            // 
            this.labelRegexAsReplaceSplit.AutoSize = true;
            this.labelRegexAsReplaceSplit.Location = new System.Drawing.Point(486, 19);
            this.labelRegexAsReplaceSplit.Name = "labelRegexAsReplaceSplit";
            this.labelRegexAsReplaceSplit.Size = new System.Drawing.Size(77, 14);
            this.labelRegexAsReplaceSplit.TabIndex = 0;
            this.labelRegexAsReplaceSplit.Text = "分隔符号：";
            this.labelRegexAsReplaceSplit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonRegexAsCreate
            // 
            this.buttonRegexAsCreate.Location = new System.Drawing.Point(694, 35);
            this.buttonRegexAsCreate.Name = "buttonRegexAsCreate";
            this.buttonRegexAsCreate.Size = new System.Drawing.Size(79, 23);
            this.buttonRegexAsCreate.TabIndex = 0;
            this.buttonRegexAsCreate.Text = "正则处理";
            this.buttonRegexAsCreate.UseVisualStyleBackColor = true;
            this.buttonRegexAsCreate.Click += new System.EventHandler(this.buttonRegExAll_Create_Click);
            // 
            // textBoxRegexAsReplace
            // 
            this.textBoxRegexAsReplace.Location = new System.Drawing.Point(228, 36);
            this.textBoxRegexAsReplace.MaxLength = 2000;
            this.textBoxRegexAsReplace.Name = "textBoxRegexAsReplace";
            this.textBoxRegexAsReplace.Size = new System.Drawing.Size(249, 23);
            this.textBoxRegexAsReplace.TabIndex = 2;
            // 
            // labelRegexAsFinder
            // 
            this.labelRegexAsFinder.AutoSize = true;
            this.labelRegexAsFinder.Location = new System.Drawing.Point(6, 19);
            this.labelRegexAsFinder.Name = "labelRegexAsFinder";
            this.labelRegexAsFinder.Size = new System.Drawing.Size(175, 14);
            this.labelRegexAsFinder.TabIndex = 0;
            this.labelRegexAsFinder.Text = "查找正则表达式（可不填）";
            // 
            // textBoxRegexAsFinder
            // 
            this.textBoxRegexAsFinder.Location = new System.Drawing.Point(8, 36);
            this.textBoxRegexAsFinder.MaxLength = 3000;
            this.textBoxRegexAsFinder.Name = "textBoxRegexAsFinder";
            this.textBoxRegexAsFinder.Size = new System.Drawing.Size(208, 23);
            this.textBoxRegexAsFinder.TabIndex = 1;
            // 
            // labelRegexAsReplace
            // 
            this.labelRegexAsReplace.AutoSize = true;
            this.labelRegexAsReplace.Location = new System.Drawing.Point(225, 19);
            this.labelRegexAsReplace.Name = "labelRegexAsReplace";
            this.labelRegexAsReplace.Size = new System.Drawing.Size(245, 14);
            this.labelRegexAsReplace.TabIndex = 0;
            this.labelRegexAsReplace.Text = "保留正则表达式：（多个用符号分隔）";
            // 
            // groupBoxSplitReplace
            // 
            this.groupBoxSplitReplace.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSplitReplace.Controls.Add(this.labelSplitReplaceMyStyle);
            this.groupBoxSplitReplace.Controls.Add(this.buttonSplitReplaceCreating);
            this.groupBoxSplitReplace.Controls.Add(this.labelSplitReplaceFirstLineContents);
            this.groupBoxSplitReplace.Controls.Add(this.labelSplitReplaceFirstLine);
            this.groupBoxSplitReplace.Controls.Add(this.textBoxSplitReplaceMyStyle);
            this.groupBoxSplitReplace.Location = new System.Drawing.Point(16, 274);
            this.groupBoxSplitReplace.Name = "groupBoxSplitReplace";
            this.groupBoxSplitReplace.Size = new System.Drawing.Size(783, 105);
            this.groupBoxSplitReplace.TabIndex = 0;
            this.groupBoxSplitReplace.TabStop = false;
            this.groupBoxSplitReplace.Text = "字符串拼接（Split + Substring）";
            // 
            // labelSplitReplaceMyStyle
            // 
            this.labelSplitReplaceMyStyle.AutoSize = true;
            this.labelSplitReplaceMyStyle.Location = new System.Drawing.Point(19, 45);
            this.labelSplitReplaceMyStyle.Name = "labelSplitReplaceMyStyle";
            this.labelSplitReplaceMyStyle.Size = new System.Drawing.Size(406, 14);
            this.labelSplitReplaceMyStyle.TabIndex = 0;
            this.labelSplitReplaceMyStyle.Text = "请输入表达式：（示例：XXX$0~2$YYYZZ$4~0$，XYZ均为新内容）";
            // 
            // buttonSplitReplaceCreating
            // 
            this.buttonSplitReplaceCreating.Location = new System.Drawing.Point(695, 69);
            this.buttonSplitReplaceCreating.Name = "buttonSplitReplaceCreating";
            this.buttonSplitReplaceCreating.Size = new System.Drawing.Size(79, 23);
            this.buttonSplitReplaceCreating.TabIndex = 0;
            this.buttonSplitReplaceCreating.Text = "拼接处理";
            this.buttonSplitReplaceCreating.UseVisualStyleBackColor = true;
            this.buttonSplitReplaceCreating.Click += new System.EventHandler(this.buttonRegExAll_Create_Click);
            // 
            // labelSplitReplaceFirstLineContents
            // 
            this.labelSplitReplaceFirstLineContents.AutoSize = true;
            this.labelSplitReplaceFirstLineContents.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSplitReplaceFirstLineContents.ForeColor = System.Drawing.Color.DarkGray;
            this.labelSplitReplaceFirstLineContents.Location = new System.Drawing.Point(116, 22);
            this.labelSplitReplaceFirstLineContents.Name = "labelSplitReplaceFirstLineContents";
            this.labelSplitReplaceFirstLineContents.Size = new System.Drawing.Size(545, 12);
            this.labelSplitReplaceFirstLineContents.TabIndex = 0;
            this.labelSplitReplaceFirstLineContents.Text = "批量处理时确保内容格式齐整、长度间隔一致！“这是第一行内容”，在这里我预读取第一行的内容。";
            // 
            // labelSplitReplaceFirstLine
            // 
            this.labelSplitReplaceFirstLine.AutoSize = true;
            this.labelSplitReplaceFirstLine.Location = new System.Drawing.Point(19, 20);
            this.labelSplitReplaceFirstLine.Name = "labelSplitReplaceFirstLine";
            this.labelSplitReplaceFirstLine.Size = new System.Drawing.Size(91, 14);
            this.labelSplitReplaceFirstLine.TabIndex = 0;
            this.labelSplitReplaceFirstLine.Text = "第一行内容：";
            // 
            // textBoxSplitReplaceMyStyle
            // 
            this.textBoxSplitReplaceMyStyle.Location = new System.Drawing.Point(21, 69);
            this.textBoxSplitReplaceMyStyle.Name = "textBoxSplitReplaceMyStyle";
            this.textBoxSplitReplaceMyStyle.Size = new System.Drawing.Size(631, 23);
            this.textBoxSplitReplaceMyStyle.TabIndex = 4;
            // 
            // labelStringOrFilesOrUrl
            // 
            this.labelStringOrFilesOrUrl.AutoSize = true;
            this.labelStringOrFilesOrUrl.ForeColor = System.Drawing.Color.Blue;
            this.labelStringOrFilesOrUrl.Location = new System.Drawing.Point(14, 10);
            this.labelStringOrFilesOrUrl.Name = "labelStringOrFilesOrUrl";
            this.labelStringOrFilesOrUrl.Size = new System.Drawing.Size(371, 14);
            this.labelStringOrFilesOrUrl.TabIndex = 0;
            this.labelStringOrFilesOrUrl.Text = "请输入要处理的文本，或选择一种方式然后输入路径地址：";
            // 
            // richTextBoxStringOrFilesOrUrl
            // 
            this.richTextBoxStringOrFilesOrUrl.ForeColor = System.Drawing.Color.Blue;
            this.richTextBoxStringOrFilesOrUrl.Location = new System.Drawing.Point(16, 29);
            this.richTextBoxStringOrFilesOrUrl.Name = "richTextBoxStringOrFilesOrUrl";
            this.richTextBoxStringOrFilesOrUrl.Size = new System.Drawing.Size(783, 48);
            this.richTextBoxStringOrFilesOrUrl.TabIndex = 0;
            this.richTextBoxStringOrFilesOrUrl.Text = "";
            this.richTextBoxStringOrFilesOrUrl.DoubleClick += new System.EventHandler(this.richTextBoxStringOrFilesOrUrl_DoubleClick);
            // 
            // radioButtonString
            // 
            this.radioButtonString.AutoSize = true;
            this.radioButtonString.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonString.Location = new System.Drawing.Point(17, 151);
            this.radioButtonString.Name = "radioButtonString";
            this.radioButtonString.Size = new System.Drawing.Size(109, 18);
            this.radioButtonString.TabIndex = 0;
            this.radioButtonString.TabStop = true;
            this.radioButtonString.Text = "文本（默认）";
            this.radioButtonString.UseVisualStyleBackColor = true;
            this.radioButtonString.CheckedChanged += new System.EventHandler(this.radioButtonString_CheckedChanged);
            // 
            // radioButtonFiles
            // 
            this.radioButtonFiles.AutoSize = true;
            this.radioButtonFiles.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonFiles.Location = new System.Drawing.Point(455, 151);
            this.radioButtonFiles.Name = "radioButtonFiles";
            this.radioButtonFiles.Size = new System.Drawing.Size(207, 18);
            this.radioButtonFiles.TabIndex = 0;
            this.radioButtonFiles.TabStop = true;
            this.radioButtonFiles.Text = "本地文件（双击输入框选择）";
            this.radioButtonFiles.UseVisualStyleBackColor = true;
            this.radioButtonFiles.CheckedChanged += new System.EventHandler(this.radioButtonFiles_CheckedChanged);
            // 
            // radioButtonUrl
            // 
            this.radioButtonUrl.AutoSize = true;
            this.radioButtonUrl.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonUrl.Location = new System.Drawing.Point(224, 151);
            this.radioButtonUrl.Name = "radioButtonUrl";
            this.radioButtonUrl.Size = new System.Drawing.Size(137, 18);
            this.radioButtonUrl.TabIndex = 0;
            this.radioButtonUrl.TabStop = true;
            this.radioButtonUrl.Text = "Web网页(HttpGet)";
            this.radioButtonUrl.UseVisualStyleBackColor = true;
            this.radioButtonUrl.CheckedChanged += new System.EventHandler(this.radioButtonUrl_CheckedChanged);
            // 
            // comboBoxRegexAsReplaceSplit
            // 
            this.comboBoxRegexAsReplaceSplit.FormattingEnabled = true;
            this.comboBoxRegexAsReplaceSplit.Items.AddRange(new object[] {
            "/",
            "爫",
            "|",
            "#",
            "犭",
            "$"});
            this.comboBoxRegexAsReplaceSplit.Location = new System.Drawing.Point(489, 36);
            this.comboBoxRegexAsReplaceSplit.MaxLength = 1;
            this.comboBoxRegexAsReplaceSplit.Name = "comboBoxRegexAsReplaceSplit";
            this.comboBoxRegexAsReplaceSplit.Size = new System.Drawing.Size(79, 22);
            this.comboBoxRegexAsReplaceSplit.TabIndex = 3;
            this.comboBoxRegexAsReplaceSplit.Text = "/";
            // 
            // groupBoxRegexAs
            // 
            this.groupBoxRegexAs.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxRegexAs.Controls.Add(this.textBoxConcatenation);
            this.groupBoxRegexAs.Controls.Add(this.labelConcatenation);
            this.groupBoxRegexAs.Controls.Add(this.buttonRegexAsCreate);
            this.groupBoxRegexAs.Controls.Add(this.comboBoxRegexAsReplaceSplit);
            this.groupBoxRegexAs.Controls.Add(this.labelRegexAsFinder);
            this.groupBoxRegexAs.Controls.Add(this.textBoxRegexAsFinder);
            this.groupBoxRegexAs.Controls.Add(this.textBoxRegexAsReplace);
            this.groupBoxRegexAs.Controls.Add(this.labelRegexAsReplaceSplit);
            this.groupBoxRegexAs.Controls.Add(this.labelRegexAsReplace);
            this.groupBoxRegexAs.Location = new System.Drawing.Point(17, 195);
            this.groupBoxRegexAs.Name = "groupBoxRegexAs";
            this.groupBoxRegexAs.Size = new System.Drawing.Size(782, 73);
            this.groupBoxRegexAs.TabIndex = 0;
            this.groupBoxRegexAs.TabStop = false;
            this.groupBoxRegexAs.Text = "正则表达式处理（RegEx）";
            // 
            // groupBoxContentSubstring
            // 
            this.groupBoxContentSubstring.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxContentSubstring.Controls.Add(this.labelContentSubstringHead);
            this.groupBoxContentSubstring.Controls.Add(this.buttonContentSubstringCreate);
            this.groupBoxContentSubstring.Controls.Add(this.labelContentSubstringTail);
            this.groupBoxContentSubstring.Controls.Add(this.checkBoxContentSubstringIncludeHead);
            this.groupBoxContentSubstring.Controls.Add(this.labelContentSubstringHeadTailInclude);
            this.groupBoxContentSubstring.Controls.Add(this.textBoxContentSubstringHead);
            this.groupBoxContentSubstring.Controls.Add(this.textBoxContentSubstringTail);
            this.groupBoxContentSubstring.Controls.Add(this.checkBoxContentSubstringIncludeTail);
            this.groupBoxContentSubstring.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxContentSubstring.Location = new System.Drawing.Point(17, 385);
            this.groupBoxContentSubstring.Name = "groupBoxContentSubstring";
            this.groupBoxContentSubstring.Size = new System.Drawing.Size(783, 81);
            this.groupBoxContentSubstring.TabIndex = 0;
            this.groupBoxContentSubstring.TabStop = false;
            this.groupBoxContentSubstring.Text = "截取字符串（Substring）";
            // 
            // labelContentSubstringHead
            // 
            this.labelContentSubstringHead.AutoSize = true;
            this.labelContentSubstringHead.Location = new System.Drawing.Point(6, 23);
            this.labelContentSubstringHead.Name = "labelContentSubstringHead";
            this.labelContentSubstringHead.Size = new System.Drawing.Size(133, 14);
            this.labelContentSubstringHead.TabIndex = 1;
            this.labelContentSubstringHead.Text = "字串截取起始字串：";
            // 
            // buttonContentSubstringCreate
            // 
            this.buttonContentSubstringCreate.Location = new System.Drawing.Point(694, 52);
            this.buttonContentSubstringCreate.Name = "buttonContentSubstringCreate";
            this.buttonContentSubstringCreate.Size = new System.Drawing.Size(79, 23);
            this.buttonContentSubstringCreate.TabIndex = 0;
            this.buttonContentSubstringCreate.Text = "开始处理";
            this.buttonContentSubstringCreate.UseVisualStyleBackColor = true;
            this.buttonContentSubstringCreate.Click += new System.EventHandler(this.buttonRegExAll_Create_Click);
            // 
            // labelContentSubstringTail
            // 
            this.labelContentSubstringTail.AutoSize = true;
            this.labelContentSubstringTail.Location = new System.Drawing.Point(448, 23);
            this.labelContentSubstringTail.Name = "labelContentSubstringTail";
            this.labelContentSubstringTail.Size = new System.Drawing.Size(140, 14);
            this.labelContentSubstringTail.TabIndex = 0;
            this.labelContentSubstringTail.Text = "|以下列字符串结束：";
            // 
            // checkBoxContentSubstringIncludeHead
            // 
            this.checkBoxContentSubstringIncludeHead.AutoSize = true;
            this.checkBoxContentSubstringIncludeHead.Location = new System.Drawing.Point(187, 49);
            this.checkBoxContentSubstringIncludeHead.Name = "checkBoxContentSubstringIncludeHead";
            this.checkBoxContentSubstringIncludeHead.Size = new System.Drawing.Size(138, 18);
            this.checkBoxContentSubstringIncludeHead.TabIndex = 0;
            this.checkBoxContentSubstringIncludeHead.Text = "包含起始字串本身";
            this.checkBoxContentSubstringIncludeHead.UseVisualStyleBackColor = true;
            this.checkBoxContentSubstringIncludeHead.CheckedChanged += new System.EventHandler(this.checkBoxContentSubstringIncludeHead_CheckedChanged);
            // 
            // labelContentSubstringHeadTailInclude
            // 
            this.labelContentSubstringHeadTailInclude.AutoSize = true;
            this.labelContentSubstringHeadTailInclude.Location = new System.Drawing.Point(6, 50);
            this.labelContentSubstringHeadTailInclude.Name = "labelContentSubstringHeadTailInclude";
            this.labelContentSubstringHeadTailInclude.Size = new System.Drawing.Size(161, 14);
            this.labelContentSubstringHeadTailInclude.TabIndex = 0;
            this.labelContentSubstringHeadTailInclude.Text = "是否包含头尾字串本身？";
            // 
            // textBoxContentSubstringHead
            // 
            this.textBoxContentSubstringHead.Location = new System.Drawing.Point(145, 20);
            this.textBoxContentSubstringHead.Name = "textBoxContentSubstringHead";
            this.textBoxContentSubstringHead.Size = new System.Drawing.Size(180, 23);
            this.textBoxContentSubstringHead.TabIndex = 0;
            // 
            // textBoxContentSubstringTail
            // 
            this.textBoxContentSubstringTail.Location = new System.Drawing.Point(594, 20);
            this.textBoxContentSubstringTail.Name = "textBoxContentSubstringTail";
            this.textBoxContentSubstringTail.Size = new System.Drawing.Size(180, 23);
            this.textBoxContentSubstringTail.TabIndex = 0;
            // 
            // checkBoxContentSubstringIncludeTail
            // 
            this.checkBoxContentSubstringIncludeTail.AutoSize = true;
            this.checkBoxContentSubstringIncludeTail.Location = new System.Drawing.Point(331, 49);
            this.checkBoxContentSubstringIncludeTail.Name = "checkBoxContentSubstringIncludeTail";
            this.checkBoxContentSubstringIncludeTail.Size = new System.Drawing.Size(138, 18);
            this.checkBoxContentSubstringIncludeTail.TabIndex = 0;
            this.checkBoxContentSubstringIncludeTail.Text = "包含结束字串本身";
            this.checkBoxContentSubstringIncludeTail.UseVisualStyleBackColor = true;
            this.checkBoxContentSubstringIncludeTail.CheckedChanged += new System.EventHandler(this.checkBoxContentSubstringIncludeTail_CheckedChanged);
            // 
            // richTextBoxResults
            // 
            this.richTextBoxResults.ForeColor = System.Drawing.Color.Tomato;
            this.richTextBoxResults.Location = new System.Drawing.Point(17, 97);
            this.richTextBoxResults.Name = "richTextBoxResults";
            this.richTextBoxResults.Size = new System.Drawing.Size(782, 48);
            this.richTextBoxResults.TabIndex = 0;
            this.richTextBoxResults.Text = "";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.ForeColor = System.Drawing.Color.Blue;
            this.labelResults.Location = new System.Drawing.Point(14, 80);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(133, 14);
            this.labelResults.TabIndex = 0;
            this.labelResults.Text = "显示文本处理结果：";
            // 
            // labelConcatenation
            // 
            this.labelConcatenation.AutoSize = true;
            this.labelConcatenation.Location = new System.Drawing.Point(585, 19);
            this.labelConcatenation.Name = "labelConcatenation";
            this.labelConcatenation.Size = new System.Drawing.Size(105, 14);
            this.labelConcatenation.TabIndex = 4;
            this.labelConcatenation.Text = "结果间连接字符";
            // 
            // textBoxConcatenation
            // 
            this.textBoxConcatenation.Location = new System.Drawing.Point(588, 35);
            this.textBoxConcatenation.Name = "textBoxConcatenation";
            this.textBoxConcatenation.Size = new System.Drawing.Size(72, 23);
            this.textBoxConcatenation.TabIndex = 5;
            this.textBoxConcatenation.Text = "#-#-#";
            // 
            // FormRegEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(815, 483);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.richTextBoxResults);
            this.Controls.Add(this.groupBoxContentSubstring);
            this.Controls.Add(this.groupBoxRegexAs);
            this.Controls.Add(this.radioButtonUrl);
            this.Controls.Add(this.radioButtonFiles);
            this.Controls.Add(this.radioButtonString);
            this.Controls.Add(this.richTextBoxStringOrFilesOrUrl);
            this.Controls.Add(this.groupBoxSplitReplace);
            this.Controls.Add(this.labelStringOrFilesOrUrl);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximumSize = new System.Drawing.Size(827, 516);
            this.MinimumSize = new System.Drawing.Size(827, 516);
            this.Name = "FormRegEx";
            this.Text = "文本处理工具";
            this.groupBoxSplitReplace.ResumeLayout(false);
            this.groupBoxSplitReplace.PerformLayout();
            this.groupBoxRegexAs.ResumeLayout(false);
            this.groupBoxRegexAs.PerformLayout();
            this.groupBoxContentSubstring.ResumeLayout(false);
            this.groupBoxContentSubstring.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegexAsReplaceSplit;
        private System.Windows.Forms.Button buttonRegexAsCreate;
        private System.Windows.Forms.TextBox textBoxRegexAsReplace;
        private System.Windows.Forms.Label labelRegexAsFinder;
        private System.Windows.Forms.TextBox textBoxRegexAsFinder;
        private System.Windows.Forms.Label labelRegexAsReplace;
        private System.Windows.Forms.GroupBox groupBoxSplitReplace;
        private System.Windows.Forms.Label labelSplitReplaceMyStyle;
        private System.Windows.Forms.Button buttonSplitReplaceCreating;
        private System.Windows.Forms.Label labelSplitReplaceFirstLineContents;
        private System.Windows.Forms.Label labelSplitReplaceFirstLine;
        private System.Windows.Forms.TextBox textBoxSplitReplaceMyStyle;
        private System.Windows.Forms.Label labelStringOrFilesOrUrl;
        private System.Windows.Forms.RichTextBox richTextBoxStringOrFilesOrUrl;
        private System.Windows.Forms.RadioButton radioButtonString;
        private System.Windows.Forms.RadioButton radioButtonFiles;
        private System.Windows.Forms.RadioButton radioButtonUrl;
        private System.Windows.Forms.ComboBox comboBoxRegexAsReplaceSplit;
        private System.Windows.Forms.GroupBox groupBoxRegexAs;
        private System.Windows.Forms.GroupBox groupBoxContentSubstring;
        private System.Windows.Forms.Label labelContentSubstringTail;
        private System.Windows.Forms.CheckBox checkBoxContentSubstringIncludeHead;
        private System.Windows.Forms.Label labelContentSubstringHeadTailInclude;
        private System.Windows.Forms.TextBox textBoxContentSubstringHead;
        private System.Windows.Forms.TextBox textBoxContentSubstringTail;
        private System.Windows.Forms.CheckBox checkBoxContentSubstringIncludeTail;
        private System.Windows.Forms.Button buttonContentSubstringCreate;
        private System.Windows.Forms.RichTextBox richTextBoxResults;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label labelContentSubstringHead;
        private System.Windows.Forms.Label labelConcatenation;
        private System.Windows.Forms.TextBox textBoxConcatenation;
    }
}
