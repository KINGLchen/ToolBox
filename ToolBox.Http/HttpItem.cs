﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ToolBox.Http
{
    /// <summary>
    /// http请求类
    /// </summary>
    public class HttpItem
    {

        /// <summary>
        /// 处理程序使用的自动解压缩方法 Gzip Deflate none=不使用压缩 默认为none
        /// </summary>
        public DecompressionMethods Decompression = DecompressionMethods.None;

        /// <summary>
        /// Authorization 认证   Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Username}:{Password}"))
        /// </summary>
        public string Authorization { get; set; }

        /// <summary>
        /// 请求URL必须填写
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// 请求方式
        /// </summary>
        public HttpMethod Method = HttpMethod.Get;

        /// <summary>
        /// 请求时间
        /// </summary>
        public int Timeout { get; set; } = 100000;

        /// <summary>
        /// 默认写入post数据超时时间
        /// </summary>
        public int ReadWriteTimeout { get; set; } = 30000;

        /// <summary>
        /// 设置Host的标头信息
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// 获取或设置一个值，该值指示是否与 Internet 资源建立持久性连接默认为true。
        /// </summary>
        public Boolean KeepAlive { get; set; } = true;

        /// <summary>
        /// 请求标头值 默认为text/html, application/xhtml+xml, */*
        /// </summary>
        public string Accept { get; set; } = "*/*";


        /// <summary>
        /// 请求返回类型默认 text/html
        /// </summary>
        public string ContentType { get; set; } = "application/x-www-form-urlencoded";


        /// <summary>
        /// 客户端访问信息默认Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)
        /// </summary>
        public string UserAgent { get; set; }= "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)";


        /// <summary>
        /// 返回数据编码默认为NUll 一般为utf-8,gbk,gb2312
        /// </summary>
        public Encoding Encoding { get; set; } = Encoding.UTF8;


        /// <summary>
        /// Post的数据类型,默认为string
        /// </summary>
        public PostDataType postDataType { get; set; } = PostDataType.String;


        /// <summary>
        /// Post请求时要发送的字符串Post数据
        /// </summary>
        public string Postdata { get; set; }


        /// <summary>
        /// Post请求时要发送的Byte类型的Post数据
        /// </summary>
        public byte[] PostdataByte { get; set; }


        /// <summary>
        /// Cookie对象集合
        /// </summary>
        private CookieContainer CookieContainer { get; set; }

        /// <summary>
        /// 请求时的Cookie
        /// </summary>
        public string Cookie { get; set; }

        /// <summary>
        /// 来源地址，上次访问地址
        /// </summary>
        public string Referer { get; set; }

        /// <summary>
        /// 证书绝对路径
        /// </summary>
        public string CerPath { get; set; }

        /// <summary>
        /// 设置代理对象，不想使用IE默认配置就设置为Null，而且不要设置ProxyIp
        /// </summary>
        public WebProxy WebProxy { get; set; }

        /// <summary>
        /// 是否设置为全文小写，默认为不转化
        /// </summary>
        public Boolean IsToLower { get; set; } = false;

        /// <summary>
        /// 支持跳转页面，查询结果将是跳转后的页面，默认是跳转
        /// </summary>
        public Boolean Allowautoredirect { get; set; } = true;

        /// <summary>
        /// 最大连接数
        /// </summary>
        public int Connectionlimit { get; set; } = 1024;

        /// <summary>
        /// 代理Proxy 服务器用户名
        /// </summary>
        public string ProxyUserName { get; set; }


        /// <summary>
        /// 代理 服务器密码
        /// </summary>
        public string ProxyPwd { get; set; }

        /// <summary>
        /// 代理 服务IP,如果要使用IE代理就设置为ieproxy
        /// </summary>
        public string ProxyIp { get; set; }

        /// <summary>
        /// 设置返回类型String和Byte
        /// </summary>
        public ResultType ResultType { get; set; }= ResultType.String;

        /// <summary>
        /// header对象
        /// </summary>
        public WebHeaderCollection Header { get; set; } = new WebHeaderCollection();

        /// <summary>
        /// 获取或设置用于请求的 HTTP 版本。返回结果:用于请求的 HTTP 版本。默认为 System.Net.HttpVersion.Version11。
        /// </summary>
        public Version ProtocolVersion { get; set; }

        /// <summary>
        /// 获取或设置一个 System.Boolean 值，该值确定是否使用 100-Continue 行为。如果 POST 请求需要 100-Continue 响应，则为 true；否则为 false。默认值为 true。
        /// </summary>
        public Boolean Expect100Continue { get; set; } = false;


        /// <summary>
        /// 设置509证书集合
        /// </summary>
        public X509CertificateCollection ClentCertificates { get; set; }


        /// <summary>
        /// 设置或获取Post参数编码,默认的为Default编码
        /// </summary>
        public Encoding PostEncoding { get; set; }

        /// <summary>
        /// Cookie返回类型,默认的是只返回字符串类型
        /// </summary>
        public ResultCookieType ResultCookieType { get; set; } = ResultCookieType.String;

        /// <summary>
        /// 获取或设置请求的身份验证信息。
        /// </summary>
        public ICredentials ICredentials { get; set; }= CredentialCache.DefaultCredentials;


        /// <summary>
        /// 设置请求将跟随的重定向的最大数目
        /// </summary>
        public int MaximumAutomaticRedirections { get; set; }

        /// <summary>
        /// 获取和设置IfModifiedSince，默认为当前日期和时间
        /// </summary>
        public DateTime? IfModifiedSince { get; set; } = null;

        /// <summary>
        /// 是否自动合并并更新Cookie 默认为true
        /// </summary>
        public bool AutoFixCookie { get; set; } = true;


        /// <summary>
        /// 是否自动处理无效Cookie 默认为true
        /// </summary>
        public bool AutoHanderCookie { get; set; } = true;



    }
}