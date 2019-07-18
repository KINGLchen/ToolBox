﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ToolBox.Log;

namespace ToolBox.Files
{
    public partial class FileUtil
    {
        /// <summary>
        /// 以只读方式读取文本文件
        /// </summary>
        /// <param name="FilePath">文件路径及文件名</param>
        /// <returns></returns>
        public static string ReadTxtFile(string FilePath)
        {
            string content = "";//返回的字符串
            using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
                {
                    string text = string.Empty;
                    while (!reader.EndOfStream)
                    {
                        text += reader.ReadLine() + "\r\n";
                        content = text;
                    }
                }
            }
            return content;
        }

        public static string ReadFile(string FilePath)
        {
            string text = string.Empty;
            System.Text.Encoding code = System.Text.Encoding.GetEncoding("gb2312");
            using (var sr = new StreamReader(FilePath, code))
            {
                try
                {
                    text = sr.ReadToEnd(); // 读取文件
                    sr.Close();
                }
                catch { }
            }
            return text;
        }


        /// <summary>
        /// 获取文本文件的行数
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>        
        public static int GetLineCount(string filePath)
        {
            //将文本文件的各行读到一个字符串数组中
            string[] rows = File.ReadAllLines(filePath);

            //返回行数
            return rows.Length;
        }

        /// <summary>
        /// 获得文件的拓展名
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>        
        public static string GetExtension(string filePath)
        {
            try
            {
                //获取文件的名称
                FileInfo fi = new FileInfo(filePath);
                return fi.Extension;
            }
            catch (Exception ex)
            {
                ex.Message.WriteErrorLog();
                return ex.Message;
            }
        }

        /// <summary>
        /// 获得文件名，不包含扩展名
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>        
        public static string GetFileNameNoExtension(string filePath)
        {
            try
            {
                //获取文件的名称
                FileInfo fi = new FileInfo(filePath);
                return fi.Name.Split('.')[0];
            }
            catch (Exception ex)
            {
                ex.Message.WriteErrorLog();
                return ex.Message;
            }

        }


    }
}
