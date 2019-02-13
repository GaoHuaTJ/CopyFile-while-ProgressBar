using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 复制文件时显示复制进度
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开路径浏览器选定要复制的地址
        /// </summary>
            string DefailtPath = "";//默认的路径
        private void btn_OriginFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OriginFileDialog = new OpenFileDialog();//路径浏览器
            if (DefailtPath != "")//记录上次点击时的路径
            {
                OriginFileDialog.FileName = DefailtPath;
            }

            if (OriginFileDialog.ShowDialog()== DialogResult.OK)
            {
                DefailtPath= OriginFileDialog.FileName;
                textBoxOrigin.Text = OriginFileDialog.FileName;
            }
        }

        /// <summary>
        /// 选定复制的目的地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnGoalFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog GoalFoldDialog = new FolderBrowserDialog();
            if (DefailtPath != "")//记录上次点击时的路径
            {
                GoalFoldDialog.SelectedPath = DefailtPath;
            }

            if (GoalFoldDialog.ShowDialog()== DialogResult.OK)//如果选定了路径之后
            {
                DefailtPath = GoalFoldDialog.SelectedPath;
                textBoxGoalFile.Text = GoalFoldDialog.SelectedPath;
            }
        }

        string toFile;
        private void btnCopy_Click(object sender, EventArgs e)
        {
            var toFile=textBoxOrigin.Text.Substring(textBoxOrigin.Text.LastIndexOf("\\")+1) ;//截取文件名
            toFile =textBoxGoalFile.Text+ "\\"+toFile;//文件地址
            CopyFile(textBoxOrigin.Text,toFile,10000,progressBar1);
        }

        public void CopyFile(string formerFile,string toFile,int sectSize,ProgressBar progressBar1)
        {
            progressBar1.Value = 0;//进度条的显示数据归0
            progressBar1.Minimum = 0;
            FileStream fileToCreate = new FileStream(toFile,FileMode.Create);//创建空文件
            fileToCreate.Close();
            fileToCreate.Dispose();
            FileStream formerFileOpen = new FileStream(formerFile,FileMode.Open,FileAccess.Read);//读取文件
            FileStream toFileOpen = new FileStream(toFile,FileMode.Append,FileAccess.Write);//给现存文件打开
            int max = Convert.ToInt32(Math.Ceiling((double)formerFileOpen.Length/(double)sectSize));//文件的长度除以分次复制的次数即为每一次的长度
            Console.WriteLine(max);
            progressBar1.Maximum = max;
            if (sectSize < formerFileOpen.Length)
            {
                byte[] buffer = new byte[sectSize];
                int copied = 0;//记录已经复制的大小
                int FileSize;//复制文件的大小
                while ((int)(formerFileOpen.Length - sectSize) >= copied)
                {
                    FileSize = formerFileOpen.Read(buffer, 0, sectSize);
                    formerFileOpen.Flush();
                    toFileOpen.Write(buffer, 0, sectSize);
                    toFileOpen.Flush();
                    toFileOpen.Position = formerFileOpen.Position;
                    copied += FileSize;
                    progressBar1.Value++;
                }
                //处理剩余的文件
                int left = (int)formerFileOpen.Length - copied;
                FileSize = formerFileOpen.Read(buffer, 0, left);
                formerFileOpen.Flush();
                toFileOpen.Write(buffer, 0, left);
                toFileOpen.Flush();
                progressBar1.Value = progressBar1.Maximum;
            }
            else
            {
                byte[] buffer = new byte[sectSize];
                formerFileOpen.Read(buffer,0,(int)formerFileOpen.Length);
                formerFileOpen.Flush();
                toFileOpen.Write(buffer, 0, (int)formerFileOpen.Length);
                toFileOpen.Flush();
            }
            formerFileOpen.Flush();
            formerFileOpen.Close();
            formerFileOpen.Dispose();
            toFileOpen.Flush();
            toFileOpen.Close();
            toFileOpen.Dispose();
            if (MessageBox.Show("复制完成") == DialogResult.OK)
            {
                progressBar1.Value = 0;
                textBoxGoalFile.Text = "";
                textBoxOrigin.Text = "";
            }
        }
    }
}
