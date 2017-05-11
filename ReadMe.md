<!-- 标题居中，Html语法，创建一条Form -->
<form style="text-align:center"><h2><font>FilesOrStringRegExManager工具说明帮助</font></h3></form>

<!-- 目录索引本身的链接等式是#_1 -->
####目录索引
+ [正则表达式处理](#_2)
+ [字符串拼接](#_3)
+ [截取字符串](#_4)


****
<!-- 分隔符，整行分隔 -->
__支持三种类型：__

+ 1.当前输入框输入后直接显示处理结果，即`文本（默认）`RadioButton选中
+ 2.通过获取web网页的内容并进行处理，即`Web网页(HttpGet)`RadioButton选中
+ 3.通过本地某个文件导入并进行处理，即`本地文件（双击输入框选择）`RadioButton选中
+ 4.`文本（默认）`类型结果直接在下方的`richTextBoxResults`输入框中输出，其它两种方式均保存为TXT文档，保存在当前路径。保存的文件名为`public static string SAVE_FILE_NAME = "outPutResult.txt"`。
+ 5.有时候出错提示信息会直接显示在`richTextBoxResults`输入框中。

<!-- 总体介绍结束 -->
####正则表达式处理：

* 1.在richTextBoxStringOrFilesOrUrl中输入要过滤的`文本`或`web网址`或`本地文件`全路径；
* 2.如果有多行，且textBoxRegexAsFinder中有输入正则式，处理过程会首先确认该行是否满足匹配`this.textBoxRegexAsFinder.Text`，如果不匹配该行直接忽略；不填写任何内容则视为不需要满足该条件。
* 3.textBoxRegexAsReplace是最主要条件输入框，支持多个条件；
	- 多个条件之间是`或`的关系；
	- 多个条件之间的分隔符号必须约定，以`this.comboBoxRegexAsReplaceSplit.Text`的符号进行分隔。

<!-- 正则表达式结束 -->

####字符串拼接：

* 1.在richTextBoxStringOrFilesOrUrl中输入要过滤的`文本`或`本地文件`的全路径；不支持`web网址`方式。
* 2.在textBoxSplitReplaceMyStyle中输入替换规则表达式。
	- 表达式分为两种形式，@1为新加字符串；@2为原字符串中的内容。
	- 新加的字符串与原字符串中的内容要用`$`区别开来，以便于混合成一条完整表达式。
	- 原来的字符串必须用`$n~m`的格式，n表示截取自原字符串的起初位置，m表示截取长度，m=1即表示一个字符。
	- 特殊值意义：`$n~m`中，n=0表示从头开始，m=0表示从n位置一直截取到最后；
	- 表示式处理过程不会考虑自然逻辑，也就是说原字符串的内容可能多次截取，先截取后段再截取前段也行。

####截取字符串：

* 1.在richTextBoxStringOrFilesOrUrl中输入要过滤的`文本`或`本地文件`的全路径；不支持`web网址`方式。
* 2.在textBoxContentSubstringHead中输入标志性字符串的前段，在textBoxContentSubstringTail中输入标志性字符串的后段。
	- 例如有一段待处理的字符串为`"真好玩"<href="http://click.hm.baidu.com/" data-index="1" >哈哈XXXXXXXYYYYYY`；
	- 现在我想截取网址的内容。先填入：`textBoxContentSubstringHead` = `<href="`，`textBoxContentSubstringTail` = `"`。
	- 处理结果为：@1不包含头不包含尾：`http://click.hm.baidu.com/`。@2包含头也包含尾：`<href="http://click.hm.baidu.com/"`。
* 3.包含头、尾，是指结果内容中包含textBoxContentSubstringHead、textBoxContentSubstringTail中输入的内容本身；
* 4.值得注意的是，截取过程中，尾的处理逻辑是：<font color=red>在头之后的第一个匹配位置</font>。

####界面原型预览：
![原型界面预览](https://github.com/YamazakyLau/FilesOrStringRegExManager/blob/master/PreView.png "Optional title")

####原型安装档下载：
[FilesOrStringRegExManager.zip](https://github.com/YamazakyLau/FilesOrStringRegExManager/blob/master/ToolsInstall.zip "下载")
