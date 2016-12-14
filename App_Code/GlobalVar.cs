using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;

/// <summary>
/// Summary description for GlobalVar
/// </summary>
public class GlobalVar
{
    //定义学科
    public static string[] ChineseSubject = { "语文", "数学", "英语", "政治", "历史", "地理", "物理", "化学", "生物",
        "音乐", "美术", "信息技术", "排球", "足球" };

    public static string[] pinyinSubject = { "yuwen", "shuxue", "yingyu",
    "zhengzhi", "lishi", "dili", "wuli", "huaxue", "shengwu", "yinyue",
        "meishu", "xinxijishu", "paiqiu", "zuqiu" };

    //定义年级
    public static string[] ChineseGrade = { "初一", "初二", "初三", "中一", "中二", "中三" };

    public static string[] pinyinGrade = {"chuyi", "chuer", "chusan",
                                          "zhongyi", "zhonger", "zhongsan"};

    
    public static string[] VideoFileNames = Directory.GetFiles(
                                     HttpContext.Current.Server.MapPath("~/UploadedVideos"), "*")
                                     .Select(Path.GetFileNameWithoutExtension)
                                     .ToArray();

    public static string[] videofilename = VideoFileNames.ToList().Select
                                           (s => s.Split('.')[2]).ToArray();
}