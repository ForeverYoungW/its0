﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// 配置
/// </summary>
public static class Config
{
    /// <summary>
    /// 网站的名字，将会呈现给用户
    /// </summary>
    public static readonly string WebsiteName = "示例网站";

    /// <summary>
    /// 管理系统的名字，将会呈现给用户
    /// </summary>
    public static readonly string ManageSystemName = WebsiteName + "管理系统";

    /// <summary>
    /// 异常日志的数目上限，到达之后最旧的日志会被删除
    /// </summary>
    public static readonly int ExceptionLogMaxCount = 100;

    /// <summary>
    /// 用于计算 HMAC 的静态密钥，将会被明文发送至客户端
    /// </summary>
    public static readonly string HmacStaticKey = "its0";

    /// <summary>
    /// 用户上传的文件所在的目录，注意末尾的斜杠不可省略
    /// </summary>
    public static readonly string UploadDirectory = "~/Upload/";

    /// <summary>
    /// 是否启用文章置顶功能
    /// </summary>
    public static readonly bool ArticleTopEnabled = false;
    /// <summary>
    /// 是否启用文章推荐功能
    /// </summary>
    public static readonly bool ArticleRecommendEnabled = false;
    /// <summary>
    /// 是否启用文章隐藏功能
    /// </summary>
    public static readonly bool ArticleHideEnabled = false;
    /// <summary>
    /// 是否启用文章图片滚动功能
    /// </summary>
    public static readonly bool ArticlePictureScrollEnabled = false;
    /// <summary>
    /// 文章标题的最大长度
    /// </summary>
    public static readonly int ArticleTitleMaxLength = 100;
    /// <summary>
    /// 文章来源的最大长度
    /// </summary>
    public static readonly int ArticleFromMaxLength = 20;

    /// <summary>
    /// 是否启用修改文章分类的功能
    /// </summary>
    public static readonly bool ArticleCategoryEditable = true;
    /// <summary>
    /// 文章分类名的最大长度
    /// </summary>
    public static readonly int ArticleCategoryNameMaxLength = 100;

    /// <summary>
    /// 是否为多用户模式
    /// </summary>
    public static readonly bool MultiUser = true;

    /// <summary>
    /// 用户名的最大长度
    /// </summary>
    public static readonly int UserNameMaxLength = 20;
    /// <summary>
    /// 用户密码的最大长度
    /// </summary>
    public static readonly int UserPasswordMaxLength = 20;

    /// <summary>
    /// 每页显示的项目数的默认值，一般只用于管理系统
    /// </summary>
    public static readonly int DefaultPageSize = 10;

    /// <summary>
    /// 日志页面是否可见
    /// </summary>
    public static readonly bool LogVisible = true;
}