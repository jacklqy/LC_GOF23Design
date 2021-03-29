using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GOF23._09组合模式
{
    /// <summary>
    /// 递归
    /// </summary>
    public class Recursion
    {
        /// <summary>
        /// 给一个根目录，获取全部的文件夹
        /// </summary>
        /// <param name="rootpath">根路径</param>
        /// <returns></returns>
        public static List<DirectoryInfo> GetDirectoryList(string rootpath)
        {
            List<DirectoryInfo> dirList = new List<DirectoryInfo>();

            DirectoryInfo dirRoot = new DirectoryInfo(rootpath);//根目录
            dirList.Add(dirRoot);

            GetDirectoryListChild(dirList, dirRoot);

            return dirList;
        }

        /// <summary>
        /// 找出当前文件夹的子文件夹，放入结果容器
        /// </summary>
        /// <param name="dirList">结果容器</param>
        /// <param name="dirParent">当前文件夹</param>
        public static void GetDirectoryListChild(List<DirectoryInfo> dirList, DirectoryInfo dirParent)
        {
            DirectoryInfo[] directoryChilds = dirParent.GetDirectories();//
            dirList.AddRange(directoryChilds);
            foreach (var dir in directoryChilds)
            {
                GetDirectoryListChild(dirList, dir);
            }
        }
    }
}
